// Brandon Rodriguez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    /// <summary>
    /// Handles main operations of program.
    /// </summary>
    class RunProgram
    {
        #region Variables

        private bool runProgram;
        private bool menusBool;         // Used to exit back to main menu if user decides to. True to stay in menus. False if user typed to exit.

        // Variables for getting/saving user input.
        private string userInputString;

        private string selectedMaterialString;
        private string selectedModelString;
        private string selectedColorString;
        private int selectedLanguageInt;
        private bool toolBoxBool;
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
        public RunProgram()
        {
            runProgram = true;
            Run();
        }

        #endregion



        #region Properties



        #endregion



        #region Methods

        /// <summary>
        /// Holds program in loop until exit is chosen.
        /// </summary>
        private void Run()
        {
            while (runProgram)
            {
                // Resets/initializes menu bool to allow user to stay in menus.
                menusBool = true;

                UserInterface.Menus.DisplayMainMenu();
                userInputString = UserInterface.GetUserInput();
                MainMenuSelection();
            }
        }

        private void MainMenuSelection()
        {
            switch (userInputString)
            {
                case "1":
                    PurchaseDroid();
                    break;
                case "2":
                    DisplayReciept();
                    break;
                case "3":
                    DisplaySingle();
                    break;
                case "4":
                    Exit();
                    break;
                case "esc":
                    Exit();
                    break;
                default:
                    break;
            }
        }

        private void PurchaseDroid()
        {
            DroidTypeSelection();
        }

        private void DisplayReciept()
        {

        }

        private void DisplaySingle()
        {

        }

        private void Exit()
        {
            runProgram = false;
        }

        private void DroidTypeSelection()
        {
            UserInterface.Menus.DisplayTypeSelectionMenu();
            userInputString = UserInterface.GetUserInput();

            switch (userInputString)
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

        /// <summary>
        /// Methods to run if purchasing any kind of droid at all (generic).
        /// </summary>
        private void PurchaseGeneric()
        {
            if (menusBool)
            {
                ModelSelection();
            }
            if (menusBool)
            {
                MaterialSelection();
            }
            if (menusBool)
            {
                ColorSelection();
            }

        }

        /// <summary>
        /// Methods to run if purchasing a droid of type Protocol.
        /// </summary>
        private void PurchaseProtocol()
        {
            if (menusBool)
            {
                PurchaseGeneric();
            }
            if (menusBool)
            {
                LanguageSelection();
            }
            if (menusBool)
            {
                IDroid aDroid = new Droid_Protocol(selectedMaterialString, selectedModelString, selectedColorString, selectedLanguageInt);
            }
        }

        /// <summary>
        /// Methods to run if purchasing a droid of type Utility.
        /// </summary>
        private void PurchaseUtility()
        {
            if (menusBool)
            {
                PurchaseGeneric();
            }
            if (menusBool)
            {
                ToolBoxSelection();
            }
            if (menusBool)
            {
                CompConnectionSelection();
            }
            if (menusBool)
            {
                ArmSelection();
            }
            if (menusBool)
            {
                IDroid aDroid = new Droid_Utility(selectedMaterialString, selectedModelString, selectedColorString, toolBoxBool, computerConnectionBool, armBool);
            }
        }

        /// <summary>
        /// Methods to run if purchasing a droid of type Janitor.
        /// </summary>
        private void PurchaseJanitor()
        {
            if (menusBool)
            {
                PurchaseUtility();
            }
            if (menusBool)
            {
                TrashCompactorSelection();
            }
            if (menusBool)
            {
                VacuumSelection();
            }
            if (menusBool)
            {
                IDroid aDroid = new Droid_Janitor(selectedMaterialString, selectedModelString, selectedColorString, toolBoxBool, computerConnectionBool, armBool, trashCompactorBool, vacuumBool);
            }
        }

        /// <summary>
        /// Methods to run if purchasing a droid of type Astromech.
        /// </summary>
        private void PurchaseAstromech()
        {
            if (menusBool)
            {
                PurchaseUtility();
            }
            if (menusBool)
            {
                FireExtinguisherSelection();
            }
            if (menusBool)
            {
                NumberOfShipsSelection();
            }
            if (menusBool)
            {
                IDroid aDroid = new Droid_Astromech(selectedMaterialString, selectedModelString, selectedColorString, toolBoxBool, computerConnectionBool, armBool, fireExtinguisherBool, selectedNumberOfShipsInt);
            }
        }

        #region Individual Feature Selections

        /// <summary>
        /// Handles user selection of droid Model.
        /// </summary>
        private void ModelSelection()
        {
            UserInterface.Menus.DisplayModelSelectionMenu(Droid_Generic.MODEL_1_STRING, Droid_Generic.MODEL_2_STRING);
            userInputString = UserInterface.GetUserInput();

            switch (userInputString)
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
                    menusBool = false;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Handles user selection of droid Material.
        /// </summary>
        private void MaterialSelection()
        {
            UserInterface.Menus.DisplayMaterialSelectionMenu(Droid_Generic.MATERIAL_1_STRING, Droid_Generic.MATERIAL_2_STRING, Droid_Generic.MATERIAL_3_STRING, Droid_Generic.MATERIAL_4_STRING, Droid_Generic.MATERIAL_5_STRING);
            userInputString = UserInterface.GetUserInput();

            switch (userInputString)
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
                    menusBool = false;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Handles user selection of droid Color.
        /// </summary>
        private void ColorSelection()
        {
            UserInterface.Menus.DisplayColorSelectionMenu(Droid_Generic.COLOR_1_STRING, Droid_Generic.COLOR_2_STRING, Droid_Generic.COLOR_3_STRING, Droid_Generic.COLOR_4_STRING, Droid_Generic.COLOR_5_STRING);
            userInputString = UserInterface.GetUserInput();

            switch (userInputString)
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
                    menusBool = false;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Handles user selection of droid Language.
        /// </summary>
        private void LanguageSelection()
        {
            UserInterface.Menus.DisplayLanguageSelectionMenu(Droid_Protocol.LANGUAGE_SELECTION_1, Droid_Protocol.LANGUAGE_SELECTION_2, Droid_Protocol.LANGUAGE_SELECTION_3, Droid_Protocol.LANGUAGE_SELECTION_4);
            userInputString = UserInterface.GetUserInput();

            switch (userInputString)
            {
                case "1":
                    selectedLanguageInt = Droid_Protocol.LANGUAGE_SELECTION_1;
                    break;
                case "2":
                    selectedLanguageInt = Droid_Protocol.LANGUAGE_SELECTION_2;
                    break;
                case "3":
                    selectedLanguageInt = Droid_Protocol.LANGUAGE_SELECTION_3;
                    break;
                case "4":
                    selectedLanguageInt = Droid_Protocol.LANGUAGE_SELECTION_4;
                    break;
                case "esc":
                    menusBool = false;
                    break;
            }
        }

        /// <summary>
        /// Handles user selection of droid Tool Box.
        /// </summary>
        private void ToolBoxSelection()
        {
            UserInterface.Menus.DisplayToolBoxSelectionMenu();
            userInputString = UserInterface.GetUserInput();

            switch (userInputString)
            {
                case "1":
                    toolBoxBool = true;
                    break;
                case "2":
                    toolBoxBool = false;
                    break;
                case "esc":
                    menusBool = false;
                    break;
            }
        }

        /// <summary>
        /// Handles user selection of droid Computer Connection.
        /// </summary>
        private void CompConnectionSelection()
        {
            UserInterface.Menus.DisplayComputerConnectionSelectionMenu();
            userInputString = UserInterface.GetUserInput();

            switch (userInputString)
            {
                case "1":
                    computerConnectionBool = true;
                    break;
                case "2":
                    computerConnectionBool = false;
                    break;
                case "esc":
                    menusBool = false;
                    break;
            }
        }

        /// <summary>
        /// Handles user selection of droid Arm.
        /// </summary>
        private void ArmSelection()
        {
            UserInterface.Menus.DisplayArmSelectionMenu();
            userInputString = UserInterface.GetUserInput();

            switch (userInputString)
            {
                case "1":
                    armBool = true;
                    break;
                case "2":
                    armBool = false;
                    break;
                case "esc":
                    menusBool = false;
                    break;
            }
        }

        /// <summary>
        /// Handles user selection of droid Trash Compactor.
        /// </summary>
        private void TrashCompactorSelection()
        {
            UserInterface.Menus.DisplayTrashCompactorSelectionMenu();
            userInputString = UserInterface.GetUserInput();

            switch (userInputString)
            {
                case "1":
                    trashCompactorBool = true;
                    break;
                case "2":
                    trashCompactorBool = false;
                    break;
                case "esc":
                    menusBool = false;
                    break;
            }
        }

        /// <summary>
        /// Handles user selection of droid Vacuum.
        /// </summary>
        private void VacuumSelection()
        {
            UserInterface.Menus.DisplayVacuumSelectionMenu();
            userInputString = UserInterface.GetUserInput();

            switch (userInputString)
            {
                case "1":
                    vacuumBool = true;
                    break;
                case "2":
                    vacuumBool = false;
                    break;
                case "esc":
                    menusBool = false;
                    break;
            }
        }

        /// <summary>
        /// Handles user selection of droid Fire Extinguisher.
        /// </summary>
        private void FireExtinguisherSelection()
        {
            UserInterface.Menus.DisplayFireExtinguisherSelectionMenu();
            userInputString = UserInterface.GetUserInput();

            switch (userInputString)
            {
                case "1":
                    fireExtinguisherBool = true;
                    break;
                case "2":
                    fireExtinguisherBool = false;
                    break;
                case "esc":
                    menusBool = false;
                    break;
            }
        }

        /// <summary>
        /// Handles user selection of droid Ship-outfitting number.
        /// </summary>
        private void NumberOfShipsSelection()
        {
            while (menusBool)
            {
                UserInterface.Menus.DisplayNumberOfShipsSelectionMenu();
                userInputString = UserInterface.GetUserInput();

                // If user does not want to back out of menu.
                if (userInputString != "esc")
                {
                    // Attempt to convert user input to int.
                    try
                    {
                        selectedNumberOfShipsInt = Convert.ToInt32(userInputString);
                    }
                    catch
                    {
                        UserInterface.DisplayError("Not a valid number.");
                        NumberOfShipsSelection();
                    }
                }
                else
                {
                    menusBool = false;
                }
            }
        }

        #endregion


        #endregion

    }
}
