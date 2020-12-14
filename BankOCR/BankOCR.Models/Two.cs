using System;
using System.Collections.Generic;
using System.Text;

namespace BankOCR.Models
{
    public class Two
    {
        private readonly string _digit;
        private readonly string[,] _lines;
        public Two()
        {
            _digit = "2";
            _lines = new string[3, 3] { { " ", "_", " " }, { " ", "_", "|" }, { "|", "_", " " } };
        }
        public string[,] lines { get { return _lines; } }
        public string Digit { get { return _digit; } }
    }
}
