using System;

public class Push : IInstruction{
	uint val;

	public Push(uint input){
		val = input;
	}
	public uint Val{
		get{
			uint retVal = 15 << 28; //1111
			retVal = retVal | val; //assumes top 4 bits of Val are 0000
			return retVal;
		}
	}
}

