using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickWarhammerRoster
{
    class ForceOrg
    {
        public static string forceType {
            get { return ForceType; }
        }

        public static int commandPoints { get; set; }
        

        private static string ForceType;

        public static void requirementSetter()
        {
            
            
            Console.WriteLine("Select Your force Org from the following list: " + "\r\n" + "Patrol" + "\r\n" + "Batallion" + "\r\n" + "Vanguard");

            ForceType = Console.ReadLine();

            ForceType.ToLower();

            //The three different types of force 
            if (ForceType == "patrol")
            {
                ForceType = forceType;
                forcePatrol.addUnits();
                forcePatrol.rosterBuilder();
                
            }



            if (ForceType == "batallion")
             
            {                
                commandPoints = 6;
                ForceType = forceType;                
            }



            if (ForceType == "vanguard")
            {             
                commandPoints = 4;
                ForceType = forceType;
            }
          
    

        }
    }

    class forcePatrol : Roster
    {
        public static void forceSet()
        {
            ForceOrg.commandPoints = 3;            
        }
            
    }

    class forceBatallion: Roster
    {

    }

    class forceOutrider: Roster
    {

    }
}
 
