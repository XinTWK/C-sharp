using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_InheritanceC
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true,"Justin Wu");
            Console.WriteLine(post1.ToString());
            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Justin Wu",
                "https://image.com/shoes",true);

            VideoPost videoPost1 = new VideoPost("FailVideo","Justin Wu","https://video.com/failvideo",true,10);

            Console.WriteLine(imagePost1.ToString());
            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();


            Console.WriteLine("Press any key to stop the video!");
            Console.ReadKey();
            videoPost1.Stop();



            Console.ReadKey();

        }

        // Chanllenge add a deriving Class "VideoPost" with a property VideoURL, Length.

        // Create the required constructors to create a VideoPost
        // adjust the ToString() method accordingly
        // create an instance of VideoPost and use the ToString method on it

        // More advanced - use Timer and a Callback method here 
        // create fields as required
        // and member methods "Play" which should write the current duration of the video
        // and "Stop" which should stop the "timer" and write "stoped at {0}s" onto the console.
        // Play the video after creating the instance and stop it, when the user presses any key

    }
}
