using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace HomeworkGame__Windows_
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        class SpacePressGame
        {
            static Timer timer;
            static bool gameStarted = false;

            static void Main()
            {
                Console.WriteLine("Press space key when you see 'start'...");

                // Initialize the timer
                timer = new Timer();
                timer.Elapsed += OnTimerElapsed;

                // Start the game
                StartGame();

                Console.ReadLine(); // Keep the console application running
            }

            static void StartGame()
            {
                // Set a random waiting time (between 2 to 5 seconds)
                int waitTime = new Random().Next(2000, 5000);
                Console.WriteLine($"Waiting for {waitTime / 1000} seconds...");

                // Set the timer interval
                timer.Interval = waitTime;

                // Hook up the Elapsed event for the timer
                timer.Start();
            }

            static void OnTimerElapsed(object sender, ElapsedEventArgs e)
            {
                // Timer elapsed, start the game
                gameStarted = true;
                Console.WriteLine("Start! Press space key now.");

                // Set a 3-second timeout for the player to press space
                timer.Interval = 3000;
            }

            // Handle keyboard input
            static bool HandleKeyPress(ConsoleKeyInfo keyInfo)
            {
                if (gameStarted && keyInfo.Key == ConsoleKey.Spacebar)
                {
                    Console.WriteLine("You pressed the space key in time! You win!");
                    timer.Stop(); // Stop the timer
                    return true;
                }
                else
                {
                    Console.WriteLine("You pressed the wrong key or too early. You lose!");
                    return false;
                }
            }

            // Subscribe to the key press event
            static void SubscribeToKeyPress()
            {
                Console.CancelKeyPress += (sender, e) =>
                {
                    // Handle Ctrl+C or similar termination
                    e.Cancel = true;
                    Console.WriteLine("Game terminated. You lose!");
                    Environment.Exit(0);
                };

                ConsoleKeyInfo keyInfo;
                do
                {
                    keyInfo = Console.ReadKey(true);
                } while (!HandleKeyPress(keyInfo));

                // Exit the application after the game is finished
                Environment.Exit(0);
            }
        }
    }
}
