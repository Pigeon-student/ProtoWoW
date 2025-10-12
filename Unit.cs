using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoWoW
{
    internal class Unit
    {
        private string name = string.Empty;
        private byte level;
        private int health;
        private int mana;
        private int expirience = 0;
        private byte[] position = new byte[2]; // Координати на полі [x,y]

        public string Name { get { return name; } set { name = value; } }
        public byte Level { get; set; }
        public int HP { get { return health; } set { health = value; } }
        public int MP { get { return mana; } set { mana = value; } }
        public int XP { get { return expirience; } set { expirience = value; } }
        public byte[] Position { get { return position; } set { position = value; } }

        public Unit(string Name)
        {
            name = Name;        
        }

        public Unit(string Name, byte Level, int HP, int MP)
        {
            name = Name;
            level = Level;
            health = HP;
            mana = MP; 
        }

        public void GetInfo()
        {
            Console.WriteLine($"\nName: {name}\nLevel: {level}\nHealth: {health}\nMana: {mana}\nExpirience: {expirience}\n");
        }

        public void GetPosition()
        {
            foreach (var pos in position)
            {
                Console.Write(pos);
            }
            Console.WriteLine();
        }




    }
}
