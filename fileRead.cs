/*
*	CS365 Project 1
*
*	Contributors:
*		Austyn Simons
*		Brandon Yen
*		Charles Rizzo
*
*	fileRead.cs creates an object of type fileRead and ultimately builds a list of IInstructions. It also constructs
*	an internal dictionary of Labels in order to associate an address with each label in the file. 
*
*/
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public class fileRead{
	private static Dictionary <string, Label> labels;
	public List <IInstruction> encodedInstrs;
	
	public fileRead(string filename){
		labels = new Dictionary <string,Label>();
		encodedInstrs = new List <IInstruction>();

		labelsLocater(filename);
		instructionExtractor(filename);
	}
	
	//Iterates through the file locating each label and creates a Label object for each one spotted. The label object
	//and its name are then added to a dictionary of Label objects. Regex is used to extract the label names.
	private void labelsLocater(string filename){
		string line;
		int labelAddr = 0;
		using(var sr = new StreamReader(File.OpenRead(filename))){ 
			while(sr.Peek() >= 0){
				line = sr.ReadLine();
				line = line.ToLower();
			
				//Ignore line with the following conditions
				if(line.Length == 0 || line[0] == '#' || (line[0] == '/' && line[1] == '/')) 
					continue;
				
				Match match = Regex.Match(line,@"[\s]*([A-Za-z0-9\-]+):[\s]*$");
				if(match.Success)
					labels.Add(match.Groups[1].Value, new Label(match.Groups[1].Value,labelAddr));
				else{
					labelAddr += 4;
				}
			}
		}
	}

	//This function uses Regex to get the Instruction and a possible argument from each line by stripping away a variable
	//amount of whitespace. We try to parse the argument as an Int and a hex before concluding if its not either of those
	//it must be a label.
	private void instructionExtractor(string filename){
		int conversion, hexConv, currentInstr = 0;
		string command, arg, line;

		using(var sr = new StreamReader(File.OpenRead(filename))){
			while(sr.Peek() >= 0){
				line = sr.ReadLine();
				line = line.ToLower();
				
				//Ignore the line if any of the following conditions are met
				if(line.Length == 0 || line[0] == '#' 
					|| (line[0] == '/' && line[1] == '/') 
						|| line[line.Length - 1] == ':') 
					continue;

				Match match = Regex.Match(line,@"([A-Za-z0-9\-]+)[\s]+([A-Za-z0-9\-]+)$",RegexOptions.IgnoreCase);
				if(match.Success){
					command = match.Groups[1].Value;
					arg = match.Groups[2].Value;
					
					if(Int32.TryParse(arg, out conversion)){
						encodedInstrs.Add(createObject(command,conversion, currentInstr));
					}else if(arg.Length > 2 && arg[0] == '0' && arg[1] == 'x'){
						arg = arg.Substring(2);
						if(Int32.TryParse(arg,System.Globalization.NumberStyles.HexNumber, null, out hexConv))
							encodedInstrs.Add(createObject(command,hexConv, currentInstr));
					}else{
						encodedInstrs.Add(createObject(command,labels[arg].Address, currentInstr));
					}
				}else{ //The line is only an instruction with no argument
					Match match2 = Regex.Match(line,@"[\s]*([A-Za-z0-9\-]+)[\s]*$");
					encodedInstrs.Add(createObject(match2.Groups[1].Value,0,currentInstr));
				}
				currentInstr += 4;
			}
		}
	}

	//This function actually creates the object associated with each Instruction by using a long switch statement. The object
	//created is polymorphed up to an IInstruction and then returned from the function to be stored in the encodedInstrs list.
	//Ugly? Very. Effective? Extremely.
	private IInstruction createObject(string comm, int valToUse, int currentInstruc){
		IInstruction retVal = null;
		switch(comm){
			case "exit":
				retVal = new Exit(valToUse) as IInstruction;
				break;
			case "swap":
				retVal = new Swap() as IInstruction;
				break;
			case "inpt":
				retVal = new Inpt() as IInstruction;
				break;
			case "nop":
				retVal = new Nop() as IInstruction;
				break;
			case "pop":
				retVal = new Pop() as IInstruction;
				break;
			case "add":
				retVal = new Add() as IInstruction;
				break;
			case "sub":
				retVal = new Sub() as IInstruction;
				break;
			case "mul":
				retVal = new Mul() as IInstruction;
				break;
			case "div":
				retVal = new Div() as IInstruction;
				break;
			case "rem":
				retVal = new Rem() as IInstruction;
				break;
			case "and":
				retVal = new And() as IInstruction;
				break;
			case "or":
				retVal = new Or() as IInstruction;
				break;
			case "xor":
				retVal = new Xor() as IInstruction;
				break;
			case "neg":
				retVal = new Neg() as IInstruction;
				break;
			case "not":
				retVal = new Not() as IInstruction;
				break;
			case "goto":
				retVal = new Goto(valToUse) as IInstruction;
				break;
			case "ifeq":
				retVal = new If1(0, valToUse, currentInstruc) as IInstruction;
				break;
			case "ifne":
				retVal = new If1(1, valToUse, currentInstruc) as IInstruction;
				break;
			case "iflt":
				retVal = new If1(2, valToUse, currentInstruc) as IInstruction;
				break;
			case "ifgt":
				retVal = new If1(3, valToUse, currentInstruc) as IInstruction;
				break;
			case "ifle":
				retVal = new If1(4, valToUse, currentInstruc) as IInstruction;
				break;
			case "ifge":
				retVal = new If1(5, valToUse, currentInstruc) as IInstruction;
				break;
			case "ifez":
				retVal = new If2(0, valToUse, currentInstruc) as IInstruction;
				break;
			case "ifnz":
				retVal = new If2(1, valToUse, currentInstruc) as IInstruction;
				break;
			case "ifmi":
				retVal = new If2(2, valToUse, currentInstruc) as IInstruction;
				break;
			case "ifpl":
				retVal = new If2(3, valToUse, currentInstruc) as IInstruction;
				break;
			case "dup":
				retVal = new Dup(valToUse) as IInstruction;
				break;
			case "print":
				retVal = new Print() as IInstruction;
				break;
			case "dump":
				retVal = new Dump() as IInstruction;
				break;
			case "push":
				retVal = new Push(valToUse) as IInstruction;
				break;
		}
		return retVal;
	}

}
