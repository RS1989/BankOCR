using System;
using System.Collections.Generic;
using System.Text;

namespace BankOCR.Models
{
    public class Four
    {
        private readonly string _digit;
        private readonly string[,] _lines;

        public Four()
        {
            _digit = "4";
            _lines = new string[3, 3] { { " ", " ", " " }, { "|", "_", "|" }, { " ", " ", "|" } };
        }
        public string[,] lines { get { return _lines; } }
        public string Digit { get { return _digit; } }
    }
}
