using System;
using System.Collections.Generic;
using System.IO;

public class fileWrite{

	private string outputFile = "byteCode.bin";

	public fileWrite(List <IInstruction> instrs){
		using(var bw = new BinaryWriter(File.OpenWrite(outputFile))){
			bw.Write(0xfeedbeef);
			foreach(var cmd in instrs){
				bw.Write(cmd.Val);
			}
		}
	}
}
