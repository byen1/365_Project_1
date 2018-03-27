/*
*	CS365 Project 1
*
*	Contributors:
*		Austyn Simons
*		Brandon Yen
*		Charles Rizzo
*
*	Pop.cs creates an object of type Pop that has a Val property. The Val property gets the byte encoding of the pop	
*	command.
*
*/
using System;

public class Pop : IInstruction{

	public Pop(){}

	public uint Val{
		get{
			uint retVal = 1 << 28;
			return retVal;
		}

	}
}
