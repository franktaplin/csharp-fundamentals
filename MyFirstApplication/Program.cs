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

// Exercise Tests
Exercise1Test();

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

// Exercise 1 Test
void Exercise1Test()
{
    Exercise1 myExercise1 = new Exercise1();
    myExercise1.OutputLiteralTypes();
    myExercise1.ImplicitConvertDataType(250, 30_000, 2_000_000_000);
    myExercise1.ExplicitConvertDataType(1.7E+8, 998_287.268F, 5_678_555);
    myExercise1.AssignVariableTypes();
}
