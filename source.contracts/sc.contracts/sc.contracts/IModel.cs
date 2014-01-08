using System;

namespace sc.contracts
{
    public interface IModel
    {
        void Calculate(string text, CalculationModes mode);

        event Action<int> On_result;
    }
}