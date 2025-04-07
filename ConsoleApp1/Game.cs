using ConsoleApp1.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Game
    {
        // private Dictionary<SceneType>
        private static Dictionary<string, BaseScene> sceneDic;
        private static BaseScene curScene;

        public static bool gameOver;

        

        public static void Run()
        {
            Start();
            while(gameOver == true)
            {
                Console.Clear();
                curScene.Render();
                curScene.Input();
                curScene.Update();
                curScene.Render();
            }

            End();
        }

        // 게임의 초기 설정
        private static void Start() 
        {
            // 게임 오버가 false
            gameOver = false;

            // 씬 설정 
            sceneDic = new Dictionary<string, BaseScene>();
            sceneDic.Add("Title", new TitleScene());

            curScene = sceneDic["Title"];
        }

        // 게임의 마무리 작업
        private static void End()
        {

        }
    }
}
