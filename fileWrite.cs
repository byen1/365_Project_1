/*
*	CS365 Project 1
*
*	Contributors:
*		Austyn Simons
*		Brandon Yen
*		Charles Rizzo
*
*	fileWrite.cs is a static class that has a fileWriter function. The function takes a list of IInstruction type 	
*	objects and writes each object's value to an output file (statically declared and stored in the outputFile string).
*
*/
using System;
using System.Collections.Generic;
using System.IO;

public static class fileWrite{

	private static string outputFile = "byteCode.bin";

	public static void fileWriter(List <IInstruction> instrs){
		using(var bw = new BinaryWriter(File.OpenWrite(outputFile))){
			bw.Write(0xefbeedfe);
			foreach(var cmd in instrs){
				bw.Write(cmd.Val);
			}
		}
	}
}
