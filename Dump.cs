using System;

public class Dump : IInstruction{
	public Dump(){}
	public uint Val{
		get{
			uint retVal = 14 << 28; //1110
			return retVal;
		}
	}
}

