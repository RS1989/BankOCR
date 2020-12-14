using BankOCR.Services.services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankOCR.Tests.services
{
    public class TransformServiceTest
    {
        private IParserService _parserService;
        private ITransformService _transformService;
        private List<List<Dictionary<int, string[,]>>> _data;
        [SetUp]
        public void Setup()
        {
            _parserService = new ParserService();
            _transformService = new TransformService();
            var data = _parserService.ParseToLine("./testfile/ocr1.txt");
            _data = _parserService.ParseLinesToNumbers(data);
        }

        [Test]
        public void GetNumbersTest()
        {
            var result = _transformService.GetNumbers(_data);

            Assert.IsTrue(result!=null, "GetNumbers returned wrong results");
            Assert.IsTrue(result.Count > 0, "GetNumbers returned wrong results");
            Assert.IsTrue(result.Count == 2, "GetNumbers returned wrong results");
            Assert.IsTrue(result[0] == "123456789", "GetNumbers returned wrong results");
            Assert.IsTrue(result[1] == "490067715", "GetNumbers returned wrong results");
        }
    }
}
