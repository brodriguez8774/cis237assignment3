using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    /// <summary>
    /// Abstract class for Droids.
    /// Derives from IDroid interface.
    /// </summary>
    abstract class Droid : IDroid
    {
        #region Variables

        public string materialString;
        public string modelString;
        public string colorString;
        public decimal baseCostDecimal;
        public decimal totalCostDecimal;

        #endregion



        #region Constructor

        /// <summary>
        /// Base constructor.
        /// </summary>
        public Droid()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="model"></param>
        /// <param name="color"></param>
        public Droid(string material, string model, string color)
        {
            Material = material;
            Model = model;
            Color = color;

            baseCostDecimal = 10m;
        }

        #endregion



        #region Properties

        public string Material
        {
            set { materialString = value; }
            get { return materialString; }
        }

        public string Model
        {
            set { modelString = value; }
            get { return modelString; }
        }

        public string Color
        {
            set { colorString = value; }
            get { return colorString; }
        }

        public decimal BaseCost
        {
            set { baseCostDecimal = value; }
            get { return baseCostDecimal; }
        }

        public decimal TotalCost
        {
            set { totalCostDecimal = value; }
            get { return totalCostDecimal; }
        }

        #endregion



        #region Methods

        public abstract void CalculateTotalCost();

        public virtual string DisplayToString()
        {
            return materialString + " " + modelString + " : " + colorString;
        }

        #endregion

    }
}
