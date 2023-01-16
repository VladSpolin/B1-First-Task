using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    internal sealed class FileMethods
    {
        public void CombineWithValue(string text, out int deletedCount)
        {
            deletedCount = 0;
            string[] files = Directory.GetFiles($@"{Directory.GetCurrentDirectory()}\files", "*.txt"); //gets all files

            var builder = new StringBuilder();

            foreach (var file in files)
            {
                var lines = File.ReadAllLines(file);
                foreach (var line in lines)
                {
                    if (!line.Contains(text))
                    {
                        builder.AppendLine(line);

                    }
                    else deletedCount++;

                }

            }
            File.WriteAllText($@"{Directory.GetCurrentDirectory()}\files\fileOutput.txt", builder.ToString()); //writes the file without deleteed lines

        }
        public void Combine()
        {
            string[] files = Directory.GetFiles($@"{Directory.GetCurrentDirectory()}\files", "*.txt");

            var builder = new StringBuilder();

            foreach (var file in files)
            {
                builder.Append(File.ReadAllText(file));

            }
            File.WriteAllText($@"{Directory.GetCurrentDirectory()}\files\fileOutput.txt", builder.ToString());
        }

        public  async Task ImportFilesToDb(IProgress<int> progress, IProgress<int> maximum)
        {
            await Task.Run(async () =>
            {
                LineService lineService = new LineService();
                string[] files = Directory.GetFiles($@"{Directory.GetCurrentDirectory()}\files", "*.txt");
                var counter = 0;
                List<string> lines = new List<string>();
                foreach (var file in files)
                {
                    if (file!= $@"{Directory.GetCurrentDirectory()}\files\fileOutput.txt")
                    {
                        lines.AddRange(File.ReadAllLines(file));
                    }
                }
                maximum.Report(lines.Count);
                foreach (var line in lines)
                {
                    var parts = line.Split(new string[] { "||" }, StringSplitOptions.None); 
                    lineService.Create(new Line {
                        Date = DateTime.Parse(parts[0]), 
                        StringEng = parts[1], 
                        StringRu = parts[2], 
                        Number = Convert.ToInt32(parts[3]), 
                        NonIntNumber = Convert.ToDouble(parts[4]) 
                    });
                    counter++;
                    progress.Report(counter);
                }
            });
        }

        public void CLearFolder()
        {
            DirectoryInfo dirInfo = new DirectoryInfo($@"{Directory.GetCurrentDirectory()}\files\");

            foreach (FileInfo file in dirInfo.GetFiles())
            {
                file.Delete();
            }
        }

        public void OpenFolder()
        {
            Process.Start("explorer.exe", $@"{Directory.GetCurrentDirectory()}\files");
        }


    }
}
