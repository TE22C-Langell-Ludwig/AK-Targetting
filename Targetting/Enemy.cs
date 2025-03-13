public class Enemy
{
    private int hp;
    private int def;
    private int res;
    private int progress;

    public Enemy(int Hp, int Def, int Res, int Progress)
    {
        hp = Hp;
        def = Def;
        res = Res;
        progress = Progress;
    }

    public void GetHit(bool artsDmg, bool airTargetting, int atk)
    {
        if (artsDmg)
        {
            hp -= atk * res / 100;
        }
        else if (artsDmg == false)
        {
            if (def > atk)
            {
                hp -= atk / 100 * 5;
            }
            else
            {
                hp -= atk - def;
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
    public int GetRes()
    {
        return res;
    }
    public int GetProgress()
    {
        return progress;
    }
    public int SetProgress(int Progress)
    {
        return progress -= Progress;
    }

}
