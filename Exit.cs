/*
*	CS365 Project 1
*
*	Contributors:
*		Austyn Simons
*		Brandon Yen
*		Charles Rizzo
*
*	Exit.cs creates an object of type Exit that has a Val property. The Val property gets the byte encoding of the exit	
*	command.
*
*/


using System;

public class Exit : IInstruction{
	
	private int arg;
	public Exit(int data){
		arg = data;
	}

	public uint Val{
		get{
			uint retVal = 0 | (uint) arg;
			return retVal;
		}

	}
}
