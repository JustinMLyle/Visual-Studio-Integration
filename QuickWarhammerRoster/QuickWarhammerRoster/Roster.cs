using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickWarhammerRoster
{
    class Roster
    {
        private static List<Unit> UnitList = new List<Unit>();
        public static List<Unit> RosterList = new List<Unit>();

        void addUnits()
        {
            UnitList.Add(new Unit("Gravis Captain", "hq", 7));
            UnitList.Add(new Unit("Lieutenent", "hq", 5));
            UnitList.Add(new Unit("Mephiston", "hq", 8));
            UnitList.Add(new Unit("Librarian", "hq", 6));
            UnitList.Add(new Unit("Librarian Dreadnought", "hq", 9));
            UnitList.Add(new Unit("Scouts", "troop", 4));
            UnitList.Add(new Unit("Tactical Squad", "troop", 9));
            UnitList.Add(new Unit("Intercessors", "troop", 10));
            UnitList.Add(new Unit("Sanguinary Guard", "elite", 8));
            UnitList.Add(new Unit("Assault Terminators", "elite", 11));
            UnitList.Add(new Unit("Reivers", "elite", 10));
            UnitList.Add(new Unit("Inceptors", "fast", 10));
            UnitList.Add(new Unit("Assault Squad", "fast", +9));
        }
        static void hqSelector()
        {
            foreach (var Unit in UnitList.FindAll(x => x.unitType == "hq"))
            {
                Console.WriteLine(Unit.unitName + ", HQ, " + Unit.unitCost + " Power Level");
            }
            string hqselected = Console.ReadLine();
            hqselected.ToLower();

            if (hqselected == "gravis captain")
            {
                RosterList.Add(new Unit("Gravis Captain", "hq", 7));
                Console.WriteLine("Gravis Captain Selected");
            }
            if (hqselected == "lieutenent")
            {
                UnitList.Add(new Unit("Lieutenent", "hq", 5));
                Console.WriteLine("Lieutenent Selected");
            }
            if (hqselected == "lieutenent")
            {
                UnitList.Add(new Unit("Lieutenent", "hq", 5));
                Console.WriteLine("Lieutenent Selected");
            }
            if (hqselected == "mephiston")
            {
                UnitList.Add(new Unit("Mephiston", "hq", 8));
                Console.WriteLine("Mephiston Selected");
            }
            if (hqselected == "librarian")
            {
                UnitList.Add(new Unit("Librarian", "hq", 6));
                Console.WriteLine("Librarian Selected");
            }

            if (hqselected == "librarian dreadnought")
            {
                UnitList.Add(new Unit("Librarian Dreadnought", "hq", 9));
                Console.WriteLine("Librarian Dreadnought Selected");
            }



        }

        static void troopSelector()
        {
            foreach (var Unit in UnitList.FindAll(x => x.unitType == "troop"))
            {
                Console.WriteLine(Unit.unitName + ", Troop, " + Unit.unitCost + " Power Level");
            }
            string troopSelected = Console.ReadLine();
            troopSelected.ToLower();

            if (troopSelected == "Scouts")
            {
               RosterList.Add(new Unit("Scouts", "troop", 4));
                Console.WriteLine("Scouts Selected");
            }
            if (troopSelected == "Tactical Squad")
            {
                RosterList.Add(new Unit("Tactical Squad", "troop", 9));
                Console.WriteLine("Tactical Squad Selected");

            }

            if (troopSelected == "intercessors")
            {
                RosterList.Add(new Unit("Intercessors", "troop", 10));
                Console.WriteLine("intercessor Squad Selected");
            }



        }

        static void eliteSelector()
        {
            foreach (var Unit in UnitList.FindAll(x => x.unitType == "elite"))
            {
                Console.WriteLine(Unit.unitName + ", Elite, " + Unit.unitCost + " Power Level");
            }
        }

        static void faSelector()
        {
            foreach (var Unit in UnitList.FindAll(x => x.unitType == "fast"))
            {
                Console.WriteLine(Unit.unitName + ", Fast, " + Unit.unitCost + " Power Level");
            }
        }



        public static void rosterBuilder()
        {
            if (ForceOrg.forceType == "patrol")
            {
                Console.WriteLine("Select 1 to 2 HQ choices from the Following List");
                hqSelector();

                Console.WriteLine("Select Another? Y/N");

                string continueHQSelected = Console.ReadLine();
                continueHQSelected.ToLower();

                if (continueHQSelected == "y")
                {
                    hqSelector();
                }
                else
                {
                    Console.WriteLine("select 1 to 3 choices from the following list");
                    troopSelector();
                    Console.WriteLine("Select Another? Y/N");

                    string continuetroopSelected = Console.ReadLine();
                    continuetroopSelected.ToLower();

                    if (continuetroopSelected == "y")
                    {
                        Console.WriteLine("select 1 to 2 choices from the following list");
                        troopSelector();
                        continuetroopSelected = null;
                    }
                    else
                    {

                    }

                }
            }


        }


    }

}

    

