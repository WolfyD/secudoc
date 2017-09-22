using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secuDoc
{
    class c_readFile
    {
        public Dictionary<string, string> morse = new Dictionary<string, string>();

        public c_readFile()
        {
            morse.Add("A","._");
            morse.Add("B","_...");
            morse.Add("C","_._.");
            morse.Add("D","_..");
            morse.Add("E",".");
            morse.Add("F",".._.");
            morse.Add("G","__.");
            morse.Add("H","....");
            morse.Add("I","..");
            morse.Add("J",".___");
            morse.Add("K","_._");
            morse.Add("L","._..");
            morse.Add("M","__");
            morse.Add("N","_.");
            morse.Add("O","___");
            morse.Add("P",".__.");
            morse.Add("Q","__._");
            morse.Add("R","._.");
            morse.Add("S","...");
            morse.Add("T","_");
            morse.Add("U",".._");
            morse.Add("V","..._");
            morse.Add("W",".__");
            morse.Add("X","_.._");
            morse.Add("Y","_.__");
            morse.Add("Z","__..");
            morse.Add("Á",".__._");
            morse.Add("É",".._..");
            morse.Add("Ö","___.");
            morse.Add("Ä","._._");
            morse.Add("Ñ","__.__");
            morse.Add("Ü","..__");
            morse.Add("1",".____");
            morse.Add("2","..___");
            morse.Add("3","...__");
            morse.Add("4","...._");
            morse.Add("5",".....");
            morse.Add("6","_....");
            morse.Add("7","__...");
            morse.Add("8","___..");
            morse.Add("9","____.");
            morse.Add("0","_____");
            morse.Add(",","__..__");
            morse.Add("?","..__..");
            morse.Add(":","___...");
            morse.Add("-","_...._");
            morse.Add("\"","._.._.");
            morse.Add("(","_.__.");
            morse.Add("=","_..._");
            morse.Add("×","_.._");
            morse.Add(".","._._._");
            morse.Add(";","_._._.");
            morse.Add("/","_.._.");
            morse.Add("'",".____.");
            morse.Add("_","..__._");
            morse.Add(")","_.__._");
            morse.Add("+","._._.");
            morse.Add("@",".__._.");
        }

        public void readFile(String fn, c_morse morse)
        {
            String fl = File.ReadAllText(fn);

        }
    }
}
