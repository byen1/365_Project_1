using System;

public class Swap : IInstruction{

	public Swap(){}

	public uint Val{
		get{
			uint retVal = 1 << 24;
			return retVal;
		}

	}
}
