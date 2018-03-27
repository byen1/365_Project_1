/*
*	CS365 Project 1
*
*	Contributors:
*		Austyn Simons
*		Brandon Yen
*		Charles Rizzo
*
*	Xor.cs creates an object of type Xor that has a read-only Val property. The Val property gets the byte encoding of the xor	
*	command.
*
*/

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
