using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Create a user Login System, where the user can first register and the/*n Login in. The Program should check if the user has entered the correct username and password, wenn login in (so the same ones that he used when registering).
As we haven't covered storing data yet, just create the program in a way, that registering and logging in, happen in the same execution of it.
User If statements and User Input and Methods to solve the challenge.
創建一個假的註冊登入系統
*/
namespace if語句小挑戰
{
    class Program
    {
        static string username;
        static string password;
        


        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }

        public static void Register()
        {
            Console.WriteLine("請輸入您要註冊的 username");
            username = Console.ReadLine();
            Console.WriteLine("請輸入您要註冊的 password");
            password = Console.ReadLine();
            Console.WriteLine("註冊完成");
            Console.WriteLine("-------------------------------");
        }

        public static void Login()
        {
            Console.WriteLine("請輸入您的 username");
            if(username == Console.ReadLine())
            {
                Console.WriteLine("請輸入您的 password");
                if(password == Console.ReadLine())
                {
                    Console.WriteLine("登入成功");
                }
                else
                {
                    Console.WriteLine("登入失敗, 密碼錯誤, 請重啟程式");
                }
            }
            else
            {
                Console.WriteLine("登入失敗, 錯誤的 username , 請重啟程式");
            }

        }

    }
}
