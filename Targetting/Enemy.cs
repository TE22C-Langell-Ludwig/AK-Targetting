public class Enemy
{
    private int hp;
    public int def;
    public int res;
    public Enemy(int _hp, int _def, int _res)
    {
        hp = _hp;
        def = _def;
        res = _res;
    }

    public void GetHit(bool ArtsDmg, int Atk)
    {
        if (ArtsDmg)
        {
            hp -= Atk * res / 100;
        }
        else if (ArtsDmg == false)
        {
            if (def > Atk)
            {
                hp -= Atk / 100 * 5;
            }
            else
            {
                hp -= Atk - def;
            }
        }
        if (hp < 0)
        {
            hp = 0;
        }
    }
    public int GetHp()
    {
        return hp;
    }
    public int GetDef()
    {
        return def;
    }
    public int Getres()
    {
        return res;
    }
}
