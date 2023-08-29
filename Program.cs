Console.WriteLine("Please enter a number of the month");
int month = Convert.ToInt32(Console.ReadLine());

switch (month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Ziema");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Pavsaris");
        break;
    case 6: 
    case 7:
    case 8:
        Console.WriteLine("Vasara");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Ruduo");
        break;

    default: Console.WriteLine("Something wrong");
        break;
}

