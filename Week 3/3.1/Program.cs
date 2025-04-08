
namespace Mod3Enumdemo
{

    // value types
    enum Seasons
    {
        Winter=1,
        Spring,
        Summer,
        Fall


    }
    enum ErrorCodes
    {
        Not_Found=400,
        Internal_Server_Error=500

    }

    internal class Program
    {
        static void Main(string[] args)
        {
           
           // System.IO.FileStream obj = new FileStream("",FileMode.Open);
            
            PrintFavSeason(Seasons.Spring);
            List<ToDo> todolist = new List<ToDo>(); // dynamic
            //1
            todolist.Add(new ToDo() { TaskId = 1, Description = "Study for Test", EstimatedHours = 1.5f, TaskStatus = Status.NotStarted });

            // 2
            ToDo mytodo = new ToDo();
            mytodo.TaskId = 2;
            mytodo.Description = "Do Challenge labs";
            mytodo.EstimatedHours = 3.5f;
            mytodo.TaskStatus=Status.Completed;
            todolist.Add (mytodo);
            todolist.Add(new ToDo() { TaskId = 3, Description = "Mentor calls", EstimatedHours = 2.0f, TaskStatus = Status.Dismissed });
            todolist.Add(new ToDo() { TaskId = 4, Description = "Build a resume", EstimatedHours = 5.0f, TaskStatus = Status.InProgress });
            todolist.Add(new ToDo() { TaskId = 5, Description = "Download VS", EstimatedHours = 0.5f, TaskStatus = Status.Completed});
           PrintList(todolist);
            
            Console.ReadKey();
         
        }

        static void PrintList(List<ToDo> todos)// ref type
        {
            foreach(var todo in todos)
            {
                switch(todo.TaskStatus)
                {
                    case Status.Dismissed:
                        Console.ForegroundColor = ConsoleColor.Red; break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Yellow; break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Green; break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.Magenta; break;
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.Blue; break;
                    default:Console.ForegroundColor = ConsoleColor.White; break;

                }
                Console.WriteLine($"{todo.TaskId}, {todo.Description}, {todo.EstimatedHours} , {todo.TaskStatus}");
            }

        }

        static void PrintFavSeason(Seasons favseason)
        {
            int val=(int)favseason;
            //
            Console.WriteLine($"Your favourite season is :{favseason} - {val}");
        }

    }
}
