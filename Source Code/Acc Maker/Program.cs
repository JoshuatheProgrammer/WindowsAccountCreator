//////////////////////////////////////////////////////
///    Admin | Guest Account ~~~~ Creator Tool     ///
//////////////////////////////////////////////////////
//////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.DirectoryServices;

namespace Acc_Maker
{
    internal class Program
    {
        /// <summary>
        /// String Name - Username For Newly Created Accounts
        /// String Pass - Password For Newly Created Accounts
        /// Both On Windows OS
        /// </summary>
        public static string Name;
        public static string Pass;

        static void Main(string[] args)
        {
            var sel = 0;
            ///<summary>
            ///Starts The Application
            ///Greets The User With An Welcome Banner
            ///</summary>
            
            while(sel != 9)
            {
                Console.Title = "Windows Account Maker";
                Console.WindowWidth = 127;
                Console.WindowHeight = 45;

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(@"
 _    _      _                            _   _               _ 
| |  | |    | |                          | | | |             | |
| |  | | ___| | ___ ___  _ __ ___   ___  | | | |___  ___ _ __| |
| |/\| |/ _ \ |/ __/ _ \| '_ ` _ \ / _ \ | | | / __|/ _ \ '__| |
\  /\  /  __/ | (_| (_) | | | | | |  __/ | |_| \__ \  __/ |  |_|
 \/  \/ \___|_|\___\___/|_| |_| |_|\___|  \___/|___/\___|_|  (_)                                                           
 _____
|_   _|    
  | | ___  
  | |/ _ \ 
  | | (_) |
  \_/\___/                     
 _    _ _           _                   
| |  | (_)         | |                  
| |  | |_ _ __   __| | _____      _____ 
| |/\| | | '_ \ / _` |/ _ \ \ /\ / / __|
\  /\  / | | | | (_| | (_) \ V  V /\__ \
 \/  \/|_|_| |_|\__,_|\___/ \_/\_/ |___/         
  ___                            _                                                       
 / _ \                          | |      
/ /_\ \ ___ ___ ___  _   _ _ __ | |_    
|  _  |/ __/ __/ _ \| | | | '_ \| __|                            
| | | | (_| (_| (_) | |_| | | | | |_                             
\_| |_/\___\___\___/ \__,_|_| |_|\__|                                   
___  ___      _                         
|  \/  |     | |                        
| .  . | __ _| | _____ _ __             
| |\/| |/ _` | |/ / _ \ '__|            
| |  | | (_| |   <  __/ |               
\_|  |_/\__,_|_|\_\___|_|      
");


                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please Choose An Option");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("∞ [ 1 ] - Admin Account ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("∞ [ 2 ] - Guest Account ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("∞ [ 3 ] - Exit          ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");


                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.Write(">");


                var selection = Console.ReadLine();
                if (selection != null) sel = int.Parse(selection);

                ///<summary>
                ///Main Program Menu Function
                ///Use Numbers Such As [1], [2], [3]
                /// [1] - Creates Admin Account
                /// [2] - Creates Guest Account
                /// [3] - Exits Application
                ///</summary>
                
                switch (sel)
                {
                    case 1:
                    {
                      Console.Clear();
                            Console.WindowWidth = 20;
                            Console.WindowHeight = 2;

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("[    ] Loading 0%");
                            Thread.Sleep(550);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("[|   ] Loading 10%");
                            Thread.Sleep(550);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("[||  ] Loading 20%");
                            Thread.Sleep(550);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("[||| ] Loading 40%");
                            Thread.Sleep(550);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("[||||] Loading 80%");
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[||||] Loading 100%");
                            Console.Beep();
                            Thread.Sleep(1000);
                            Console.Clear();

                            Console.WindowWidth = 40;
                            Console.WindowHeight = 7;

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Enter An Username");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            Console.Write(">");
                            Name = Console.ReadLine();

                            Thread.Sleep(1000);
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Enter Password For The New User");

                            Console.ForegroundColor = ConsoleColor.White; 
                            Console.WriteLine();
                            Console.Write(">");
                            Pass = Console.ReadLine();


                            createUserAdmin(Name, Pass);


                            Console.WindowWidth = 137;
                            Console.WindowHeight = 13;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();

                            Console.WriteLine();
                            Console.WriteLine("Username :");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(Name);
                            Console.WriteLine();

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Password :");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(Pass);
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.WriteLine();
                            Console.WriteLine("Current Username And Password Please Write It Down If Needed Unless You Did Not Type An Password.\nTo Delete An Account Press Windows Key And Type Settings Press Your Account Go To Family And Others And Delete The Account If You Want A No Password Account. \nPress Enter To Continue");
                            Console.ReadLine();
                        }
                        break;

                    case 2:
                        {
                            Console.Clear();
                            Console.WindowWidth = 20;
                            Console.WindowHeight = 2;

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("[    ] Loading 0%");
                            Thread.Sleep(550);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("[|   ] Loading 10%");
                            Thread.Sleep(550);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("[||  ] Loading 20%");
                            Thread.Sleep(550);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("[||| ] Loading 40%");
                            Thread.Sleep(550);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("[||||] Loading 80%");
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[||||] Loading 100%");
                            Console.Beep();
                            Thread.Sleep(1000);
                            Console.Clear();

                            Console.WindowWidth = 40;
                            Console.WindowHeight = 7;

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Enter An Username");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            Console.Write(">");
                            Name = Console.ReadLine();
                            Thread.Sleep(1000);

                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Enter Password For The New User");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            Console.Write(">");
                            Pass = Console.ReadLine();


                            createUserGuest(Name, Pass);


                            Console.WindowWidth = 125;
                            Console.WindowHeight = 25;

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Username :");

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(Name);
                            Console.WriteLine();

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Password :");

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(Pass);

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            Console.WriteLine("Current Username And Password Please Write It Down If Needed Unless You Did Not Type An Password.\nTo Delete An Account Press Windows Key And Type Settings Press Your Account Go To Family And Others And Delete The Account If You Want A No Password Account. \nPress Enter To Continue");
                            Console.ReadLine();
                        }
                        break;

                    case 3:
                        {
                            Console.Clear();
                            Exit();
                        }
                        break;
                }
                Console.Clear ();
            }
        }

        /// <summary>
        /// Create Admin Account Function
        /// Typically Found Under Add, Edit Account Tab In Settings
        /// [Makes Administrator Account[s]]
        /// Mostly Used For Users Who Just Bought An Computer And Are Setting Up An Account.
        /// And Or Teachers
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Pass"></param>
        
        public static void createUserAdmin(string Name, string Pass)
        {
            try
            {
                DirectoryEntry AD = new DirectoryEntry("WinNT://" +
                    Environment.MachineName + ",computer");
                DirectoryEntry NewUser = AD.Children.Add(Name, "user");
                NewUser.Invoke("SetPassword", new object[] { Pass });
                NewUser.Invoke("Put", new object[] { "Description", "Created via [ Windows Account Creator ]" });
                NewUser.CommitChanges();
                DirectoryEntry grp;

                grp = AD.Children.Find("Administrators", "group");
                if (grp != null) { grp.Invoke("Add", new object[] { NewUser.Path.ToString() }); }
                Console.Clear();
                Thread.Sleep(1000);

                Console.WindowHeight = 25;
                Console.WindowWidth = 55;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Beep();
                Console.Beep();
                Console.WriteLine("Admin Account Created Successfully");
                Console.WriteLine("Press Enter To Continue.");
                Console.WriteLine();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WindowHeight = 5;
                Console.WindowWidth = 55;

                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine("Make Sure You Run The Tool Administrator!\nPress Enter To Continue");
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Create Guest Account Function
        /// Typically Found Under Add, Edit Account Tab In Settings
        /// [Makes Local Account[s]]
        /// Mostly Used At Schools On School Computers To Ensure That Students Cant Download/Use Un Wanted Softwares.
        /// And Or Parents Or Siblings Setting Up Accounts For Either Kid Or Brother Or Sister.
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Pass"></param>

        public static void createUserGuest(string Name, string Pass)
        {
            try
            {
                DirectoryEntry AD = new DirectoryEntry("WinNT://" +
                    Environment.MachineName + ",computer");
                DirectoryEntry NewUser = AD.Children.Add(Name, "user");
                NewUser.Invoke("SetPassword", new object[] { Pass });
                NewUser.Invoke("Put", new object[] { "Description", "Created via [ Windows Account Creator ]" });
                NewUser.CommitChanges();
                DirectoryEntry grp;

                grp = AD.Children.Find("Guests", "group");
                if (grp != null) { grp.Invoke("Add", new object[] { NewUser.Path.ToString() }); }
                Console.Clear();
                Thread.Sleep(1000);

                Console.WindowHeight = 25;
                Console.WindowWidth = 55;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Beep();
                Console.Beep();
                Console.WriteLine("Guest Account Created Successfully");
                Console.WriteLine("Press Enter To Continue.");
                Console.WriteLine();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WindowHeight = 5;
                Console.WindowWidth = 55;

                Console.Beep();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine("Make Sure You Run The Tool Administrator!\nPress Enter To Continue");
                Console.ReadLine();
            }
        }
        /// <summary>
        /// Exit Function
        /// Exits Out Of The Software
        /// With An 1.78 Second Timer 
        /// To Show Off An GoodBye Banner.
        /// </summary>
        public static void Exit()
        {
            Console.WindowWidth = 78;
            Console.WindowHeight = 11;
            Console.ForegroundColor= ConsoleColor.White;
            Console.Clear();
            Console.WriteLine();

            Console.WriteLine(@"
 _____                 _  ______              _   _                     ___ 
|  __ \               | | | ___ \            | | | |                _  |_  |
| |  \/ ___   ___   __| | | |_/ /_   _  ___  | | | |___  ___ _ __  (_)   | |
| | __ / _ \ / _ \ / _` | | ___ \ | | |/ _ \ | | | / __|/ _ \ '__|       | |
| |_\ \ (_) | (_) | (_| | | |_/ / |_| |  __/ | |_| \__ \  __/ |     _    | |
 \____/\___/ \___/ \__,_| \____/ \__, |\___|  \___/|___/\___|_|    (_)  _| |
                                  __/ |                                |___|
                                 |___/                                      ");

            Console.WriteLine();
            Thread.Sleep(1738);
            System.Environment.Exit(0);
        }
    }
}