using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.GameObjects
{
    public abstract class Item : GameObject
    {
        public string name;
        public string description;
        public Item(ConsoleColor color, char symbol, Vector2 position) : base(color, symbol, position, true)
        {

        }

        public override void Interact(Player player)
        {
            // 플레이어가 습득한다.
            player.inventory.Add(this);
        }

        public abstract void Use();
    }
}
