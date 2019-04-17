using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame {
    class Player {
        public int currentHp, currentDamage, currentDefense;
        public bool isAlive, hasWeapon, hasArmour;
        public string currentLocation;

        public Player() {
            currentHp = 30;
            isAlive = true;
            currentLocation = "00";
            hasWeapon = false;
            currentDamage = 0;
            currentDefense = 0;
        }

        public void Health (int amount) {
            currentHp -= amount;
            if (currentHp <= 0) {
                isAlive = false;
                currentHp = 0;
            }
        }
        public void Damage() {
            if (hasWeapon)
                currentDamage += 5;
        }
        public void Armor() {
            if (hasArmour)
                currentDefense += 5;
        }

    }
}
