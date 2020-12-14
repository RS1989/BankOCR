using System;
using System.Collections.Generic;
using System.Text;

namespace BankOCR.Models
{
    public class One
    {
        private readonly string _digit;
        private readonly string[,] _lines;
        public One()
        {
            _digit = "1";
            _lines = new string[3, 3] { { " ", " ", " " }, { " ", " ", "|" }, { " ", " ", "|" } };
        }
        public string[,] lines { get { return _lines; } }
        public string Digit { get { return _digit; } }
    }
}
