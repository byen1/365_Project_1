/*
 * CS365 Project 1
 *
 * Contributors:
 * Austyn Simons
 * Brandon Yen
 * Charles Rizzo
 *
 * Push.cs creates an object of type Push that has a Val property. The Val property gets the byte encoding of the push 
 * command.
 *
 */
using System;

public class Push : IInstruction{
	int val;

	public Push(int input){
		val = input;
	}
	public uint Val{
		get{
			int retVal = 15 << 28; //1111
			retVal = retVal | val; //assumes top 4 bits of Val are 0000
			return (uint)retVal;
		}
	}
}

