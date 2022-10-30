namespace TicTacToe
{
	class Player
	{
		private string Value{get;}
		
		public Player(string value)
		{
			Value = value;
		}
		
		//The Play method is the loop in which a player plays. Uses method's in the MainGame class.
		public void Play()
		{
			while(true)
			{
				Console.WriteLine("Player" + Value + " is playing");
				Console.Write("Player" + Value + ", select a place to play: ");
				string? input = Console.ReadLine();
				if(input == "1" || input == "2" || input == "3" || input == "4" || input == "5" || input == "6" || input == "7" || input == "8" || input == "9")
				{
					if(!MainGame.IsPlacePlayed(input))
					{
						MainGame.ChangePlace(input, Value);
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