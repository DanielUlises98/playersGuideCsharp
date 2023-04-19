

Sword basicSword = new Sword(Material.iron, Gemstone.noGemstone, 1.5f, 2.4f);
Sword variationSword = basicSword with {mats=Material.wood,lenght=3f};
Sword variationSword2 = basicSword with { mats = Material.binarium, crossWardWidth = 3f };

Console.WriteLine(basicSword);
Console.WriteLine(variationSword);
Console.WriteLine(variationSword2);

record Sword(Material mats, Gemstone gem, float lenght, float crossWardWidth);

enum Material
{
    wood,
    bronze,
    iron, 
    steel,
    binarium
}
enum Gemstone 
{
    emerald, 
    amber,
    sapphire,
    diamond,
    bitstone,
    noGemstone
}