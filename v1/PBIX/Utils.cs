using System;
using System.Collections.Generic;
using System.IO;

namespace PBIAnalyzer
{
    public class Utils
    {
        public List<string> GetAbsoluteFilePaths(string root, string filename)
        {

            var files = TraverseTree(root);

            List<string> matched_files = new List<string>();

            foreach (var file in files)
            {
                if (file.Contains(filename))
                {
                    matched_files.Add(file);
                }
            }

            return matched_files;
        }

        private List<string> TraverseTree(string root)
        {

            Stack<string> dirs = new Stack<string>(20);
            List<string> files = new List<string>();

            if (!Directory.Exists(root))
            {
                throw new ArgumentException();
            }

            dirs.Push(root);

            while (dirs.Count > 0)
            {
                string currentDir = dirs.Pop();
                string[] subDirs;
                try
                {
                    subDirs = Directory.GetDirectories(currentDir);
                }

                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                catch (DirectoryNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }


                try
                {
                    files.AddRange(Directory.GetFiles(currentDir));
                }

                catch (UnauthorizedAccessException e)
                {

                    Console.WriteLine(e.Message);
                    continue;
                }

                catch (DirectoryNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                foreach (string str in subDirs)
                    dirs.Push(str);

            }

            return files;
        }
    }
}
