/*
*	CS365 Project 1
*
*	Contributors:
*		Austyn Simons
*		Brandon Yen
*		Charles Rizzo
*
*	IInstruction.cs defines an interface for an Instruction class. It only contains a uint val property that returns
*	the binary code corresponding to a specific instruction. Every instruction class implements this.
*
*/
using System;

public interface IInstruction{

	uint Val{get;}
}
