// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

(Plate, mainIngredient, seasoning) soup;
Console.WriteLine($"What plate are you having today,\n 1: soup,\n2: stew,\n3: gumbo?");
soup.Item1 = (Plate)int.Parse(Console.ReadLine()) - 1;
Console.WriteLine($"What main ingredient do you want it with, \n1: mushrooms,\n2: chicken,\n3: carrots, \n4: potatoes?");
soup.Item2 = (mainIngredient)int.Parse(Console.ReadLine()) - 1;
Console.WriteLine($"and which seasoning,\n 1: spicy,\n2: salty,\n3: sweet?");
soup.Item3 = (seasoning)int.Parse(Console.ReadLine()) - 1;

Console.WriteLine($"Here's your dish {soup.Item1} with {soup.Item2} seasoned with {soup.Item3}");

enum Plate {
    soup,
    stew,
    gumbo
}
enum mainIngredient
{
    mushroom,
    chicken,
    carrots,
    potatoes
}

enum seasoning
{
    spicy,
    salty,
    sweet
}