﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    /// <summary>
    /// Class for Droids of type Astromech.
    /// Inherits from Utility which inherits from Droid.
    /// </summary>
    class Droid_Astromech : Droid_Utility
    {
        #region Variables

        protected bool hasFireExtinguisherBool;
        protected int numberOfShipsInt;

        #endregion



        #region Constructor

        /// <summary>
        /// Base constructor.
        /// </summary>
        public Droid_Astromech()
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
        /// <param name="hasFireExtinguisher"></param>
        /// <param name="numberOfShips"></param>
        public Droid_Astromech(string material, string model, string color, bool hasToolBox, bool hasComputerConnection, bool hasArm, bool hasFireExtinguisher, int numberOfShips)
            : base(material, model, color, hasToolBox, hasComputerConnection, hasArm)
        {
            HasFireExtinguisher = hasFireExtinguisher;
            NumberOfShips = numberOfShips;
        }

        #endregion



        #region Properties

        public bool HasFireExtinguisher
        {
            set { hasFireExtinguisherBool = value; }
            get { return hasFireExtinguisherBool; }
        }

        public int NumberOfShips
        {
            set { numberOfShipsInt = value; }
            get { return numberOfShipsInt; }
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
                "Fire Extinguisher: " + YesNoString(hasFireExtinguisherBool) + Environment.NewLine;
        }

        #endregion

    }
}