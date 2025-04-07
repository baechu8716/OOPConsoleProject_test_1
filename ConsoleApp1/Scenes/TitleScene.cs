using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Scenes
{
    public class TitleScene : BaseScene
    {
        public override void Render()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("*        레전드 RPG         *");
            Console.WriteLine("****************************");
            Console.WriteLine();
            Console.WriteLine("계속하려면 아무키나 누르시오...");
        }

        public override void Input()
        {
            Console.ReadKey(true);
        }     

        public override void Update()
        {

        }
        public override void Result()
        {

        }
    }
}
