/*
 * CS365 Project 1
 *
 * Contributors:
 * Austyn Simons
 * Brandon Yen
 * Charles Rizzo
 *
 * Not.cs creates an object of type Not that has a Val property. The Val property gets the byte encoding of the not 
 * command.
 *
 */
using System;

public class Not : IInstruction{
	public Not(){}
	public uint Val{
		get{
			int retVal = 49 << 24; //0011 0001
			return (uint)retVal;
		}
	}
}

