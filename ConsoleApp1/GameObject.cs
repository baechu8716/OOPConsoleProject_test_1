using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class GameObject : Iinteractable
    {
        public ConsoleColor color;
        public Vector2 position;
        public char symbol;
        public bool isOnce;

        public GameObject(ConsoleColor color, char symbol, Vector2 position, bool isOnce)
        {
            this.color = color;
            this.symbol = symbol;
            this.position = position;
            this.isOnce = isOnce;
        }

        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = color;
            Console.Write(symbol);
            Console.ResetColor();
        }

        public abstract void Interact(Player player);

    }
}
