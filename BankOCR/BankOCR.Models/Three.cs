using System;
using System.Collections.Generic;
using System.Text;

namespace BankOCR.Models
{
    public class Three
    {
        private readonly string _digit;
        private readonly string[,] _lines;
        public Three()
        {
            _digit = "3";
            _lines = new string[3, 3] { { " ", "_", " " }, { " ", "_", "|" }, { " ", "_", "|" } };
        }
        public string[,] lines { get { return _lines; } }
        public string Digit { get { return _digit; } }
    }
}
