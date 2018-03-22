using System;

public class Exit : IInstruction{
	
	private int arg;
	public Exit(int data){
		arg = data;
	}

	public uint Val{
		get{
			uint retVal = 0 | (uint) arg;

			return retVal;
		}

	}
}
