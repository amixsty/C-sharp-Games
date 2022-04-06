using System;

namespace prs

{

    class Program

    {

        static void Main(string[] args)

        {

            Random r = new Random();

            int user_score = 0, computer_score = 0, index;

            string computer_choice, user_choice;

            string[] options = new string[3];

            options[0] = "sang";

            options[1] = "kaqaz";

            options[2] = "gheychi";

            for (int i = 0; i < 5; i++)

            {

                index = r.Next(0, 3);

                computer_choice = options[index];




                user_choice = Console.ReadLine();

                Console.WriteLine(computer_choice);




                if (computer_choice == "kaqaz" && user_choice == "sang")

                {

                    computer_score++;

                }

                else if (computer_choice == "kaqaz" && user_choice == "gheychi")

                {

                    user_score++;

                }
                else if (computer_choice == "kaqaz" && user_choice == "kaqaz")

                {

                    user_score++;
                    computer_score++;


                }

                else if (computer_choice == "gheychi" && user_choice == "gheychi")

                {

                    computer_score++;

                    user_score++;

                }
                else if (computer_choice == "gheychi" && user_choice == "kaqaz")

                {

                    computer_score++;

                }
                else if (computer_choice == "gheychi" && user_choice == "sang")

                {

                    user_score++;

                }
                else if (computer_choice == "gheychi" && user_choice == "gheychi")

                {

                    computer_score++;
                    user_score++;


                }
                else if (computer_choice == "sang" && user_choice == "sang")

                {

                    user_score++;
                    computer_score++;


                }
                else if (computer_choice == "sang" && user_choice == "gheychi")

                {

                    computer_score++;

                }
                else if (computer_choice == "sang" && user_choice == "kaqaz")

                {

                    user_score++;

                }




            }

            if (user_score > computer_score)

            {

                Console.WriteLine("Shoma Bordid");

            }

            else if (computer_score > user_score)

            {

                Console.WriteLine("computer Bord");

            }

            else

            {

                Console.WriteLine("Mosavi");

            }

        }

    }

}
