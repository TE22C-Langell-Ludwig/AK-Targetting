public class Character
{
    private int atk;
    private int minRange;
    private int maxRange;

    public Character(int _atk, int _minRange, int _maxRange)
    {
        atk = _atk;
        minRange=_minRange;
        maxRange=_maxRange;

    }
    public int GetAtk()
    {
        return atk;
    }
    public int GetMinRange()
    {
        return minRange;
    }
    public int GetMaxRange()
    {
        return maxRange;
    }
}

