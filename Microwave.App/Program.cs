using System;
using Microwave.Classes.Boundary;
using Microwave.Classes.Controllers;

namespace Microwave.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Button startCancelButton = new Button();
            Button powerButton = new Button();
            Button timeButton = new Button();

            Door door = new Door();

            Output output = new Output();

            Display display = new Display(output);

            System.Console.WriteLine("Enter a maximum power value (W): ");

            var maxPower = Convert.ToInt32(System.Console.ReadLine());

            PowerTube powerTube = new PowerTube(output, maxPower);

            Light light = new Light(output);

            Microwave.Classes.Boundary.Timer timer = new Timer();

            CookController cooker = new CookController(timer, display, powerTube);

            Buzzer buzzer = new Buzzer();

            UserInterface ui = new UserInterface(powerButton, timeButton, startCancelButton, door, display, light, cooker, buzzer);

            // Finish the double association
            cooker.UI = ui;

            // Simulate a simple sequence

            powerButton.Press();

            timeButton.Press();

            startCancelButton.Press();

            // The simple sequence should now run

            //System.Console.WriteLine("When you press enter, the program will stop");
            // Wait for input

            Console.WriteLine("Type E and press Enter to extend time by 10 seconds... and X for exit");
            string x = "";

            while (x != "X")
            {
                x = System.Console.ReadLine();

                if (x == "E")
                    timeButton.Press();
            }
        }
    }
}
