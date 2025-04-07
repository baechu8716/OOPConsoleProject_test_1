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
        private List<Item> items;

        //가지고 있는 아이템들
        public Inventory()
        {
            items = new List<Item>();
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
