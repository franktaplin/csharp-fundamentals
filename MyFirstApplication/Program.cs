using MyFirstApplication;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// The below statement calls a local function
// single line comment

// BottlesOfBeer bottles = new BottlesOfBeer();
// bottles.LetsSing();

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
// Lesson5Example();
// Lesson6Example();
// Lesson7Example();
// Lesson8Example();
// Lesson9Example();
// Lesson10Example();
// HouseUpdated();
// Lesson11Example();
// Lesson12Example();
// CondoExample();
// Lesson13Example();
// Lesson14Example();
// Lesson15Example();
// Lesson16Example();

// Lesson 16 Example
void Lesson16Example()
{
    Lesson16 myLesson16 = new Lesson16();
    // myLesson16.MyListExample();
    myLesson16.MyDictionaryExample();
}

// Lesson 15 Example
void Lesson15Example()
{
    Lesson15 myLesson15 = new Lesson15();
    // myLesson15.EnumExample();
    string flavor = myLesson15.FavoriteIceCream(IceCreamFlavors.Chocolate);
    // Console.WriteLine(flavor);
    // myLesson15.TupleExample();
    (int val1, int val2, int val3) = myLesson15.TupleReturnExample(11, 35);
    Console.WriteLine($"Answers are {val1}, {val2}, {val3}");
}

// Lesson 14 Example
void Lesson14Example()
{
    Lesson14 myLesson14 = new Lesson14();
    // myLesson14.SingleIntArray();
    // myLesson14.SingleHouseArray();
    // myLesson14.MultiintArray();
    // myLesson14.MultiStringArray();
    myLesson14.JaggedArraySample();
}

// Lesson 13 Example
void Lesson13Example()
{
    Lesson13Derived myLesson13 = new Lesson13Derived(3);
    int total1 = myLesson13.ConvertFeetToInches();
    int total2 = myLesson13.ConvertYardsToFeet();
    Console.WriteLine($"Converting feet to inches {total1}");
    Console.WriteLine($"Converting yard to feet {total2}");

    // these are from the interface
    int total3 = myLesson13.ConvertMilesToYards();
    Console.WriteLine($"Converting miles to yards {total3}");
}

// Condo Example
void CondoExample()
{
    Condo myCondo = new Condo();
    myCondo.Maintenance();
    myCondo.DoorOpenClose();
    Console.WriteLine(myCondo.RoofType);
}

// Lesson 12 Example
void Lesson12Example()
{
    Fruit myFruit = new Fruit();
    myFruit.EatFruit();
    myFruit.EatFruit(3);

    Apple myApple = new Apple();
    myApple.EatFruit();

}

// Lesson 11
void Lesson11Example()
{
    Square square = new Square();
    double total = square.CalculateInteriorAngle();
    Console.WriteLine(total);

    Triangle triangle = new Triangle();
    double total2 = triangle.CalculateInteriorAngle();
    Console.Write(total2);
}

void HouseUpdated()
{
    // Calling Default
    House myHouse = new House();
    Console.WriteLine(myHouse.RoofType);
    myHouse.DoorOpenClose();

    // Calling Constructor with 2 parameters
    House mySecond = new House("straw", "bamboo");
    Console.WriteLine(mySecond.WindowSize);
    mySecond.DoorOpenClose();

    // Calling Constructor with 4 parameters
    House myThird = new House("dirt", "plastic", "green", 40);
    Console.WriteLine(myThird.Foundation);
    myThird.DoorOpenClose();
}

// Lesson 10 Examples
void Lesson10Example()
{
    Lesson10 myLesson10 = new Lesson10();

    // Using this to call another constructor
    Console.WriteLine(myLesson10.FirstName);

    // Normal property
    myLesson10.FirstName = "Paul";
    Console.WriteLine(myLesson10.FirstName);

    // Calling auto Property
    // myLesson10.LastName = "Smith"; // only works in LEsson10 constructor
    Console.WriteLine(myLesson10.Id); // default value
    myLesson10.Id = 1500;
    Console.WriteLine(myLesson10.Id); // get 1500

    // Expression Body Property
    myLesson10.Address = "123 Main St.";
    Console.WriteLine(myLesson10.Address);

    // Second constructor
    Lesson10 MyOther10 = new Lesson10("Ben", "Franklin", 64119);
    Console.WriteLine(MyOther10.Zipcode);
}

// Lesson 9 Examples
void Lesson9Example()
{
    Lesson9 myLesson9 = new Lesson9();
    Lesson9.Nested nested = new Lesson9.Nested(myLesson9);

    // Access Modifiers
    myLesson9.SampleInternal();
    myLesson9.SampleProtectedInternal();
}

// Lesson 8 Examples
void Lesson8Example()
{
    Lesson8 myLesson8 = new Lesson8(3);
    // Calling constant directly
    Console.WriteLine(Lesson8.DaysPerMonth);

    // Calculate Temperature
    Console.WriteLine(Lesson8Static.CelsiusToFahrenheit(45.6));

    // Static Methods
    Lesson8.DayCount = 10;
    myLesson8.CalculateHours();
    Lesson8.CalculateDayCount();
    Console.WriteLine($"The calculation has been done {Lesson8.DayCount} times");

    // Static lambda
    myLesson8.CalculateHoursV2();
}

// Lesson 7 Examples
void Lesson7Example()
{
    Location myLocation = new Location(34.5, 47.8);
    Console.WriteLine(myLocation.Latitude);
    Console.WriteLine(myLocation);

    // Readonly Struct
    Student myStudent = new Student(10, "Roger");
    Console.WriteLine(myStudent);
    Console.WriteLine(myStudent.StudentName);

    // Record
    Person person = new Person("Nancy", "Drew");
    Console.WriteLine(person);
    Console.WriteLine(person.lastName);

    // Struct Record
    Resolution res = new Resolution(1920, 1080);
    res.CalculateRes();
    Console.WriteLine(res);
}

// Lesson 6 Examples
void Lesson6Example()
{
    // default constructor
    Lesson6 myLesson6 = new Lesson6();
    Lesson6 myLessonHats = new Lesson6("Cowboy", 7);
    Lesson6.TryOn theHat = myLessonHats.TryOnHat;
    theHat($"I tried on a {myLessonHats.HatType} hat that was size {myLessonHats.HatSize}");

    Console.WriteLine();

    // constructor with 1 parameter
    Lesson6 myOther6 = new Lesson6(22);

    // constructor with 2 parameters
    Lesson6 myHats = new Lesson6("Cowboy", 7);
    Console.WriteLine(myHats.HatSize); // getting value
    myHats.HatSize = 6; // setting value

    // Method for parameter Modifiers
    int able = 33, beta = 22, charlie;
    myLesson6.InExample(able);
    myLesson6.RefExample(ref beta);
    Console.WriteLine(beta);
    myLesson6.OutExample(out charlie);
    Console.WriteLine(charlie);

    Console.WriteLine();

    // Multi-cast Delegate
    Lesson6.TryOn theNewHat, hangTheHat, multiHat;

    theNewHat = myLesson6.TryOnHat;
    hangTheHat = myLesson6.HangUpHat;
    multiHat = theNewHat + hangTheHat;

    theNewHat($"Trying a {myLessonHats.HatType} hat");
    hangTheHat($"Hanging up my {myLessonHats.HatType} hat");
    multiHat($"My {myLessonHats.HatType} hat");
}

// Lesson 5 Expressions & Pattern matching
void Lesson5Example()
{
    Lesson5 myLesson5 = new Lesson5();

    // Call method of myLesson5
    // myLesson5.IsOperatorExample(34);

    // Instantiate delegate
    Lesson5.Del handler = myLesson5.DelegateMethod;
    // handler("Hello CSharp");

    //  Func delegate
    Func<int, int> add = myLesson5.Sum;
    // Console.WriteLine($"func example = {add(23)}");

    // Lambda Expression
    // myLesson5.LambdaSquare();
    // myLesson5.LambdaGreeting();

    // Switch Expression
    string value1 = myLesson5.BasicSwitch("red");
    // Console.WriteLine(value1);
    string value2 = myLesson5.FavoriteColor("green");
    // Console.WriteLine(value2);

    // Relational Pattern
    // myLesson5.DrinkSize(33);

    // Logical Patterns
    myLesson5.TemperatureGuide(48.6);
    myLesson5.NumberChoice(3);
}

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
// Exercise4Test();
// Exercise5Test();
// Exercise6Test();
// Exercise7Test();
// Exercise8Test();
// HorseTest();
// BoatTest();
// ArabianTest();
// LongBoatTest();
// Horse2Test();
// Arabian2Test();
// Boat2Test();
// LongBoat2Test();
// Exercise13Test();
// Exercise14Test();
// Exercise15Test();
Exercise16Test();

// Exercise 16 Test
void Exercise16Test()
{
    Exercise16 myExercise16 = new Exercise16();
    // myExercise16.HorseList();
    myExercise16.FavoriteMovieDict();
}

// Exercise 15 Test
void Exercise15Test()
{
    Exercise15 myExercise15 = new Exercise15();
    string movie = myExercise15.FavoriteMovieSwitch(FavoriteMovies.BluesBrothers);
    Console.WriteLine(movie);
    Console.WriteLine(myExercise15.FavoriteMovieTuple(FavoriteMovies.Aliens));
}

// Exercise 14 Test
void Exercise14Test()
{
    Exercise14 myExercise14 = new Exercise14();
    myExercise14.IceCreamArray();
    myExercise14.ChiefsScoresArray();
}

// Exercise 13 Test
void Exercise13Test()
{
    WaterBirdsDerived myWaterBird = new WaterBirdsDerived(30);
    myWaterBird.FlightSpeed();
    Console.WriteLine(myWaterBird.BirdName());
}

// Long Boat Test for Exercise 12
void LongBoat2Test()
{
    LongBoat myLongBoat = new LongBoat();
    myLongBoat.SetSail();
}

// Boat Test for Exercise 12
void Boat2Test()
{
    Boat myBoat = new Boat();
    myBoat.SetSail();
    myBoat.SetSail("steel");
}

// Arabian class for Exercise 12
void Arabian2Test()
{
    Arabian myArabian = new Arabian();
    myArabian.Gallop();
}

// Horse class for Exercise 12
void Horse2Test()
{
    Horse myHorse = new Horse();
    myHorse.Gallop();
    myHorse.Gallop(650);
}
// LongBoat class for Exercise 11
void LongBoatTest()
{
    LongBoat myLongBoat = new LongBoat();
    Console.WriteLine(myLongBoat.DraftDepth);
    Console.WriteLine(myLongBoat.KeelLength);
    Console.WriteLine(myLongBoat.HullMaterial);
    Console.WriteLine(myLongBoat.NumberOfOars);
    Console.WriteLine(myLongBoat.Row());
}

// Arabian class for Exercise 11
void ArabianTest()
{
    Arabian myArabian = new Arabian();
    Console.WriteLine(myArabian.Weight);
    Console.WriteLine(myArabian.Height);
    Console.WriteLine(myArabian.Sex);
    Console.WriteLine(myArabian.ManeLength);
    Console.WriteLine(myArabian.Trot());
}

// Boat class for Exercise 10
void BoatTest()
{
    Boat myBoat = new Boat();
    Console.WriteLine(myBoat.DraftDepth);
    Console.WriteLine(myBoat.KeelLength);
    Console.WriteLine(myBoat.HullMaterial);
    myBoat.SetSail();
}

// Horse class for Exercise 10
void HorseTest()
{
    Horse myHorse = new Horse();
    Console.WriteLine(myHorse.Weight);
    Console.WriteLine(myHorse.Height);
    Console.WriteLine(myHorse.Sex);
    myHorse.Gallop();
}

// Exercise 8 Test
void Exercise8Test()
{
    Exercise8 myExercise8 = new Exercise8();
    myExercise8.FeetToInches(3);
    Exercise8.AreaOfRectangle(4, 4);
}

// Exercise 7 Test
void Exercise7Test()
{
    Employee myEmployee = new Employee(123, "Frank");
    Console.WriteLine(myEmployee);
    Console.WriteLine(myEmployee.EmployeeId);

    // Boat myBoat = new Boat(125, 35, 25);
    // myBoat.SetSail();
}

// Exercise 6 Test
void Exercise6Test()
{
    Exercise6 myExercise6 = new Exercise6(9, "Hiking Boot");
    Exercise6.TryOn myShoe = myExercise6.ShoeSizeTest;
    myShoe($"I tried on a size {myExercise6.ShowSize} {myExercise6.ShoeType}.");

}

// Exercise 5 Test
void Exercise5Test()
{
    Exercise5 myExercise5 = new Exercise5();
    Console.WriteLine(myExercise5.OhmsLawExample(3, 5));
    Console.WriteLine(myExercise5.GradeResultExample('V'));
    myExercise5.PopcornSizeExample(128);
}


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
    Console.WriteLine(myExercise3.ModulusExamples(5));
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

