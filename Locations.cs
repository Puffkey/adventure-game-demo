using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame {
    class Locations {
        string choice;
        public bool isDoorOpen, isKeyTaken, isMobAlive, isWeaponTaken, isArmorTaken;

        public Locations() {
            isDoorOpen = false;
            isKeyTaken = false;
            isMobAlive = true;
            isWeaponTaken = false;
            isArmorTaken = false;
        }
        public string loc00() {
            Console.WriteLine("      [ ][ ]");
            Console.WriteLine("[ ]      [ ][ ][ ]");
            Console.WriteLine("[ ][x][ ][ ]   [ ]");
            Console.WriteLine("      [ ]");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("It's just an ordinary room...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("What do you want to do?");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("(GO LEFT), (GO RIGHT)");
            choice = Console.ReadLine().ToUpper();
            if (choice == "GO LEFT")
                return "01";
            else if (choice == "GO RIGHT")
                return "03";
            else {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("You can't do that... that's illegal.");
                return "00";
            }
        }
        public string loc01() {
            Console.WriteLine("      [ ][ ]");
            Console.WriteLine("[ ]      [ ][ ][ ]");
            Console.WriteLine("[x][ ][ ][ ]   [ ]");
            Console.WriteLine("      [ ]");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("It's just an ordinary room...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("What do you want to do?");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("(GO UP), (GO RIGHT)");
            choice = Console.ReadLine().ToUpper();
            if (choice == "GO UP")
                return "02";
            else if (choice == "GO RIGHT")
                return "00";
            else {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("You can't do that... that's illegal.");
                return "01";
            }
        }
        public string loc02(Player user) {
            Console.WriteLine("      [ ][ ]");
            Console.WriteLine("[x]      [ ][ ][ ]");
            Console.WriteLine("[ ][ ][ ][ ]   [ ]");
            Console.WriteLine("      [ ]");
            System.Threading.Thread.Sleep(1000);
            if (isArmorTaken) {
                Console.WriteLine("It's just an ordinary room...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("(GO DOWN)");
                System.Threading.Thread.Sleep(1000);
                choice = Console.ReadLine().ToUpper();
                if (choice == "GO DOWN")
                    return "01";
                else {
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("You can't do that... that's illegal.");
                    return "02";
                }
            } else {
                Console.WriteLine("It's just an ordinary room...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("... but wait! It looks like there's something on the ground!");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("What do you want to do?");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("(GO DOWN), (PICK UP ITEM)");
                choice = Console.ReadLine().ToUpper();
                if (choice == "GO DOWN")
                    return "01";
                else if (choice == "PICK UP ITEM") {
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("You pick the item up and examine it...");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("It's an armour!");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Now you have +5 to your Defense stat!");
                    user.hasArmour = true;
                    user.Armor();
                    isArmorTaken = true;
                    return "02";
                } else {
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("You can't do that... that's illegal.");
                    return "02";
                }

            }
        }
        public string loc03() {
            Console.WriteLine("      [ ][ ]");
            Console.WriteLine("[ ]      [ ][ ][ ]");
            Console.WriteLine("[ ][ ][x][ ]   [ ]");
            Console.WriteLine("      [ ]");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("It's just an ordinary room...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("What do you want to do?");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("(GO LEFT), (GO DOWN), (GO RIGHT)");
            choice = Console.ReadLine().ToUpper();
            if (choice == "GO LEFT")
                return "00";
            else if (choice == "GO DOWN")
                return "04";
            else if (choice == "GO RIGHT")
                return "05";
            else {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("You can't do that... that's illegal.");
                return "03";
            }
        }
        public string loc04(Player user) {
            Console.WriteLine("      [ ][ ]");
            Console.WriteLine("[ ]      [ ][ ][ ]");
            Console.WriteLine("[ ][ ][ ][ ]   [ ]");
            Console.WriteLine("      [x]");
            System.Threading.Thread.Sleep(1000);
            if (isWeaponTaken) {
                Console.WriteLine("It's just an ordinary room...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("(GO UP)");
                System.Threading.Thread.Sleep(1000);
                choice = Console.ReadLine().ToUpper();
                if (choice == "GO UP")
                    return "03";
                else {
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("You can't do that... that's illegal.");
                    return "04";
                }
            } else {
                Console.WriteLine("It's just an ordinary room...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("... but wait! It looks like there's something on the ground!");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("What do you want to do?");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("(GO UP), (PICK UP ITEM)");
                choice = Console.ReadLine().ToUpper();
                if (choice == "GO UP")
                    return "03";
                else if (choice == "PICK UP ITEM") {
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("You pick the item up and examine it...");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("It's a sword!");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Now you have +5 to your Attack stat!");
                    user.hasWeapon = true;
                    user.Damage();
                    isWeaponTaken = true;
                    return "04";
                } else {
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("You can't do that... that's illegal.");
                    return "04";
                }

            }
        }
        public string loc05() {
            Console.WriteLine("      [ ][ ]");
            Console.WriteLine("[ ]      [ ][ ][ ]");
            Console.WriteLine("[ ][ ][ ][x]   [ ]");
            Console.WriteLine("      [ ]");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("It's just an ordinary room...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("What do you want to do?");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("(GO LEFT), (GO UP)");
            choice = Console.ReadLine().ToUpper();
            if (choice == "GO UP")
                return "06";
            else if (choice == "GO LEFT")
                return "03";
            else {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("You can't do that... that's illegal.");
                return "05";
            }
        }
        public string loc06() {
            Console.WriteLine("      [ ][ ]");
            Console.WriteLine("[ ]      [x][ ][ ]");
            Console.WriteLine("[ ][ ][ ][ ]   [ ]");
            Console.WriteLine("      [ ]");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("What do you want to do?");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("(GO UP), (GO DOWN), (GO RIGHT)");
            choice = Console.ReadLine().ToUpper();
            if (choice == "GO RIGHT")
                return "08";
            else if (choice == "GO DOWN")
                return "05";
            else if (choice == "GO UP") {
                if (isDoorOpen)
                    return "07";
                else if (isKeyTaken) {
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("The doors are closed, but you use your key!");
                    System.Threading.Thread.Sleep(1000);
                    Console.Write(".");
                    System.Threading.Thread.Sleep(1000);
                    Console.Write(".");
                    System.Threading.Thread.Sleep(1000);
                    Console.Write(".");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("\nThe doors are now unlocked!");
                    isDoorOpen = true;
                    return "07";
                } else {
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("The doors are locked!");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("But if there's a keyhole... there must be a key!");
                    return "06";
                }
            } else {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("You can't do that... that's illegal.");
                return "06";
            }
        }
        public string loc07() {
            Console.WriteLine("      [ ][x]");
            Console.WriteLine("[ ]      [ ][ ][ ]");
            Console.WriteLine("[ ][ ][ ][ ]   [ ]");
            Console.WriteLine("      [ ]");
            if (isMobAlive)
                return "69";
            else {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("(GO LEFT), (GO DOWN)");
                choice = Console.ReadLine().ToUpper();
                if (choice == "GO DOWN")
                    return "06";
                else if (choice == "GO LEFT")
                    return "11";
                else {
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("You can't do that... that's illegal.");
                    return "07";
                }
            }
        }
        public string loc08() {
            Console.WriteLine("      [ ][ ]");
            Console.WriteLine("[ ]      [ ][x][ ]");
            Console.WriteLine("[ ][ ][ ][ ]   [ ]");
            Console.WriteLine("      [ ]");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("It's just an ordinary room...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("What do you want to do?");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("(GO LEFT), (GO RIGHT)");
            choice = Console.ReadLine().ToUpper();
            if (choice == "GO LEFT")
                return "06";
            else if (choice == "GO RIGHT")
                return "09";
            else {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("You can't do that... that's illegal.");
                return "08";
            }
        }
        public string loc09() {
            Console.WriteLine("      [ ][ ]");
            Console.WriteLine("[ ]      [ ][ ][x]");
            Console.WriteLine("[ ][ ][ ][ ]   [ ]");
            Console.WriteLine("      [ ]");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("It's just an ordinary room...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("What do you want to do?");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("(GO LEFT), (GO DOWN)");
            choice = Console.ReadLine().ToUpper();
            if (choice == "GO LEFT")
                return "08";
            else if (choice == "GO DOWN")
                return "10";
            else {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("You can't do that... that's illegal.");
                return "09";
            }
        }
        public string loc10() {
            Console.WriteLine("      [ ][ ]");
            Console.WriteLine("[ ]      [ ][ ][ ]");
            Console.WriteLine("[ ][ ][ ][ ]   [x]");
            Console.WriteLine("      [ ]");
            System.Threading.Thread.Sleep(1000);
            if (isKeyTaken) {
                Console.WriteLine("It's just an ordinary room...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("(GO UP)");
                System.Threading.Thread.Sleep(1000);
                choice = Console.ReadLine().ToUpper();
                if (choice == "GO UP")
                    return "09";
                else {
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("You can't do that... that's illegal.");
                    return "10";
                }
            } else {
                Console.WriteLine("It's just an ordinary room...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("... but wait! It looks like there's something on the ground!");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("What do you want to do?");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("(GO UP), (PICK UP ITEM)");
                choice = Console.ReadLine().ToUpper();
                if (choice == "GO UP")
                    return "09";
                else if (choice == "PICK UP ITEM") {
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("You pick the item up and examine it...");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("It's a key!");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("If there's a key, there must be a keyhole...!");
                    isKeyTaken = true;
                    return "10";
                } else {
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("You can't do that... that's illegal.");
                    return "10";
                }

            }
        }
        public string loc11() {
            Console.WriteLine("      [x][ ]");
            Console.WriteLine("[ ]      [ ][ ][ ]");
            Console.WriteLine("[ ][ ][ ][ ]   [ ]");
            Console.WriteLine("      [ ]");
            System.Threading.Thread.Sleep(1000);
            return "12";
            
        }
    }
}
