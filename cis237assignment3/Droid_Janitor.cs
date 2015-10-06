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



        #region Methods

        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();
        }

        public override string DisplayToString()
        {
            return base.DisplayToString() + Environment.NewLine +
                "Trash Compactor: " + YesNoString(hasTrashCompactorBool) + Environment.NewLine +
                "Vacuum: " + YesNoString(hasVacuumBool);
        }

        #endregion

    }
}
