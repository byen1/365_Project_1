using System;

public class Pop : IInstruction{

	public Pop(){}

	public uint Val{
		get{
			uint retVal = 1 << 28;
			return retVal;
		}

	}
}
