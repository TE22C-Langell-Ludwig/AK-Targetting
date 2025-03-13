using System;

namespace Targetting;

public class MeleeOperator : Operator
{
    private int blockCount;
    private int position;
    public MeleeOperator(int Atk, int BlockCount, int Position) : base(Atk)
    {
        blockCount = BlockCount;
        position = Position;
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
