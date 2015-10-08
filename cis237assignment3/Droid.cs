// Brandon Rodriguez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    /// <summary>
    /// Abstract class for Droids. Handles "higher level" thinking/rules.
    /// Derives from IDroid interface.
    /// </summary>
    abstract class Droid : IDroid
    {
        #region Variables

        protected string materialString;
        protected string modelString;
        protected string colorString;
        protected decimal baseCostDecimal;
        protected decimal totalCostDecimal;
        protected decimal costPerFeature;       // Standard cost per most features.

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



        #region Protected Methods

        

        #endregion



        #region Public Methods

        public abstract void CalculateTotalCost();

        /// <summary>
        /// Shortened string for displaying of many droids, each in single line format.
        /// </summary>
        /// <returns>String of short Droid information.</returns>
        public abstract string DisplayShortToString();

        /// <summary>
        /// Full string for displaying of single droid spanning multiple lines.
        /// </summary>
        /// <returns>String of full Droid information.</returns>
        public virtual string DisplayFullToString()
        {
            return materialString + " " + modelString + " : " + colorString;
        }

        #endregion

    }
}
