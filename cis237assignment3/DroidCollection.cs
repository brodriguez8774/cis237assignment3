// Brandon Rodriguez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    static class DroidCollection
    {
        #region Variables

        // Variables for getting/saving user input.
        private string userInput;

        private string selectedMaterialString;
        protected string selectedModelString;
        private string selectedColorString;
        private int selectedLanguageInt;
        private bool ToolBoxBool;
        private bool computerConnectionBool;
        private bool armBool;
        private bool trashCompactorBool;
        private bool vacuumBool;
        private bool fireExtinguisherBool;
        private int selectedNumberOfShipsInt;

        #endregion



        #region Constructor

        /// <summary>
        /// Base constructor.
        /// </summary>
        public DroidCollection()
        {

        }


        public DroidCollection(int userSelection)
        {

        }

        #endregion



        #region Properties



        #endregion



        #region Private Methods

        private void TypeSelection()
        {
            UserInterface.DisplayTypeSelectionMenu();
            userInput = UserInterface.GetUserInput();

            switch (userInput)
            {
                case "1":
                    PurchaseProtocol();
                    break;
                case "2":
                    PurchaseUtility();
                    break;
                case "3":
                    PurchaseJanitor();
                    break;
                case "4":
                    PurchaseAstromech();
                    break;
                case "esc":
                    break;
                default:
                    break;
            }
        }

        private void PurchaseGeneric()
        {
            ModelSelection();
            MaterialSelection();
            ColorSelection();

        }

        private void PurchaseProtocol()
        {
            PurchaseGeneric();
            LanguageSelection();

        }

        private void PurchaseUtility()
        {
            PurchaseGeneric();
            ToolBoxSelection();
            CompConnectionSelection();
            ArmSelection();
        }

        private void PurchaseJanitor()
        {
            PurchaseUtility();

        }

        private void PurchaseAstromech()
        {
            PurchaseUtility();

        }

        #region Individual Feature Selections

        private void ModelSelection()
        {
            UserInterface.DisplayModelSelectionMenu(Droid_Generic.MODEL_1_STRING, Droid_Generic.MODEL_2_STRING);
            userInput = UserInterface.GetUserInput();

            switch (userInput)
            {
                case "1":
                    selectedModelString = Droid_Generic.MODEL_1_STRING;
                    break;
                case "2":
                    selectedModelString = Droid_Generic.MODEL_2_STRING;
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "esc":
                    break;
                default:
                    break;
            }
        }

        private void MaterialSelection()
        {
            UserInterface.DisplayMaterialSelectionMenu(Droid_Generic.MATERIAL_1_STRING, Droid_Generic.MATERIAL_2_STRING, Droid_Generic.MATERIAL_3_STRING, Droid_Generic.MATERIAL_4_STRING, Droid_Generic.MATERIAL_5_STRING);
            userInput = UserInterface.GetUserInput();

            switch (userInput)
            {
                case "1":
                    selectedMaterialString = Droid_Generic.MATERIAL_1_STRING;
                    break;
                case "2":
                    selectedMaterialString = Droid_Generic.MATERIAL_2_STRING;
                    break;
                case "3":
                    selectedMaterialString = Droid_Generic.MATERIAL_3_STRING;
                    break;
                case "4":
                    selectedMaterialString = Droid_Generic.MATERIAL_4_STRING;
                    break;
                case "5":
                    selectedMaterialString = Droid_Generic.MATERIAL_5_STRING;
                    break;
                case "esc":
                    break;
                default:
                    break;
            }
        }

        private void ColorSelection()
        {
            UserInterface.DisplayColorSelectionMenu(Droid_Generic.COLOR_1_STRING, Droid_Generic.COLOR_2_STRING, Droid_Generic.COLOR_3_STRING, Droid_Generic.COLOR_4_STRING, Droid_Generic.COLOR_5_STRING);
            userInput = UserInterface.GetUserInput();

            switch (userInput)
            {
                case "1":
                    selectedColorString = Droid_Generic.COLOR_1_STRING;
                    break;
                case "2":
                    selectedColorString = Droid_Generic.COLOR_2_STRING;
                    break;
                case "3":
                    selectedColorString = Droid_Generic.COLOR_3_STRING;
                    break;
                case "4":
                    selectedColorString = Droid_Generic.COLOR_4_STRING;
                    break;
                case "5":
                    selectedColorString = Droid_Generic.COLOR_5_STRING;
                    break;
                case "esc":
                    break;
                default:
                    break;
            }
        }

        private void LanguageSelection()
        {

        }

        private void ToolBoxSelection()
        {

        }

        private void CompConnectionSelection()
        {

        }

        private void ArmSelection()
        {

        }

        private void TrashCompactorSelection()
        {

        }

        private void VacuumSelection()
        {

        }

        private void FireExtinguisherSelection()
        {

        }

        private void NumberOfShipsSelection()
        {

        }

        #endregion

        #endregion



        #region Public Methods

        public void PurchaseDroid()
        {
            

            
        }

        #endregion

    }
}
