// Brandon Rodriguez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    /// <summary>
    /// Class for Droids of type Utility.
    /// Inherits only from Droid.
    /// </summary>
    class Droid_Utility : Droid
    {
        #region Variables

        protected bool hasToolBoxBool;
        protected bool hasComputerConnectiontBool;
        protected bool hasArmBool;

        #endregion



        #region Constructor

        /// <summary>
        /// Base constructor.
        /// </summary>
        public Droid_Utility()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="model"></param>
        /// <param name="color"></param>
        /// <param name="hasToolbox"></param>
        /// <param name="hasComputerConnection"></param>
        /// <param name="hasArm"></param>
        public Droid_Utility(string material, string model, string color, bool hasToolBox, bool hasComputerConnection, bool hasArm)
            : base(material, model, color)
        {
            HasToolBox = hasToolBoxBool;
            HasComputerConnection = hasComputerConnection;
            HasArm = hasArm;
        }

        #endregion



        #region Properties

        public bool HasToolBox
        {
            set { hasToolBoxBool = value; }
            get { return hasToolBoxBool; }
        }

        public bool HasComputerConnection
        {
            set { hasComputerConnectiontBool = value; }
            get { return hasComputerConnectiontBool; }
        }

        public bool HasArm
        {
            set { hasArmBool = value; }
            get { return hasArmBool; }
        }

        #endregion



        #region Protected Methods

        /// <summary>
        /// Mostly used for UI display. Transforms bool display from "true/false" to "yes/no."
        /// </summary>
        /// <param name="validationBool">Bool to convert for display.</param>
        /// <returns>Appropriate string based on bool.</returns>
        protected virtual string YesNoString(bool validationBool)
        {
            string displayString;

            if (validationBool)
            {
                displayString = "Yes";
            }
            else
            {
                displayString = "No";
            }

            return displayString;
        }

        #endregion



        #region Public Methods

        public override void CalculateTotalCost()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Shortened string for displaying of many droids, each in single line format.
        /// </summary>
        /// <returns>String of short Droid information.</returns>
        public override string DisplayShortToString()
        {
            return "Utility Droid: " + totalCostDecimal.ToString().PadLeft(10);
        }

        /// <summary>
        /// Full string for displaying of single droid spanning multiple lines.
        /// </summary>
        /// <returns>String of full Droid information.</returns>
        public override string DisplayFullToString()
        {
            return base.DisplayFullToString() + Environment.NewLine +
                "Toolbox: " + YesNoString(hasArmBool) + Environment.NewLine +
                "Computer Connection: " + YesNoString(hasComputerConnectiontBool) + Environment.NewLine +
                "Arm: " + YesNoString(hasArmBool);
        }

        #endregion

    }
}
