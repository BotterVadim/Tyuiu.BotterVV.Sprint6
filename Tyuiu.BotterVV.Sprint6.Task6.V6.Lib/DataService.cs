using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BotterVV.Sprint6.Task6.V6.Lib
{
    public class DataService : ISprint6Task6V6
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] linee = line.Split(' ');
                    for (int i = 0; i < linee.Length; i++)
                    {
                        if (linee[i].Contains('b'))
                        {
                            resStr = resStr + " " + linee[i];
                        }
                    }
                }
                return resStr;
            }
        }
    }
}
