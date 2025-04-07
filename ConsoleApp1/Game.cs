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
        public static string prevSceneName; 
        private static Player player;

        public static Player Player { get { return player; } }

        public static bool gameOver;  

        public static void Run()
        {
            Start();

            while(gameOver == false)
            {
                Console.Clear();
                curScene.Render();
                Console.WriteLine();
                curScene.Input();
                Console.WriteLine();
                curScene.Update();
                Console.WriteLine();
                curScene.Result();
                Console.WriteLine();
            }

            End();
        }
        public static void ChangeScene(string sceneName)
        {
            prevSceneName = curScene.name;

            curScene.Exit();
            curScene = sceneDic[sceneName];
            curScene.Enter();

        }

        // 게임의 초기 설정
        private static void Start() 
        {
            // 커서 비활성화
            Console.CursorVisible = false;

            // 게임 오버가 false
            gameOver = false;

            // 플레이어 설정
            player = new Player();

            // 씬 설정 
            sceneDic = new Dictionary<string, BaseScene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Town", new TownScene());
            sceneDic.Add("NormalField", new NormalFieldScene());
            sceneDic.Add("ForestField", new ForestFieldScene());

            curScene = sceneDic["Title"];
            
        }

        // 게임의 마무리 작업
        private static void End()
        {

        }

        
    }
}

