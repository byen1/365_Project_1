using System;

public class Mul : IInstruction
{
    public Mul(){}
    
    public uint Val{
        get{
            uint retVal = 1 << 4;
            retVal += 1;
            retVal <<= 25;
            return retVal;
        }
    }
}
