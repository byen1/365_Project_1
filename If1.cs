using System;

public class If1 : IInstruction{
	int cond;
	int val;

	public If1(int input1, int input2, int input3){
		cond = input1;
		val = input2 - input3;
	}
	public uint Val{
		get{
			int retVal = 8 << 28; //1000
			retVal = retVal | (cond << 24);
			retVal = retVal | (val & 0xffffff); //assumes top 8 bits of Val are 0000 0000
			return (uint)retVal;
		}
	}
}

