using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_List
{
	public class Task
	{
		private List<string> addTask = new List<string>();
		private List<string> descriptionTask = new List<string>();
		public void AddTask()
		{
			Console.WriteLine("Name Task: ");
			addTask.Add(Console.ReadLine());
			Console.WriteLine("Description: ");
			descriptionTask.Add(Console.ReadLine());
		}

		public void RemoveTask()
		{
			Console.WriteLine("Enter the name of the task to remove: ");
			string taskNameToRemove = Console.ReadLine();

			// Поиск индекса задачи по имени
			int indexToRemove = addTask.IndexOf(taskNameToRemove);

			if (indexToRemove >= 0)
			{
				// Если задача найдена, удаляем ее из обоих списков
				addTask.RemoveAt(indexToRemove);
				descriptionTask.RemoveAt(indexToRemove);

				Console.WriteLine($"Task '{taskNameToRemove}' removed successfully.");
			}
			else
			{
				Console.WriteLine($"Task '{taskNameToRemove}' not found.");
			}
		}

		public void VievTask()
		{
			for (int i = 0; i < addTask.Count; i++)
			{
				Console.WriteLine($"Task {i + 1}:");
				Console.WriteLine($"Name: {addTask[i]}");
				Console.WriteLine($"Description: {descriptionTask[i]}");
			}
		}
	}
}
