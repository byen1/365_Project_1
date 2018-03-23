using System;

public class Not : IInstruction{
	public Not(){}
	public uint Val{
		get{
			uint retVal = 49 << 24; //0011 0001
			return retVal;
		}
	}
}

