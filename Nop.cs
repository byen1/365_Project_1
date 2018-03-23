using System;

public class Nop : IInstruction{

	public Nop(){}

	public uint Val{
		get{
			uint retVal = 3 << 24;
			return retVal;
		}

	}
}
