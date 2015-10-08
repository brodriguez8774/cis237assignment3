// Brandon Rodriguez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    /// <summary>
    /// Handles all display to user and reading of user input.
    /// Having one class handle everything UI helps create consistency.
    /// </summary>
    static class UserInterface
    {
        #region Variables



        #endregion



        #region Constructor



        #endregion



        #region Properties



        #endregion



        #region Private Methods



        #endregion



        #region Public Methods

        /// <summary>
        /// Gets user input from console.
        /// </summary>
        /// <returns>String of user's input.</returns>
        public static string GetUserInput()
        {
            return Console.ReadLine().Trim().ToLower();
        }


        public static void DisplayLine(string displayString)
        {
            Console.WriteLine(displayString);
        }

        /// <summary>
        /// Struct to hold overbloated list of menus.
        /// </summary>
        public struct Menus
        {
            /// <summary>
            /// Displays Main Menu to user.
            /// </summary>
            public static void DisplayMainMenu()
            {
                Console.WriteLine(
                    "   Select an option: " + Environment.NewLine +
                    "" + Environment.NewLine +
                    "   1) Purchase Droid" + Environment.NewLine +
                    "   2) Display Full Reciept" + Environment.NewLine +
                    "   3) Display Single Item" + Environment.NewLine +
                    "   4) Exit");
            }

            public static void DisplayTypeSelectionMenu()
            {
                Console.WriteLine(
                    "   Select a Droid Type: " + Environment.NewLine +
                    "" + Environment.NewLine +
                    "   1) Protocol Droid" + Environment.NewLine +
                    "   2) Utility Droid" + Environment.NewLine +
                    "   3) Janitor Droid" + Environment.NewLine +
                    "   4) Astromech Droid" + Environment.NewLine);
            }

            public static void DisplayModelSelectionMenu(string model1, string model2)
            {
                Console.WriteLine(
                    "   Select a Droid Model: " + Environment.NewLine +
                    "" + Environment.NewLine +
                    "   1) " + model1 + Environment.NewLine +
                    "   2) " + model2 + Environment.NewLine);
            }

            public static void DisplayMaterialSelectionMenu(string material1, string material2, string material3, string material4, string material5)
            {
                Console.WriteLine(
                    "   Select a Droid Material: " + Environment.NewLine +
                    "" + Environment.NewLine +
                    "   1) " + material1 + Environment.NewLine +
                    "   2) " + material2 + Environment.NewLine +
                    "   3) " + material3 + Environment.NewLine +
                    "   4) " + material4 + Environment.NewLine +
                    "   5) " + material5 + Environment.NewLine);
            }

            public static void DisplayColorSelectionMenu(string color1, string color2, string color3, string color4, string color5)
            {
                Console.WriteLine(
                    "   Select a Droid Color: " + Environment.NewLine +
                    "" + Environment.NewLine +
                    "   1) " + color1 + Environment.NewLine +
                    "   2) " + color2 + Environment.NewLine +
                    "   3) " + color3 + Environment.NewLine +
                    "   4) " + color4 + Environment.NewLine +
                    "   5) " + color5 + Environment.NewLine);
            }

            public static void DisplayLanguageSelectionMenu()
            {
                Console.WriteLine(
                    "   Select number of Built in Languages: " + Environment.NewLine +
                    "" + Environment.NewLine +
                    "   1) 1" + Environment.NewLine +
                    "   2) 3" + Environment.NewLine +
                    "   3) 7" + Environment.NewLine +
                    "   4) 12" + Environment.NewLine);
            }

            public static void DisplayToolBoxSelectionMenu()
            {
                Console.WriteLine(
                    "   Add Toolbox Functionality? " + Environment.NewLine +
                    "" + Environment.NewLine +
                    "   1) Yes" + Environment.NewLine +
                    "   2) No" +Environment.NewLine);
            }

            public static void DisplayComputerConnectionSelectionMenu()
            {
                Console.WriteLine(
                    "   Add Computer Connection Functionality? " + Environment.NewLine +
                    "" + Environment.NewLine +
                    "   1) Yes" + Environment.NewLine +
                    "   2) No" + Environment.NewLine);
            }

            public static void DisplayArmSelectionMenu()
            {
                Console.WriteLine(
                    "   Add Mechanical Arm Functionality? " + Environment.NewLine +
                    "" + Environment.NewLine +
                    "   1) Yes" + Environment.NewLine +
                    "   2) No" + Environment.NewLine);
            }

            public static void DisplayTrashCompactorSelectionMenu()
            {
                Console.WriteLine(
                    "   Add Trash Compactor Functionality? " + Environment.NewLine +
                    "" + Environment.NewLine +
                    "   1) Yes" + Environment.NewLine +
                    "   2) No" + Environment.NewLine);
            }

            public static void DisplayVacuumSelectionMenu()
            {
                Console.WriteLine(
                    "   Add Vacuum Functionality? " + Environment.NewLine +
                    "" + Environment.NewLine +
                    "   1) Yes" + Environment.NewLine +
                    "   2) No" + Environment.NewLine);
            }

            public static void DisplayFireExtinguisherSelectionMenu()
            {
                Console.WriteLine(
                    "   Add built in Fire Extinguisher? " + Environment.NewLine +
                    "" + Environment.NewLine +
                    "   1) Yes" + Environment.NewLine +
                    "   2) No" + Environment.NewLine);
            }

            public static void DisplayNumberOfShipsSelectionMenu()
            {
                Console.WriteLine(
                    "   How many ships do you need to outfit this kind of droid onto? " + Environment.NewLine +
                    "" + Environment.NewLine +
                    "   1)");
            }

        }

        #endregion

    }
}
