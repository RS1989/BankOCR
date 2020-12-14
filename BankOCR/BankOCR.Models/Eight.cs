using System;
using System.Collections.Generic;
using System.Text;

namespace BankOCR.Models
{
    public class Eight
    {
        private readonly string _digit;
        private readonly string[,] _lines;
        public Eight()
        {
            _digit = "8";
            _lines = new string[3, 3] { { " ", "_", " " }, { "|", "_", "|" }, { "|", "_", "|" } };
        }
        public string[,] lines { get { return _lines; } }
        public string Digit { get { return _digit; } }
    }
}
