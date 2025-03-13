using Targetting;

public class RangedOperator : Operator
{
    private int minRange;
    private int maxRange;

    public RangedOperator(int Atk, int MinRange, int MaxRange) : base(Atk)
    {
        minRange = MinRange;
        maxRange = MaxRange;

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

