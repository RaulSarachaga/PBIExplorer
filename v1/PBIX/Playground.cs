using Microsoft.AnalysisServices.AdomdClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace PBIAnalyzer
{
    public partial class Playground : Form
    {
        private Int32 MIN_TB_INPUT_SIZE_W = 730;
        private Int32 MIN_TB_INPUT_SIZE_H = 190;

        private Int32 MIN_GB_INPUT_SIZE_W = 748;
        private Int32 MIN_GB_INPUT_SIZE_H = 241;

        private Int32 MAX_GB_INPUT_SIZE_W = 1020;
        private Int32 MAX_GB_INPUT_SIZE_H = 280;

        private DBServer server = null;
        private AdomdDataReader dataReader = null;
        private MultiLineAutoCompleteTextBox tbQuery = null;

        private float _tbQueryFontSize = 12F;
        
        public Playground() { }

        public Playground(DBServer server, string [] daxFunctions)
        {
            InitializeComponent();
            this.server = server;
            cmsColumnNode.Hide();

            MultiLineAutoCompleteTextBox tb = new MultiLineAutoCompleteTextBox
            {
                Values = daxFunctions,
                Location = new Point(9, 18),
                Size = new Size(730, 190),
                Margin = new Padding(3, 3, 3, 3),
                Parent = gbQueryInput,
                Multiline = true,
                Font = new Font(FontFamily.GenericSansSerif, _tbQueryFontSize, FontStyle.Regular, GraphicsUnit.Point),
                Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right),
                ScrollBars = ScrollBars.Vertical,
                Visible = true
            };

            tbQuery = tb;
            gbQueryInput.Controls.Add(tb);
            _tbQueryFontSize = tbQuery.Font.Size;
        }

        private void Playground_Load(object sender, EventArgs e)
        {

            var tables = server.GetTables();

            tvTables.BeginUpdate();

            foreach (var table in tables)
            {
                var columns = server.GetColumnsFromTable(table);
                TreeNode tableNode = new TreeNode(table.Name);

                foreach (var column in columns)
                {
                    tableNode.Nodes.Add(column.Name);
                }

                tableNode.ContextMenuStrip = cmsColumnNode;

                tvTables.Nodes.Add(tableNode);
            }

            tvTables.EndUpdate();


            foreach (TreeNode RootNode in tvTables.Nodes)
            {
                foreach (TreeNode ChildNode in RootNode.Nodes)
                {
                    ChildNode.ContextMenuStrip = cmsColumnNode;
                }
            }
        }

        private void tvTables_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent != null && e.Node.Parent.GetType() == typeof(TreeNode))
            {
                tbQuery.Text = $"{tbQuery.Text}{e.Node.Parent.Text}[{e.Node.Text}]";
            }
        }

        private void tvTables_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right) 
            {
                if (e.Node.Parent != null && e.Node.Parent.GetType() == typeof(TreeNode))
                {
                    cmsColumnNode.Show();
                }
            }
        }

        private void Playground_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            // get query text
            string query = tbQuery.Text;

            if (query != null && query.Length != 0)
            {

                // run the query
                ExecuteQuery(query);
            }
            else
            {
                MessageBox.Show("There's no query to execute!", "Query Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAllStorageQuery_Click(object sender, EventArgs e)
        {
            string query = "SELECT dimension_name AS tablename, attribute_name AS columnname, datatype, (dictionary_size/1024) AS size_kb FROM $system.discover_storage_table_columns WHERE dictionary_size > 0";

            // execute query
            ExecuteQuery(query);
        }

        private void ExecuteQuery(string query) {

            var table = new DataTable("Table");
            var schema = new DataTable("Schema");

            dataReader = server.ExecuteQuery(query);

            try
            {

                if (dataReader != null)
                {
                    schema = dataReader.GetSchemaTable();

                    foreach (DataRow schemarow in schema.Rows)
                    {
                        table.Columns.Add(schemarow.ItemArray[0].ToString(), System.Type.GetType(schemarow.ItemArray[5].ToString()));
                    }

                    while (dataReader.Read())
                    {
                        object[] ColArray = new object[dataReader.FieldCount];

                        for (int i = 0; i < dataReader.FieldCount; i++)
                        {
                            if (dataReader[i] != null)
                            {
                                ColArray[i] = dataReader[i];
                            }
                        }

                        table.LoadDataRow(ColArray, true);

                    }
                }
                else
                {
                    MessageBox.Show("Unable to execute the query", "Invalid query",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data load failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                table.AcceptChanges();
                schema.AcceptChanges();

                dgvQueryResult.DataSource = table;
            }

        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            string contents = tbQuery.Text;

            if (contents != null && contents.Length != 0)
            {

                Stream fileStream;
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Filter = "DAX Files (*.dax)|*.dax|All Files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if ((fileStream = saveFileDialog.OpenFile()) != null)
                    {
                        using (var writer = new StreamWriter(fileStream))
                        {
                            writer.Write(contents);
                        }

                        fileStream.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("There's nothing to save!", "Save Dax Query",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {

            if (dgvQueryResult.Rows.Count > 0)
            {

                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Filter = "Excel Workbook (*.xls)|*.xls";
                saveFileDialog.FileName = "dax-query-result.xls";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Copy DataGridView results to clipboard
                    copyAlltoClipboard();

                    object misValue = System.Reflection.Missing.Value;
                    Excel.Application xlexcel = new Excel.Application();

                    xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
                    Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                    Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                    for (int i = 1; i < dgvQueryResult.Columns.Count + 1; i++)
                    {
                        xlWorkSheet.Cells[1, i + 1] = dgvQueryResult.Columns[i - 1].HeaderText;
                    }

                    // Paste clipboard results to worksheet range
                    Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[2, 1];
                    CR.Select();
                    xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                    // For some reason column A is always blank in the worksheet. ¯\_(ツ)_/¯
                    // Delete blank column A and select cell A1
                    Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
                    delRng.Delete(Type.Missing);
                    xlWorkSheet.get_Range("A1").Select();

                    // Save the excel file under the captured location from the SaveFileDialog
                    xlWorkBook.SaveAs(saveFileDialog.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    xlexcel.DisplayAlerts = true;
                    xlWorkBook.Close(true, misValue, misValue);
                    xlexcel.Quit();

                    releaseObject(xlWorkSheet);
                    releaseObject(xlWorkBook);
                    releaseObject(xlexcel);

                    // Clear Clipboard and DataGridView selection
                    Clipboard.Clear();
                    dgvQueryResult.ClearSelection();

                    // Open the newly saved excel file
                    if (File.Exists(saveFileDialog.FileName))
                        System.Diagnostics.Process.Start(saveFileDialog.FileName);
                }
            }
            else 
            {
                MessageBox.Show("There's nothing to export!", "Exports to Excel",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void copyAlltoClipboard()
        {
            dgvQueryResult.SelectAll();
            DataObject dataObj = dgvQueryResult.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnMeasureDeps_Click(object sender, EventArgs e)
        {
            string query = @"SELECT
                                OBJECT AS[MEASURE],
                                EXPRESSION,
                                REFERENCED_OBJECT AS[MEASURE_REFERENCE],
                                REFERENCED_EXPRESSION AS[MEASURE_EXPRESSION_REFERENCE]
                                FROM $SYSTEM.DISCOVER_CALC_DEPENDENCY
                                WHERE OBJECT_TYPE = 'MEASURE' AND REFERENCED_OBJECT_TYPE = 'MEASURE'";

            // execute query
            ExecuteQuery(query);
        }

        FormWindowState LastWindowState = FormWindowState.Minimized;
        private void Playground_Resize(object sender, EventArgs e)
        {

            // When window state changes
            if (WindowState != LastWindowState)
            {
                LastWindowState = WindowState;

                if (WindowState == FormWindowState.Maximized)
                {
                    SizeF scale = this.AutoScaleFactor;
                    Size desiredSize = new Size(MAX_GB_INPUT_SIZE_W, MAX_GB_INPUT_SIZE_H);

                    gbQueryInput.Size = new Size(Convert.ToInt32(desiredSize.Width * scale.Width), Convert.ToInt32(desiredSize.Height * scale.Height));
                    tbQuery.Size = new Size(Convert.ToInt32(desiredSize.Width * scale.Width)-20, Convert.ToInt32(desiredSize.Height * scale.Height) - 40);

                    tbQuery.relocateWithParent();
                }

                if (WindowState == FormWindowState.Normal)
                {
                    gbQueryInput.Size = new Size(MIN_GB_INPUT_SIZE_W, MIN_GB_INPUT_SIZE_H);
                    tbQuery.Size = new Size(MIN_TB_INPUT_SIZE_W, MIN_TB_INPUT_SIZE_H);
                    tbQuery.relocateWithParent();
                }
            }   
        }

        private void cbZoomOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbZoomOptions.SelectedIndex;

            if (selectedIndex > -1) 
            {
                var zoomLevel = cbZoomOptions.Items[selectedIndex].ToString();
                var percentage = Convert.ToInt32(zoomLevel.Remove(zoomLevel.Length - 1, 1));
                
                var newFontSize = (float)(_tbQueryFontSize * (float)(percentage / 100F));
                tbQuery.Font = new Font(tbQuery.Font.Name, newFontSize, tbQuery.Font.Style, tbQuery.Font.Unit);
            }

        }
    }
}
