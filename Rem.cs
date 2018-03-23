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
