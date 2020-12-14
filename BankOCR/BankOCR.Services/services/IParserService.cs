using System.Collections.Generic;

namespace BankOCR.Services.services
{
    public interface IParserService
    {
        Dictionary<int, List<string>> ParseToLine(string path);
        List<List<Dictionary<int, string[,]>>> ParseLinesToNumbers(Dictionary<int, List<string>> data);
    }
}