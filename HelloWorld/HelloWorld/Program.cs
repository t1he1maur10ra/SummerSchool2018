                                                        /*--------------Comments--------------*/
//This is a comment, it's not part of the code and will not be executed at runtime. A comment needs to have the "//" at the beginning and can only span 1 line or,

/* a comment can be added between the forwardslash and asterix as they are with this comment. Unlike the "//", these comment can span multiple lines. Comments are
   coloured green in visual studio and are used to add explainations or description to your code and are required for many of the projects we will be doing.*/


                                                        /*----------Using References----------*/
/*These are using references, they are used to add extra functionality to your applications. As you can see with this example the System reference is brighter than the
  others, this is because part of it is currently being used inside the code. The others are faded because no part of them is being used and could potentially be deleted*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


                                                        /*-------------Namespaces-------------*/
//This is a namespace, all of your classes and methods need to be contained within a namespace. Note, there is a dotted line indicating where the 
namespace HelloWorld
{


                                                        /*---------------classes--------------*/
    //This is a class, classes belong inside of a namespace and can contain both variables and methods.
    class Program
    {
           
                                                        /*--------------Methods--------------*/
        //This is a method, methods belong inside of a class. Methods contain the functional code for your application.
        static void Main(string[] args)
        {
                                                        /*---------------code---------------*/
            //This is the actual functional code, this type of code needs to be contained inside of a method for it to execute.
            Console.WriteLine("Hello World!");

        }

    }

}
