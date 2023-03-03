﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamMemberName = "";
            Dictionary<string, Member> myTeam = new();

            int bankDifficulty = 100;
            int luckValue = new Random().Next(-10, 10);
            bankDifficulty = bankDifficulty + luckValue;


            int teamSkill = 0;

            do

            {
                Console.WriteLine("Plan Your Heist!");
                Console.WriteLine("Enter your a team member's name:");
                teamMemberName = Console.ReadLine();
                if (teamMemberName != "")
                {
                    Console.WriteLine("Enter your a team member's skill level:");
                    string teamMemberSkill = Console.ReadLine();

                    Console.WriteLine("Enter your a team member's courage level between 0 - 2.0:");
                    string teamMemberCourage = "";
                    while (teamMemberCourage == "")
                    {
                        teamMemberCourage = Console.ReadLine();
                        if (double.Parse(teamMemberCourage) > 2 || double.Parse(teamMemberCourage) < 0)
                        {
                            Console.WriteLine("You entered an incorrect value.");
                            Console.WriteLine("Enter your a team member's courage level between 0 - 2.0:");
                            teamMemberCourage = "";
                        }

                    }

                    // creating the member
                    Member teamMember = new Member(teamMemberName, int.Parse(teamMemberSkill), double.Parse(teamMemberCourage));
                    myTeam.Add(teamMemberName, teamMember);

                    // adding to the dictionary, w/ the string = teamMemberName,
                }

            }


            while (teamMemberName.Length > 0);

            // Console.WriteLine($"Your team has {myTeam.Count} members.");

            foreach (KeyValuePair<string, Member> member in myTeam)
            {
                teamSkill += member.Value.SkillLevel;
            }

            Console.WriteLine($"Your team's skill: {teamSkill}");
            Console.WriteLine($"Bank's difficulty: {bankDifficulty}");

            if (teamSkill > bankDifficulty)
            {
                Console.WriteLine("Success! You're ready to rob the bank.");
            }
            else
            {
                Console.WriteLine("Your heist plans have been foiled. Better luck next time.");
            }

        }
    }
}

/*

Dictionary<string, Member> member1 = new();

member1.Add("taco",new Member(teamMemberName, int.Parse(teamMemberSkill), double.Parse(teamMemberCourage));
member1.Add("taco",new Member(teamMemberName, int.Parse(teamMemberSkill), double.Parse(teamMemberCourage));
member1.Add("taco",new Member(teamMemberName, int.Parse(teamMemberSkill), double.Parse(teamMemberCourage));


*/

/*
                    do
                        {
                            // this will generate a random number as long as the number is already in the list.
                            number = rnd.Next(0, affirmations.Count - 1);
                        } 
                        while (ListNumbers.Contains(number));
                        ListNumbers.Add(number);
                    }
                     */