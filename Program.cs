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

                Console.WriteLine("Enter the team member's skill level");
                int skillLevel = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the team member's courage factor");
                double courageFactor = Convert.ToDouble(Console.ReadLine());

                TeamMember newMember = new TeamMember(name, skillLevel, courageFactor);

                Console.WriteLine($"{newMember.Name} has a skill level of {newMember.SkillLevel} and a courage factor of {newMember.CourageFactor}");
                team.Add($"{newMember.Name}", newMember);

            }
            Console.WriteLine($"Team Count: {team.Count}");
            foreach(KeyValuePair<string, TeamMember> each in team)
            {
                Console.WriteLine(each.Value.Stringify());
            }
        }
    }
}
