using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace BankOCR.Models
{
    public class Numbers
    {
        private readonly Dictionary<int, object> _numbers;

        public Numbers(Dictionary<int, object> numbers)
        {
            _numbers = numbers;
        }

        public Dictionary<int, object> numbers { get { return _numbers; }  }
    }
}
