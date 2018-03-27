/*
*	CS365 Project 1
*
*	Contributors:
*		Austyn Simons
*		Brandon Yen
*		Charles Rizzo
*
*	Neg.cs creates an object of type Neg that has a read-only Val property. The Val property gets the byte encoding of the neg	
*	command.
*
*/

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
