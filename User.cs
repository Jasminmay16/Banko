using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoBanko
{
	class User
	{
		Plate Jasmin1 = new Plate();
		Plate Jasmin2 = new Plate();
		Plate Jasmin3 = new Plate();
		Plate Jasmin4 = new Plate();
		Plate Jasmin5 = new Plate();

		public List<Plate> Plates = new List<Plate>();


		// Use printlist method in here
		public List<int> UserPlate(string input)
		{
			Jasmin1.ID = "Jasmin1";
			Jasmin2.ID = "Jasmin2";
			Jasmin3.ID = "Jasmin3";
			Jasmin4.ID = "Jasmin4";
			Jasmin5.ID = "Jasmin5";

			// first plate
			Jasmin1.firstRow = new List<int>()
							{
								33, 42, 60, 74, 80
							};
			Jasmin1.secondRow = new List<int>()
							{
								7, 22, 54, 68, 78
							};
			Jasmin1.thirdRow = new List<int>()
							{
								8, 18, 39, 58, 87
							};
			List<int> firstIdJasmin = new List<int>();
			//firstIdJasmin.AddRange(Jasmin.firstRow);
			//firstIdJasmin.AddRange(Jasmin.secondRow);
			//firstIdJasmin.AddRange(Jasmin.thirdRow);

			// second plate
			Jasmin2.firstRow = new List<int>()
							{
								2, 20, 50, 63, 74,
							};
			Jasmin2.secondRow = new List<int>()
							{
								33, 45, 65, 76, 85,
							};
			Jasmin2.thirdRow = new List<int>()
							{
								17, 24, 34, 68, 79
							};
			List<int> secondIdJasmin = new List<int>();
			//secondIdJasmin.AddRange(Jasmin2.firstRow);
			//secondIdJasmin.AddRange(Jasmin2.secondRow);
			//secondIdJasmin.AddRange(Jasmin2.thirdRow);

			// third plate
			Jasmin3.firstRow = new List<int>()
							{
								10, 53, 62, 73, 81
							};
			Jasmin3.secondRow = new List<int>()
							{
								7, 31, 47, 63, 82
							};
			Jasmin3.thirdRow = new List<int>()
							{
								29, 58, 66, 78, 86
							};
			List<int> thirdIdJasmin = new List<int>();
			//thirdIdJasmin.AddRange(Jasmin3.firstRow);
			//thirdIdJasmin.AddRange(Jasmin3.secondRow);
			//thirdIdJasmin.AddRange(Jasmin3.thirdRow);

			// fourth plate
			Jasmin4.firstRow = new List<int>()
							{
								4, 21, 41, 51, 70
							};
			Jasmin4.secondRow = new List<int>()
							{
								11, 32, 42, 65, 72
							};
			Jasmin4.thirdRow = new List<int>()
							{
								8, 19, 33, 66, 84
							};
			List<int> fourthIdJasmin = new List<int>();
			//fourthIdJasmin.AddRange(Jasmin4.firstRow);
			//fourthIdJasmin.AddRange(Jasmin4.secondRow);
			//fourthIdJasmin.AddRange(Jasmin4.thirdRow);

			// fifth plate
			Jasmin5.firstRow = new List<int>()
							{
								1, 15, 40, 52, 61
							};
			Jasmin5.secondRow = new List<int>()
							{
								17, 45, 53, 75, 89
							};
			Jasmin5.thirdRow = new List<int>()
							{
								8, 29, 39, 48, 65
							};
			List<int> fifthIdJasmin = new List<int>();
			//fifthIdJasmin.AddRange(Jasmin5.firstRow);
			//fifthIdJasmin.AddRange(Jasmin5.secondRow);
			//fifthIdJasmin.AddRange(Jasmin5.thirdRow);

			Plates.Add(Jasmin1);
			Plates.Add(Jasmin2);
			Plates.Add(Jasmin3);
			Plates.Add(Jasmin4);
			Plates.Add(Jasmin5);

			// Return an empty list to satisfy the method's return type
			return new List<int>();
		}

		public void PrintSinglePlate(Plate plate)
		{
			string rowSeparator = "";
			Console.WriteLine("--------------");
			plate.PrintList(plate.firstRow, rowSeparator);
			plate.PrintList(plate.secondRow, rowSeparator);
			plate.PrintList(plate.thirdRow, rowSeparator);
			Console.WriteLine("--------------");
		}
		public void PrintPlate()
		{
			Console.WriteLine(Jasmin1.ID);
			PrintSinglePlate(Jasmin1);

			Console.WriteLine(Jasmin2.ID);
			PrintSinglePlate(Jasmin2);

			Console.WriteLine(Jasmin3.ID);
			PrintSinglePlate(Jasmin3);

			Console.WriteLine(Jasmin4.ID);
			PrintSinglePlate(Jasmin4);

			Console.WriteLine(Jasmin5.ID);
			PrintSinglePlate(Jasmin5);
		}
	}
}
//string rowSeparator = "";

//Console.WriteLine("--------------");

//Jasmin.PrintList(Jasmin.firstRow, rowSeparator);
//Jasmin.PrintList(Jasmin.secondRow, rowSeparator);
//Jasmin.PrintList(Jasmin.thirdRow, rowSeparator);

//Console.WriteLine("--------------");

//Jasmin2.PrintList(Jasmin2.firstRow, rowSeparator);
//Jasmin2.PrintList(Jasmin2.secondRow, rowSeparator);
//Jasmin2.PrintList(Jasmin2.thirdRow, rowSeparator);

//Console.WriteLine("--------------");

//Jasmin3.PrintList(Jasmin3.firstRow, rowSeparator);
//Jasmin3.PrintList(Jasmin3.secondRow, rowSeparator);
//Jasmin3.PrintList(Jasmin3.thirdRow, rowSeparator);

//Console.WriteLine("--------------");

//Jasmin4.PrintList(Jasmin4.firstRow, rowSeparator);
//Jasmin4.PrintList(Jasmin4.secondRow, rowSeparator);
//Jasmin4.PrintList(Jasmin4.thirdRow, rowSeparator);

//Console.WriteLine("--------------");

//Jasmin5.PrintList(Jasmin5.firstRow, rowSeparator);
//Jasmin5.PrintList(Jasmin5.secondRow, rowSeparator);
//Jasmin5.PrintList(Jasmin5.thirdRow, rowSeparator);

//Console.WriteLine("--------------");
