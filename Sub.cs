/*
*	CS365 Project 1
*
*	Contributors:
*		Austyn Simons
*		Brandon Yen
*		Charles Rizzo
*
*	Sub.cs creates an object of type Sub that has a Val property. The Val property gets the byte encoding of the sub	
*	command.
*
*/
using System;

public class Sub : IInstruction{

	public Sub(){}

	public uint Val{
		get{
			uint retVal = 33 << 24;
			return retVal;
		}

	}
}
