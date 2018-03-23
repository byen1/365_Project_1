using System;

public class If2 : IInstruction{
	int cond;
	int val;

	public If2(int input1, int input2){
		cond = input1;
		val = input2;
	}
	public uint Val{
		get{
			uint retVal = 9 << 28 //1001
			retVal = retVal | (cond << 24);
			retVal = retVal | val; //assumes top 8 bits of Val are 0000 0000
			return retVal;
		}
	}
}

