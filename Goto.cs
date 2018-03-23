using System;

public class Goto : IInstruction{
	uint val;

	public Goto(uint input){
		val = input;
	}
	public uint Val{
		get{
			uint retVal = 7 << 28; //0111
			retVal = retVal | val; //assumes top 4 bits of Val are 0000
			return retVal;
		}
	}
}

