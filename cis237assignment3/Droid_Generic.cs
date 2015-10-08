// Brandon Rodriguez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    /// <summary>
    /// Not Sure if needed?
    /// </summary>
    class Droid_Generic : Droid
    {
        #region Variables

        // All the necessary variables for material selection.
        private string selectedMaterialString;
        private decimal selectedMaterialDecimal;
        public static const string MATERIAL_1_STRING = "Tin";
        public static const string MATERIAL_2_STRING = "Steel";
        public static const string MATERIAL_3_STRING = "Titanium";
        public static const string MATERIAL_4_STRING = "Mythril";
        public static const string MATERIAL_5_STRING = "Unobtanium";
        private decimal material1Decimal;
        private decimal material2Decimal;
        private decimal material3Decimal;
        private decimal material4Decimal;
        private decimal material5Decimal;

        // All the necessary variables for model selection.
        protected string selectedModelString;
        protected decimal selectedModelDecimal;
        public static const string MODEL_1_STRING = "TI-84";
        public static const string MODEL_2_STRING = "TI-84";
        private decimal model1Decimal;
        private decimal model2Decimal;

        // All the necessary variables for color selection.
        private string selectedColorString;
        private decimal selectedColorDecimal;
        public static const string COLOR_1_STRING = "White";
        public static const string COLOR_2_STRING = "Black";
        public static const string COLOR_3_STRING = "Blue";
        public static const string COLOR_4_STRING = "Red";
        public static const string COLOR_5_STRING = "Green";
        private decimal color1Decimal;
        private decimal color2Decimal;
        private decimal color3Decimal;
        private decimal color4Decimal;
        private decimal color5Decimal;

        // Random variables for pricing creation.
        Random random = new Random();
        private int randomNumberInt;
        private int clearanceInt;

        #endregion



        #region Constructor

        /// <summary>
        /// Base constructor.
        /// </summary>
        public Droid_Generic()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="model"></param>
        /// <param name="color"></param>
        public Droid_Generic(string material, string model, string color)
            : base(material, model, color)
        {

        }

        #endregion



        #region Properties



        #endregion



        #region Private Methods

        

        /// <summary>
        /// Sets a clearance int for the program. This is the permanent discount for all items on clearance.
        /// </summary>
        private void SetClearancePrice()
        {
            if (clearanceInt == null)
            {
                clearanceInt = random.Next(1, 10);
            }
        }

        /// <summary>
        /// Sets pricings of each material type.
        /// </summary>
        private void MaterialPricing()
        {
            SetClearancePrice();

            randomNumberInt = random.Next(5);
            decimal baseMaterialCost = baseCostDecimal * 10;

            // Set price of material 1.
            if (randomNumberInt == 0)
            {
                material1Decimal = ((baseMaterialCost - clearanceInt) / 2) + AddCents();
            }
            else
            {
                material1Decimal = (baseMaterialCost / 2) + AddCents();
            }

            // Set price of material 2.
            if (randomNumberInt == 1)
            {
                material2Decimal = (baseMaterialCost - clearanceInt) + AddCents();
            }
            else
            {
                material2Decimal = baseMaterialCost + AddCents();
            }

            // Set price of material 3.
            if (randomNumberInt == 2)
            {
                material3Decimal = (baseMaterialCost - clearanceInt) + AddCents();
            }
            else
            {
                material3Decimal = baseMaterialCost + AddCents();
            }

            // Set price of material 4.
            if (randomNumberInt == 3)
            {
                material4Decimal = (baseMaterialCost - clearanceInt) + AddCents();
            }
            else
            {
                material4Decimal = baseMaterialCost + AddCents();
            }

            // Set price of material 5.
            if (randomNumberInt == 4)
            {
                material5Decimal = (baseMaterialCost - clearanceInt) + AddCents();
            }
            else
            {
                material5Decimal = baseMaterialCost + AddCents();
            }
        }

        /// <summary>
        /// Sets pricings of each model.
        /// </summary>
        private void ModelPricing()
        {
            randomNumberInt = random.Next(2);
            decimal baseModelCost = baseCostDecimal * 5;

            // Sets price of model 1.
            if (randomNumberInt == 0)
            {
                model1Decimal = (baseModelCost - clearanceInt) + AddCents();
            }
            else
            {
                model1Decimal = baseModelCost + AddCents();
            }

            // Sets price of model 2.
            if (randomNumberInt == 1)
            {
                model2Decimal = (baseModelCost - clearanceInt) + AddCents();
            }
            else
            {
                model2Decimal = baseModelCost + AddCents();
            }
        }

        /// <summary>
        /// Sets pricings of each color.
        /// </summary>
        private void ColorPricing()
        {
            randomNumberInt = random.Next(5);
            decimal baseColorCost = baseCostDecimal / 2;

            // Sets price of color 1.
            if (randomNumberInt == 0)
            {
                color1Decimal = (baseColorCost - clearanceInt) + AddCents();
            }
            else
            {
                color1Decimal = baseColorCost + AddCents();
            }

            // Sets price of color 2.
            if (randomNumberInt == 1)
            {
                color2Decimal = (baseColorCost - clearanceInt) + AddCents();
            }
            else
            {
                color2Decimal = baseColorCost + AddCents();
            }

            // Sets price of color 3.
            if (randomNumberInt == 2)
            {
                color3Decimal = (baseColorCost - clearanceInt) + AddCents();
            }
            else
            {
                color3Decimal = baseColorCost + AddCents();
            }

            // Sets price of color 4.
            if (randomNumberInt == 3)
            {
                color4Decimal = (baseColorCost - clearanceInt) + AddCents();
            }
            else
            {
                color4Decimal = baseColorCost + AddCents();
            }

            // Sets price of color 5.
            if (randomNumberInt == 4)
            {
                color5Decimal = (baseColorCost - clearanceInt) + AddCents();
            }
            else
            {
                color5Decimal = baseColorCost + AddCents();
            }
        }

        #endregion



        #region Protected Methods

        /// <summary>
        /// Adds a random amount of change for each pricing.
        /// </summary>
        /// <returns>A random decimal between 0(inclusive) and 1(exclusive).</returns>
        protected decimal AddCents()
        {
            double centsDouble = random.NextDouble();
            return Convert.ToDecimal(centsDouble);
        }

        #endregion



        #region Public Methods

        public override void CalculateTotalCost()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
