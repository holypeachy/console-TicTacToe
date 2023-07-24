namespace TicTacToe
{
	public static class Checker
	{
		private static string winner = "N";
		
		//Returns true if there is a winner, and determines who the winner is used by the WhoWins method.
		public static bool Check(string[,] board)
		{
			bool isThereWinner = false;
			
			//Vertical Check
			for (int column = 0; column < board.GetLength(1); column++)
			{
				string[] holder = new string[3]; 
				for (int row = 0; row < board.GetLength(0); row++)
				{
					holder[row] = board[row,column];
				}
				if(holder[0] == holder[1] && holder[1] == holder[2])
				{
					isThereWinner = true;
					winner = holder[0];
					break;
				}
			}
			
			//Horizontal Check
			if(!isThereWinner)
			{
				for (int row = 0; row < board.GetLength(0); row++)
				{
					string[] holder = new string[3]; 
					for (int column = 0; column < board.GetLength(1); column++)
					{
						holder[column] = board[row,column];
					}
					if(holder[0] == holder[1] && holder[1] == holder[2])
					{
						isThereWinner = true;
						winner = holder[0];
						break;
					}
				}
			}
			
			//Across left,top to right,bottom
			if(!isThereWinner)
			{
				string[] holder = new string[3]; 
				for (int index = 0; index < board.GetLength(0); index++)
				{
					holder[index] = board[index,index];
				}
					if(holder[0] == holder[1] && holder[1] == holder[2])
					{
						isThereWinner = true;
						winner = holder[0];
					}
			}
			
			//Across left,bottom to right,top
			if(!isThereWinner)
			{
				string[] holder = new string[3]; 
				for (int row = board.GetLength(0) - 1, column = 0; column < board.GetLength(1); row--, column++)
				{
					holder[column] = board[row, column];
				}
					if(holder[0] == holder[1] && holder[1] == holder[2])
					{
						isThereWinner = true;
						winner = holder[0];
					}
			}
			
			return isThereWinner;
		}
		
		//Returns X, O, or N meaning no winner. The program, as written, will never return N.
		public static string WhoWins(string[,] board)
		{
			return winner;
		}

	}
}
