using Microsoft.AnalysisServices.AdomdClient;
using Microsoft.AnalysisServices.Tabular;
using System;

namespace PBIAnalyzer
{
    public class DBServer
    {
        private string port = null;
        private string connectionString = null;
        private Server server = null;

        public DBServer(string port) {
            this.port = port;
            server = new Server();

            try 
            {           
                server.Connect(port);

                if (server.Connected) 
                {
                    SetConnectionString();
                }
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public bool IsReady() {
            return server.Connected;
        }

        public void TryReconnect() {
            
            server.Reconnect();

            if (server.Connected)
            {
                SetConnectionString();
            }
        }

        public TableCollection GetTables() {
            Model model = server.Databases[0].Model;
            return model.Tables;
        }

        public ColumnCollection GetColumnsFromTable(Table table) {
            return table.Columns;
        }

        public AdomdDataReader ExecuteQuery(string queryString) {

            AdomdDataReader reader = null;
            AdomdConnection connection = new AdomdConnection
            {
                ConnectionString = connectionString
            };

            connection.Open();

            AdomdCommand cmd = new AdomdCommand(queryString)
            {
                Connection = connection
            };

            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (AdomdException)
            {
                // do something here
            }

            return reader;
        }

        private void SetConnectionString() {
            var database = server.Databases[0].Name;
            connectionString = $@"Provider=MSOLAP; Data Source={port};Initial Catalog={database};Persist Security Info=False; Integrated Security=SSPI";
        }
    }
}
