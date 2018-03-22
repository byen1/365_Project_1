using System;

public class Exit : IInstruction{
	
	private int arg;
	public Exit(int data){
		arg = data;
	}

	public uint Val{
		get{
			return (uint) arg * 2;
		}

	}
	


}
