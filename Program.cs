using System;

namespace Trial1
{
    class Program
    {
        static void Main(string[] args)
        {
           
          //unsigned is always positive
            //byte x =1; // 0 to 255 (8 byte)
            // sbyte y =100; // -128  to 127 (8byte) signed byte so divide by 2
            
            //short a = 65335;   //(16 byte) is signed data type, (2^16)/2= -32768 to 32767
//ushort b = 65535;//unsigned short 
           // Console.WriteLine("x is " + x);
            //Console.WriteLine("y is "+ y);
            
          //  uint x= 4294967295 ; // it is 0 to 2^32 - 1
         //   Console.WriteLine(x);

        //    int y = 2147483647; // -2^31 to 2^31 - 1
         //   Console.WriteLine(y);
            //To convert to byte or anythng use,
            //convert.byte() but it should be within the range.
            //float32bits= 4 bytes =  6-9 digits
            //double  15-17
            //decimal 16 bytes = 16*8= 28-29 digits precision
 
float num = 1.5f; // rounds up if its more than 6-9 digits if ita decimal 
//or else rounds down if its whole number

//float use f after decimal
//decimale use m after decimal
Console.WriteLine(num);
//float to int doesnt work
// float to double works but douvke adds extra numbers
// float to   decimal doesnt

//concatnating - ading += to string

string apple = "hi";
apple += " to";
Console.WriteLine(apple);

        }
    }
}
