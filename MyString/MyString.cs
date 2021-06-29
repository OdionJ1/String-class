using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CP
{
    public class MyString
    {
        //Created the array of characters property
        private char[] arr = new char[] { };

        //Created the Length property to return the length of the array
        public int Length
        {
            get
            {
                return arr.Length;
            }
        }

        //Created a constructor that takes no argument
        public MyString()
        {

        }

        //Created an 'integer index operator' method that returns the value of the index that was passed in
        public char this[int i]
        {
            get
            {
                return arr[i];
            }
        }

        //Created a constructor that takes an array of characters
        public MyString(char[] a)
        {
            //Assigned the values of the array of characters that was passed in to the
            //char array property
            arr = a;
        }

        public static MyString operator +(MyString a, MyString b)
        {
            //Created a variable to hold the length of 'temp' array
            int tempLength = a.Length + b.Length;

            //Created an array with the aforementioned length
            char[] temp = new char[tempLength];

            //Created a for loop that would loop through the "a" MyString object array property and assign the values to the temp array
            int i;
            for (i = 0; i < a.Length; i++)
            {
                temp[i] = a[i];
            }

            //Created a for loop that would loop through the "b" MyString object array property and assign the values to the temp array
            for (int k = 0; k < b.Length; k++)
            {
                temp[i] = b[k];
                i++;
            }

            //Created a variable of type MyString and passed the temp array into the constructor
            MyString c = new MyString(temp);

            //returned the object
            return c;
        }

        //Created a constructor that takes a character
        public MyString(char a)
        {
            //Stored the character that was passed in a char array
            char[] temp = new char[] { a };

            //Assigned the value in 'temp' to the char array property
            arr = temp;
        }

        //Created the 'ToCharArray' method, which returns the char arr property
        public char[] ToCharArray()
        {
            return arr;
        }

        //Created the 'ToLower' method
        public MyString ToLower()
        {
            //Created an array to hold the converted characters
            char[] temp = new char[arr.Length];

            //Loops through the arr property converting each character to lower Case
            for (int i = 0; i < arr.Length; i++)
            {
                //Checks that the character is in upper case
                if (arr[i] >= 'A' && arr[i] <= 'Z')
                {
                    //Converts the character to lower case using ASCII and assigns to the temp array
                    temp[i] = (char)(arr[i] + 32);
                }
                else
                {
                    temp[i] = arr[i];
                }

            }

            //Created a variable of type MyString and passed the temp array into the constructor
            MyString converted = new MyString(temp);

            //returned the object
            return converted;
        }

        //Created the 'ToUpper' method
        public MyString ToUpper()
        {
            //Created an array to hold the converted characters
            char[] temp = new char[arr.Length];

            //Loops through the arr property converting each character to upper Case
            for (int i = 0; i < arr.Length; i++)
            {
                //Checks that the character is in lower case
                if (arr[i] >= 'a' && arr[i] <= 'z')
                {
                    //Converts the character to upper case using ASCII and assigns to the temp array
                    temp[i] = (char)(arr[i] - 32);
                }
                else
                {
                    temp[i] = arr[i];
                }

            }

            //Created a variable of type MyString and passed the temp array into the constructor
            MyString converted = new MyString(temp);

            //returned the object
            return converted;
        }

        //Overrode the 'Equals' method
        public bool Equals(MyString a)
        {
            //Checks that the length of the arr property in the object are the same
            while (arr.Length == a.Length)
            {
                //Created a for loop to check the values.
                for (int i = 0; i < a.Length; i++)
                {
                    if (arr[i] != a[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        //Created a '==' operator method
        public static bool operator ==(MyString a, MyString b)
        {
            //Called the 'Equals' method
            return a.Equals(b);
        }

        //Created a '!=' operator method
        public static bool operator !=(MyString a, MyString b)
        {
            //Called the 'Equals' method
            return !a.Equals(b);
        }

        //Created a '<' operator method
        public static bool operator <(MyString a, MyString b)
        {
            //Created variables to keep track of my location in the char arr properties when looping
            int i = 0;
            int m = 0;

            //Created a while loop to iterate through and compare the char arr property in the passed in objects
            while (i <= a.Length || m <= b.Length)
            {
                //Returns True if we've reached the end of 'a' while 'b' still has values
                if (i == a.Length && m != b.Length)
                {
                    return true;
                }
                //Returns False if we've reached the end of 'b' while 'a' still has values
                else if (i != a.Length && m == b.Length)
                {
                    return false;
                }
                //Return False if we've reached the end of both 'b' and 'a'
                else if (i == a.Length && m == b.Length)
                {
                    return false;
                }

                if (a[i] < b[m])
                {
                    return true;
                }
                else if (a[i] > b[m])
                {
                    return false;
                }
                else
                {
                    i++;
                    m++;
                }
            }
            return false;
        }

        public static bool operator >(MyString a, MyString b)
        {
            //Called the '<' operator method and the Equals method
            if (a < b == false && a.Equals(b) == false)
            {
                return true;
            }
            return false;
        }

        public static bool operator <=(MyString a, MyString b)
        {
            //Called the '>' operator method
            if (a > b == false)
            {
                return true;
            }
            return false;
        }

        public static bool operator >=(MyString a, MyString b)
        {
            //Called the '<' operator method
            if (a < b == false)
            {
                return true;
            }
            return false;
        }

        //Created the Reverse method
        public IEnumerable<char> Reverse()
        {
            //Created an array to hold the values of the reversed characters
            char[] temp = new char[arr.Length];

            //Looped through the char arr property in reverse, and assigns the values to 'temp'
            int m = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                temp[m] = arr[i];
                m++;
            }

            //Created a variable of type IEnumerable<char>, and assigned the values of temp to it
            IEnumerable<char> temp2 = temp;

            //Returns temp2
            return temp2;
        }

        //Created the Write method to write the values of the char array property on the console
        public void Write()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }
    }


}
