using System;

namespace Targetting;

public class Sniper : RangedOperator
{
    private bool airTargetting;

    public Sniper(int _atk, int _minRange, int _maxRange, bool _airTargetting) : base(_atk, _minRange, _maxRange)
    {
        airTargetting = _airTargetting;
    }
    public bool GetAirTargetting()
    {
        return airTargetting;
    }
}
