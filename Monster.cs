using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame {
    class Monster {

        public int currentHp;
        public bool isAlive;

        public Monster() {
            currentHp = 40;
            isAlive = true;
        }

        public void Health(int amount) {
            currentHp -= amount;
            if (currentHp <= 0) {
                isAlive = false;
                currentHp = 0;
            }
        }
    }
}
