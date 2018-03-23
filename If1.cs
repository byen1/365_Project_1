using System;

public class If1 : IInstruction{
	int cond;
	int val;

	public If1(int input1, int input2){
		cond = input1;
		val = input2;
	}
	public uint Val{
		get{
			uint retVal = 8 << 28 //1000
			retVal = retVal | (cond << 24);
			retVal = retVal | val; //assumes top 8 bits of Val are 0000 0000
			return retVal;
		}
	}
}

