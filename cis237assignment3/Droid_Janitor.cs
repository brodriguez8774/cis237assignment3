// Brandon Rodriguez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    /// <summary>
    /// Class for Droids of type Janitor.
    /// Inherits from Utility which inherits from Droid.
    /// </summary>
    class Droid_Janitor : Droid_Utility
    {
        #region Variables

        protected bool hasTrashCompactorBool;
        protected bool hasVacuumBool;

        protected decimal trashCompactorDecimal;
        protected decimal vacuumDecimal;

        #endregion



        #region Constructor

        /// <summary>
        /// Base constructor.
        /// </summary>
        public Droid_Janitor()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="model"></param>
        /// <param name="color"></param>
        /// <param name="hasToolBox"></param>
        /// <param name="hasComputerConnection"></param>
        /// <param name="hasArm"></param>
        /// <param name="hasTrashCompactor"></param>
        /// <param name="hasVacuum"></param>
        public Droid_Janitor(string material, string model, string color, bool hasToolBox, bool hasComputerConnection, bool hasArm, bool hasTrashCompactor, bool hasVacuum)
            : base(material, model, color, hasToolBox, hasComputerConnection, hasArm)
        {
            HasTrashCompactor = hasTrashCompactor;
            HasVacuum = hasVacuum;
            numberOfItemsInt = 8;

            CreateDroid();
        }

        #endregion



        #region Properties

        public bool HasTrashCompactor
        {
            set { hasTrashCompactorBool = value; }
            get { return hasTrashCompactorBool; }
        }

        public bool HasVacuum
        {
            set { hasVacuumBool = value; }
            get { return hasVacuumBool; }
        }

        #endregion



        #region Private Methods

        private void CalculateTrashCompactorCost()
        {
            if (hasTrashCompactorBool)
            {
                trashCompactorDecimal = costPerFeatureDecimal;
            }
            else
            {
                trashCompactorDecimal = 0;
            }
        }

        private void CalculateVacuumCost()
        {
            if (hasVacuumBool)
            {
                vacuumDecimal = costPerFeatureDecimal;
            }
            else
            {
                vacuumDecimal = 0;
            }
        }

        #endregion



        #region Protected Methods

        protected override void CreateDroid()
        {
            base.CreateDroid();

            CalculateTrashCompactorCost();
            CalculateVacuumCost();

            CalculateTotalCost();
        }

        #endregion



        #region Public Methods

        /// <summary>
        /// Calculates total cost of a Janitor droid.
        /// </summary>
        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();
            totalCostDecimal += trashCompactorDecimal + vacuumDecimal;
        }

        /// <summary>
        /// Shortened string for displaying of many droids, each in single line format.
        /// </summary>
        /// <returns>Single ine formatted for list of droids.</returns>
        public override string DisplayShortToString()
        {
            return "Janitor ".PadRight(10) + base.DisplayShortToString();
        }

        /// <summary>
        /// Full string for displaying of single droid spanning multiple lines.
        /// </summary>
        /// <returns>Full information regarding single droid.</returns>
        public override string DisplayLongToString()
        {
            return base.DisplayLongToString() + Environment.NewLine +
                "".PadRight(5) + ("Trash Compactor: " + YesNoString(hasTrashCompactorBool)).PadRight(30) + trashCompactorDecimal.ToString("C").PadLeft(10) + Environment.NewLine +
                "".PadRight(5) + ("Vacuum: " + YesNoString(hasVacuumBool)).PadRight(30) + vacuumDecimal.ToString("C").PadLeft(10) + Environment.NewLine;
        }

        #endregion

    }
}
