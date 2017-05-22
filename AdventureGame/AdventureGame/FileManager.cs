using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventureGame
{
    class FileManager
    {
        public static int getDeaths()
        {
            int d = 0;
            try
            {
                FileStream rf = new FileStream("..\\..\\deaths.txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader sr = new StreamReader(rf);
                d = Convert.ToInt32(sr.ReadLine());
                sr.Close();
                rf.Close();
            }
            catch
            {

            }
            return d;
        }

        public static void addDeath()
        {
            try
            {
                int d = getDeaths();
                FileStream wf = new FileStream("..\\..\\deaths.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(wf);

                sw.WriteLine(d + 1);
                sw.Close();
                wf.Close();
            }
            catch
            {

            }
        }

        public static void resetDeaths()
        {
            File.Delete("..\\..\\deaths.txt");
        }
        
    }
}
