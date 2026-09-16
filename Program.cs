using System;
using System.Collections.Generic;
using System.Linq;

const int MaxTasks = 10;
List<string> tasks = new List<string>();
bool running = true;

Console.WriteLine("Student Task Manager");
Console.WriteLine("===================");

while (running)
{
    ShowMenu();
    Console.Write("Choose: ");
    
    
    if (!int.TryParse(Console.ReadLine(), out int option))
    {
        Console.WriteLine("Invalid option. Please enter a number.");
        continue;
    }

    switch (option)
    {
        case 1:
            AddTask(tasks, MaxTasks);
            break;

        case 2:
            ShowTasks(tasks);
            break;

        case 3:
            RemoveTask(tasks);
            break;

        case 4:
            SearchTasks(tasks);
            break;

        case 5:
            ShowTaskCount(tasks, MaxTasks);
            break;

        case 0:
            running = false;
            Console.WriteLine("Goodbye!");
            break;

        default:
            Console.WriteLine("Invalid option. Please enter a valid menu number.");
            break;
    }
}


void ShowMenu()
{
    Console.WriteLine();
    Console.WriteLine("1. Add task");
    Console.WriteLine("2. View tasks");
    Console.WriteLine("3. Remove task");
    Console.WriteLine("4. Search tasks");
    Console.WriteLine("5. Show task count");
    Console.WriteLine("0. Exit");
}

void AddTask(List<string> tasksList, int maxLimit)
{
    if (tasksList.Count >= maxLimit)
    {
        Console.WriteLine("Maximum number of tasks reached.");
        return;
    }

    Console.Write("Enter task: ");
    string task = Console.ReadLine();

    
    if (string.IsNullOrWhiteSpace(task))
    {
        Console.WriteLine("Task description cannot be empty.");
        return;
    }

    tasksList.Add(task);
    Console.WriteLine("Task added.");
}

void ShowTasks(List<string> tasksList)
{
    if (tasksList.Count == 0)
    {
        Console.WriteLine("No tasks available.");
        return;
    }

    Console.WriteLine("\n--- Tasks List ---");
    for (int i = 0; i < tasksList.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {tasksList[i]}");
    }
}

void RemoveTask(List<string> tasksList)
{
    if (tasksList.Count == 0)
    {
        Console.WriteLine("No tasks available to remove.");
        return;
    }

    Console.Write("Task to remove: ");
    if (!int.TryParse(Console.ReadLine(), out int taskNumber))
    {
        Console.WriteLine("Invalid input. Please enter a valid task number.");
        return;
    }

    int indexToRemove = taskNumber - 1;

    if (indexToRemove >= 0 && indexToRemove < tasksList.Count)
    {
        tasksList.RemoveAt(indexToRemove);
        Console.WriteLine("Task removed.");
    }
    else
    {
        Console.WriteLine("Invalid task number.");
    }
}


void SearchTasks(List<string> tasksList)
{
    if (tasksList.Count == 0)
    {
        Console.WriteLine("No tasks available to search.");
        return;
    }

    Console.Write("Search: ");
    string searchTerm = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(searchTerm))
    {
        Console.WriteLine("Search term cannot be empty.");
        return;
    }

    var matchingTasks = tasksList
        .Where(t => t.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
        .ToList();

    if (!matchingTasks.Any())
    {
        Console.WriteLine("No matching tasks found.");
        return;
    }

    Console.WriteLine("\nResults:");
    for (int i = 0; i < matchingTasks.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {matchingTasks[i]}");
    }
}

void ShowTaskCount(List<string> tasksList, int maxLimit)
{
    int currentCount = tasksList.Count;
    int remaining = maxLimit - currentCount;

    Console.WriteLine($"\nYou currently have {currentCount} tasks.");
    Console.WriteLine($"Maximum allowed: {maxLimit}");
    Console.WriteLine($"Remaining capacity: {remaining}");
}