using Chess.MenuUtils;
using Chess.MiscUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.GamePlayer
{
    class Player
    {
        // Attributes
        public Name Name_ { get; }
        public Score Score_ { get; }

        // Constructor
        public Player(Name name)
        {
            Name_ = name;
            Score_ = new Score();
        }

        // Method - Display Player Information
        public void Display()
        {
            Text heading = new Text("Name:\t", ConsoleColor.Yellow);
            Text data = new Text(Name_.Get(), ConsoleColor.Cyan);

            heading.Display();
            data.Display(true);

            heading.Data = "Score:\t";
            data.Data = Score_.Get().ToString();

            heading.Display();
            data.Display(true);
        }

        // Method - Get through input
        public static Player GetPlayerViaInput(Name? nameCheck = null)
        {
            Name name = new Name();

            // Loop until a valid name is entered
            do
            {
                // Get the name from user input
                Message.Prompt("Enter your name (minimum 3 characters): ");
                name.ChangeName(Console.ReadLine());

                if (nameCheck is not null && name == nameCheck)
                {
                    Message.Error("This name is already taken. Please choose a different name.");
                }
                else if (!Name.IsValid(name.Get()))
                {
                    Message.Error("Invalid name. Please enter a name with at least 3 characters.");
                }
            }
            while (!Name.IsValid(name.Get()));

            // Create and return a new Player object
            return new Player(name);
        }

        // Method - Reset Player's Score
        public void Reset()
        {
            Score_.Reset();
        }
    }
}
