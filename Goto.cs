/*
 * CS365 Project 1
 *
 * Contributors:
 * Austyn Simons
 * Brandon Yen
 * Charles Rizzo
 *
 * Goto.cs creates an object of type Goto that has a Val property. The Val property gets the byte encoding of the goto 
 * command.
 *
 */
using System;

public class Goto : IInstruction{
	int val;

	public Goto(int input){
		val = input;
	}
	public uint Val{
		get{
			int retVal = 7 << 28; // 0111
			retVal = retVal | val; //assumes top 4 bits of Val are 0000
			return (uint)retVal;
		}
	}
}

