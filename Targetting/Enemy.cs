public class Enemy
{
    public int hp;
    public int def;
    public int res;

    public void GetHit(bool ArtsDmg, int Atk)
    {
        if (ArtsDmg)
        {
            hp = -Atk * res / 100;
        }
        if (ArtsDmg == false)
        {
            if (def > Atk)
            {
                hp = -(Atk / 100) * 5;
            }
            else
            {
                hp = -Atk - def;
            }
        }
    }
}
