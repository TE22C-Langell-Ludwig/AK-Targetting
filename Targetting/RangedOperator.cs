using Targetting;

public class RangedOperator : Operator
{
    private int minRange;
    private int maxRange;

    public RangedOperator(int _atk, int _minRange, int _maxRange) : base(_atk)
    {
        minRange = _minRange;
        maxRange = _maxRange;

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

