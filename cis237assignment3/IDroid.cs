using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    /// <summary>
    /// Interface for all droid objects.
    /// Acts as a "universal blueprint/contract" of sorts.
    /// </summary>
    interface IDroid
    {
        void CalculateTotalCost();

        decimal TotalCost { get; set; }
    }
}
