static class GoalManager
{
    private static List<Goal> _goals = new List<Goal>();
    private static int _score;

    public static void Start()
    {
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("Eternal Quest");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Details");
            Console.WriteLine("3. Create Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine();
                    DisplayPlayerInfo();
                    Thread.Sleep(1000);
                    break;
                case "2":
                    Console.WriteLine();
                    ListGoalDetails();
                    Thread.Sleep(1000);
                    break;
                case "3":
                    Console.WriteLine();
                    CreateGoal();
                    Thread.Sleep(1000);
                    break;
                case "4":
                    Console.WriteLine();
                    RecordEvent();
                    Thread.Sleep(1000);
                    break;
                case "5":
                    Console.WriteLine();
                    SaveGoals();
                    Thread.Sleep(1000);
                    break;
                case "6":
                    Console.WriteLine();
                    LoadGoals();
                    Thread.Sleep(1000);
                    break;
                case "7":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    private static void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player Score: {_score}");
    }

    private static void ListGoalNames()
    {
        int index = 1;
        Console.WriteLine("Goal Names:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}) {goal._shortName}");
            index++;
        }
    }

    private static void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    private static void CreateGoal()
    {
        Console.WriteLine("Select the goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        Console.WriteLine("Create a new goal");
        Console.Write("Enter the short name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the description: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter the target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    private static void RecordEvent()
    {
        Console.WriteLine("Record an event");
        ListGoalNames();
        Console.Write("Enter the number of the goal you accomplished: ");
        int index = Int32.Parse(Console.ReadLine());

        Goal selectedGoal = _goals[index-1];
        if (selectedGoal != null)
        {
            selectedGoal.RecordEvent();
            DisplayPlayerInfo();
            Thread.Sleep(1000);
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    private static void SaveGoals()
    {
        Console.Write("Enter the file name: ");
        string fileName = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(_score);
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }

            Console.WriteLine("Goals saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    private static void LoadGoals()
    {
        Console.Write("Enter the file name: ");
        string fileName = Console.ReadLine();

        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                _goals.Clear();
                _score = int.Parse(reader.ReadLine());

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    string type = parts[0];
                    string[] goalParts = parts[1].Split(',');
                    string name = goalParts[0];
                    string description = goalParts[1];
                    int points = int.Parse(goalParts[2]);

                    switch (type)
                    {
                        case "SimpleGoal":
                        bool isComplete = bool.Parse(goalParts[3]);
                        SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                        simpleGoal.SetIsComplete(isComplete);
                        _goals.Add(simpleGoal);
                        break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(name, description, points));
                            break;
                        case "ChecklistGoal":
                            int target = int.Parse(goalParts[3]);
                            int bonus = int.Parse(goalParts[4]);
                            int amountCompleted = int.Parse(goalParts[5]);
                            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                            checklistGoal.SetAmountCompleted(amountCompleted);
                            _goals.Add(checklistGoal);
                            break;
                   }
               }
           }

           Console.WriteLine("Goals loaded successfully.");
       }
       catch (Exception ex)
       {
           Console.WriteLine($"Error loading goals: {ex.Message}");
       }
   }

   public static void AddScore(int points)
   {
       _score += points;
   }
}