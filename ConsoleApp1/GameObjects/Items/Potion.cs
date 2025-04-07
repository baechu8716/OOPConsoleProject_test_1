using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.GameObjects.Items
{
    public class Potion : Item
    {
        public Potion(Vector2 position) : base(ConsoleColor.DarkRed, 'I', position)
        {
            name = "포션";
            description = "사용시 플레이어의 체력 30을 회복한다.";
        }

        public override void Use()
        {
            Game.Player.Heal(30);
        }
    }
}
