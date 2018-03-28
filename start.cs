/*
*	CS365 Project 1
*
*	Contributors:
*		Austyn Simons
*		Brandon Yen
*		Charles Rizzo
*
*	start.cs kicks off the program and is structured so that anything that goes wrong will be caught by the try-catch block.
*	a fileRead object is created, which compiles a list of IInstructions. That list is then passed to the fileWrited function
*	to use in order to write each Instruction's binary value to an output file specified in fileWrite.cs.
*/
using System;
using System.IO;

public class start{

	public static int Main(string []args){
		try{
			var readFile = new fileRead(args[0]);
			fileWrite.fileWriter(readFile.encodedInstrs);
		}catch(Exception ex){
			Console.WriteLine($"Error: {ex.Message}");
			return 1;
		}
		return 0;
	}
}
