namespace miniproject3
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Data.SqlClient; 

    
    enum PlayerStatus { Normal, Injured, Suspended }

    // Tranasfer record class 
    class TransferRecord
    {
        public string OldTeam { get; set; }
        public string NewTeam { get; set; }
        public DateTime Date { get; set; }

        public TransferRecord(string oldTeam, string newTeam, DateTime date)
        {
            OldTeam = oldTeam;
            NewTeam = newTeam;
            Date = date;
        }

        public override string ToString() => $"{OldTeam} -> {NewTeam} ({Date:yyyy-MM-dd})";
    }

    // player class 
    class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public int Age { get; set; }
        public int Goals { get; set; }
        public int Ranking { get; set; }
        public PlayerStatus Status { get; set; } = PlayerStatus.Normal;
        public List<TransferRecord> TransferHistory { get; set; } = new List<TransferRecord>();

        public Player(string name, string team, int age, int goals, int ranking)
        {
            Name = name;
            Team = team;
            Age = age;
            Goals = goals;
            Ranking = ranking;
        }

        public void AddTransfer(string oldTeam, string newTeam)
        {
            TransferHistory.Add(new TransferRecord(oldTeam, newTeam, DateTime.Now));
        }

        public string GetTransferHistory()
        {
            return TransferHistory.Any() ? string.Join(" | ", TransferHistory) : "No transfer history";
        }

        public override string ToString()
        {
            return $"Name: {Name}, Team: {Team}, Age: {Age}, Goals: {Goals}, Ranking: {Ranking}, Status: {Status}";
        }
    }

    class Program
    {
        static LinkedList<Player> players = new LinkedList<Player>();
        static string filePath = @"C:\Training\MSSA\Assigments\mini project\players.txt"; // 修改为文本文件路径
        static Stack<Player> deletedPlayers = new Stack<Player>();

        static void Main(string[] args)
        {
            // if file does not exist, initialize data and save to file
            if (!File.Exists(filePath))
            {
                InitializeData();
                SaveData(); 
            }
            else
            {
                LoadData(); 
            }

            bool running = true;
            while (running)
            {
                DisplayMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": AddPlayer(); break;
                    case "2": DisplayPlayers(); break;
                    case "3": UpdatePlayer(); break;
                    case "4": DeletePlayer(); break;
                    case "5": SearchPlayer(); break;
                    case "6": SortPlayers(); break;
                    case "7": ShowStatistics(); break;
                    case "9": SaveData(); break;
                    case "10": UpdateTransfer(); break;
                    case "11": UpdatePlayerStatus(); break;
                    case "12": ShowStatusStats(); break;
                    case "13": FilterPlayers(); break;
                    case "14": ComparePlayers(); break;
                    case "15": RecommendPlayer(); break;
                    case "16": UndoDelete(); break;
                    case "0": running = false; break;
                    default: Console.WriteLine("Invalid option!"); break;
                }
            }
        }

        // initialize data 
        static void InitializeData()
        {
            players.AddLast(new Player("Erling Haaland", "Manchester City", 24, 25, 1));
            players.AddLast(new Player("Kevin De Bruyne", "Manchester City", 33, 8, 3));
            players.AddLast(new Player("Mohamed Salah", "Liverpool", 32, 18, 2));
            players.AddLast(new Player("Darwin Nunez", "Liverpool", 25, 12, 10));
            players.AddLast(new Player("Bukayo Saka", "Arsenal", 23, 15, 5));
            players.AddLast(new Player("Martin Odegaard", "Arsenal", 26, 7, 8));
            players.AddLast(new Player("Harry Kane", "Tottenham", 31, 20, 4));
            players.AddLast(new Player("Son Heung-min", "Tottenham", 32, 14, 6));
            players.AddLast(new Player("Bruno Fernandes", "Manchester United", 30, 10, 7));
            players.AddLast(new Player("Marcus Rashford", "Manchester United", 27, 9, 9));

            var haaland = players.First(p => p.Name == "Erling Haaland");
            haaland.AddTransfer("Borussia Dortmund", "Manchester City");

            var kane = players.First(p => p.Name == "Harry Kane");
            kane.AddTransfer("Tottenham", "Bayern Munich");
            kane.AddTransfer("Bayern Munich", "Tottenham");

            var salah = players.First(p => p.Name == "Mohamed Salah");
            salah.Status = PlayerStatus.Injured;

            Console.WriteLine("Initial data loaded successfully!");
        }

        
        static void DisplayMenu()
        {
            Console.WriteLine("\n=== English Premier League Player Management ===");
            Console.WriteLine("1. Add Player");
            Console.WriteLine("2. Display All Players");
            Console.WriteLine("3. Update Player");
            Console.WriteLine("4. Delete Player");
            Console.WriteLine("5. Search Player");
            Console.WriteLine("6. Sort Players");
            Console.WriteLine("7. Show Statistics");
            Console.WriteLine("9. Save Data");
            Console.WriteLine("10. Update Transfer History");
            Console.WriteLine("11. Update Player Status");
            Console.WriteLine("12. Show Status Statistics");
            Console.WriteLine("13. Filter Players");
            Console.WriteLine("14. Compare Players");
            Console.WriteLine("15. Recommend Player");
            Console.WriteLine("16. Undo Last Delete");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
        }

        static void AddPlayer()
        {
            try
            {
                Console.Write("Enter Name: ");
                string name = ValidateStringInput(Console.ReadLine(), "Name", 50);
                Console.Write("Enter Team: ");
                string team = ValidateStringInput(Console.ReadLine(), "Team", 50);
                Console.Write("Enter Age: ");
                int age = GetValidInt(0, 100);
                Console.Write("Enter Goals: ");
                int goals = GetValidInt(0);
                Console.Write("Enter Ranking: ");
                int ranking = GetValidInt(0);

                players.AddLast(new Player(name, team, age, goals, ranking));
                Console.WriteLine("Player added successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        
        static void DisplayPlayers()
        {
            if (players.Count == 0)
            {
                Console.WriteLine("No players in the system.");
                return;
            }
            foreach (var player in players)
            {
                Console.WriteLine(player);
                Console.WriteLine($"Transfer History: {player.GetTransferHistory()}");
            }
        }

        
        static void UpdatePlayer()
        {
            Console.Write("Enter player name to update: ");
            string name = Console.ReadLine();
            var player = players.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (player != null)
            {
                Console.Write("Enter new Team: ");
                player.Team = ValidateStringInput(Console.ReadLine(), "Team", 50);
                Console.Write("Enter new Age: ");
                player.Age = GetValidInt(0, 100);
                Console.Write("Enter new Goals: ");
                player.Goals = GetValidInt(0);
                Console.Write("Enter new Ranking: ");
                player.Ranking = GetValidInt(0);
                Console.WriteLine("Player updated successfully!");
            }
            else
            {
                Console.WriteLine("Player not found!");
            }
        }

        
        static void DeletePlayer()
        {
            Console.Write("Enter player name to delete: ");
            string name = Console.ReadLine();
            var player = players.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (player != null)
            {
                deletedPlayers.Push(player);
                players.Remove(player);
                Console.WriteLine("Player deleted successfully!");
            }
            else
            {
                Console.WriteLine("Player not found!");
            }
        }

        static void SearchPlayer()
        {
            Console.Write("Search by (1) Name or (2) Team: ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();
                var result = players.Where(p => p.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
                DisplayResults(result);
            }
            else if (choice == "2")
            {
                Console.Write("Enter Team: ");
                string team = Console.ReadLine();
                var result = players.Where(p => p.Team.Contains(team, StringComparison.OrdinalIgnoreCase));
                DisplayResults(result);
            }
        }

        
        static void DisplayResults(IEnumerable<Player> results)
        {
            if (!results.Any())
            {
                Console.WriteLine("No matching players found.");
                return;
            }
            foreach (var player in results)
            {
                Console.WriteLine(player);
            }
        }

       
        static void SortPlayers()
        {
            Console.WriteLine("Sort by: (1) Age, (2) Goals, (3) Ranking");
            string choice = Console.ReadLine();
            var sortedList = players.ToList();

            switch (choice)
            {
                case "1": sortedList.Sort((x, y) => x.Age.CompareTo(y.Age)); break;
                case "2": sortedList.Sort((x, y) => y.Goals.CompareTo(x.Goals)); break;
                case "3": sortedList.Sort((x, y) => x.Ranking.CompareTo(y.Ranking)); break;
                default: Console.WriteLine("Invalid option!"); return;
            }

            foreach (var player in sortedList) Console.WriteLine(player);
        }

        
        static void ShowStatistics()
        {
            if (players.Count == 0)
            {
                Console.WriteLine("No players in the system.");
                return;
            }

            int totalGoals = players.Sum(p => p.Goals);
            var bestPlayer = players.OrderByDescending(p => p.Goals).First();
            double avgAge = players.Average(p => p.Age);

            Console.WriteLine($"Total Goals: {totalGoals}");
            Console.WriteLine($"Best Player (Most Goals): {bestPlayer}");
            Console.WriteLine($"Average Age: {avgAge:F2}");
        }

     
        static void SaveData()
        {
            try
            {
                
                string content = string.Join(Environment.NewLine, players.Select(p =>
                    $"{p.Name},{p.Team},{p.Age},{p.Goals},{p.Ranking},{p.Status}"));

               
                File.WriteAllText(filePath, content);
                Console.WriteLine($"Data saved to: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving data: {ex.Message}");
            }
        }

       
        static void LoadData()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    players.Clear(); 
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 6)
                        {
                            string name = parts[0];
                            string team = parts[1];
                            int age = int.Parse(parts[2]);
                            int goals = int.Parse(parts[3]);
                            int ranking = int.Parse(parts[4]);
                            PlayerStatus status = Enum.Parse<PlayerStatus>(parts[5]);

                            players.AddLast(new Player(name, team, age, goals, ranking) { Status = status });
                        }
                    }
                    Console.WriteLine("Data loaded successfully!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading data: {ex.Message}");
            }
        }

        
        static void UpdateTransfer()
        {
            Console.Write("Enter player name: ");
            string name = Console.ReadLine();
            var player = players.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (player != null)
            {
                Console.Write("Enter previous team: ");
                string oldTeam = ValidateStringInput(Console.ReadLine(), "Old Team", 50);
                Console.Write("Enter new team: ");
                string newTeam = ValidateStringInput(Console.ReadLine(), "New Team", 50);
                player.AddTransfer(oldTeam, newTeam);
                Console.WriteLine("Transfer history updated!");
                Console.WriteLine($"Current History: {player.GetTransferHistory()}");
            }
            else
            {
                Console.WriteLine("Player not found!");
            }
        }

     
        static void UpdatePlayerStatus()
        {
            Console.Write("Enter player name: ");
            string name = Console.ReadLine();
            var player = players.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (player != null)
            {
                Console.WriteLine("Set status: (1) Normal, (2) Injured, (3) Suspended");
                string choice = Console.ReadLine();
                player.Status = choice switch
                {
                    "1" => PlayerStatus.Normal,
                    "2" => PlayerStatus.Injured,
                    "3" => PlayerStatus.Suspended,
                    _ => player.Status
                };
                Console.WriteLine("Status updated!");
            }
            else
            {
                Console.WriteLine("Player not found!");
            }
        }

     
        static void ShowStatusStats()
        {
            if (players.Count == 0)
            {
                Console.WriteLine("No players in the system.");
                return;
            }
            var stats = players.GroupBy(p => p.Status)
                              .Select(g => new { Status = g.Key, Count = g.Count() });
            foreach (var stat in stats)
            {
                Console.WriteLine($"{stat.Status}: {stat.Count} players");
            }
        }

   
        static void FilterPlayers()
        {
            Console.Write("Enter minimum age (or 0 for no limit): ");
            int minAge = GetValidInt(0);
            Console.Write("Enter minimum goals (or 0 for no limit): ");
            int minGoals = GetValidInt(0);

            var filtered = players.Where(p =>
                (minAge == 0 || p.Age >= minAge) &&
                (minGoals == 0 || p.Goals >= minGoals));

            DisplayResults(filtered);
        }

        
        static void ComparePlayers()
        {
            Console.Write("Enter first player name: ");
            string name1 = Console.ReadLine();
            Console.Write("Enter second player name: ");
            string name2 = Console.ReadLine();

            var player1 = players.FirstOrDefault(p => p.Name.Equals(name1, StringComparison.OrdinalIgnoreCase));
            var player2 = players.FirstOrDefault(p => p.Name.Equals(name2, StringComparison.OrdinalIgnoreCase));

            if (player1 != null && player2 != null)
            {
                Console.WriteLine("\nComparison:");
                Console.WriteLine($"Name: {player1.Name} vs {player2.Name}");
                Console.WriteLine($"Team: {player1.Team} vs {player2.Team}");
                Console.WriteLine($"Age: {player1.Age} vs {player2.Age}");
                Console.WriteLine($"Goals: {player1.Goals} vs {player2.Goals}");
                Console.WriteLine($"Ranking: {player1.Ranking} vs {player2.Ranking}");
                Console.WriteLine($"Status: {player1.Status} vs {player2.Status}");
            }
            else
            {
                Console.WriteLine("One or both players not found!");
            }
        }

       
        static void RecommendPlayer()
        {
            if (players.Count == 0)
            {
                Console.WriteLine("No players available!");
                return;
            }
            Random rand = new Random();
            int index = rand.Next(0, players.Count);
            var recommended = players.ElementAt(index);
            Console.WriteLine("Recommended Player of the Day:");
            Console.WriteLine(recommended);
        }

        //LIFO - Last In First Out
        static void UndoDelete()
        {
            if (deletedPlayers.Count > 0)
            {
                var player = deletedPlayers.Pop();
                players.AddLast(player);
                Console.WriteLine("Last delete undone!");
            }
            else
            {
                Console.WriteLine("Nothing to undo!");
            }
        }

        static int GetValidInt(int minValue, int maxValue = int.MaxValue)
        {
            int value;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out value) && value >= minValue && value <= maxValue)
                    return value;
                Console.WriteLine($"Invalid input! Please enter a number between {minValue} and {maxValue}:");
            }
        }


        static string ValidateStringInput(string input, string fieldName, int maxLength)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new Exception($"{fieldName} cannot be empty!");
            if (input.Length > maxLength)
                throw new Exception($"{fieldName} too long! Max length is {maxLength}.");
            if (!input.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
                throw new Exception($"{fieldName} must be alphanumeric!");
            return input;
        }
    }
}