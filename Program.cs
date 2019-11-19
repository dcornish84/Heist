using System;
using System.Collections.Generic;

namespace HeistExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Phase 1
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine();

            //Create a way to store a single team member. A team member will have a name, a skill Level and a courage factor. The skill Level will be a positive integer and the courage factor will be a decimal between 0.0 and 2.0.

            Heister teamMember;

            //Prompt the user to enter a team member's name and save that name.
            Console.WriteLine("Enter your team member's name");
            string name = Console.ReadLine();
            // teamMember.Add("Name", name);

            //Prompt the user to enter a team member's skill level and save that skill level with the name.
            Console.WriteLine("Enter your team member's skill level");
            string skillLevelString = Console.ReadLine();

            int skillLevel;
            try
            {
                skillLevel = int.Parse(skillLevelString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{skillLevelString} is not a valid skill level.  Using a default value of 10");
                skillLevel = 10;
                throw;
            }


            //Prompt the user to enter a team member's courage factor and save that courage factor with the name.
            Console.WriteLine("Enter your team member's courage factor");
            string courageFactorString = Console.ReadLine();
            decimal courageFactor;

            try
            {
                courageFactor = decimal.Parse(courageFactorString);
            }
            catch (Exception)
            {
                Console.WriteLine($"{courageFactorString} is not a valid courage factor. Using a default value of 1.0");
                courageFactor = 1.0M;
            }


            //Display the team member's information.
            teamMember = new Heister()
            {
                Name = name,
                SkillLevel = skillLevel,
                CourageFactor = courageFactor
            };

            Console.WriteLine($"Name: {teamMember.Name}");
            Console.WriteLine($"Skill Level: {teamMember.SkillLevel}");
            Console.WriteLine($"Courage Factor: {teamMember.CourageFactor}");

            //Display the team member's information.
            // foreach (KeyValuePair<string, string> attribute in teamMember)
            // {
            //     Console.WriteLine($"{attribute.Key}: {attribute.Value}");
            // }

        }
    }
}