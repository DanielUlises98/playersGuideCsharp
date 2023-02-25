using PackingInventory;
using System;

int maxItems = 10;
int maxVolume = 20;
int maxWeight = 25;

Pack pack = new Pack(maxItems,maxVolume,maxWeight);


do
{
    Console.WriteLine("You can insert the following items, by choosing the number of said item");
    Console.WriteLine($"Your Max limit of items is {maxItems}, max Volume:{maxVolume}, max Weight:{25}");
    Console.WriteLine("[1] Arrow, Weight: 0.1 volume of 0.05");
    Console.WriteLine("[2] Bow, Weight: 1 volume of 4");
    Console.WriteLine("[3] Rope, Weight: 1 volume of 1.5");
    Console.WriteLine("[4] Water, Weight: 2 volume of 3");
    Console.WriteLine("[5] Food Rations, Weight: 1 volume of 0.5");
    Console.WriteLine("[6] Sword, Weight: 5 volume of 3");
    int selection = int.Parse(Console.ReadLine());
    Console.Clear();
    switch (selection)
    {
        case 1:
            {
                Arrow arrow= new Arrow();
                IsFull(pack.Add(arrow));
                break;
            }
        case 2:
            {
                Bow bow = new Bow();
                IsFull(pack.Add(bow));
                break;
            }
        case 3:
            {
                Rope rope = new Rope();
                IsFull(pack.Add(rope));
                break;
            }
        case 4:
            {
                Water water = new Water();
                IsFull(pack.Add(water));
                break;
            }
        case 5:
            {
                FoodRation foodRation= new FoodRation();
                IsFull(pack.Add(foodRation));
                break;
            }
        case 6:
            {
                Sword sword= new Sword();
                IsFull(pack.Add(sword));
                break;
            }
        
    }
    Console.WriteLine($"The pack is at {maxItems}/{pack.ItemCount}, volume {maxVolume}/{pack.VolumeCount}, weight {maxWeight}/{pack.WeightCount}");
}while(pack.ItemCount<maxItems);

void IsFull(bool full)
{
    if (!full)
        Console.WriteLine($"The Pack is full, you can't add more items");
}