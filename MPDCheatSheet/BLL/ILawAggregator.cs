using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace BLL
{
    public interface ILawAggregator
    {
        IEnumerable<Charge> GetFelonyCharges();
        IEnumerable<Charge> GetMisdemeanorCharges();
        IEnumerable<Charge> MinorMisdemeanors();
    }
}
