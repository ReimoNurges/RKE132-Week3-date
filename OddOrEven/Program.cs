Console.WriteLine("sisestage number");
int usernumber = Convert.ToInt32(Console.ReadLine());

int result = usernumber % 2;
Console.WriteLine(result);

if (result != 0)
{ Console.WriteLine("arv on paaritu");
}
else
{
    Console.WriteLine("arv on paaris");
}