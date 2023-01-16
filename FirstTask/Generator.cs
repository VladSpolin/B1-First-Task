using System;

using System.IO;


namespace FirstTask
{
    internal sealed class Generator
    {
        private readonly Random random = new Random();

        public void GenerateFiles(int filesCount, int linesCount) // generates a certain number of files and lines in each file
        {
            for (int i = 0; i < filesCount; i++)
            {
                using (var writer = new StreamWriter($@"{Directory.GetCurrentDirectory()}\files\{i + 1}.txt"))
                {
                    for (int j = 0; j < linesCount; j++)
                    {
                        writer.WriteLine(GenerateLine());
                    }
                }
            }
        }

        private string GenerateLine() //generates one line
        {
            DateTime randomDate = DateTime.Now.AddDays(-random.Next(365 * 5));

            var massCharEng = new char[10];
            char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray(); //because random.Next('A', 'z') includes such chars as [ _ etc.
            for (int i = 0; i < massCharEng.Length; i++)
            {

                massCharEng[i] = chars[random.Next(0, chars.Length)];

            }
            var randomEng = new string(massCharEng);

            var massCharRu = new char[10];
            for (int i = 0; i < massCharRu.Length; i++)
            {
                massCharRu[i] = (char)random.Next('А', 'я');
            }
            var randomRu = new string(massCharRu);

            int randomNum = random.Next(1, 100000000);

            double randomNonInt = random.Next(1 * (int)Math.Pow(10, 8), 20 * (int)Math.Pow(10, 8)) / Math.Pow(10, 8);

            string line = $"{randomDate.ToShortDateString()}||{randomEng}||{randomRu}||{randomNum}||{string.Format("{0:F8}", randomNonInt)}";
            return line;
        }
    }
}
