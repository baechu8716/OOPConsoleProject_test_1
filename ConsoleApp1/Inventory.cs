using ConsoleApp1.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class Inventory // : List<Item>
    {
        // public enum State {  Menu, UseMunu, DropMunu, UseCofirm, DropConfirm }

        private List<Item> items;
        private Stack<string> stack;
        private int selectIndex;

        //가지고 있는 아이템들
        public Inventory()
        {
            items = new List<Item>();
            stack = new Stack<string>();
        }
        // 아이템 사용
        public void UseItem(int index)
        {
            items[index].Use();
        }
        // 아이템 추가
        public void Add(Item item)
        {
            items.Add(item);
        }
        // 아이템 제거
        public void Remove(Item item)
        {
            items.Remove(item);
        }

        public void RemoveAt(int index)
        {
            items.RemoveAt(index);
        }
        
        public void Open()
        {
            stack.Push("Menu");

            while (stack.Count>0)
            {
                Console.Clear();
                switch(stack.Peek())
                {
                    case "Menu":
                        Menu();
                        break;
                    case "UseMenu":
                        UseMenu();
                        break;
                    case "DropMenu":
                        DropMenu();
                        break;
                    case "UseConfirm":
                        UseConfirm();
                        break;
                    case "DropConfirm":
                        DropConfirm();
                        break;
                    default:
                        break;
                }
            }
        }

        public void Menu()
        {
            PrintAll();

            Console.WriteLine("1. 사용하기");
            Console.WriteLine("2. 버리기");
            Console.WriteLine("0 뒤로가기");

            ConsoleKey input = Console.ReadKey(true).Key;
            switch(input)
            {
                case ConsoleKey.D1:
                    stack.Push("UseMenu");
                    break;
                case ConsoleKey.D2:
                    stack.Push("DropMenu");
                    break;
                case ConsoleKey.D0:
                    stack.Pop();
                    break;
                default:
                    break;
            }
        }

        public void UseMenu()
        {
            PrintAll();

            Console.WriteLine("사용할 아이템을 선택해주세요.");
            Console.WriteLine("0. 뒤로가기");

            ConsoleKey input = Console.ReadKey(true).Key;
            if (input ==  ConsoleKey.D0)
            {
                stack.Pop();
            }
            else
            {
                int select = (int)input - (int)ConsoleKey.D1;
                if (select < 0 || items.Count <= select)
                {
                    Util.PressAnyKey("범위 내의 아이템을 선택하세요");
                }
                else
                {
                    selectIndex = select;
                    stack.Push("UseConfirm"); 
                }
            }
        }

        public void DropMenu()
        {
            PrintAll();

            Console.WriteLine("버릴 아이템을 선택해주세요.");
            Console.WriteLine("0. 뒤로가기");

            ConsoleKey input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.D0)
            {
                stack.Pop();
            }
            else
            {
                int select = (int)input - (int)ConsoleKey.D1;
                if (select < 0 || items.Count <= select)
                {
                    Util.PressAnyKey("범위 내의 아이템을 선택하세요");
                }
                else
                {
                    selectIndex = select;
                    stack.Push("DropConfirm");
                }
            }
        }

        public void UseConfirm()
        {
            Item selectItem = items[selectIndex];
            
            Console.WriteLine($"{selectItem.name} 을/를 사용하시겠습니까? (y/n)");

            ConsoleKey input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.Y:
                    selectItem.Use();
                    Util.PressAnyKey($"{selectItem.name}을/를 사용했습니다.");
                    Remove(selectItem);
                    stack.Pop();
                    break;
                case ConsoleKey.N:
                    stack.Pop();
                    break;
                default:
                    break;
            }
        }

        public void DropConfirm()
        {
            Item selectItem = items[selectIndex];
            Console.WriteLine($"{selectItem.name} 을/를 버리시겠습니까? (y/n)");

            ConsoleKey input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.Y:
                    Util.PressAnyKey($"{selectItem.name}을/를 버렸습니다.");
                    Remove(selectItem);
                    stack.Pop();
                    break;
                case ConsoleKey.N:
                    stack.Pop();
                    break;
                default:
                    break;
            }
        }

        public void PrintAll()
        {
            Console.WriteLine("====인벤토리 목록====");
            if(items.Count == 0)
            {
                Console.WriteLine("없음");
            }
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i].name}");
            }
            Console.WriteLine("===================");
        }
    }
}
