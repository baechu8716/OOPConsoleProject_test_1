using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Player
    {  
        public Vector2 position;
        public bool[,] map;
        public Inventory inventory;

        private int curHP;
        public int CurHp { get { return curHP; } }
        private int maxHP;
        public int MaxHp { get { return maxHP; } }

        public Player()
        {
            inventory = new Inventory();
            maxHP = 100;
            curHP = maxHP;
        }
        
        public void Heal(int amoumt)
        {
            curHP += amoumt;
            if (curHP > maxHP)
            {
                curHP = maxHP;
            }
        }
        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("P");
            Console.ResetColor();
        }
        public void Action(ConsoleKey input)
        {
            switch (input)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.DownArrow:
                case ConsoleKey.LeftArrow:
                case ConsoleKey.RightArrow:
                    Move(input);
                    break;
                case ConsoleKey.E:
                    inventory.Open();
                    break;
                default:
                    break;
            }
        }
        public void Move(ConsoleKey input)
        {
            Vector2 targetPos = position;


            switch(input)
            {
                case ConsoleKey.UpArrow:
                    targetPos.y--;
                    break;
                case ConsoleKey.DownArrow:
                    targetPos.y++;
                    break;
                case ConsoleKey.LeftArrow:
                    targetPos.x--;
                    break;
                case ConsoleKey.RightArrow:
                    targetPos.x++;
                    break;
                default:
                    break;
            }

            if (map[targetPos.y, targetPos.x] == true)
            {
                position = targetPos;
            }
        }
    }
}
