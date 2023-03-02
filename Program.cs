using System;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist");
            
            Console.WriteLine("Enter the name of a new team member");
            string name = Console.ReadLine();
            
            Console.WriteLine("Enter the team member's skill level");
            int skillLevel = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the team member's courage factor");
            double courageFactor = Convert.ToDouble(Console.ReadLine());
            
            TeamMember john = new TeamMember(name, skillLevel, courageFactor);

            Console.WriteLine($"{john.Name} has a skill level of {john.SkillLevel} and a courage factor of {john.CourageFactor}");
        }
    }
}
