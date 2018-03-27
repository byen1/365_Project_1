/*
*	CS365 Project 1
*
*	Contributors:
*		Austyn Simons
*		Brandon Yen
*		Charles Rizzo
*
*	ILabel.cs defines an interface for a Label class that consists of a string name and an integer address 
*	corresponding to the Label's address in a .asm file.
*
*/
using System;

interface ILabel{
	string Name{get;}
	int Address{get;}
}
