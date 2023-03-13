using MyProject.Test_Loop_25Feb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_3_11March
{
    internal class Person //constructor chaining 
    {
        private int Age;
        private string Name;
        private string EyesColour;


        public Person(int theAge) : this(theAge, "", "")
        {
            Age = theAge; //1 para
        }

        public Person(int theAge, string theName) : this(theAge, theName, "")
        {
            Age = theAge;  //2 para
            Name = theName;
        }

        public Person(int theAge, string theName, string theEyesColour)
        {

            Age = theAge;   //3 para
            Name = theName;
            EyesColour = theEyesColour;
        }

    }
    /*class Main(){
        Person p = new Person();
        Age.
*/

}

