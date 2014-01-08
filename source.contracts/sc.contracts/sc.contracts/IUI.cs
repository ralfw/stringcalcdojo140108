using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sc.contracts
{
    public interface IUI
    {
        event Action<string, CalculationModes> On_calc_cmd;

        void Show_result(int value);
    }
}
