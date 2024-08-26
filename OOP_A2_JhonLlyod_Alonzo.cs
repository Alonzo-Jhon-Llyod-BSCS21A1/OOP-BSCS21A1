using System;
using System.Linq;
using System.Collections.Generic;

namespace OOP;

public static class Program
{
	public static void Main()
	{
		bool exit = true;
		Dictionary<string, decimal> list = new Dictionary<string, decimal> { };
		Dictionary<string, decimal> order = new Dictionary<string, decimal> { };

		while (exit != false)
		{

			Console.WriteLine("Welcome to the Coffee Shop!\n1. Add Menu Item\n2. View Menu Item\n3. Place Order\n4. View Order\n5.Calculate Total\n6. Exit");
			Console.WriteLine("Please Select Above: ");
			var choice = Console.ReadLine();
			if (choice == "1")
			{
				Console.WriteLine("Enter Item: ");
				string item = Console.ReadLine();
				Console.WriteLine("Enter Price: ");
				decimal price = decimal.Parse(Console.ReadLine());
				if (price > 0)
				{
					list.Add(item, price);
					Console.WriteLine("Item Added Succesfully");
				}
				else
				{
					Console.WriteLine("Invalid Input Price!");
				}


			}
			else if (choice == "2")
			{
				int a = 0;
				Console.WriteLine("Menu:");
				foreach (var items in list)
				{
					a++;
					Console.WriteLine(a + "." + "" + items.Key + "-" + items.Value);
				}

			}
			else if (choice == "3")
			{
				int a = 0;
				Console.WriteLine("Menu: ");
				foreach (var items in list)
				{
					a++;
					Console.WriteLine(a + "=" + items.Key + "-" + items.Value);
				}

				Console.WriteLine("Select Number To Order: ");
				int orders = int.Parse(Console.ReadLine());
				if (orders >= 1 && orders <= list.Count)
				{
					int b = 0;
					foreach (var items in list)
					{
						b++;
						if (b == orders)
						{
							order[items.Key] = items.Value;
							Console.WriteLine("Item Added!");
						}
					}
				}
				else
				{
					Console.WriteLine("Invalid Order");
				}

			}
			else if (choice == "4")
			{
				Console.WriteLine("Your Order: ");
				foreach (var c in order)
				{
					Console.WriteLine(c.Key + "." + c.Value);

				}

			}
			else if (choice == "5")
			{
				decimal total = order.Values.Sum();
				Console.WriteLine("Total Amount Payable by Admin: " + total);

			}
			else if (choice == "6")
			{
				Console.WriteLine("Thankyou Come Again!");
				exit = false;
			}
		}

	}
}
