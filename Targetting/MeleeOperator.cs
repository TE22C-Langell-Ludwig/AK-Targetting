using System;

namespace Targetting;

public class MeleeOperator : Operator
{
    private int blockCount;
    private int position;
    public MeleeOperator(int _atk, int _blockCount, int _position) : base(_atk)
    {
        blockCount = _blockCount;
        position = _position;
    }
    public int GetBlockCount()
    {
        return blockCount;
    }
    public int GetPosition()
    {
        return position;
    }
}
