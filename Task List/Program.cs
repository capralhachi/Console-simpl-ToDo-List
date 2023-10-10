using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_List
{
	class Program : Task
	{
		static void Main(string[] args)
		{
            List<string> toDoList = new List<string>();

			Task task = new Task();

			while (true)
			{
				Console.WriteLine("Choose an option!");
				Console.WriteLine("1. Add task!");
				Console.WriteLine("2. Remove task!");
				Console.WriteLine("3. Viev task!");
				Console.WriteLine("4. Exit!");
				int option = GetIntInRange(4);

				if (option == 1)
				{
					task.AddTask();
                    Console.WriteLine("Task added!");
                }
				else if (option == 2)
				{
					task.RemoveTask();
                    Console.WriteLine("Task removed!");
                }
				else if (option == 3)
				{
					task.VievTask();
				}
				else
				{
					break;
				}
			}
		}

		static int GetIntInRange(int optrionalNumber)
		{
			string choose = Console.ReadLine();
			int number = -1;
			bool isConverted = int.TryParse(choose, out number);
			bool isInRange = number >= 1 && number <= optrionalNumber;

			while (!isConverted || !isInRange)
			{
				Console.WriteLine("Error!");
				choose = Console.ReadLine();
				isConverted = int.TryParse(choose, out number);
				isInRange = number >= 1 && number <= optrionalNumber;
			}
			return number;
		}
	}
}
