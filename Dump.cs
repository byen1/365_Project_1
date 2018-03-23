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

