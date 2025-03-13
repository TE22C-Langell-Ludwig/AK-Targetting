using System;

namespace Targetting;

public class Sniper : RangedOperator
{
    private bool airTargetting;

    public Sniper(int Atk, int MinRange, int MaxRange, bool AirTargetting) : base(Atk, MinRange, MaxRange)
    {
        airTargetting = AirTargetting;
    }
    public bool GetAirTargetting()
    {
        return airTargetting;
    }
}
