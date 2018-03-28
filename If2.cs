/*
 * CS365 Project 1
 *
 * Contributors:
 * Austyn Simons
 * Brandon Yen
 * Charles Rizzo
 *
 * If2.cs creates an object of type If2 that has a Val property. The Val property gets the byte encoding of the following 
 * if commands: ifez, ifnz, ifmi, and ifpl.
 *
 */
using System;

public class If2 : IInstruction{
	int cond;
	int val;

	public If2(int input1, int input2, int input3){
		cond = input1;
		val = input2 - input3;
	}
	public uint Val{
		get{
			int retVal = 9 <<  28; //1001
			retVal = retVal | (cond << 24);
			retVal = retVal | (val & 0xffffff); //assumes top 8 bits of Val are 0000 0000
			return (uint) retVal;
		}
	}
}

