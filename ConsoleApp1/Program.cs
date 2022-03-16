using System;
using System.Windows.Input;
public class PName
{
    string name; int cnt = 0;
    string[] bots = {"Jack", "Asshley", "John", "Aaron", "Joshua", "Laura" };
    public void PlayerName()
    {
        Console.WriteLine("Enter your name: \n");
        name = Console.ReadLine();
        Console.WriteLine("You will be remembered as: " + name);
        Console.WriteLine("Let's choose your school (1-6): \n");
        for (int i = 0; i < bots.Length; ++i)
        {
            Console.Write(bots[i] + " ");
        }
        Console.WriteLine();
        cnt = Int32.Parse(Console.ReadLine());
        --cnt;
        Console.WriteLine("You chose " + bots[cnt] + " school. Let's start the game!");
    }
}
public class ABC
{
    int ID(int i)
    {
        return Math.Abs(i) * -1;
    }
    public void Intro()
    {
        int space1 = 0, space2 = 40, laser1 = -1;
        string str = " Choosing ", str2 = " Game !!!";
        while (laser1 < 42)
        {
            Console.Clear();
            for (int i = -3; i <= 3; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j <= 39; j++)
                    {
                        if ((space1 >= 30) && (laser1 >= j) && (j >= 0) && (j < 10)) Console.Write(str[j]);
                        else if ((j == space1 + ID(i)) || (j == space1 + ID(i) - 1) || (j == space1 + ID(i) - 5) || (j == space1 + ID(i) - 6) || (j == space1 + ID(i) - 11) || (j == space1 + ID(i) - 12))
                        {
                            Console.Write("\\");
                        }
                        else
                        if ((j == space2 - ID(i)) || (j == space2 - ID(i) + 1) || (j == space2 - ID(i) + 5) || (j == space2 - ID(i) + 6) || (j == space2 - ID(i) + 11) || (j == space2 - ID(i) + 12))
                        {
                            Console.Write("/");
                        }
                        else Console.Write(" ");
                    }
                    Console.Write("\n");
                    for (int j = 0; j <= 39; j++)
                    {
                        if ((space1 >= 30) && (laser1 >= j) && (j >= 0) && (j < 9)) Console.Write(str2[j]);
                        else if ((j == space1 + ID(i)) || (j == space1 + ID(i) - 1) || (j == space1 + ID(i) - 5) || (j == space1 + ID(i) - 6) || (j == space1 + ID(i) - 11) || (j == space1 + ID(i) - 12))
                        {
                            Console.Write("/");
                        }
                        else
                        if ((j == space2 - ID(i)) || (j == space2 - ID(i) + 1) || (j == space2 - ID(i) + 5) || (j == space2 - ID(i) + 6) || (j == space2 - ID(i) + 11) || (j == space2 - ID(i) + 12))
                        {
                            Console.Write("\\");
                        }
                        else Console.Write(" ");
                    }
                    Console.Write("\n");
                    continue;
                }
                for (int j = 0; j <= 39; j++)
                {
                    if ((ID(i) == -1) && (space1 >= 30))
                    {
                        if (((j == 18) || (j == 17)) && (i == 1)) Console.Write("/");
                        else if ((((j == 18) || (j == 17)) && (i == -1))) Console.Write(("\\"));
                        else if (((j == 23) || (j == 24)) && (i == 1)) Console.Write("/");
                        else if ((((j == 23) || (j == 24)) && (i == -1))) Console.Write("\\");
                        else if (((j == 28) || (j == 29)) && (i == 1)) Console.Write("/");
                        else if ((((j == 28) || (j == 29)) && (i == -1))) Console.Write("\\");
                        else if (j <= laser1) Console.Write("=");
                        else if ((j == 16) && (i == 1)) Console.Write("\\");
                        else if ((j == 16) && (i == -1)) Console.Write("/");
                        else if ((j == 22) && (i == 1)) Console.Write("\\");
                        else if ((j == 22) && (i == -1)) Console.Write("/");
                        else if ((((j == 11) || (j == 12)) && (i == -1))) Console.Write("/");
                        else if (((j == 11) || (j == 12)) && (i == 1)) Console.Write("\\");
                        else Console.Write(" ");
                    }
                    else
                    if ((j == space1 + ID(i)) || (j == space1 + ID(i) - 1) || (j == space1 + ID(i) - 5) || (j == space1 + ID(i) - 6) || (j == space1 + ID(i) - 11) || (j == space1 + ID(i) - 12))
                    {
                        if (i < 0) Console.Write("\\");
                        else Console.Write("/");
                    }
                    else
                    if ((j == space2 - ID(i)) || (j == space2 - ID(i) + 1) || (j == space2 - ID(i) + 5) || (j == space2 - ID(i) + 6) || (j == space2 - ID(i) + 11) || (j == space2 - ID(i) + 12))
                    {
                        if (i < 0) Console.Write("/");
                        else Console.Write("\\");
                    }
                    else Console.Write(" ");
                }
                Console.Write("\n");
            }
            if (space1 < 30)
            {
                space1++; space2--;
            }
            else if (space1 == 30)
            {
                if (laser1 < 41) laser1 += 2;
                else
                {
                    laser1++;
                }
            }
        }
    }
}
class GFG
{
    public static void Main(string[] args)
    {
        var intro = new ABC();
        var player = new PName();

        intro.Intro();
        player.PlayerName();
        Console.Write("..." +
            "\n (option A)" +
            "\n (option B)");
        if (Console.ReadKey().Key == ConsoleKey.A)
        {
            Console.Write("\nYou Press 'A'" +
                "\n ..." +
                "\n (option A)" +
                "\n (option B)");
            if (Console.ReadKey().Key == ConsoleKey.A)
            {
                Console.Write("\nYou Press 'A'" +
                    "\n ..." +
                    "\n (option A)" +
                    "\n (option B)");
                if (Console.ReadKey().Key == ConsoleKey.A)
                {
                    Console.Write("\nYou Press 'A'" +
                        "\n ..." +
                        "\n (option A)" +
                        "\n (option B)");
                    if (Console.ReadKey().Key == ConsoleKey.A)
                    {
                        Console.Write("\nYou Press 'A'" +
                            "\n..." +
                            "\n (option A)" +
                            "\n (option B)");
                        if (Console.ReadKey().Key == ConsoleKey.A)
                        {
                            Console.Write("\nYou Press 'A'" +
                                "\n ...");
                        }
                        else
                        {
                            Console.Write("\nYou Press 'B'" +
                                "\n ...");
                        }
                    }
                    else
                    {
                        Console.Write("\nYou Press 'B'" +
                            "\n..." +
                            "\n (option A)" +
                            "\n (option B)");
                        if (Console.ReadKey().Key == ConsoleKey.A)
                        {
                            Console.Write("\nYou Press 'A'" +
                                "\n ...");
                        }
                        else
                        {
                            Console.Write("\nYou Press 'B'" +
                                "\n ...");
                        }
                    }
                }
                else
                {
                    Console.Write("\nYou Press 'B'" +
                        "\n ..." +
                        "\n (option A)" +
                        "\n (option B)");
                    if (Console.ReadKey().Key == ConsoleKey.A)
                    {
                        Console.Write("\nYou Press 'A'" +
                            "\n..." +
                            "\n (option A)" +
                            "\n (option B)");
                        if (Console.ReadKey().Key == ConsoleKey.A)
                        {
                            Console.Write("\nYou Press 'A'" +
                                "\n ...");
                        }
                        else
                        {
                            Console.Write("\nYou Press 'B'" +
                                "\n ...");
                        }
                    }
                    else
                    {
                        Console.Write("\nYou Press 'B'" +
                            "\n..." +
                            "\n (option A)" +
                            "\n (option B)");
                        if (Console.ReadKey().Key == ConsoleKey.A)
                        {
                            Console.Write("\nYou Press 'A'" +
                                "\n ...");
                        }
                        else
                        {
                            Console.Write("\nYou Press 'B'" +
                                "\n ...");
                        }
                    }
                }
            }
            else
            {
                Console.Write("\nYou Press 'B'" +
                    "\n ..." +
                    "\n (option A)" +
                    "\n (option B)");
                if (Console.ReadKey().Key == ConsoleKey.A)
                {
                    Console.Write("\nYou Press 'A'" +
                        "\n ..." +
                        "\n (option A)" +
                        "\n (option B)");
                    if (Console.ReadKey().Key == ConsoleKey.A)
                    {
                        Console.Write("\nYou Press 'A'" +
                            "\n..." +
                            "\n (option A)" +
                            "\n (option B)");
                        if (Console.ReadKey().Key == ConsoleKey.A)
                        {
                            Console.Write("\nYou Press 'A'" +
                                "\n ...");
                        }
                        else
                        {
                            Console.Write("\nYou Press 'B'" +
                                "\n ...");
                        }
                    }
                    else
                    {
                        Console.Write("\nYou Press 'B'" +
                            "\n..." +
                            "\n (option A)" +
                            "\n (option B)");
                        if (Console.ReadKey().Key == ConsoleKey.A)
                        {
                            Console.Write("\nYou Press 'A'" +
                                "\n ...");
                        }
                        else
                        {
                            Console.Write("\nYou Press 'B'" +
                                "\n ...");
                        }
                    }
                }
                else
                {
                    Console.Write("\nYou Press 'B'" +
                        "\n ..." +
                        "\n (option A)" +
                        "\n (option B)");
                    if (Console.ReadKey().Key == ConsoleKey.A)
                    {
                        Console.Write("\nYou Press 'A'" +
                            "\n..." +
                            "\n (option A)" +
                            "\n (option B)");
                        if (Console.ReadKey().Key == ConsoleKey.A)
                        {
                            Console.Write("\nYou Press 'A'" +
                                "\n ...");
                        }
                        else
                        {
                            Console.Write("\nYou Press 'B'" +
                                "\n ...");
                        }
                    }
                    else
                    {
                        Console.Write("\nYou Press 'B'" +
                            "\n..." +
                            "\n (option A)" +
                            "\n (option B)");
                        if (Console.ReadKey().Key == ConsoleKey.A)
                        {
                            Console.Write("\nYou Press 'A'" +
                                "\n ...");
                        }
                        else
                        {
                            Console.Write("\nYou Press 'B'" +
                                "\n ...");
                        }
                    }
                }
            }
        }
        else
        {
            Console.Write("\nYou Press 'A'" +
                "\n ..." +
                "\n (option A)" +
                "\n (option B)");
            if (Console.ReadKey().Key == ConsoleKey.A)
            {
                Console.Write("\nYou Press 'A'" +
                    "\n ..." +
                    "\n (option A)" +
                    "\n (option B)");
                if (Console.ReadKey().Key == ConsoleKey.A)
                {
                    Console.Write("\nYou Press 'A'" +
                        "\n ..." +
                        "\n (option A)" +
                        "\n (option B)");
                    if (Console.ReadKey().Key == ConsoleKey.A)
                    {
                        Console.Write("\nYou Press 'A'" +
                            "\n..." +
                            "\n (option A)" +
                            "\n (option B)");
                        if (Console.ReadKey().Key == ConsoleKey.A)
                        {
                            Console.Write("\nYou Press 'A'" +
                                "\n ...");
                        }
                        else
                        {
                            Console.Write("\nYou Press 'B'" +
                                "\n ...");
                        }
                    }
                    else
                    {
                        Console.Write("\nYou Press 'B'" +
                            "\n..." +
                            "\n (option A)" +
                            "\n (option B)");
                        if (Console.ReadKey().Key == ConsoleKey.A)
                        {
                            Console.Write("\nYou Press 'A'" +
                                "\n ...");
                        }
                        else
                        {
                            Console.Write("\nYou Press 'B'" +
                                "\n ...");
                        }
                    }
                }
                else
                {
                    Console.Write("\nYou Press 'B'" +
                        "\n ..." +
                        "\n (option A)" +
                        "\n (option B)");
                    if (Console.ReadKey().Key == ConsoleKey.A)
                    {
                        Console.Write("\nYou Press 'A'" +
                            "\n..." +
                            "\n (option A)" +
                            "\n (option B)");
                        if (Console.ReadKey().Key == ConsoleKey.A)
                        {
                            Console.Write("\nYou Press 'A'" +
                                "\n ...");
                        }
                        else
                        {
                            Console.Write("\nYou Press 'B'" +
                                "\n ...");
                        }
                    }
                    else
                    {
                        Console.Write("\nYou Press 'B'" +
                            "\n..." +
                            "\n (option A)" +
                            "\n (option B)");
                        if (Console.ReadKey().Key == ConsoleKey.A)
                        {
                            Console.Write("\nYou Press 'A'" +
                                "\n ...");
                        }
                        else
                        {
                            Console.Write("\nYou Press 'B'" +
                                "\n ...");
                        }
                    }
                }
            }
            else
            {
                Console.Write("\nYou Press 'A'" +
                    "\n ..." +
                    "\n (option A)" +
                    "\n (option B)");
                if (Console.ReadKey().Key == ConsoleKey.A)
                {
                    Console.Write("\nYou Press 'A'" +
                        "\n ..." +
                        "\n (option A)" +
                        "\n (option B)");
                    if (Console.ReadKey().Key == ConsoleKey.A)
                    {
                        Console.Write("\nYou Press 'A'" +
                            "\n..." +
                            "\n (option A)" +
                            "\n (option B)");
                        if (Console.ReadKey().Key == ConsoleKey.A)
                        {
                            Console.Write("\nYou Press 'A'" +
                                "\n ...");
                        }
                        else
                        {
                            Console.Write("\nYou Press 'B'" +
                                "\n ...");
                        }
                    }
                    else
                    {
                        Console.Write("\nYou Press 'B'" +
                            "\n..." +
                            "\n (option A)" +
                            "\n (option B)");
                        if (Console.ReadKey().Key == ConsoleKey.A)
                        {
                            Console.Write("\nYou Press 'A'" +
                                "\n ...");
                        }
                        else
                        {
                            Console.Write("\nYou Press 'B'" +
                                "\n ...");
                        }
                    }
                }
                else
                {
                    Console.Write("\nYou Press 'B'" +
                        "\n ..." +
                        "\n (option A)" +
                        "\n (option B)");
                    if (Console.ReadKey().Key == ConsoleKey.A)
                    {
                        Console.Write("\nYou Press 'A'" +
                            "\n..." +
                            "\n (option A)" +
                            "\n (option B)");
                        if (Console.ReadKey().Key == ConsoleKey.A)
                        {
                            Console.Write("\nYou Press 'A'" +
                                "\n ...");
                        }
                        else
                        {
                            Console.Write("\nYou Press 'B'" +
                                "\n ...");
                        }
                    }
                    else
                    {
                        Console.Write("\nYou Press 'B'" +
                            "\n..." +
                            "\n (option A)" +
                            "\n (option B)");
                        if (Console.ReadKey().Key == ConsoleKey.A)
                        {
                            Console.Write("\nYou Press 'A'" +
                                "\n ...");
                        }
                        else
                        {
                            Console.Write("\nYou Press 'B'" +
                                "\n ...");
                        }
                    }
                }
            }
        }
    }
}