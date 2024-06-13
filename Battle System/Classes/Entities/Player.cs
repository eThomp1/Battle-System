using Battle_System.Classes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_System.Classes.Entities
{
    public class Player : Entity
    {
        protected string ClassName;
        public Player(string name) : base(name)
        {
            GiveItem(new Item("food", "some food"));
            GiveItem(new Item("torch", "a torch"));
            GiveItem(new Item("map", "a map"));
            ClassName = "None";
        }
        internal void GiveItem(Item item)
        {
            
        }
        public string GetClassName()
        {
            return ClassName;
        }
    }
    public class Fighter : Player
    {
        public Fighter(string name) : base(name) 
        {
            strength = 5;
            mana = 1;
            dexterity = 3;
            ClassName = "Fighter";
            EquipItem(new Weapon("sword", "a basic sword", 1));
        }
    }
    public class Mage : Player
    {
        public Mage(string name) : base(name)
        {
            strength = 1;
            mana = 5;
            dexterity = 3;
            ClassName = "Mage";
            EquipItem(new Weapon("staff", "a simple staff", 1));
        }
    }
    public class Archer : Player
    {
        public Archer(string name) : base(name)
        {
            strength = 1;
            mana = 3;
            dexterity=5;
            ClassName = "Archer";
            EquipItem(new Weapon("bow", "a basic bow", 1));
        }
    }
    public class God : Player
    {
        public God(string name) : base(name)
        {
            strength = 5;
            mana = 5;
            dexterity = 5;
            ClassName = "God";
            EquipItem(new Weapon("op", "litteral op weapon", 1));
        }
    }
}
