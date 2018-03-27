/*
*	CS365 Project 1
*
*	Contributors:
*		Austyn Simons
*		Brandon Yen
*		Charles Rizzo
*
*	And.cs creates an object of type And that has a read-only Val property. The Val property gets the byte encoding of the and	
*	command.
*
*/

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
