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

