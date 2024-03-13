using Village;

Villageois a, b;
string rep;

a = new Villageois(true, "Panoramix", 16);
b = new Villageois("Abraracourcix");
Console.WriteLine(b.get_Poids());
b.setPoids(26);
Console.WriteLine(a.ToString());
Console.WriteLine(a.get_Nom());
Console.WriteLine(a.get_Poids());
Console.WriteLine(a.poidsSouleve() + "Kg");
Console.WriteLine(a.soulevememepoids(b));

if (a.poidsSouleve() > b.poidsSouleve())
    {
    Console.WriteLine(a.get_Nom() + " soulève plus lourd que " + b.get_Nom());
    }
else
{
    Console.WriteLine(b.get_Nom() + " soulève plus lourd que " + a.get_Nom());
}