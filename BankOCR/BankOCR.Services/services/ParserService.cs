using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BankOCR.Services.services
{
    public class ParserService : IParserService
    {
        public Dictionary<int, List<string>> ParseToLine(string path)
        {
            var counter = 0;
            var lineNumber = 0;
            var line = string.Empty;
            var lineDictionary = new Dictionary<int, List<string>>();
            var lineArray = new List<string>();
            var file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                counter ++;
                lineArray.Add(line);
                if (counter == 4)
                {
                    counter = 0;
                    lineArray = new List<string>();
                    continue;
                }
                if (counter == 3)
                {
                    lineDictionary.Add(lineNumber, lineArray);
                    lineNumber++;                   
                    lineArray = new List<string>();
                }
            }
            return lineDictionary;
        }

        public List<List<Dictionary<int, string[,]>>> ParseLinesToNumbers(Dictionary<int, List<string>> data)
        {
            var result = new List<List<Dictionary<int, string[,]>>>();
            var resultRow = new List<Dictionary<int, string[,]>>();
            var lineCount = 0;
            foreach (var lines in data.Values)
            {                
                var numberInLineCount = 0;
                var lineNumber = new List<Dictionary<int, List<string>>>();
                foreach (var line in lines)
                {                    
                    var lineArray = line.ToCharArray();                    
                    var linePerNumberList = new Dictionary<int,List<string>>();
                    var linesNumberCharList = new List<string>();
                    var charCount = 0;
                    var numberCount = 0;
                    foreach (var ch in lineArray)
                    {
                        linesNumberCharList.Add(ch.ToString());
                        charCount++;
                        if (charCount == 3)
                        {
                            numberCount++;
                            linePerNumberList.Add(numberCount, linesNumberCharList);
                            linesNumberCharList = new List<string>();
                            numberInLineCount = numberCount;
                            charCount = 0;                            
                        }
                    }
                    lineNumber.Add(linePerNumberList);
                }

                var numberArray = new string[3, 3];
                for (var i = 1; i <= numberInLineCount; i++)
                {
                    var numberCharLineCounter = 0;
                    foreach (var lineNumbeValue in lineNumber)
                    {
                        for (var j = 0; j < lineNumbeValue.GetValueOrDefault(i).Count(); j++)
                        {
                            numberArray[numberCharLineCounter, j] = lineNumbeValue.GetValueOrDefault(i)[j];
                        }

                        numberCharLineCounter++;
                        if (numberCharLineCounter == 3)
                        {
                            var numberInRow = new Dictionary<int, string[,]>();
                            numberInRow.Add(lineCount, numberArray);
                            numberArray = new string[3, 3];
                            lineCount++;
                            numberCharLineCounter = 0;
                            resultRow.Add(numberInRow);
                        }
                    }
                }
                result.Add(resultRow);
                resultRow = new List<Dictionary<int, string[,]>>();
            }
            return result;
        }
    }
}
