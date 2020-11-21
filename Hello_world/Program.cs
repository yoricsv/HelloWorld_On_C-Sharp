/*
  *****************************************************************************************
  *                                     It's C# Code                                      *
  *****************************************************************************************
  *****************************************************************************************
  *                             The PREPROCESSOR DIRECTIVEs                               *
  *****************************************************************************************
  * USING (the preprocessor directive) - addict access to the methods and classes from    *
  * other namespaces;                                                                     *
  *---------------------------------------------------------------------------------------*
  * USING STATIC [_each_other_namespace_] - copy in program all methods, features and     *
  * constants. EXP: using static System; In place where we should access to method from   *
  * the namespace, we don't need to write full adress.                                    *
  * EXP: Insted Console.Writeline(); we can write only WriteLine();                      *
  *****************************************************************************************
  * SYSTEM - name of namespace we must use if we wanna have access to features of console *
  *          or other                                                                     *
  * SYSTEM.COLLECTIONS.GENERIC - namespace consist of interfaces and classes for creation *
  *                              strictly typification collections (EXP: Arrays, Task     *
  *                              manager and etc.)                                        *
  * SYSTEM.LINQ -                                                                         *
  * SYSTEM.TEXT -                                                                         *
  * SYSTEM.THREADING.TASKS -                                                              *
  *****************************************************************************************
*/
// USING CODE BEGIN //
using System;
// USING CODE END //
/*
  *****************************************************************************************
  * NAMESPACE - is a namespace of our project where we will be create our methods,        *
  * classes, objects and then they can operate with each other                            *
  * In here, is like an analogue of USING directive (see above).
  * There's HELLO_WORLD - is a name of NAMESPACE where our methods, variables and etc.    *
  * will be operate and be visible. Anywhere else to them don't be access (except here)!  *  
  *****************************************************************************************
*/
// OUR NAMESPACE AREA BEGIN //
namespace Hello_world
{
/*
  *****************************************************************************************
  * EACH program MUST have don't less than one MainClass contained a STATIC MAIN function *
  * There's PROGRAM - is a name of MainClass that contain MAIN function                   *
  *****************************************************************************************
*/
  // CLASS DEFINITIONS BEGIN //
  class Program
  {
/*
  *****************************************************************************************
  *                                  The MAIN function                                    *
  *****************************************************************************************
  * STATIC or PUBLIC                                                                      *
  * STATIC - include in program all methods, features and constants                       *
  * PUBLIC - give access to all classes and methods into the function                     *
  *---------------------------------------------------------------------------------------*
  * MAIN - the major function in program (Start point of program)                         *
  * VOID - data type that function should be return after operating (nothing return)      *
  * ( ... ) - there is write everything we wanna take to the function                     *
  * ARGS - name of array. (Show that Main function might get some values throw array)     *
  * STRING[] - is a data type of array (contains string values of data).                  *
  *****************************************************************************************
*/
    // MAIN FUNCTION BEGIN //
    static void Main(string[] args)
    {
      // CODE/INSTRUCTIONS BEGIN //
/*
  *****************************************************************************************
  * For access to features of console we should write a full "address" name where the     *
  * class is located.                                                                     *
  * EXP:   System.Console.Write("Hello World \n");                                        *
  * WHERE: SYSTEM          - is a namespace,                                              *
  *        CONSOLE         - is a class,                                                  *
  *        WRITE/WRITELINE - is a method of class                                         *
  *---------------------------------------------------------------------------------------*
  * WRITE     - is a method displayed our information in console.                         *
  * WRITELINE - the same as previous, but include end line escape consequence in the end  *
  *             of a string.                                                              * 
  *****************************************************************************************
*/
            Console.Write("Hello World	\n");
            Console.WriteLine("Привет, Мир!");

      // CODE/INSTRUCTIONS END //
    }
	// MAIN FUNCTION END //
  }
  // CLASS DEFINITIONS END //
}
// OUR NAMESPACE AREA END //

