Enemy Soldier = new Enemy(1650,100,0);
Character Adnachiel = new Character(false,365);
while (true)
{
    Soldier.GetHit(Adnachiel.GetArtsDmg(), Adnachiel.GetAtk());
    if (Soldier.GetHp() <= 0)
    {
        break;
    }
    else{
    Console.WriteLine(Soldier.GetHp());
    Console.ReadLine();
    }
}
Console.WriteLine(Soldier.GetHp() + ". Defeated");
Console.ReadLine();






