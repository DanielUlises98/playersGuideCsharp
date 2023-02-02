double sisters = 4;
double sisterEggs = 0;
double duckberEggs= 0;
Console.WriteLine("Number of chocolate eggs gathered today");
double eggsChoco = Convert.ToDouble(Console.ReadLine());
duckberEggs = eggsChoco % sisters;
sisterEggs = (eggsChoco - duckberEggs)/sisters;
Console.WriteLine("Each sister should get: " + sisterEggs + " chocolate eggs");
Console.WriteLine("Duckbear should get: " + duckberEggs + " chocolate eggs");
if (duckberEggs > sisterEggs)
{
    Console.WriteLine("WOW! the duckbear got more eggs (" + duckberEggs + ") eggs than the sisters (" + sisterEggs + ")");
}
