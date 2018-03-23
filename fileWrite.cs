using System;
using System.Collections.Generic;
using System.IO;

public class fileWrite{

	private string outputFile = "byteCode.bin";

	public fileWrite(List <IInstruction> instrs){
		using(var bw = new BinaryWriter(File.OpenWrite(outputFile))){
			foreach(var cmd in instrs){
			}
		}
	}
}
