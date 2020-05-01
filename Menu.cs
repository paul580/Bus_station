using System;
using System.Collections.Generic;

namespace Console_Menu
{
    class Menu
    {
        private const int MAIN_MENU_EXIT_OPTION =9;

        private const int GO_BACK_OPTION = 9;

        List<int> mainMenuOptions = new List<int>(new int[]{1, 2, 3, 4, 5, 6, 9});

        List<int> SelectMessage = new List<int>(new int[]{1, 2, 3, 4, 5, 6, 9});

        private string Ruta = "Ruta a la ciudad";

        private void DisplayWelcomeMessage() {
            System.Console.WriteLine("Bienvenido al panel de control!");
            System.Console.WriteLine();
        }
       
        
        private void DisplayMainMenuOptions() {
            System.Console.WriteLine("1) Ingresar camión");
            System.Console.WriteLine("2) Ingresar saldida de camión");
            System.Console.WriteLine("3) Exportar camión");
            System.Console.WriteLine("4) Imprimir camión");
            System.Console.WriteLine("5) Ver estadisticas");
            System.Console.WriteLine("6) Borrar información");
            System.Console.WriteLine();
            System.Console.WriteLine("9) Salir");
        }


        private int RequestOption(List<int> ValidOptions) {
            int userInputAsInt = 0;
            bool isUserInputValid = false;

            while(!isUserInputValid) {
                System.Console.WriteLine("Selecciona una opción:");
                string userInput = System.Console.ReadLine();


                try { 
                    userInputAsInt = Convert.ToInt32(userInput);
                    isUserInputValid = ValidOptions.Contains(userInputAsInt);
                }catch (System.Exception) {
                    isUserInputValid = false;
                }

                if (!isUserInputValid)
                {
                    System.Console.WriteLine("La opcion seleccionada es valida.");
                }
            }

            return userInputAsInt;
        }

        private void DisplayIngresarcamiónMessage() {
            System.Console.WriteLine("Ingresar camión");
            System.Console.WriteLine();
        }
        private void DisplaySelecMessage() {
            System.Console.WriteLine("1) Nombre del conductor");
            System.Console.WriteLine("2) Numero del camion");
            System.Console.WriteLine();
            System.Console.WriteLine("9) volver");
        }
         private void DisplaySalidacamionMessage() {
             System.Console.WriteLine("Ingresar del camión");
             System.Console.WriteLine();
         }
         private void DisplaySalidaMessage() {
             System.Console.WriteLine("1) Numero de camión");
             System.Console.WriteLine("2) Ruta de salida");
             System.Console.WriteLine();
             System.Console.WriteLine("9) volver");
         }
         private void SelectsMessage() {
           System.Console.WriteLine("1) Ruta a la ciudad A");
           System.Console.WriteLine("2) Ruta a la ciudad B");
           System.Console.WriteLine("3) Ruta a la ciudad C");
           System.Console.WriteLine("4) Ruta a la ciudad D");
           System.Console.WriteLine("5) Ruta a la ciudad E");
           System.Console.WriteLine();
           System.Console.WriteLine("9) volver");

         } 
        private void SelectRuta() {
            int selectedOption = 0;

            while (selectedOption != GO_BACK_OPTION) {
                SelectRuta();
                SelectRuta();
                System.Console.WriteLine($"Ruta seleccionada: {Ruta}");

                switch(selectedOption)
                {
                    case 1://Ruta a la ciudad A
                    Ruta = "Ruta a la ciudad A";
                    break;
                    case 2://Ruta a la ciudad B
                    Ruta = "Ruta a la ciudad B";
                    break;
                    case 3://Ruta a la ciudad C"
                    Ruta = "Ruta a la ciudad C";
                    break;
                    case 4://Ruta a la ciudad D
                    Ruta = "Ruta a la ciudad D";
                    break;
                    case 5://Ruta a la ciudad E
                    Ruta = "Ruta a la ciudad E";
                    break;
                }

            }
        }
       

    }
}  