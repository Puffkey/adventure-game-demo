using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame {
    class Program {
        static void Main(string[] args) {
            Player user = new Player();
            Locations gps = new Locations();
            Monster mob = new Monster();
            bool isGameFinished = false;

            Console.WriteLine("Welcome to the demo!\n");

            while (user.isAlive && !isGameFinished) {
                System.Threading.Thread.Sleep(800);
                switch (user.currentLocation) {
                    case "00":
                        user.currentLocation = gps.loc00();
                        break;
                    case "01":
                        user.currentLocation = gps.loc01();
                        break;
                    case "02":
                        user.currentLocation = gps.loc02(user);
                        break;
                    case "03":
                        user.currentLocation = gps.loc03();
                        break;
                    case "04":
                        user.currentLocation = gps.loc04(user);
                        break;
                    case "05":
                        user.currentLocation = gps.loc05();
                        break;
                    case "06":
                        user.currentLocation = gps.loc06();
                        break;
                    case "07":
                        user.currentLocation = gps.loc07();
                        break;
                    case "08":
                        user.currentLocation = gps.loc08();
                        break;
                    case "09":
                        user.currentLocation = gps.loc09();
                        break;
                    case "10":
                        user.currentLocation = gps.loc10();
                        break;
                    case "11":
                        user.currentLocation = gps.loc11();
                        break;
                    case "12":
                        isGameFinished = true;
                        break;
                    case "69":
                        user.currentLocation = Fight(gps, user, mob);
                        break;
                }
                Console.WriteLine();
            }
            if (user.isAlive)
                Console.WriteLine("Thank you for playing this demo!");
            else
                Console.WriteLine("Thanks for playing this demo! Maybe next time try to look a bit around before heading to the boss...");
            Console.ReadLine();
        }
        static string Fight(Locations gps, Player user, Monster mob) {
            Random dmg = new Random();
            int attack;
            Console.WriteLine("You've encountered a monster!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("You must fight!");
            while (user.isAlive && mob.isAlive) {
                System.Threading.Thread.Sleep(1000);
                attack = dmg.Next(0, 6) + user.currentDamage;
                mob.Health(attack);
                if (!mob.isAlive) {
                    Console.WriteLine($"You attack monster for {attack} points! And it's dead, Jim.");
                    break;
                } else if(attack == 0) {
                    Console.WriteLine("You try to attack monster, but you miss!");
                } else
                    Console.WriteLine($"You attack monster for {attack} points! It has {mob.currentHp} points left!");

                System.Threading.Thread.Sleep(1000);
                attack = dmg.Next(5, 12) - user.currentDefense;
                user.Health(attack);
                if (!user.isAlive) {
                    Console.WriteLine($"Monster attacks you for {attack} points! And you're dead, Jim.");
                }
                else if (attack == 0) {
                    Console.WriteLine("Monster tries to attack you, but it misses!");
                } else
                    Console.WriteLine($"Monster attacks you for {attack} points! You have {user.currentHp} points left!");
            }
            System.Threading.Thread.Sleep(1000);
            if (!user.isAlive) {
                Console.WriteLine("You're dead!");
                System.Threading.Thread.Sleep(1000);
                return "end";
            } else {
                Console.WriteLine("You've defeated the monster!");
                gps.isMobAlive = false;
                return "07";
            }
        }
    }
}
