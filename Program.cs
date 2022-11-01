namespace TicTacToe
{
	public static class MainGame
	{
		static string[,] board = new string[3,3];
		
		static void Main()
		{
			Player playerX = new("X");
			Player playerO = new("O");

			// Main program loop.
			bool playing = true;
			while(playing)
			{
				board = new string[,]
				{
					{"7", "8", "9"},
					{"4", "5", "6"},
					{"1", "2", "3"},
				};
				
				// Game loop.
				for (int plays = 1; plays<= 10; plays++)
				{
					if(Checker.Check(board))
					{
						if(Checker.WhoWins(board) == "X")
						{
							Console.Clear();
							BoardPrinter();
							Console.WriteLine("PlayerX wins!");
							break;
						}
						else if(Checker.WhoWins(board) == "O")
						{
							Console.Clear();
							BoardPrinter();
							Console.WriteLine("PlayerO wins!");
							break;
						}
						else
						{
							Console.WriteLine("--!--Winner was not detected, something went wrong--!--");
							Console.WriteLine("--!--Try naming the players properly--!--");
						}
					}
					if(!Checker.Check(board) && plays == 10)
					{
						Console.Clear();
						BoardPrinter();
						Console.WriteLine("The game is tied!");
						break;
					}
					if(plays % 2 == 0)
					{
						Console.Clear();
						BoardPrinter();
						Play(playerO);
					}
					else
					{
						Console.Clear();
						BoardPrinter();
						Play(playerX);
					}
				}
				
				// Prompts the user if they wish to play again
				while(true)
				{
					Console.WriteLine("Would you like to play again?(y/n)");
					string? input = Console.ReadLine();
					if (input == "n")
					{
						playing = false;
						break;
					}
					else if (input == "y")
					{
						break;
					}
					else
					{
						Console.WriteLine("Invalid input...");
					}
				}

			}

		}

		// Prints the board
		public static void BoardPrinter()
		{
			Console.WriteLine("\n-----TicTacToe 1.1 | Made by HolyPeach-----\n");
			Console.WriteLine("                |     |     ");
			Console.WriteLine("             {0}  |  {1}  |  {2}  ", board[0, 0], board[0, 1], board[0, 2]);
			Console.WriteLine("           _____|_____|_____");
			Console.WriteLine("                |     |     ");
			Console.WriteLine("             {0}  |  {1}  |  {2}  ", board[1, 0], board[1, 1], board[1, 2]);
			Console.WriteLine("           _____|_____|_____");
			Console.WriteLine("                |     |     ");
			Console.WriteLine("             {0}  |  {1}  |  {2}  ", board[2, 0], board[2, 1], board[2, 2]);
			Console.WriteLine("                |     |     \n");
		}

		//Checks if the board is full. Not used.
		public static bool IsBoardFull()
		{
			int counter = 0;
			foreach (string item in board)
			{
				if(item == "X" || item == "O")
				{
					counter++;
				}
			}
			if(counter == 9)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	
		// Check is the place selected has already been played.
		public static bool IsPlacePlayed(string place)
		{
			bool played = false;
			
			switch (place)
			{
				case "1":
					if (board[2, 0] == "X" || board[2, 0] == "O")
					{
						played = true;
					}
					break;
				case "2":
					if (board[2, 1] == "X" || board[2, 1] == "O")
					{
						played = true;
					}
					break;
				case "3":
					if (board[2, 2] == "X" || board[2, 2] == "O")
					{
						played = true;
					}
					break;
				case "4":
					if (board[1, 0] == "X" || board[1, 0] == "O")
					{
						played = true;
					}
					break;
				case "5":
					if (board[1, 1] == "X" || board[1, 1] == "O")
					{
						played = true;
					}
					break;
				case "6":
					if (board[1, 2] == "X" || board[1, 2] == "O")
					{
						played = true;
					}
					break;
				case "7":
					if (board[0, 0] == "X" || board[0, 0] == "O")
					{
						played = true;
					}
					break;
				case "8":
					if (board[0, 1] == "X" || board[0, 1] == "O")
					{
						played = true;
					}
					break;
				case "9":
					if (board[0, 2] == "X" || board[0, 2] == "O")
					{
						played = true;
					}
					break;

				// This default will never be executed as the program is written.
				default:
					Console.WriteLine("--!--Invalid input. Please try again...--!--");
					Console.WriteLine("--!--Something went wrong--!--");
					break;
			}
			return played;
		}
	
		// Places the player value into the selected place of the matrix.
		public static void ChangePlace(string place, string value)
		{
			switch (place)
			{
				case "1":
					board[2, 0] = value;
					break;
				case "2":
					board[2, 1] = value;
					break;
				case "3":
					board[2, 2] = value;
					break;
				case "4":
					board[1, 0] = value;
					break;
				case "5":
					board[1, 1] = value;
					break;
				case "6":
					board[1, 2] = value;
					break;
                case "7":
                    board[0, 0] = value;
                    break;
                case "8":
                    board[0, 1] = value;
                    break;
                case "9":
                    board[0, 2] = value;
                    break;
				default:
					Console.WriteLine("--!--Unexpected Error--!--");
					break;
			}
		}

		// The Play method is the loop in which a player plays. Uses method's in the MainGame class.
		static void Play(Player player)
		{
			while (true)
			{
				Console.WriteLine("Player" + player.Value + " is playing");
				Console.Write("Player" + player.Value + ", select a place to play: ");
				string? input = Console.ReadLine();
				if (input == "1" || input == "2" || input == "3" || input == "4" || input == "5" || input == "6" || input == "7" || input == "8" || input == "9")
				{
					if (!MainGame.IsPlacePlayed(input))
					{
						MainGame.ChangePlace(input, player.Value);
						break;
					}
					else
					{
						Console.WriteLine("\nThat spot is already played, select another spot");
					}
				}
				else
				{
					Console.WriteLine("\nInvalid input, please try again...");
				}
			}
		}
	}
}
