using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public class fileRead{
	
	public static Dictionary<string,int> commands = new Dictionary<string,int>
	{
		{"push",0},{"dump",1},{"print",2},{"dup",3},
		{"ifez",4},{"ifnz",5},{"ifmi",6},{"ifpl",7},
		{"ifeq",8},{"ifne",9},{"iflt",10},{"ifgt",11},
		{"ifle",12},{"ifge",13},{"goto",14},{"not",15},
		{"neg",16},{"xor",17},{"or",18},{"and",19},
		{"rem",20},{"div",21},{"mul",22},{"sub",23},
		{"add",24},{"pop",25},{"nop",26},{"inpt",27},
		{"swap",28},{"exit",29}
	};

	public static Dictionary<string,int> labels;

	public fileRead(string filename){
		labels = new Dictionary<string,int>();

		labelsLocater(filename);
		foreach(KeyValuePair<string, int> label in labels){
			Console.WriteLine($"Label: {label.Key} with address {label.Value}");
		}
		instructionExtractor(filename);

	}

	private void labelsLocater(string filename){
		string line;
		using(var sr = new StreamReader(File.OpenRead(filename))){ //First pass through to get labels and "addresses"
			while(sr.Peek() >= 0){
				line = sr.ReadLine();
				line = line.ToLower();
			
				if(line.Length == 0 || line[0] == '#' || (line[0] == '/' && line[1] == '/')) //Ignore the line
					continue;
				
				Match match = Regex.Match(line,@"[\s]*([A-Za-z0-9\-]+):[\s]*$");
				if(match.Success)
					labels.Add(match.Groups[1].Value,11111);
			}
		}
	}

	private void instructionExtractor(string filename){
		int conversion, hexConv;
		string command, arg, line;

		using(var sr = new StreamReader(File.OpenRead(filename))){
			while(sr.Peek() >= 0){
				line = sr.ReadLine();
				line = line.ToLower();
				
				if(line.Length == 0 || line[0] == '#' || (line[0] == '/' && line[1] == '/') || line[line.Length - 1] == ':') //Ignore the line
					continue;

				Match match = Regex.Match(line,@"([A-Za-z0-9\-]+)[\s]+([A-Za-z0-9\-]+)$",RegexOptions.IgnoreCase);
				if(match.Success){
					command = match.Groups[1].Value;
					arg = match.Groups[2].Value;
					
					if(Int32.TryParse(arg, out conversion)){
						Console.WriteLine($"{command}   {arg} : {conversion}");
					}else if(arg.Length > 2 && arg[0] == '0' && arg[1] == 'x'){
						arg = arg.Substring(2);
						if(Int32.TryParse(arg,System.Globalization.NumberStyles.HexNumber, null, out hexConv))
							Console.WriteLine($"{command}   {arg} => {hexConv}");
					}else{
						Console.WriteLine($"{command}   {arg}: Some sort of label");
					}
				}else{ //The line is only one word
					Match match2 = Regex.Match(line,@"[\s]*([A-Za-z0-9\-]+)[\s]*$");
					Console.WriteLine(match2.Groups[1].Value);
				}
			}
		}
	}

}
