using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.GameObjects
{
    class Place : GameObject
    {
        private string scene;

        public Place(string scene, ConsoleColor color, char symbol, Vector2 position) : base(color, symbol, position, false)
        {
            this.scene = scene;
        }
        public override void Interact(Player player)
        {
            Game.ChangeScene(scene);
        }
    }
}
