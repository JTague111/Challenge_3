using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Challenge_3
{
    class App
    {
        private BadgeRepository _badgeRepo = new BadgeRepository();
        private int input;
        private List<Badge> _listOfBadges = new List<Badge>();
        public void Start()
        {
            SeedMenuList();
            Title = "Komodo Insurance";
            RunMainMenu();
        }

        private void RunMainMenu()
        {
            string prompt = @"
 _   __                          _         _____                                         
| | / /                         | |       |_   _|                                        
| |/ /  ___  _ __ ___   ___   __| | ___     | | _ __  ___ _   _ _ __ __ _ _ __   ___ ___ 
|    \ / _ \| '_ ` _ \ / _ \ / _` |/ _ \    | || '_ \/ __| | | | '__/ _` | '_ \ / __/ _ \
| |\  \ (_) | | | | | | (_) | (_| | (_) |  _| || | | \__ \ |_| | | | (_| | | | | (_|  __/
\_| \_/\___/|_| |_| |_|\___/ \__,_|\___/   \___/_| |_|___/\__,_|_|  \__,_|_| |_|\___\___|
                                                                                                                                                                               
Hello Security Admin of Komodo Insurance. Please enter Desired Course of action.";
            string[] options = { "See all Badges", "Delete a Badge", "Edit a Badge", "Create a Badge", "Exit" };
            Selection mainMenu = new Selection(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunSeeBadges();
                    break;
                case 1:
                    RunDeleteBadges();
                    break;
                case 2:
                    RunEditBadges();
                    break;
                case 3:
                    RunAddBadges();
                    break;
                case 4:
                    RunExit();
                    break;

            }
        }
        private void RunSeeBadges()
        {
            Clear();
            List<Badge> listOfBadges = _badgeRepo.GetBadges();
            foreach (Badge badge in listOfBadges)
            {
                WriteLine($"Claim ID: {badge.BadgeID}\n" +
                    $"Access to Door A1 {badge.DoorA1}\n" +
                    $"Access to Door A2 {badge.DoorA2}\n" +
                    $"Access to Door A3 {badge.DoorA3}\n" +
                    $"Access to Door A4 {badge.DoorA4}\n" +
                    $"Access to Door A5 {badge.DoorA5}\n" +
                    $"Access to Door B1 {badge.DoorB1}\n" +
                    $"Access to Door B2 {badge.DoorB2}\n" +
                    $"Access to Door B3 {badge.DoorB3}\n" +
                    $"Access to Door B4 {badge.DoorB4}\n" +
                    $"Access to door B5 {badge.DoorB5}\n");
            }
            WriteLine("Press any key to continue");
            ReadKey();
            RunMainMenu();

        }
        private void RunSeeBadges1()
        {
            Clear();
            List<Badge> listOfBadges = _badgeRepo.GetBadges();
            foreach (Badge badge in listOfBadges)
            {
                WriteLine($"Claim ID: {badge.BadgeID}\n" +
                    $"Access to Door A1 {badge.DoorA1}\n" +
                    $"Access to Door A2 {badge.DoorA2}\n" +
                    $"Access to Door A3 {badge.DoorA3}\n" +
                    $"Access to Door A4 {badge.DoorA4}\n" +
                    $"Access to Door A5 {badge.DoorA5}\n" +
                    $"Access to Door B1 {badge.DoorB1}\n" +
                    $"Access to Door B2 {badge.DoorB2}\n" +
                    $"Access to Door B3 {badge.DoorB3}\n" +
                    $"Access to Door B4 {badge.DoorB4}\n" +
                    $"Access to door B5 {badge.DoorB5}\n");
            }
        }

        private void RunDeleteBadges()
        {
            Clear();
            RunSeeBadges1();
            WriteLine("Enter the BadgeId of the badge you'd like to remove.");
            int number1;
            string number = ReadLine().Trim();
            number1 = int.Parse(number);

            bool wasDeleted = _badgeRepo.RemoveBadgeFromList(number1);
            
            if (wasDeleted)
            {
                WriteLine("Badge successfully deleted.");
            }
            else
            {
                WriteLine("Badge could not be deleted.");
            }
            RunMainMenu();
        }
        private void RunAddBadges()
        {
            Clear();
            Badge newbadge = new Badge();
            WriteLine("Enter BadgeID for new badge");
            string badgeIDString = ReadLine().Trim();
            newbadge.BadgeID = int.Parse(badgeIDString);
            WriteLine("Access to door A1? (y/n)");
            string doorA1String = ReadLine().Trim();

            if (doorA1String == "y")
            {
                newbadge.DoorA1 = true;
            }
            else
            {
                newbadge.DoorA1 = false;
            }
            WriteLine("Access to door A2? (y/n)");
            string doorA2String = ReadLine().Trim();

            if (doorA2String == "y")
            {
                newbadge.DoorA2 = true;
            }
            else
            {
                newbadge.DoorA2 = false;
            }
            WriteLine("Access to door A3? (y/n)");
            string doorA3String = ReadLine().Trim();

            if (doorA3String == "y")
            {
                newbadge.DoorA3 = true;
            }
            else
            {
                newbadge.DoorA3 = false;
            }
            WriteLine("Access to door A4? (y/n)");
            string doorA4String = ReadLine().Trim();

            if (doorA4String == "y")
            {
                newbadge.DoorA4 = true;
            }
            else
            {
                newbadge.DoorA4 = false;
            }
            WriteLine("Access to door A5? (y/n)");
            string doorA5String = ReadLine().Trim();

            if (doorA5String == "y")
            {
                newbadge.DoorA5 = true;
            }
            else
            {
                newbadge.DoorA5 = false;
            }
            WriteLine("Access to door B1? (y/n)");
            string doorB1String = ReadLine().Trim();

            if (doorB1String == "y")
            {
                newbadge.DoorB1 = true;
            }
            else
            {
                newbadge.DoorB1 = false;
            }
            WriteLine("Access to door B2? (y/n)");
            string doorB2String = ReadLine().Trim();

            if (doorB2String == "y")
            {
                newbadge.DoorB2 = true;
            }
            else
            {
                newbadge.DoorB2 = false;
            }
            WriteLine("Access to door B3? (y/n)");
            string doorB3String = ReadLine().Trim();

            if (doorB3String == "y")
            {
                newbadge.DoorB3 = true;
            }
            else
            {
                newbadge.DoorB3 = false;
            }
            WriteLine("Access to door B4? (y/n)");
            string doorB4String = ReadLine().Trim();

            if (doorB4String == "y")
            {
                newbadge.DoorB4 = true;
            }
            else
            {
                newbadge.DoorB4 = false;
            }
            WriteLine("Access to door B5? (y/n)");
            string doorB5String = ReadLine().Trim();

            if (doorB5String == "y")
            {
                newbadge.DoorB5 = true;
            }
            else
            {
                newbadge.DoorB5 = false;
            }


            _badgeRepo.AddBadgeToList(newbadge);

            RunMainMenu();
        }
        private void RunEditBadges()
        {
            Clear();
            RunSeeBadges1();
            Badge newbadge = new Badge();
            WriteLine("Enter the BadgeID of the badge you'd like to update");
            string oldBadgeID = ReadLine();
            WriteLine("Enter BadgeID for new badge");
            string badgeIDString = ReadLine().Trim();
            newbadge.BadgeID = int.Parse(badgeIDString);
            WriteLine("Access to door A1? (y/n)");
            string doorA1String = ReadLine().Trim();

            if (doorA1String == "y")
            {
                newbadge.DoorA1 = true;
            }
            else
            {
                newbadge.DoorA1 = false;
            }
            WriteLine("Access to door A2? (y/n)");
            string doorA2String = ReadLine().Trim();

            if (doorA2String == "y")
            {
                newbadge.DoorA2 = true;
            }
            else
            {
                newbadge.DoorA2 = false;
            }
            WriteLine("Access to door A3? (y/n)");
            string doorA3String = ReadLine().Trim();

            if (doorA3String == "y")
            {
                newbadge.DoorA3 = true;
            }
            else
            {
                newbadge.DoorA3 = false;
            }
            WriteLine("Access to door A4? (y/n)");
            string doorA4String = ReadLine().Trim();

            if (doorA4String == "y")
            {
                newbadge.DoorA4 = true;
            }
            else
            {
                newbadge.DoorA4 = false;
            }
            WriteLine("Access to door A5? (y/n)");
            string doorA5String = ReadLine().Trim();

            if (doorA5String == "y")
            {
                newbadge.DoorA5 = true;
            }
            else
            {
                newbadge.DoorA5 = false;
            }
            WriteLine("Access to door B1? (y/n)");
            string doorB1String = ReadLine().Trim();

            if (doorB1String == "y")
            {
                newbadge.DoorB1 = true;
            }
            else
            {
                newbadge.DoorB1 = false;
            }
            WriteLine("Access to door B2? (y/n)");
            string doorB2String = ReadLine().Trim();

            if (doorB2String == "y")
            {
                newbadge.DoorB2 = true;
            }
            else
            {
                newbadge.DoorB2 = false;
            }
            WriteLine("Access to door B3? (y/n)");
            string doorB3String = ReadLine().Trim();

            if (doorB3String == "y")
            {
                newbadge.DoorB3 = true;
            }
            else
            {
                newbadge.DoorB3 = false;
            }
            WriteLine("Access to door B4? (y/n)");
            string doorB4String = ReadLine().Trim();

            if (doorB4String == "y")
            {
                newbadge.DoorB4 = true;
            }
            else
            {
                newbadge.DoorB4 = false;
            }
            WriteLine("Access to door B5? (y/n)");
            string doorB5String = ReadLine().Trim();

            if (doorB5String == "y")
            {
                newbadge.DoorB5 = true;
            }
            else
            {
                newbadge.DoorB5 = false;
            }

            _badgeRepo.UpdateExistingBadge(oldBadgeID, newbadge);
        }
        private void RunExit()
        {
            WriteLine("\nPress any key to exit...");
            ReadKey(true);
            Environment.Exit(0);
        }

        private void SeedMenuList()
        {
            Badge daryl = new Badge(0001, true, true, true, true, true, true, true, true, true, true);
            Badge sandra = new Badge(01562, true, true, false, false, false, true, true, false, false, false);
            Badge parker = new Badge(04213, true, true, true, true, true, false, false, false, false, false);

            _badgeRepo.AddBadgeToList(daryl);
            _badgeRepo.AddBadgeToList(sandra);
            _badgeRepo.AddBadgeToList(parker);
        }
    }
}