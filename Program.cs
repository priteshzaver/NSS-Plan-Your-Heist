using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist");
            Console.WriteLine("");
            Console.Write("Please enter the bank difficulty:");
            int bankDifficulty = int.Parse(Console.ReadLine());

            string name = "Pritesh";
            Dictionary<string, TeamMember> team = new Dictionary<string, TeamMember>();

            while (name != "")
            {
                Console.WriteLine("Enter the name of a new team member");
                name = Console.ReadLine();
                if (name == "")
                {
                    continue;
                }

                Console.WriteLine("Enter the team member's skill level (1 - 100): ");
                int skillLevel = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the team member's courage factor (0.0 - 2.0): ");
                double courageFactor = Convert.ToDouble(Console.ReadLine());

                TeamMember newMember = new TeamMember(name, skillLevel, courageFactor);

                team.Add($"{newMember.Name}", newMember);

            }
            Console.Write("How many trial runs are needed?");
            int trials = int.Parse(Console.ReadLine());
            int successes = 0;
            int fails = 0;

            for (int i = 0; i < trials; i++)
            {
                Random random = new Random();
                int teamLuck = random.Next(-10, 11);
                bankDifficulty += teamLuck;

                int totalSkill = team.Sum(each => each.Value.SkillLevel);
                Console.WriteLine($"Team Skill: {totalSkill}");
                Console.WriteLine($"Bank Difficulty: {bankDifficulty}");
                if (totalSkill >= bankDifficulty)
                {
                    Console.WriteLine("You have successfully broken in and stolen some shit!");
                    bankDifficulty -= teamLuck;
                    successes++;
                }
                else
                {
                    Console.WriteLine("You couldn't break in so you go to jail bad boy!");
                    bankDifficulty -= teamLuck;
                    fails++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"The program succeeded {successes} times and failed {fails} times.");
        }
    }
}
