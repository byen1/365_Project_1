using System;

public class And : IInstruction
{
    public And(){}
    
    public uint Val{
        get{
            uint retVal = 1 << 3;
            ++retVal;
            retVal <<= 2;
            ++retVal;
            retVal <<= 24;
            return retVal;
        }
    }
}
