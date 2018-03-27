/*
*	CS365 Project 1
*
*	Contributors:
*		Austyn Simons
*		Brandon Yen
*		Charles Rizzo
*
*	Or.cs creates an object of type Or that has a read-only Val property. The Val property gets the byte encoding of the or	
*	command.
*
*/

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
