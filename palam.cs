using System;

namespace palam
{
    class Program
    {
        static void Main(string[] args)
        {
            string cp1, user, cp2;
            Random r = new Random();
            int pointuser = 0, cppoint1 = 0, cppoint2 = 0, index;

            string[] options = new string[2];
            options[0] = "roo";
            options[1] = "posht";
            for (int i = 0; i < 5; i++)
            {
                index = r.Next(0, 2);
                cp1 = options[index];
                cp2 = options[index];
                user = Console.ReadLine();
                Console.WriteLine(cp1);
                Console.WriteLine(cp2);



                if (cp1 == cp2 && user != cp1)
                {
                    pointuser++;
                }
                else if (cp1 == user && cp2 != cp1)
                {
                    cppoint1++;
                }
                else if (cp2 == user && cp1 != cp2)
                {
                    cppoint1++;
                }


            }
            Console.WriteLine(pointuser);
            Console.WriteLine(cppoint1);
            Console.WriteLine(cppoint2);




            if (cppoint1 > cppoint2 && cppoint1 > pointuser)
            {
                Console.WriteLine("cp1 win");
            }
            if (pointuser > cppoint1 && pointuser > cppoint2)
            {
                Console.WriteLine("user win");
            }
            if (cppoint2 > cppoint1 && cppoint2 > pointuser)
            {
                Console.WriteLine("cp2 win");
            }

        }
    }
}
