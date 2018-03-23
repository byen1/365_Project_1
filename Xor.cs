using System;

public class Xor : IInstruction
{
    public Xor(){}
    
    public uint Val{
        get{
            uint retVal = 1 << 3;
            ++retVal;
            retVal <<= 1;
	    ++retVal;
	    retVal <<= 1;
	    ++retVal;
	    retVal <<= 24;
            return retVal;
        }
    }
}
