using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] questions = new string[3];
            questions[0] = "Is the sky purple?";
            questions[1] = "Can pigs fly?";
            questions[2] = "Water is colourless";

            string[] answers = new string[3];
            answers[0] = "false";
            answers[1] = "false";
            answers[2] = "true";

            int score = 0;
            int i;

            Console.WriteLine("You will be asked three true or false questions, type \"True\" or \"False\"");

            for (i = 0; i <questions.Length; i ++)
            {
                Console.WriteLine(questions[i]);
                var response = Console.ReadLine().ToLower();
                
                if (response == answers[i])
                {
                    score++;
                }
                
            }
            Console.WriteLine("Your score is " + score);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
