namespace TicTacToe
{
	class MainGame
	{
		static string[,] board = new string[3,3];
		
		static void Main()
		{
			Player playerX = new("X");
			Player playerO = new("O");

			bool playing = true;
			while(playing)
			{
				board = new string[,]
				{
					{"1", "2", "3"},
					{"4", "5", "6"},
					{"7", "8", "9"},
				};
				for (int play = 1; play <= 10; play++)
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
					}
					if(!Checker.Check(board) && play == 10)
					{
						Console.Clear();
						BoardPrinter();
						Console.WriteLine("The game is tied!");
						break;
					}
					if(play % 2 == 0)
					{
						Console.Clear();
						BoardPrinter();
						playerO.Play();
					}
					else
					{
						Console.Clear();
						BoardPrinter();
						playerX.Play();
					}
				}
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

		// BoardPrinter prints the board
		static void BoardPrinter()
		{
			Console.WriteLine("\n-----TicTacToe 1.0 | Made by HolyPeach-----\n");
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

		//Checks if the board. Not used the way the program is written
		static bool IsBoardFull()
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
	
		// Check is the place selected has already been played
		public static bool IsPlacePlayed(string place)
		{
			bool played = false;
			switch (place)
			{
				case "1":
					if(board[0,0] == "X" || board[0,0] == "O")
					{
						played = true;
					}
					break;
				case "2":
					if (board[0, 1] == "X" || board[0, 1] == "O")
					{
						played = true;
					}
					break;
				case "3":
					if (board[0, 2] == "X" || board[0, 2] == "O")
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
					if (board[2, 0] == "X" || board[2, 0] == "O")
					{
						played = true;
					}
					break;
				case "8":
					if (board[2, 1] == "X" || board[2, 1] == "O")
					{
						played = true;
					}
					break;
				case "9":
					if (board[2, 2] == "X" || board[2, 2] == "O")
					{
						played = true;
					}
					break;
				default:
					Console.WriteLine("Invalid input. Please try again");
					break;
			}
			return played;
		}
	
		//Places the plaver value into the selected place of the matrix
		public static void ChangePlace(string place, string player)
		{
			switch (place)
			{
				case "1":
					board[0,0] = player;
					break;
				case "2":
					board[0, 1] = player;
					break;
				case "3":
					board[0, 2] = player;
					break;
				case "4":
					board[1, 0] = player;
					break;
				case "5":
					board[1, 1] = player;
					break;
				case "6":
					board[1, 2] = player;
					break;
				case "7":
					board[2, 0] = player;
					break;
				case "8":
					board[2, 1] = player;
					break;
				case "9":
					board[2, 2] = player;
					break;
				default:
					break;
			}
		}
	}
}
