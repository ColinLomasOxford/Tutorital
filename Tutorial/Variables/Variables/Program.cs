using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // first thing: to run a program, either hit the play button or F5. In the following, you need hit return at the end of the
            // program as I've put a readline in which kind of halts things until it gets a response. It's good to see the results before
            // they disappear - you'll see the results in the Terminal window (i'll show you this). If you get in a mess, just hit the stop button and that will reset things.

            // this is a comment - it doesn't do anything apart from tell people what you're doing

            // to define a variable you do: 'type variable_name' so 'int a' defines a variable called a as a type int - then give it a value
            int a;
            a = 0;

            Console.WriteLine("a) a = " + a);

            // to define a variable and give it a value straight away you can do this:
            int b = 1;

            Console.WriteLine("b) b = " + b);

            // there are quite a few different variable types: int, decimal/double/float (similar, we'll discuss later), bool

            // int means integer which means a number with no decimal places such as -1, 1, 3, 45 not 1.34

            // int c = 3.14; won't work (won't compile to be exact but we'll talk about that soon) for instance (try it),
            // but you can try and give an int the result of a division which will give a
            // floating number (one with decimal places) - 22/7 is about pi so see what this gives you:
            int c = 22 / 7;
            Console.WriteLine("c) c = " + c);

            // what did that give? 3. huh? that's because it tried to put 3.142... into an int but couldn't so just
            // rounded it to 3. If you want to do something like that then you need to think about what the result
            // of the division is going to give you. a double type lets you have decimal places:
            
            double d = 22 / 7;
            Console.WriteLine("d) d = " + d);

            // so this shows you how important the type of a variable is. Imagine accidentally rounding up the size of a bridge or every
            // penny in a billion financial trades!

            // you can also use variables to give other variables values. so (just look at how e and f are used in each line below):

            int e = 22;
            int f = 7; 

            double g = e / f;               // divide e by f (22/7) and put it in g;
            int h = e + f;                  // add e to f (22 + 7) and put it in h
            int i = (e * 2) + (f * 3);      // you can do whatever you want with them
            Console.WriteLine("g) g = " + g);
            Console.WriteLine("h) h = " + h);
            Console.WriteLine("i) i = " + i);

            // now play around with some different things. just bear in mind you can't define another variable with
            // the same name again (you can in certain instances, but we'll come to that later), so any new stuff you try,
            // give the variable a new name - it can be a single letter like we've done here or 'int carter' 'int fartypants', etc
            // there are some rules though which you'll proabbly find out as you go (for instance you can't call a variable a number like '1'

            // ok, now you've played around a bit, let's look at another useful variable type: bool
            // bool is short for boolean and can only be set to true or false. you'd think that's a bit useless but it's really useful
            // when you want to say whether to do something or not. Have I hit a baddie? Have I collected the coin? You could use an int and
            // just use 1 or 0, and that's ok, but bool is better for a few reasons which i'll explain later.

            bool isMarioDead = true;
            Console.WriteLine("isMarioDead) isMarioDead = " + isMarioDead);

            bool isLuigiDead = false;
            Console.WriteLine("isLuigiDead) isLuigiDead = " + isLuigiDead);

            // what do you think would happen if you tried to set a bool variable to, say, 4? Think about it then try it out?

            // Ok, booleans and numbers done. What about words? In computer programming we call words strings. And C# has loads and loads
            // of stuff for strings but the most simple is the string type:

            string myName = "Colin";
            Console.WriteLine("myName) myName = " + myName);

            // Very similar to everything we've done before. the only difference is that we put the string in double quotes (") because
            // we could have a string with a space in it, which would cause problems in the program (string myName = colin lomas and stuff;)
            // rather than string myName = "colin lomas and stuff");

            // you can add strings together (called concatenation) in a similar way to numbers:

            string yourName = "Carter";
            string mumName = "Caroline";
            string bothName = yourName + mumName;
            Console.WriteLine("bothName) bothName = " + bothName);

            // and that's it for the basics of variables. One thing that i will mention that we'll cover much more in the future is that
            // you can convert one variable type to another, as long as it makes sense, in this case using the Parse method. Try and change this so
            // that the number variable is something like 'bob' and see what happens.

            string number = "1";
            int number1 = Int32.Parse(number);
            Console.WriteLine("number1) number1 = " + number1);

            Console.ReadLine();



        }
    }
}
