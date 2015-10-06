using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    /// <summary>
    /// Class for Droids of type Protocol.
    /// Inherits only from Droid.
    /// </summary>
    class Droid_Protocol : Droid
    {
        #region Variables

        protected int numberOfLanguagesInt;

        protected const decimal COST_PER_LANGUAGE = 1;        // Temp cost placeholder.

        #endregion



        #region Constructor

        /// <summary>
        /// Base constructor.
        /// </summary>
        public Droid_Protocol()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="model"></param>
        /// <param name="color"></param>
        /// <param name="numberOfLanguages"></param>
        public Droid_Protocol(string material, string model, string color, int numberOfLanguages)
            : base(material, model, color)
        {
            NumberOfLanguages = numberOfLanguages;
        }

        #endregion



        #region Properties

        public int NumberOfLanguages
        {
            set { numberOfLanguagesInt = value; }
            get { return numberOfLanguagesInt; }
        }

        #endregion



        #region Methods

        public override void CalculateTotalCost()
        {
            throw new NotImplementedException();
        }

        public override string DisplayToString()
        {
            return base.DisplayToString() + Environment.NewLine +
                "Languages: " + numberOfLanguagesInt;
        }

        #endregion

    }
}
