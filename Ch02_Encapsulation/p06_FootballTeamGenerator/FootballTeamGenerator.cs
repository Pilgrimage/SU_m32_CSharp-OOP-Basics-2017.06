namespace p06_FootballTeamGenerator
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class FootballTeamGenerator
    {
        public static void Main()
        {
            List<Team> teams = new List<Team>();
            string input;


            while ((input = Console.ReadLine()) != "END")
            {
                try
                {
                    string[] inParams = input.Split(';');//.Select(x => x.Trim()).ToArray();

                    switch (inParams[0].ToLower())
                    {
                        case "team":
                            if (IsTeamExist(teams, inParams[1]))
                            {
                                throw new InvalidOperationException($"Team {inParams[1]} already exist.");
                            }
                            teams.Add(new Team(inParams[1]));
                           break;

                        case "add":
                            if (!IsTeamExist(teams, inParams[1]))
                            {
                                throw new InvalidOperationException($"Team {inParams[1]} does not exist.");
                            }
                            Player newPlayer = new Player(inParams[2], double.Parse(inParams[3]), double.Parse(inParams[4]), double.Parse(inParams[5]), double.Parse(inParams[6]), double.Parse(inParams[7]));
                            Team team = teams.FirstOrDefault(n => n.Name == inParams[1]);
                            team.AddPlayer(newPlayer);
                            break;
                            
                        case "remove":
                            if (!IsTeamExist(teams, inParams[1]))
                            {
                                throw new InvalidOperationException($"Team {inParams[1]} does not exist.");
                            }
                            //Team team = teams.FirstOrDefault(n => n.Name == inParams[1]);
                            teams.FirstOrDefault(n => n.Name == inParams[1]).RemovePlayer(inParams[2]);
                            break;
                            
                        case "rating":
                            if (!IsTeamExist(teams, inParams[1]))
                            {
                                throw new InvalidOperationException($"Team {inParams[1]} does not exist.");
                            }
                            Console.WriteLine(teams.FirstOrDefault(n => n.Name == inParams[1]));
                            break;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        public static bool IsTeamExist(List<Team> teams, string teamName)
        {
            return teams.Any(n => n.Name == teamName);
        }
    }
}
