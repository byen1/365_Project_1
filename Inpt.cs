using System;

public class Inpt : IInstruction{

	public Inpt(){}

	public uint Val{
		get{
			uint retVal = 1 << 25;
			return retVal;
		}

	}

}
