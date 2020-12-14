using BankOCR.Services.services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankOCR.Tests.services
{
    public class ParserServiceTest
    {
        private IParserService _parserService; 
        [SetUp]
        public void Setup()
        {
            _parserService = new ParserService();
        }


        [Test]
        [TestCase("./testfile/ocr1.txt")]
        public void ParseToLineTest(string path)
        {
            var result = _parserService.ParseToLine(path);

            Assert.IsTrue(result != null, "ParserToLine retrurns wrong results");
            Assert.IsTrue(result.Count > 0, "ParserToLine retrurns wrong results");
            Assert.IsTrue(result.Count == 2, "ParserToLine retrurns wrong results");
        }

        [Test]
        [TestCase("./testfile/ocr1.txt")]
        public void ParseLinesToNumbersTest(string path)
        {
            var data = _parserService.ParseToLine(path);
            var result = _parserService.ParseLinesToNumbers(data);

            Assert.IsTrue(result != null, "ParserToLine retrurns wrong results");
            Assert.IsTrue(result.Count > 0, "ParserToLine retrurns wrong results");
            Assert.IsTrue(result.Count == 2, "ParserToLine retrurns wrong results");
        }
    }
}
