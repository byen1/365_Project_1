/*
*	CS365 Project 1
*
*	Contributors:
*		Austyn Simons
*		Brandon Yen
*		Charles Rizzo
*
*	Rem.cs creates an object of type Rem that has a read-only Val property. The Val property gets the byte encoding of the rem	
*	command.
*
*/

public class Rem : IInstruction{
    public Rem(){}
    
    public uint Val{
        get{
            uint retVal = 1 << 3;
            ++retVal;
            retVal <<= 26;
            
            return retVal;
        }
    }
}
