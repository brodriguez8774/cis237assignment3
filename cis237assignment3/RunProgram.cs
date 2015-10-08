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
        private string inputString;

        #endregion



        #region Constructor

        public RunProgram()
        {
            runProgram = true;
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
                UserInterface.DisplayMainMenu();
                inputString = UserInterface.GetUserInput();
                MainMenuSelection();
            }
        }

        private void MainMenuSelection()
        {
            switch (inputString)
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

        #endregion

    }
}
