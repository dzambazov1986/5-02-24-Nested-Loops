using System.ComponentModel.Design;

int floorsCount = int.Parse(Console.ReadLine());
int estatesCount = int.Parse(Console.ReadLine());   

for  (int f = floorsCount; f >= 1; f--)
{
    string type = "";
    if (f == floorsCount)
    {
        type = "L";
    }
    else if (f % 2 == 0)
    {
        type = "O";
    }
    else type = "A";

    for (int e = 0; e < estatesCount; e++)
    {
        Console.Write($"{type}{f}{e} ");
    }
    Console.WriteLine();
}