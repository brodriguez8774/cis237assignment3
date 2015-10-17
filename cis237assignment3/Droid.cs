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

        protected string selectedMaterialString;
        protected string selectedModelString;
        protected string selectedColorString;
        protected decimal baseCostDecimal;                  // Cost of droid before any extra features. IE, just the material, model, and color cost.
        protected decimal totalCostDecimal;                 // Full cost of droid, including all extra features.
        protected decimal costPerFeatureDecimal = 10;       // Standard cost per most features.
        protected int numberOfItemsInt;                     // Number of individual items influencing droid price.

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
            set { selectedMaterialString = value; }
            get { return selectedMaterialString; }
        }

        public string Model
        {
            set { selectedModelString = value; }
            get { return selectedModelString; }
        }

        public string Color
        {
            set { selectedColorString = value; }
            get { return selectedColorString; }
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

        public int NumberOfItems
        {
            get { return numberOfItemsInt; }
        }

        #endregion



        #region Protected Methods

        

        #endregion



        #region Public Methods

        /// <summary>
        /// Calculates total cost of droid.
        /// </summary>
        public abstract void CalculateTotalCost();

        /// <summary>
        /// Calculates individual feature costs of droid.
        /// </summary>
        public abstract void CalculateFeatures();

        /// <summary>
        /// Shortened string for displaying of many droids, each in single line format.
        /// </summary>
        /// <returns>Single ine formatted for list of droids.</returns>
        public virtual string DisplayShortToString()
        {
            return (selectedMaterialString + " ").PadRight(11) + (selectedModelString + " ").PadRight(10) + (selectedColorString + " ").PadRight(10) + totalCostDecimal.ToString("C").PadLeft(10) + Environment.NewLine;
        }

        /// <summary>
        /// Full string for displaying of single droid spanning multiple lines.
        /// </summary>
        /// <returns>Full information regarding single droid.</returns>
        public abstract string DisplayLongToString();

        #endregion

    }
}
