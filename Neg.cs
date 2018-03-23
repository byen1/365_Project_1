using System;

public class Neg : IInstruction
{
    public Neg(){}
    
    public uint Val{
        get{
            uint retVal = 1 << 1;
            ++retVal;
            retVal <<= 28;
            return retVal;
        }
    }
}
