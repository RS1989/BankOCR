using System;
using System.Collections.Generic;
using System.Text;

namespace BankOCR.Models
{
    public class Zero
    {
        private readonly string _digit;
        private readonly string[,] _lines;
        public Zero()
        {
            _digit = "0";
            _lines = new string[3, 3] { {" ", "_", " " }, { "|", " " , "|" }, { "|", "_", "|" } };
        }
        public string[,] lines { get { return _lines; } }
        public string Digit { get { return _digit; } }
    }
}
