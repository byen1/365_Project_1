/*
*	CS365 Project 1
*
*	Contributors:
*		Austyn Simons
*		Brandon Yen
*		Charles Rizzo
*
*	Div.cs creates an object of type Div that has a read-only Val property. The Val property gets the byte encoding of the div	
*	command.
*
*/

public class Div : IInstruction{
    public Div(){}
    
    public uint Val{
        get{
            uint retVal = 1 << 4;
            retVal += 1;
            retVal <<= 1;
            retVal += 1;
            retVal <<= 24;
            
            return retVal; 
        }
    }
}
