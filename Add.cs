/*
*	CS365 Project 1
*
*	Contributors:
*		Austyn Simons
*		Brandon Yen
*		Charles Rizzo
*
*	Add.cs creates an object of type Add that has a Val property. The Val property gets the byte encoding of the add	
*	command.
*
*/
using System;

public class Add : IInstruction{

	public Add(){}

	public uint Val{
		get{
			uint retVal = 1 << 29;
			return retVal;
		}

	}
}
