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
