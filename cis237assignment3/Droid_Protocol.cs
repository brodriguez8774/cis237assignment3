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
    class Droid_Protocol : Droid_Generic
    {
        #region Variables

        protected int numberOfLanguagesInt;
        protected const decimal COST_PER_LANGUAGE = 1;        // Temp cost placeholder.
        protected decimal totalLanguageDecimal;

        // Language selection constants
        public const int LANGUAGE_SELECTION_1 = 1;
        public const int LANGUAGE_SELECTION_2 = 3;
        public const int LANGUAGE_SELECTION_3 = 7;
        public const int LANGUAGE_SELECTION_4 = 15;

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
            numberOfItemsInt = 4;

            CreateDroid();
        }

        #endregion



        #region Properties

        public int NumberOfLanguages
        {
            set { numberOfLanguagesInt = value; }
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



        #region Protected methods

        protected override void CreateDroid()
        {
            base.CreateDroid();

            CalculateLanguageCost();

            CalculateTotalCost();
        }

        #endregion



        #region Public Methods

        /// <summary>
        /// Calculates total cost of a Protocol droid.
        /// </summary>
        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();
            totalCostDecimal += totalLanguageDecimal;
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
        public override string DisplayLongToString()
        {
            return base.DisplayLongToString() + Environment.NewLine +
                "Languages: " + numberOfLanguagesInt;
        }

        #endregion

    }
}
