using System;

public class Add : IInstruction{

	public Add(){}

	public uint Val{
		get{
			uint retVal = 1 << 29;
			return retVal;
		}

	}
}
