using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Create an application with a score, highscore and a highscorePlayer.
Create a method which has two parameters, one for the score and one for the playerName.
When ever that method is called, it should be checked if the score of the player is higher than the highscore, if so, "New highscore is + " score" and in another line "New highscore holder is " + playerName - should be written onto the console, if not "The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer.
Consider which variables are required globally and which ones locally.
 紀錄保持人與最高分數刷新
*/

namespace if語句小挑戰2
{
    class Program
    {
        static int score,highScore =50;
        static string playerName,highScorePlayer = "Mike";

        static void Main(string[] args)
        {
            Console.WriteLine("目前最高分保持人為: {0} 最高分數為: {1}" ,highScorePlayer, highScore);
            //checkHighScore(15, "Denis");
            //checkHighScore(100, "Justin");
            //checkHighScore(30, "Michael");
            Console.WriteLine("請輸入玩家名稱: ");
            playerName = Console.ReadLine();

            Console.WriteLine("請輸入分數: ");
            try
            {
                score = int.Parse(Console.ReadLine());
                checkHighScore(score, playerName);
            }
            catch (Exception)
            {
                Console.WriteLine("輸入數字錯誤");
               
            }

            Console.Read();

        }


        public static void checkHighScore(int score,string playerName)
        {
            if(score> highScore)
            {
                highScore = score;
                highScorePlayer = playerName;
                Console.WriteLine("最高分數為: {0}",highScore);
                Console.WriteLine("目前保持人為: {0}",highScorePlayer);
                Console.WriteLine("----------------------------------------");
            }
            else
            {
                Console.WriteLine("目前最高分數尚未被打破!");
                Console.WriteLine("目前最高分: {0} 目前保持人: {1} ",highScore ,highScorePlayer);
                Console.WriteLine("----------------------------------------");


            }
        }

    }
}
