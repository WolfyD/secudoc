using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace secuDoc
{
    class Program
    {
        
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                foreach (string s in args)
                {
                    if (s.ToLower() == "help")
                    {
                        string hlp = "HELP:\r\n\r\n" +
                                     "dot:|.:".PadRight(25) +                   ">   Length of dot in ms (default 50ms)\r\n" +
                                     "dash:|-:".PadRight(25) +                  ">   Length of dash in ms (default 200ms)\r\n" +
                                     "space:|word:".PadRight(25) +              ">   Length of space in ms (default 200ms)\r\n" +
                                     "fullstop:|sentence:".PadRight(25) +       ">   Length of full stop in ms (default 500ms)\r\n" +
                                     "key:|led:".PadRight(25) +                 ">   LED to use 0:CAPS_LOCK, 1:NUM_LOCK, 2:SCROLL_LOCK (default: 2)\r\n\r\n" + 
                                     "Full setup example: secuDoc.exe .:30 -:100 word:80 fullstop:200 key:2";
                        Console.WriteLine(hlp);
                        Console.ReadLine();
                        break;
                    }
                    else if (s.StartsWith("dot:") || s.StartsWith(".:"))
                    {
                        int i = 50;
                        string n = s.Substring(s.IndexOf(":") + 1).Trim();
                        Int32.TryParse(n, out i);
                        set.Default.dot = i;
                        set.Default.Save();
                    }
                    else if (s.StartsWith("dash:") || s.StartsWith("-:"))
                    {
                        int i = 200;
                        string n = s.Substring(s.IndexOf(":") + 1).Trim();
                        Int32.TryParse(n, out i);
                        set.Default.dash = i;
                        set.Default.Save();
                    }
                    else if (s.StartsWith("space:") || s.StartsWith("word:"))
                    {
                        int i = 200;
                        string n = s.Substring(s.IndexOf(":") + 1).Trim();
                        Int32.TryParse(n, out i);
                        set.Default.space = i;
                        set.Default.Save();
                    }
                    else if (s.StartsWith("fullstop:") || s.StartsWith("sentence:"))
                    {
                        int i = 500;
                        string n = s.Substring(s.IndexOf(":") + 1).Trim();
                        Int32.TryParse(n, out i);
                        set.Default.fullstop = i;
                        set.Default.Save();
                    }
                    else if (s.StartsWith("key:") || s.StartsWith("led:"))
                    {
                        int i = 2;
                        string n = s.Substring(s.IndexOf(":") + 1).Trim();
                        Int32.TryParse(n, out i);
                        set.Default.key = i;
                        set.Default.Save();
                    }
                }
            }


            //lightshow();
        }

        public static void lightshow()
        {
            string s = "";
            int i = 0;
            bool on = false;
            c_morse x = new c_morse();

            while (s.Length == 0)
            {
                Thread.Sleep(new Random().Next(50,200));
                i = new Random(Environment.TickCount).Next(0, 3);
                x.setBTN(i);
                on = !on;
                //ConsoleKeyInfo cki = new ConsoleKeyInfo(' ', ConsoleKey.Spacebar, false, false, false);
                //if (Console.ReadKey().KeyChar == cki.KeyChar) { s = "NO"; }
                x.doSet(on);
            }
        }
    }
}
