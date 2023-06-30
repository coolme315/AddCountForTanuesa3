using System;
using System.Text;
using System.IO;

namespace tanu3addcount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                string admode = Decode_Base64(args[0]);
                string fn = Decode_Base64(args[1]);
                string plusnum = Decode_Base64(args[2]);
                string line = "";
                int num = 0;
                if (admode == "-add")
                {
                    using (var reader = new StreamReader(fn))
                    {
                        line = reader.ReadToEnd();
                        num = int.Parse(line);
                        num = num + int.Parse(plusnum);
                        line = num.ToString();
                    }
                    using (StreamWriter sw = new StreamWriter(fn))
                    {

                        sw.Write(line);
                    }

                }

            }
        }

        static string Decode_Base64(string str)
        {
            Encoding enc = Encoding.UTF8;
            return enc.GetString(Convert.FromBase64String(str));
        }
    }
}