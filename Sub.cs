using System;

public class Sub : IInstruction{

	public Sub(){}

	public uint Val{
		get{
			uint retVal = 33 << 24;
			return retVal;
		}

	}
}
