/*
*	CS365 Project 1
*
*	Contributors:
*		Austyn Simons
*		Brandon Yen
*		Charles Rizzo
*
*	Nop.cs creates an object of type Nop that has a Val property. The Val property gets the byte encoding of the nop	
*	command.
*
*/
using System;

public class Nop : IInstruction{

	public Nop(){}

	public uint Val{
		get{
			uint retVal = 3 << 24;
			return retVal;
		}

	}
}
