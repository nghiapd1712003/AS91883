using System;
using System.Collections.Generic;
namespace AS91883
{
    class Program
    {
        static void Main(string[] args)
        {
            // say hi to the player
            Console.WriteLine("hi let play some Te Reo Maori quiz !");
            // ask the player which kind of question do they wanna play and guild them how to choose
            Console.WriteLine("what type of question do you wanna play ( type 0 for multiple choice question ; type 1 for word answer question)?");
            // store 2 kind of question
            List<string> TypeOfQuestion = new List<string>() { "multiple choice", "word answer" };
            // store player's kind of qustion choice
            int NoTypeOfQuestion = int.Parse(Console.ReadLine());
            // vaild the player's choice , request player choose agian if their choice is not correct
            while (NoTypeOfQuestion < 0 || NoTypeOfQuestion > 1)
            {
                Console.WriteLine("your choose is not vaild , please choose again (you must choose 0 of 1)");
                NoTypeOfQuestion = int.Parse(Console.ReadLine());
            }
            // ask the player to choose the level 
            Console.WriteLine("we have 2 levels : easy, hard; type 0 for easy ,1 for hard");
            // store levels
            List<string> Level = new List<string>() {"easy", "hard" };
            // store player's level choice
            int NoOfLevel = int.Parse(Console.ReadLine());
            // vaild the choice of level , if is not vaild ,ask them to choose agian
            while (NoOfLevel < 0 || NoOfLevel > 1)
            {
                Console.WriteLine("your choose is not vaild , please choose again (you must choose 0 of 1)");
                NoOfLevel = int.Parse(Console.ReadLine());
            }
            // show the player their selection.
            Console.WriteLine("you choose to play {0} {1} question", TypeOfQuestion[NoTypeOfQuestion], Level[NoOfLevel]);
            
            // for the multiple choice easy question
            if (NoTypeOfQuestion == 0 && NoOfLevel == 0)
            {
                // show the player the quetion , the answers and guild them how to answer
                Console.WriteLine("what is the word sutible in the blank ");
                Console.WriteLine("kia ora, me pēhea ...? ");
                Console.WriteLine("1. koe");
                Console.WriteLine("2. ou");
                Console.WriteLine("3. hoa");
                Console.WriteLine("anwser by type the number before the option you think is correct.");
                // store their answer
                int NoAnswer = int.Parse(Console.ReadLine());
                // vaild player's answer , ask them to choose again if the answer is not vaild
                while (NoAnswer < 1 || NoAnswer > 3)
                {
                    Console.WriteLine("your choose is not vaild , please choose again (you must choose 1, 2 or 3)");
                    // restore player's choice
                    NoAnswer = int.Parse(Console.ReadLine());
                }
                // if the answer is correct
                if (NoAnswer == 1)
                {
                    // show player that their answer is correct
                    Console.WriteLine("Your answer is correct");
                }
                // if the answer is not correct
                else
                {
                    // show player that their answer is not correct and the correct answer
                    Console.WriteLine("Your answer is incorrect ,the correct answer is 1. koe");
                }
            }
            // for the multiple choice  hard question
            if(NoTypeOfQuestion == 0 && NoOfLevel == 1)
            {
                // show player the question , answers and guild them how to make there choice
                Console.WriteLine("what is the word sutible in the blank ");
                Console.WriteLine("Ko ... o Niu Tireni he Jacinda Ardern ");
                Console.WriteLine("1. te Pirimia");
                Console.WriteLine("2. te tākuta");
                Console.WriteLine("3. te kāwana");
                Console.WriteLine("anwser by type the number before the option you think is correct.");
                // store player's choice
                int NoAnswer = int.Parse(Console.ReadLine());
                // vaild player answer , if it is not vaid ask them to choose agian 
                while (NoAnswer < 1 || NoAnswer > 3)
                {
                    Console.WriteLine("your choose is not vaild , please choose again (you must choose 1,2 or 3)");
                    //restore player's chooice
                    NoAnswer = int.Parse(Console.ReadLine());
                }
                // if player's answer is correct
                if (NoAnswer == 1)
                {
                    //show them their answer is correct
                    Console.WriteLine("Your answer is correct");
                }
                // if player's answer is incorrect
                else
                {
                    //show them thier answer is not correct and the correct answer
                    Console.WriteLine("Your answer is incorrect ,the correct answer is 1. te Pirimia");
                }
            }
            // for the mutilple choice easy question
            if (NoTypeOfQuestion == 1 && NoOfLevel == 0)
            {
                //show them thier answer is not correct and the correct answer
                Console.WriteLine("what is the word sutible in the blank ");
                Console.WriteLine("kia ora, me pēhea ...? ");
                Console.WriteLine("your answer must NOT be in Caps Lock ");            
                //store player'answer
                string answer = Console.ReadLine();
                // if there answer is correct
                if (answer == "koe")
                {
                    //show player their answer is correct
                    Console.WriteLine("your answer is correct");
                }
                // if there answer is not correct
                else
                {
                    //show their answer is incorrect and the correct one 
                    Console.WriteLine("your ansewr is incorrect , the correct anwser is koe");
                }             
            }
            // for the multiple choice hard question
            if (NoTypeOfQuestion == 1 && NoOfLevel == 1)
            {
                //show them thier answer is not correct and the correct answer
                Console.WriteLine("what is the word sutible in the blank ");
                Console.WriteLine("Ko te ... o Niu Tireni he Jacinda Ardern ");
                Console.WriteLine("your answer must NOT be in Caps Lock ");
                //store player's answer
                string answer = Console.ReadLine();
                // if player answer is correct
                if (answer == "pirimia")
                {
                    //show player that their answer is correct
                    Console.WriteLine("your answer is correct");
                }
                else
                {
                    //show player that their answer is incorrect and show the correct one
                    Console.WriteLine("your ansewr is incorrect , the correct anwser is pirimia");
                }
            }
        }
    }
}
                                                                                    
