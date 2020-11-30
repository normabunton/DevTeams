using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public enum TeamName
    {
        FrontEnd = 1,
        BackEnd,
        FullStack,
        Design
    }
    public class Developer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double IdNumber { get; set; }
        public bool PluralSightAccess { get; set; }
        public TeamName NameOfTeam { get; set; }

        public Developer() { }
        public Developer(string firstName, string lastName, double idNumber, bool pluralSightAccess, TeamName teamName)
        {
            FirstName = firstName;
            LastName = lastName;
            IdNumber = idNumber;
            PluralSightAccess = pluralSightAccess;
            NameOfTeam = teamName;
        }
    }
}
