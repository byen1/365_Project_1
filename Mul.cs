/*
*	CS365 Project 1
*
*	Contributors:
*		Austyn Simons
*		Brandon Yen
*		Charles Rizzo
*
*	Mul.cs creates an object of type Mul that has a read-only Val property. The Val property gets the byte encoding of the mul	
*	command.
*
*/
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
