package Sandipan.Array;

public class binary {
    
    public static int Binary(int n)
    {
        String binaryString = Integer.toBinaryString(n);
        StringBuilder binaryConvert = new StringBuilder(binaryString);
        
        for(int i=0; i<binaryConvert.length(); i++)
        {
            if(binaryConvert.charAt(i)=='0')
            {
                binaryConvert.setCharAt(i, '1');
            }
            else
            {
                binaryConvert.setCharAt(i, '0');
            }
        }

        return Integer.parseInt(binaryConvert.toString(), 2);
    }
    
}
