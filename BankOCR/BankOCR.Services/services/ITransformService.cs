using System.Collections.Generic;

namespace BankOCR.Services.services
{
    public interface ITransformService
    {
        List<string> GetNumbers(List<List<Dictionary<int, string[,]>>> data);
    }
}