using System;

public class Or : IInstruction
{
    public Or(){}
    
    public uint Val{
        get{
            uint retVal = 1 << 3;
            ++retVal;
            retVal <<= 1;
            ++retVal;
            retVal <<= 25;
            return retVal;
        }
    }
}
