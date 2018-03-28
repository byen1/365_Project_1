/*
 * CS365 Project 1
 *
 * Contributors:
 * Austyn Simons
 * Brandon Yen
 * Charles Rizzo
 *
 * Dump.cs creates an object of type Dump that has a Val property. The Val property gets the byte encoding of the dump 
 * command.
 *
 */
using System;

public class Dump : IInstruction{
	public Dump(){}
	public uint Val{
		get{
			int retVal = 14 << 28; //1110
			return (uint)retVal;
		}
	}
}

