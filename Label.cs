using System;

public class Label : ILabel{
	
	private string labelName;
	private uint labAddr;

	public Label(string labName, uint addr){
		labelName = labName;
		labAddr = addr;
	}

	public string Name{
		get{
			return labelName;
		}
	}

	public uint Address{
		get{
			return labAddr;
		}	
	}
}
