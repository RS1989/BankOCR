using System;
using System.Collections.Generic;
using System.Text;

namespace BankOCR.Models
{
    public class Nine
    {
        private readonly string _digit;
        private readonly string[,] _lines;
        public Nine()
        {
            _digit = "9";
            _lines = new string[3, 3] { { " ", "_", " " }, { "|", "_", "|" }, { " ", "_", "|" } };
        }
        public string[,] lines { get { return _lines; } }
        public string Digit { get { return _digit; } }
    }
}
