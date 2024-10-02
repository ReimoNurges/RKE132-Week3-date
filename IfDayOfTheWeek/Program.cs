

int weekday = Convert.ToInt32(DateTime.Now.DayOfWeek);

Console.WriteLine(weekday);

if (weekday == 0)
{
    Console.WriteLine("Its sunday");
}
else if (weekday == 1)
{
    Console.WriteLine("Its monday");
}
else if (weekday == 2)
{
    Console.WriteLine("Its tuesday");
}
else if (weekday == 3)
{
    Console.WriteLine("Its wedensday");
}
else if (weekday == 4)
{
    Console.WriteLine("Its thirsday");
}
else if (weekday == 5)
{
    Console.WriteLine("Its friday");
}
else if (weekday == 6)
{
    Console.WriteLine("Its saturday");
}
