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
                   
                    line = line.Replace("Ссловарные сслова сс удвоенной ссогласной нн",
                                        "Словарные слова с удвоенной согласной нн");

                    
                    string cleanedLine = "";
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] != 'с' && line[i] != 'С') 
                        {
                            cleanedLine += line[i];
                        }
                    }

                   
                    File.AppendAllText(pathSaveFile, cleanedLine + Environment.NewLine);
                }
            }

            return pathSaveFile;
        }
    }
}