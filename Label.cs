/*
*	CS365 Project 1
*
*	Contributors:
*		Austyn Simons
*		Brandon Yen
*		Charles Rizzo
*
*	Label.cs implements the ILabel interface and defines the get methods for the two properties. All they do is return	
*	whatever values are provided upon the construction of the Label (i.e. the label's name and address).
*
*/
using System;

public class Label : ILabel{
	
	private string labelName;
	private int labAddr;

	public Label(string labName, int addr){
		labelName = labName;
		labAddr = addr;
	}

	public string Name{
		get{
			return labelName;
		}
	}

	public int Address{
		get{
			return labAddr;
		}	
	}
}
