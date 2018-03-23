using System;

public class Dup : IInstruction{
	uint val;

	public Dup(uint input){
		val = input;
	}
	public uint Val{
		get{
			uint retVal = 12 << 28; //1100
			retVal = retVal | (val << 2); //assumes top 6 bits of Val are 0000 00
									   //Last two Bits of Dup are always 00
			return retVal;
		}
	}
}

