using System;
using System.IO;

public class start{

	public static int Main(string []args){
		try{
			var readFile = new fileRead(args[0]);
		}catch(Exception ex){
			Console.WriteLine($"Error: {ex.Message}");
			return 1;
		}

		return 0;
	}
}
