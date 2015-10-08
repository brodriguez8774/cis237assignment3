// Brandon Rodriguez

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
        protected decimal totalLanguageDecimal;

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

        public decimal TotalLanguageCost
        {
            get { return numberOfLanguagesInt; }
        }

        #endregion



        #region Private Methods

        /// <summary>
        /// Determines total language cost for droid.
        /// </summary>
        private void CalculateLanguageCost()
        {
            totalLanguageDecimal = numberOfLanguagesInt * COST_PER_LANGUAGE;
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
            return "Protocol Droid: " + totalCostDecimal.ToString().PadLeft(10);
        }

        /// <summary>
        /// Full string for displaying of single droid spanning multiple lines.
        /// </summary>
        /// <returns>String of full Droid information.</returns>
        public override string DisplayFullToString()
        {
            return base.DisplayFullToString() + Environment.NewLine +
                "Languages: " + numberOfLanguagesInt;
        }

        #endregion

    }
}
