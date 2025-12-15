using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FendelNS.Sprint5.Task7.V20.Lib
{
    public class DataService : ISprint5Task7V20
    {
        public string LoadDataAndSave(string path)
        {
            string tempPath = Path.GetTempPath();
            string pathSaveFile = Path.Combine(tempPath, "OutPutDataFileTask7V20.txt");

            
            if (File.Exists(pathSaveFile))
                File.Delete(pathSaveFile);

            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                   
                    string result = "";
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (i > 0 && (line[i] == 'с' || line[i] == 'С') &&
                            (line[i - 1] == 'с' || line[i - 1] == 'С'))
                        {
                            
                            continue;
                        }
                        result += line[i];
                    }

                   
                    File.AppendAllText(pathSaveFile, result + Environment.NewLine);
                }
            }

            return pathSaveFile;
        }
    }
}