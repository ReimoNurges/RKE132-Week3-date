

int weekday = Convert.ToInt32(DateTime.Now.DayOfWeek);

switch(weekday)
{
    case 0:
        Console.WriteLine("püh");
        break;
    case 1:
        Console.WriteLine("es");
        break;
    case 2:
        Console.WriteLine("teis");
        break;
    case 3:
        Console.WriteLine("kolm");
        break;
    case 4:
        Console.WriteLine("nel");
        break;
    case 5:
        Console.WriteLine("ree");
        break;
    case 6:
        Console.WriteLine("laup");
        break;
        default:
        Console.WriteLine("oops ur callendar is broken");
        break;
}