/*
*	CS365 Project 1
*
*	Contributors:
*		Austyn Simons
*		Brandon Yen
*		Charles Rizzo
*
*	Inpt.cs creates an object of type Inpt that has a Val property. The Val property gets the byte encoding of the inpt	
*	command.
*
*/
using System;

public class Inpt : IInstruction{

	public Inpt(){}

	public uint Val{
		get{
			uint retVal = 1 << 25;
			return retVal;
		}

	}

}
