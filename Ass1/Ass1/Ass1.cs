using System;
class Assign1
{
    public static void Main()
    {
        int n1;
        int n2;
        int c;
        int a = 0;
        Console.WriteLine("Enter 1st number:");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter 2nd number:");
        n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Required task number:\n1-add\n2-subtract\n3-multiplication\n4-division");
        c = int.Parse(Console.ReadLine());
        switch (c)
        {
            case 1:a = n1 + n2;
                break;
                case 2:a = n1 - n2;
                break;
            case 3:a = n1 * n2;
                break;
            case 4:a = n1 / n2;
                break;
                default :Console.WriteLine("Enter Correct Task number");
                break;
        }
        Console.WriteLine("Answer is {0}", a);
        Console.ReadLine();
    }
}

