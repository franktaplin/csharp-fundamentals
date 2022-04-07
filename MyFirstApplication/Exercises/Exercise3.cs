
namespace MyFirstApplication;

/*
 This is the class for Exercise 3. This exercise covers the types of Operators
 and how to use them. 
 */
internal class Exercise3
{
    /*
     1. Write a method that takes 1 int argument and an int return type.
     Utilize the modulus operator to complete this task. Assign the data values below
     to their own variables. Use the Console WriteLine statement on the
     first 4 variables listed below and calculate the modulus with the passed
     in argument parameter. Using the last variable below, calculate the modulus
     with the passed in argument parameter and return it.
     a. 15
     b. 456
     c. 23
     d. 89
     e. 245
     */
    public int ModulusExamples(int modArg)
    {
        int myMod = modArg;
        int mod1 = 15;
        int mod2 = 456;
        int mod3 = 23;
        int mod4 = 89;
        int mod5 = 245;
        Console.WriteLine(mod1 % myMod);
        Console.WriteLine(mod2 % myMod);
        Console.WriteLine(mod3 % myMod);
        Console.WriteLine(mod4 % myMod);
        return mod5 % myMod;
    }

    /*
     2. Write a method that takes no arguments and a void return type.
     Utilizing the math problem in this task, fill in any missing pieces 
     to get the output. 10 + 32 * 12 / 3. Write a Console WriteLine to solve each output.
     a. Output: 138
     b. Output: 168
     c. Output: 131
    */
    public void ArithmeticExamples()
    {
        int able = 10 + (32 * 12 / 3);
        int baker = (10 + 32) * 12 / 3;
        int charlie = (10 + 32 * 12) / 3;
        Console.WriteLine(able);
        Console.WriteLine(baker);
        Console.WriteLine(charlie);
    }

    /*
     3. Write a method that takes two short type arguments and a void return type.
     Using the Compound Assignment operators below, use the first argument parameter
     as the left operand to get the result. Print each one using the Console WriteLine
     statement.
     a. +=
     b. /=
     c. *=
     d. %=
    */
    public void CompoundExamples(short compVal1, short compVal2)
    {
        Console.WriteLine(compVal1 += compVal2);
        Console.WriteLine(compVal1 /= compVal2);
        Console.WriteLine(compVal1 *= compVal2);
        Console.WriteLine(compVal1 %= compVal2);
    }

    /*
     4. Write a method that takes two bool type arguments and a void return type.
     Using Boolean Logical operators &, |, ^,and || to complete this task.
     Use a Console WriteLine statement to calculate each result using the operators.
     The second argument is the left operand. Use the below values when testing
     your method. Using comments, provide your output results inside the method
     after your statements.
     a. Argument1= true, Argument2 = false
     b. Argument1= false, Argument2 = false
     c. Argument1= true, Argument2 = true
     d. Argument1= false, Argument2 = true
    */
    public void BooleanExamples(bool boolVal1, bool boolVal2)
    {
        Console.WriteLine(boolVal2 & boolVal1);
        Console.WriteLine(boolVal2 | boolVal1);
        Console.WriteLine(boolVal2 ^ boolVal1);
        Console.WriteLine(boolVal2 || boolVal1);
        //a. output is false, true, true, true
        //b. output is false, false, false, false
        //c. output is true, true, false, true
        //d. output is false, true, true, true
    }
}

