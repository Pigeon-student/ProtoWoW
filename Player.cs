using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProtoWoW
{
    class Player : Unit
    {
        private Race race = Race.None;
        private Specialisation specialization = Specialisation.None;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Race">Расса може бути людина, орк або ельф</param>
        /// <param name="Spec">Клас може бути воін, маг або мисливець </param>
        public Player(string Name, Race Race, Specialisation Spec) : base(Name)
        {
            race = Race;
            specialization = Spec;

        }

        public void GetPlayerInfo()
        {           
            var infoRace = race.ToString();
            var infoSpec = specialization.ToString();
            Console.WriteLine($"\n{Name}, {infoRace}, {infoSpec}\n");
        }

        // $"Name: {base(Name)}\nLevel: {level}\nHealth: {health}\nMana: {mana}\nExpirience: {expirience}"

    }
}
