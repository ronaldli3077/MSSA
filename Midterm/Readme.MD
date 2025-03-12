EPL Player Management System
----------------------------

Language: C#
Platform: .NET
License: MIT

Overview
--------
The English Premier League (EPL) Player Management System is a console-based application written in C# that allows users to manage player data for EPL teams. This project demonstrates object-oriented programming, file handling, and data manipulation in a simple yet functional system.

Features
--------
- Player Management: Add, update, delete, and search for players.
- Data Persistence: Save and load player data in JSON format (players.json).
- Export to CSV: Export player data to a CSV file (players.csv).
- Transfer History: Track player transfers with old team, new team, and date.
- Player Status: Manage player status (Normal, Injured, Suspended).
- Statistics: View total goals, average age, and top goal scorers.
- Sorting and Filtering: Sort players by age, goals, or ranking; filter by age or goals.
- Undo Delete: Revert the last player deletion using a stack-based undo feature.
- Preloaded Data: Comes with sample EPL player data for immediate use.

Sample Data
-----------
The system preloads data for the following teams and players (based on fictional 2025 stats):
- Manchester City: Erling Haaland, Kevin De Bruyne
- Liverpool: Mohamed Salah, Darwin Nunez
- Arsenal: Bukayo Saka, Martin Odegaard
- Tottenham: Harry Kane, Son Heung-min
- Manchester United: Bruno Fernandes, Marcus Rashford

Players include attributes like age, goals, ranking, status, and transfer history.

Prerequisites
-------------
- .NET SDK: Version 6.0 or later (download from https://dotnet.microsoft.com/download)
- A C# IDE (e.g., Visual Studio, Visual Studio Code)

Installation
------------
1. Clone the Repository:
   git clone https://github.com/yourusername/epl-player-management.git
   cd epl-player-management

2. Build the Project:
   Open the solution in your IDE (e.g., Visual Studio) and build it, or use the CLI:
   dotnet build

3. Run the Program:
   Execute the program from your IDE or via the CLI:
   dotnet run --project EPLPlayerManagement

Usage
-----
1. On first run, the program initializes with preloaded EPL player data and saves it to players.json.
2. Use the interactive console menu to manage players:

   === English Premier League Player Management ===
   1. Add Player
   2. Display All Players
   3. Update Player
   4. Delete Player
   5. Search Player
   6. Sort Players
   7. Show Statistics
   8. Export to CSV
   9. Save Data
   10. Update Transfer History
   11. Update Player Status
   12. Show Status Statistics
   13. Filter Players
   14. Compare Players
   15. Recommend Player
   16. Undo Last Delete
   0. Exit
   Enter your choice:

3. Follow the prompts to input data (e.g., player name, team, age) as needed.

Example
-------
- Add a Player:
  Enter your choice: 1
  Enter Name: Phil Foden
  Enter Team: Manchester City
  Enter Age: 24
  Enter Goals: 10
  Enter Ranking: 12
  Player added successfully!

- View All Players:
  Enter your choice: 2
  Name: Erling Haaland, Team: Manchester City, Age: 24, Goals: 25, Ranking: 1, Status: Normal
  Transfer History: Borussia Dortmund -> Manchester City (2025-03-12)
  ...

File Structure
--------------
- Program.cs: Main application logic and classes (Player, TransferRecord).
- players.json: Stores player data in JSON format (auto-generated on first run).
- players.csv: Exported player data in CSV format (generated via option 8).

Contributing
------------
Contributions are welcome! To contribute:
1. Fork the repository.
2. Create a new branch (git checkout -b feature/your-feature).
3. Make your changes and commit (git commit -m "Add your feature").
4. Push to your branch (git push origin feature/your-feature).
5. Open a Pull Request.

Please ensure your code follows C# coding conventions and includes comments where necessary.

License
-------
This project is licensed under the MIT License.

Acknowledgments
---------------
- Built with love using C# and .NET.
- Inspired by the English Premier League and its amazing players.
