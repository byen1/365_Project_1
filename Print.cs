/*
 * CS365 Project 1
 *
 * Contributors:
 * Austyn Simons
 * Brandon Yen
 * Charles Rizzo
 *
 * Print.cs creates an object of type Print that has a Val property. The Val property gets the byte encoding of the print 
 * command.
 *
 */
using System;

public class Print : IInstruction{
	public Print(){}
	public uint Val{
		get{
			int retVal = 13 << 28; //1101
			return (uint)retVal;
		}
	}
}

