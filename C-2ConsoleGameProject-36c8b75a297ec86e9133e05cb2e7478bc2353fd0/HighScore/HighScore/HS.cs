
namespace HighScore
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    class HS
    {
        public const int placesCount = 6;

        public static int Add(int pts, string name = null) //If name is null or string.Empty - this method will ask for name.
        {
            if (name == null || name == string.Empty)//ask for name
            {
                while (name == null || name == string.Empty)
                {
                    Console.Write("Input your name here: ");
                    name = Console.ReadLine();
                    Console.WriteLine();
                }
            }

            //read from file
            var hslist = ReadFromFile_to_List();

            int? pos = null;
            //input Points in right position
            if (hslist.Count != 0 && hslist[0] != null)
            {
                for (int i = 0; i < hslist.Count; i += 2)
                {
                    int tempL = int.Parse(hslist[i].ToString());
                    if (tempL <= pts)
                    {
                        pos = i;
                        break;
                    }
                }
            }
            else
            {
                pos = 0;
            }
            if (pos != null)
            {
                if (hslist.Count != 0 && hslist[0] != null)
                {
                    hslist.Insert((int)pos, pts.ToString());
                    hslist.Insert((int)(pos + 1), name);
                }
                else
                {
                    hslist.Add(pts.ToString());
                    hslist.Add(name.ToString());
                }
            }
            else
            {
                pos = (hslist.Count);
                hslist.Add(pts.ToString());
                hslist.Add(name.ToString());
            }

            if (hslist.Count > ((placesCount * 2))) // if more places then placesCount  - remove last 2 rows;
            {
                hslist.RemoveRange((placesCount * 2), 2);
            }

            Save(hslist); // save to file

            //return position added or -1 if not added;
            if (pos / 2 + 1 <= placesCount)
            {
                return ((int)pos / 2 + 1);
            }
            else
            {
                return (-1);
            }
        }

        public static string PrintPoints_WithPosition(int pos) //result is returned as string!!
        {
            StringBuilder sb = new StringBuilder();
            var hslist = ReadFromFile_to_List();
            int maxLen = 0;
            int intLen = 0;

            for (int i = 0; i < hslist.Count - 1; i += 2)
            {
                if (maxLen <= hslist[i+1].Length)
                {
                    maxLen = hslist[i+1].Length;
                }
                if (intLen <= hslist[i].Length)
                {
                    intLen = hslist[i].Length;
                }

            }


            for (int i = 0; i < hslist.Count - 1; i += 2)
            {
                sb.Append(hslist[i + 1].PadLeft(maxLen, ' ') + " with [" + hslist[i].PadLeft(intLen, ' ') + "] points!");
                if (i / 2 + 1 == pos) sb.Append(" <-- This is your new highscore!");
                sb.Append("\n");
            }
            return (sb.ToString());
        }



        static List<string> ReadFromFile_to_List()
        {
            var hslist = new List<string>();
            string fileName = @".\HighScore.txt";
            try
            {
                StreamReader streamReader = new StreamReader(fileName);
                using (streamReader)
                {
                    string fileContents = string.Empty;
                    while (fileContents != null)
                    {
                        fileContents = streamReader.ReadLine();
                        if (fileContents != null)
                        {
                            hslist.Add(fileContents);
                        }
                    }
                }

                streamReader.Close();
            }
            catch (System.IO.FileNotFoundException)
            {
                //Console.Error.WriteLine("Can not find file {0}.", fileName);
                Save(new List<string> { });
                return (ReadFromFile_to_List());
            }


            return (hslist);
        }

        static void Save(List<string> hslist)
        {
            string fileName = @".\HighScore.txt";

            StreamWriter streamWriter = new StreamWriter(fileName);
            using (streamWriter)
            {
                for (int i = 0; i < hslist.Count; i++)
                {
                    streamWriter.WriteLine(hslist[i].ToString());
                }
            }
            streamWriter.Close();
            //Console.WriteLine("File is written!");
        }


        static void Main()
        {
            //int position = Add(9, null); //null - to ask for name; or input string directly as name;
            //string newString = PrintPoints_WithPosition(position);
            //Console.WriteLine(newString);
        }
    }
}
