using System;

public class Not : IInstruction{
	public Not(){}
	public uint Val{
		get{
			int retVal = 49 << 24; //0011 0001
			return (uint)retVal;
		}
	}
}

