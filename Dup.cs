/*
 * CS365 Project 1
 *
 * Contributors:
 * Austyn Simons
 * Brandon Yen
 * Charles Rizzo
 *
 * Dup.cs creates an object of type Dup that has a Val property. The Val property gets the byte encoding of the Dup 
 * command.
 *
 */
using System;

public class Dup : IInstruction{
	int val;

	public Dup(int input){
		val = input;
	}
	public uint Val{
		get{
			int retVal = 12 << 28; //1100
			retVal = retVal | (val << 2); //assumes top 6 bits of Val are 0000 00
									   //Last two Bits of Dup are always 00
			return (uint)retVal;
		}
	}
}

