using MyFirstApplication;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// The below statement calls a local function
// single line comment


/*
 Multi-Line comment
The below statement is a local function. Local functions
are inside of members and are private by default. This means
They are specific to that member and can only be called
inside that member.
 */

// Lesson Examples
// HouseExample();
// Lesson1Example();
// Lesson2Example();
// Lesson3Example();
// Lesson4Example();

// Lesson 4 Control Flow
void Lesson4Example()
{
    Lesson4 myLesson4 = new Lesson4();
    // myLesson4.BasciIfStatement(11);
    // myLesson4.BasicIfElseStatement(12);
    // myLesson4.BasicIfElseChainStatement(5);
    // myLesson4.BasicAndOrCondition(20, 20);
    // Console.WriteLine(myLesson4.BasicTernaryExample(35));
    // myLesson4.BasicSwitchStatement(5);
    // myLesson4.BasicWhileStatement();
    // myLesson4.BasicDoStatement();
    // myLesson4.BasicForStatement();
    // myLesson4.BasicForeachStatement();
    // myLesson4.BasicJumpStatement();
}

// Lesson 3 Operators and Overflow Checking
void Lesson3Example()
{
    Lesson3 myLesson3 = new Lesson3();
    // myLesson3.BasicCheckedOperator(14);
    // myLesson3.BasicCheckedExample2();
    // int alpha = 2147483647;
    // int total = alpha + 10;
    // Console.WriteLine(total);
    // -214748639
    // myLesson3.BasicUncheckedExample();
    // myLesson3.BasicMath();
    // myLesson3.BasicModulus(783);
    // myLesson3.BasicBooleanLogical(true, false);
    // myLesson3.BasicCompoundExample(12, 35, 9);
    // myLesson3.BasicRelationalExample("Tom", "Tim");
    // myLesson3.MyIncrDecrExample();
}

// Lesson 2 Strings
void Lesson2Example()
{
    Lesson2 myLesson2 = new Lesson2();
    myLesson2.MyTrimExample();
    int able = myLesson2.MyStringLength();
    Console.WriteLine(able);
    myLesson2.myEqualsExample("Hello World");
    myLesson2.MyExampleChar();
    Console.WriteLine(myLesson2.MyEscapeExample());
    myLesson2.MyJoinedStrings("CSharp", "Rules");
    Console.WriteLine(myLesson2.MyInterpolationExample("pizza", 3));
    myLesson2.MyOtherInterpolation();
}


// void HouseExample()
// {
//     House myHouse = new House();
//     myHouse.DoorOpenClose();
// }



// Lesson 1 Value Types
void Lesson1Example()
{
    Lesson1 myLesson = new Lesson1();
    myLesson.IntMinMax();
    myLesson.IntegralExample();
    myLesson.ConvertFloatToInt();
    myLesson.LongFromInt();
}

// Exercise Tests
// Exercise1Test();
// Exercise2Test();
// Exercise3Test();
Exercise4Test();

// Exercise 4 Test
void Exercise4Test()
{
    Exercise4 myExercise4 = new Exercise4();
    myExercise4.IfElseExample("Have a nice day", "See ya");
    Console.WriteLine(myExercise4.SwitchExample('V'));
    myExercise4.IterationLoopExample();
}

// Exercise 3 Test
void Exercise3Test()
{
    Exercise3 myExercise3 = new Exercise3();
    myExercise3.ModulusExamples(5);
    myExercise3.ArithmeticExamples();
    myExercise3.CompoundExamples(10, 20);
    myExercise3.BooleanExamples(true, false);
}

// Exercise 2 test
void Exercise2Test()
{
    Exercise2 myExercise2 = new Exercise2();
    myExercise2.StringConcatenationExercise(" EXERCISE two Lab ");
    myExercise2.UnicodeExample();
    myExercise2.EscapeSequenceExample();
    Console.WriteLine(myExercise2.InterpolationMovieExample());
}

// Exercise 1 Test
void Exercise1Test()
{
    Exercise1 myExercise1 = new Exercise1();
    myExercise1.OutputLiteralTypes();
    myExercise1.ImplicitConvertDataType(250, 30_000, 2_000_000_000);
    myExercise1.ExplicitConvertDataType(1.7E+8, 998_287.268F, 5_678_555);
    myExercise1.AssignVariableTypes();
}
