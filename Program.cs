using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

namespace BingoBanko
{
	internal class Program
	{

		static void Main(string[] args)
		{
			Plate plate = new Plate();
			User user = new User();
			List<string> bingoMessages = new List<string>();

			bool gameOver = true;

			while (gameOver)
			{
				Console.SetCursorPosition(0, 0);

				Console.WriteLine($"Player name:");
				string inputName = Console.ReadLine();

				if (inputName == "Jasmin")
				{
					user.UserPlate(inputName);

					bool checkNumber = false;

					while (!checkNumber)
					{
						Console.Clear();
						Thread.Sleep(1000);
						Console.SetCursorPosition(0, 0);
						user.PrintPlate();

						foreach (var i in bingoMessages)
						{
							Console.WriteLine(i);
						}

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