namespace MyFirstApplication;

/*
 This is the class that is to used with Exercise 1. The exercise will cover creating four
 methods dealing with the various data types.
 */
public class Exercise1
{

    /*
    1. Write out a method with no arguments and a void return type that will print the output
    of the number 35 based on the number systems below. The values should be assigned to
    a variable inside the method prior to printing them using Console WriteLine.
    Utilize the conversion document from your resources.
    a.Decimal
    b.Hexadecimal
    c.Binary
     */
    public void OutputLiteralTypes()
    {
        int decimalValue = 35;
        int hexadecimalValue = 0x23;
        int binaryValue = 0b100011;

        Console.WriteLine(decimalValue);
        Console.WriteLine(hexadecimalValue);
        Console.WriteLine(binaryValue);
    }

    /*
     2. Write a method that will accept 3 argument parameters and a void return type.
     The first argument should be of type byte. The second argument should be of type short.
     The third argument should be of type int. Using Implicit conversion, create variables
     to convert to using the below information. Use the argument parameters as the values
     to convert from. Print each converted variable using Console WriteLine.
     a.From byte to int
     b.From short to long
     c.From int to float
     */
    public void ImplicitConvertDataType(byte value1, short value2, int value3)
    {
        int alpha = value1;
        long beta = value2;
        float charlie = value3;

        Console.WriteLine(alpha);
        Console.WriteLine(beta);
        Console.WriteLine(charlie);
    }

    /*
     3. Write a method that will accept 3 argument parameters and a void return type.
     The first argument should be of type double. The second argument should be of type float.
     The third argument should be of type long. Using Explicit conversion, create variables
     to convert to using the below information. Use the argument parameters as the values
     to convert from. Print each converted variable using Console WriteLine.
     a.From double to long
     b.From float to int
     c.From long to short
     */
    public void ExplicitConvertDataType(double doubleValue, float floatValue, long longValue)
    {
        long endLong = (long)doubleValue;
        int endInt = (int)floatValue;
        short endShort = (short)longValue;

        Console.WriteLine(endLong);
        Console.WriteLine(endInt);
        Console.WriteLine(endShort);
    }
    /*
     4. Write a method with no arguments and a void return type.Using the values below,
     assign them to a variable that best suits their value type.Utilize the digit
     separator when assigning them to your variables. Once you have defined your variables,
     print out each one using Console WriteLine.Do not use the same value type more
     than once.
    a.123456.987
    b.-9516248
    c.3500
    d.988562486
    e.-19733.14895
     */
    public void AssignVariableTypes()
    {
        float floatVariable = 123_456.987F;
        int intVariable = -9_516_248;
        short shortVariable = 3_500;
        long longVariable = 988_562_486L;
        decimal decimalVariable = -19_733.148_95M;

        Console.WriteLine(floatVariable);
        Console.WriteLine(intVariable);
        Console.WriteLine(shortVariable);
        Console.WriteLine(longVariable);
        Console.WriteLine(decimalVariable);
    }
} // end class

