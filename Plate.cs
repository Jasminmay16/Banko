using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoBanko
{
    class Plate
    {
		//Properties for the plate class. ID is a string, and the rows are lists of integers.
		public string ID { get; set; }
		public List<int> firstRow { get; set; }
		public List<int> secondRow { get; set; }
        public List<int> thirdRow { get; set; }

		//Variables for messages. And just to make sure that the message is only printed once.
		private int oneRowMessage = 0;
		private int twoRowsMessage = 0;
		private int fullPlateMessage = 0;

		//Method to print the list of numbers in the plate, as well as adding a row separator.
		public void PrintList(List<int> list, string rowSeparator)
		{
			if (list == null)
			{
				Console.WriteLine("List is null");
				return;
			}
			foreach (int i in list)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine(rowSeparator);
		}
		//Methods to check for bingo on a row, two rows or full plate.
		public void CheckForBingoOnARow(int inputNumber, List<string> bingoMessage)
		{
			this.firstRow.Remove(inputNumber);
			if (this.firstRow.Count == 0 && oneRowMessage < 1)
			{
				bingoMessage.Add($"ID {this.ID} has banko on the first row!");
				oneRowMessage++;
			}

			this.secondRow.Remove(inputNumber);
			if (this.secondRow.Count == 0 && oneRowMessage < 1)
			{
				bingoMessage.Add($"ID {this.ID} has banko on the second row!");
				oneRowMessage++;
			}

			this.thirdRow.Remove(inputNumber);
			if (this.thirdRow.Count == 0 && oneRowMessage < 1)
			{
				bingoMessage.Add($"ID {this.ID} has banko on the third row!");
				oneRowMessage++;
			}
		}

		public void CheckForBingoOnTwoRows(int inputNumber, List<string> bingoMessage)
		{
			this.firstRow.Remove(inputNumber);
			this.secondRow.Remove(inputNumber);
			this.thirdRow.Remove(inputNumber);

			if ((this.firstRow.Count == 0 && this.secondRow.Count == 0) && twoRowsMessage < 1 ||
			(this.firstRow.Count == 0 && this.thirdRow.Count == 0) && twoRowsMessage < 1 ||
			(this.secondRow.Count == 0 && this.thirdRow.Count == 0 && twoRowsMessage < 1))
			{
				bingoMessage.Add($"ID {this.ID} has banko on two rows!");
				twoRowsMessage++;
			}

		}

		public void CheckForBingoOnFullPlate(List<string> bingoMessage)
		{
			if (this.firstRow.Count == 0 && this.secondRow.Count == 0 && this.thirdRow.Count == 0 && fullPlateMessage < 1)
			{
				bingoMessage.Add($"ID {this.ID} has banko on the full plate!");
				fullPlateMessage++;
			}
		}
	}
}
