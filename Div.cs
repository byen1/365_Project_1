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
