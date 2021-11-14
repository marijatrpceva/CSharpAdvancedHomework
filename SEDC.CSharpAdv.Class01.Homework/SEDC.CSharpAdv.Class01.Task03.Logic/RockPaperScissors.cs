using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SEDC.CSharpAdv.Class01.Task03.Logic
{
    public class RockPaperScissors : Game
    {
        private Random _rand = new Random();
        public Player Player { get; set; }
        public Player Cpu { get; set; }
        
        public RockPaperScissors()
        {
            Player = new Player { Name = "Player1" };
            Cpu = new Player { Name = "Cpu" };
        }
        public void InitGame()
        {
            Console.WriteLine("ROCK PAPER SCISSORS");
            Console.WriteLine("Lets play");

            while(true)
            {
                Console.WriteLine("1) Start round\n2) View Stats\n3) Quit");
                bool IsValidInput = int.TryParse(Console.ReadLine(), out int selection);
                
                if(!IsValidInput)
                {
                    Console.WriteLine("Not valid input. Please try again");
                    continue;
                }
                switch(selection)
                {
                    case 1:
                        //start game
                        StartGame();
                        break;
                    case 2:
                        //stats
                        break;
                    case 3:
                        Console.WriteLine("Thank you for playing RPS");
                        Thread.Sleep(3000);
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid menu selection");
                        break;
                }
            }
        }
        private void  StartGame()
        {
            IsActive = true;
            while (IsActive)
            {
                Console.WriteLine("1) Start round\n 2) End round");
                bool IsValidInput = int.TryParse(Console.ReadLine(), out int selection);

                if (!IsValidInput)
                {
                    Console.WriteLine("Not valid input. Please try again");
                    continue;
                }
                switch (selection)
                {
                    case 1:
                        //PlayRound
                        break;
                    case 2:
                        IsActive = !IsActive;
                        break;
                    default:
                        Console.WriteLine("Invalid menu selection");
                        break;
                }
            }
        }
        private void PlayRound()
        {
            Console.WriteLine("1) Rock\n2) Paper\n3) Scissors");
            bool IsValidInput = int.TryParse(Console.ReadLine(), out int selection);

            if (!IsValidInput)
            {
                Console.WriteLine("Not valid input. Please try again");
                return;
            }
            RoundResult result = RoundResult(selection);

            
        }
        private RoundResult RoundResult(int playerSelection)
        {
            RoundResult result = new RoundResult();
            int cpuSelection = _rand.Next(1, 4);

            // rulles of wining the game
            if (playerSelection == cpuSelection)
            {
                result.Winner = 0; // 0 is draw 1 player one 2 cpu
                result.Message = "It is a draw";
                return result;
            }

            // "1) Rock \n2) Paper \n3) Scissors"
            // rulles of wining the game
            switch (cpuSelection)
            {
                case 1:
                    if (playerSelection == 2)
                    {
                        result.Winner = 2;
                        result.Message = "Rock crushes scissors or somethimes blunts them.";
                    }
                    else if (playerSelection == 3)
                    {
                        result.Winner = 1;
                        result.Message = "Paper covers rock.";
                    }
                    break;
                case 2:
                    if (playerSelection == 1)
                    {
                        result.Winner = 2;
                        result.Message = "Paper covers rock.";
                    }
                    else if (playerSelection == 3)
                    {
                        result.Winner = 1;
                        result.Message = "Scissors cut paper";
                    }
                    break;
                case 3:
                    if (playerSelection == 1)
                    {
                        result.Winner = 1;
                        result.Message = "Rock crushes scissors or somethimes blunts them.";
                    }
                    else if (playerSelection == 2)
                    {
                        result.Winner = 2;
                        result.Message = "Scissors cut paper";
                    }
                    break;
            }

            return result;
        }

        private void PlayerStats()
        {
            Console.WriteLine($"{Player.Name} stats");
            Console.WriteLine($"Won: {Player.Won} Lost: {Player.Lost} Draw: {Player.Draw} Win%: {CalculateWinPercent(GetGamesPlayed(), Player.Won)}");

            Console.WriteLine($"{Cpu.Name} stats");
            Console.WriteLine($"Won: {Cpu.Won} Lost: {Cpu.Lost} Draw: {Cpu.Draw} Win%: {CalculateWinPercent(GetGamesPlayed(), Cpu.Won)}");
        }

        private double CalculateWinPercent(int played, int won)
        {
            try
            {
                return (played / won) * 100;
            }
            catch (DivideByZeroException)
            {
                return 0;
            }
        }
    }
}
