using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamUIConsoleApp
{
    class ProgramUI
    {
        private DevelperContentRepository _contentRepo = new DevelperContentRepository();

        public void Run()
        {
            Menu();
        }
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning) { 
            Console.WriteLine("Please register for DevTeams:\n +" +
                "1. Enter your Unique ID Number:\n" +
                "2. Enter Your First Name:\n" +
                "3. Enter Your Last Name:\n" +
                "4. Do you have access to Pluralsight?:\n" +
                "5. Enter the Name of your Team:\n" +
                "6. Exit");
            string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        DisplayUniqueID();
                        break;
                    case "2":
                        DisplayFirstName();
                        break;
                    case "3":
                        DisplayLastName();
                        break;
                    case "4":
                        DisplayPluralSightAccess();
                        break;
                    case "5":
                        DisplayTeamName();
                        break;
                    case "6":
                        Console.WriteLine("Welcome to the Team!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid ID Number.");
                        break;
                }
                Console.WriteLine("Please press Enter to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void DisplayUniqueID()
        {
            Console.Clear();
            Developer newContent = new Developer();

            Console.WriteLine("Enter your Unique ID:");
            string idAsString = Console.ReadLine();
            newContent.IdNUmber = double.Parse(idAsString);

            Console.WriteLine("Enter your First Name:");
            newContent.FirstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name:");
            newContent.LastName = Console.ReadLine();

            Console.WriteLine("Do you have Pluralsight Access? (y/n):");
            string pluralSightAccessString = Console.ReadLine().ToLower();
            if(pluralSightAccessString == "y")
            {
                newContent.PluralSightAccess = true;
            }
            else
            {
                newContent.PluralSightAccess = false;
            }            

            Console.WriteLine("Enter the Team Number have you been assigned to:\n" +
                                "1. Front End\n" +
                                "2. Back End\n" +
                                "3. Full Stack\n" +
                                "4. Design");
            string teamNameAsString = Console.ReadLine();
            int teamNameAsInt = int.Parse(teamNameAsString);
            newContent.NameOfTeam = (NameOfTeam)teamNameAsInt;

            _contentRepo.AddContentToList(newContent);
        }
        private void DisplayFirstName()
        {
            List<Developers> listOfDevelopers = _contentRepo.GetCOntentList();
            foreach(DeveloperConetnt content in listOfDevelopers)
            {
                Console.WriteLine($"FirstName: {content.FirstName} LastName: {content.LastName}");

            }
        }
        private void DisplayLastName()
        {

        }
        private void DisplayPluralSightAccess()
        {

        }
        private void DisplayTeamName()
        {

        }
        private void seedContentList()
        {

        }
    }
}
