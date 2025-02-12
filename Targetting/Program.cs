
using Targetting;

Enemy Soldier = new Enemy(1650, 100, 0, 16);
Sniper Adnachiel = new Sniper(true,365, 5, 9);
Console.WriteLine(Soldier.GetHp() + "/1650");
Console.ReadLine();
while (Soldier.GetProgress() > 0)
{
    if (Adnachiel.GetMinRange() <= Soldier.GetProgress() && Soldier.GetProgress() <= Adnachiel.GetMaxRange())
    {
      Soldier.GetHit(false,Adnachiel.GetAirTargetting(), Adnachiel.GetAtk());
    }
    if (Soldier.GetHp() >= 0)
    {
        Console.WriteLine(Soldier.GetHp() + "/1650 " + Soldier.GetProgress());
        //Console.WriteLine();
        //Console.WriteLine($"{Adnachiel.GetAtk()}" + $" {Adnachiel.GetMinRange()}" + $" {Adnachiel.GetMaxRange()}");

        Console.ReadLine();
    }
    else
    {
        Console.WriteLine(Soldier.GetHp() + "/1650" + ". Defeated");
    }
    Soldier.SetProgress(1);
}
Console.ReadLine();






