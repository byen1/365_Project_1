/*
*	CS365 Project 1
*
*	Contributors:
*		Austyn Simons
*		Brandon Yen
*		Charles Rizzo
*
*	Swap.cs creates an object of type Swap that has a Val property. The Val property gets the byte encoding of the swap	
*	command.
*
*/
using System;

public class Swap : IInstruction{

	public Swap(){}

	public uint Val{
		get{
			uint retVal = 1 << 24;
			return retVal;
		}

	}
}
