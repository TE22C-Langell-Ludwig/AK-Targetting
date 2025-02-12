using System;

namespace Targetting;

public class Caster : Character
{
    private bool artsDmg;
    public Caster(bool _artsDmg, int _atk, int _minRange, int _maxRange) : base(_atk, _minRange, _maxRange)
    {
        artsDmg = _artsDmg;
    }
    public bool GetArtsDmg()
    {
        return artsDmg;
    }
}
