using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

namespace BingoBanko
{
	internal class Program
	{

		static void Main(string[] args)
		{
			//Instantiate the plate and user objects
			Plate plate = new Plate();
			User user = new User();

			//Create a list to store bingo messages
			List<string> bingoMessages = new List<string>();

			bool Game = true;
			while (Game)
			{
				//Set the console cursor position to the top left corner
				Console.SetCursorPosition(0, 0);

				Console.WriteLine($"Player name:");
				string inputName = Console.ReadLine();

				if (inputName == "Jasmin")
				{
					//Create a plate for the user
					user.UserPlate(inputName);

					bool checkNumber = false;
					while (!checkNumber)
					{

						Console.Clear();
						Console.SetCursorPosition(0, 0);
						user.PrintPlate();

						//Print the bingo messages
						foreach (var index in bingoMessages)
						{
							Console.WriteLine(index);
						}

						//Prompt the user to enter a number to check if it's on the plate
						//If the number is on the plate, remove it from the list
						//and check for bingo
						Console.WriteLine("Enter a number to check if it's on the plate:");
						int inputNumber = Convert.ToInt32(Console.ReadLine());
						foreach (Plate i in user.Plates)
						{
							i.CheckForBingoOnARow(inputNumber, bingoMessages);
							i.CheckForBingoOnTwoRows(inputNumber, bingoMessages);
							i.CheckForBingoOnFullPlate(bingoMessages);
						}
					}
				}
			}
		}

		static bool CheckForNumberInList(List<int> list, int inputNumber)
		{
			foreach (int i in list)
			{
				if (i == inputNumber)
				{
					Console.WriteLine("Number is on the plate!");
					list.Remove(i);
					break;
				}
				else
				{
					Console.WriteLine("Number is not on the plate");
				}
			}
			return true;
		}
	}
}
//foreach (int i in Jasmin.firstRow)
//{
//	if (i == inputNumber)
//	{
//		Console.WriteLine("Number is on the plate!");
//		Jasmin.firstRow.Remove(i);

//	}
//	else
//	{
//		Console.WriteLine("Number is not on the plate");

//	}
//}
//if (Jasmin.firstRow.Count() == 0)
//{
//	checkNumber = true;
//	break;
//}

//if (user.UserPlate(inputName).Count == 0)
//{
//	Console.WriteLine("You have won!");
//	gameOver = false;
//	break;
//}