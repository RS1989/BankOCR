using System;
using System.Collections.Generic;
using System.Text;

namespace BankOCR.Models
{
    public class Seven
    {
        private readonly string _digit;
        private readonly string[,] _lines;
        public Seven()
        {
            _digit = "7";
            _lines = new string[3, 3] { { " ", "_", " " }, { " ", " ", "|" }, { " ", " ", "|" } };
        }
        public string[,] lines { get { return _lines; } }
        public string Digit { get { return _digit; } }
    }
}
