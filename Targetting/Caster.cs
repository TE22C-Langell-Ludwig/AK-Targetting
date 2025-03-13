using System;

namespace Targetting;

public class Caster : RangedOperator
{
    private bool artsDmg;
    public Caster(bool ArtsDmg, int Atk, int MinRange, int MaxRange) : base(Atk, MinRange, MaxRange)
    {
        artsDmg = ArtsDmg;
    }
    public bool GetArtsDmg()
    {
        return artsDmg;
    }
}
