using System.Collections.Generic;
class TaskManager
{
    List<string> task = new List<string>();

    public void ShowTask()
    {
        Console.WriteLine("\nTo Do List");
        Console.WriteLine("-------------\n");
        for (int i = 0; i < task.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{task[i]}");
        }
        Console.WriteLine("\n-------------\n");
    }

    public void AddTask(string NewTask)
    {
        task.Add(NewTask);
    }

    public void RemoveTask(int index)
    {
        task.RemoveAt(index);

    }

    public void UpdateTask(int index, string newTask)
    {
        task[index] = newTask;
    }
    public void InsertTask(string newTask, int index)
    {
        task.Insert(index, newTask);
    }

    public int GetTaskCount()
    {
        return task.Count;
    }

    public void ShowOptions()
    {
        Console.WriteLine("Select operation");
        Console.WriteLine("1.ShowTask\n2.Add Task\n3.Edit Task\n4.Delete Task\n5.Insert Task");
    }

    
}
class Program
{
        static void Main(string[] args)
    {

        Console.WriteLine("hello world");
        string[] list = new string[5];
        list[0] = "task 1";
        list[1] = "task 2";
        list[2] = "task 3";
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{list[i]}");
        }

        List<string> taskList = new List<string>();

        for (int i = 0; i < 3; i++)
        {
            taskList.Add($"task {i}");
        }

        for (int i = 0; i < taskList.Count; i++)
        {
            Console.WriteLine(taskList[i]);
        }
        Console.WriteLine("after Removing first Element");
        taskList.RemoveAt(0);

        Console.WriteLine(taskList[0]);

        taskList[0] = "new task";
        Console.WriteLine("new task added");

        for (int i = 0; i < taskList.Count; i++)
        {
            Console.WriteLine(taskList[i]);
        }

        Console.WriteLine("insert element at index 1");

        taskList.Insert(1, "inserted task");
        for (int i = 0; i < taskList.Count; i++)
        {
            Console.WriteLine(taskList[i]);
        }
        Console.WriteLine("TO DO LIST APP");
        TaskManager manager = new TaskManager();
        int option = 0;
        manager.ShowOptions();
        while (true)
        {

            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    manager.ShowTask();
            
                    manager.ShowOptions();
                    break;
                case 2:

                    Console.WriteLine("Task ?");
                    string? NewTask = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(NgitewTask))
                    {
                        Console.WriteLine("Empty");
                        continue;
                    }
                    manager.AddTask(NewTask);
                    Console.Clear();
                    manager.ShowOptions();
                    break;
                case 3:
                    if (manager.GetTaskCount() == 0)
                    {
                        Console.WriteLine("No tasks available!");
                        continue;
                    }
                    string? UpdatedTask;
                    Console.WriteLine("Task No");
                    string? numTaskNo = Console.ReadLine();
                    if (!int.TryParse(numTaskNo, out int TaskNo))
                    {
                        Console.WriteLine("Enter a number");
                        continue;
                    }
                    if (TaskNo < 1 || TaskNo > manager.GetTaskCount())
                    {
                        Console.WriteLine("wrong task no");
                        continue;
                    }
                    Console.WriteLine("updated task");
                    UpdatedTask = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(UpdatedTask))
                    {
                        Console.WriteLine("Empty");
                        continue;
                    }
                    manager.UpdateTask(TaskNo - 1, UpdatedTask);
                    Console.Clear();
                    manager.ShowOptions();
                    break;
                case 4:
                    if (manager.GetTaskCount() == 0)
                    {
                        Console.WriteLine("No tasks to delete!");
                        continue;
                    }

                    Console.WriteLine("Task No");
                    string? numDelTaskNo = Console.ReadLine();
                    if (!int.TryParse(numDelTaskNo, out int DelTaskNo))
                    {
                        Console.WriteLine("Enter a number");
                        continue;
                    }
                    if (DelTaskNo > manager.GetTaskCount())
                    {
                        Console.WriteLine("wrong task no");
                        continue;
                    }
                    manager.RemoveTask(DelTaskNo - 1 );
                    Console.Clear();
                    manager.ShowOptions();
                    break;
                case 5:

                    Console.WriteLine("Task position (1 to " + (manager.GetTaskCount() + 1) + "):");
                    string? numInsertTaskNo = Console.ReadLine();
                    if (!int.TryParse(numInsertTaskNo, out int InsertTaskNo))
                    {
                        Console.WriteLine("Enter a number");
                        continue;
                    }
                    if (InsertTaskNo < 1 || InsertTaskNo > manager.GetTaskCount() + 1)
                    {
                        Console.WriteLine("wrong task no");
                        continue;
                    }
                    Console.WriteLine("Insert Task");
                    string? InsertTask = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(InsertTask))
                    {
                        Console.WriteLine("Empty");
                        continue;
                    }
                    manager.InsertTask(InsertTask, InsertTaskNo - 1);
                    Console.Clear();
                    manager.ShowOptions();
                    break;
                default:
                    Console.WriteLine("Enter a correct no");
                    Console.Clear();
                    manager.ShowOptions();
                    break;
                    

            }
        }

        }
}