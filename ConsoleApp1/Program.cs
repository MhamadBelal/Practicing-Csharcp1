using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
     //   public static int y = 77;                      //example           2
        static void Main(string[] args)
        {

            /*
              Boolean f = false;            //I can say bool or Booleanint i =10;
                float c = 2.6f;    //here we put f sign to know that this is float varaible 
                double d=5468.55;
               int i=10;
                string s1;
                //   d = i;            //double can take anything smaller than him
                //  d=c;                  //double can take anything smaller than him
                i = (int)d;             //how to convert double to int 
                s1 =d.ToString();          //how to convert to string
                int h = 87;
                 char j=(char)h;
            char e1 = 'L';
           int z = Convert.ToInt32(e1);    //we even can say // int f=(int)e1;
           int m = 10;
           string r =m.ToString();
                Console.WriteLine(r);
                Console.WriteLine(i);
                Console.WriteLine(s1);
                Console.WriteLine(c);
                Console.WriteLine(z);
                Console.WriteLine(j);
           */

            /* 
              string s = "saaed";
                string st = "ali";
                Console.WriteLine(s.Equals(st));   //that means if it is the same print true and if it is wrong print false
            */

            /*
             var x = new {name="saad",address="yamen" , app=10};
             Console.WriteLine(x.name);
            */

            /*
             var x = 9.4;
             var y = 10;
             var c = 9;
             var g = y + c;
             var v = (float)y + x;  //we also can say double 
             int i = (int)x;
             int p = (int)y;
             int z = p + i;     //we can not make a math operations on var varaible berfore converting them o determine what they are
             Console.WriteLine(z);
             Console.WriteLine(g);
             Console.WriteLine(v);
            */

            /*
               int a = 10;
               int b = 9;
               Console.WriteLine(a > b ? a : b);
            */

            /*
            string s1 = "saaed ahmed";
            string s2 = "dema ali";
            Console.Write("{1}  ....  {0}\n",s1 ,s2);
            */

            /*
             int s;        
             s = Console.Read();    //Console.Read takes anything from thg user then print the ASCII code for the input
                                    //we can make it take A and print 65 while we define s by integer
             Console.Write(s);
             */

            /*   
           char n;
           n =(char) Console.Read();  //but here it is gonna print the same char
           Console.WriteLine(n);
           */

            /*
            string num1, num2;
            int result;
            int x;
            num1= Console.ReadLine();
            num2= Console.ReadLine();
            x = Int32.Parse(Console.ReadLine());   //or we can say //x = int.Parse(Console.ReadLine());//
            int s1 =Int32.Parse(num1);
            int s2 = Int32.Parse(num2);
            result = s1 + s2;
            Console.WriteLine(result);
            Console.Write(x);
            */

            /*
            string s = "saaed salem";
            for (int i = 0; i < s.Length; i++)
                Console.WriteLine(s[i]);
            */

            /*
            for (; ; )                                    //infinite loop
                Console.WriteLine("welcome");
            */

            /*
            int t1 = 0, t2 = 0, t3 = 1;     //fibonacci series's example
            for(int i=0;i<8;i++)
            {
                Console.Write(t3 + " ");
                t2 = t1;
                t1 = t3;
                t3 = t1 + t2;
            }
            */

            /*
            string[] a = new string[5];
            for (int i = 0; i<a.Length; i++)
                a[i] =Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(a.Max());
            Console.WriteLine();
            Array.Sort(a);
            for (int i = 0; i < a.Length; i++)
                Console.WriteLine(a[i]);
            */


            /*
            int x = 4, y = 4, z = 8;
            Console.WriteLine("x= {0} , y= {1}", y, z);
            Console.WriteLine("x= {0,4} , y= {1,2}", y, z);    //here the second number is for space
            */



            /*
            string[] a = new string[] { "mohammed", "Ali", "Omer", "Saad"};
            string s = "SAad";
            Boolean f = false;
            for (int i = 0; i < a.Length; i++)
                if (a[i].ToUpper().Equals(s.ToUpper()))
                    f = true;
            if (f)
                Console.WriteLine("found");
            else
                Console.WriteLine(" Not found");
            */

            /*
            string[,] a = new string[4,4];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    if (i == 0 || (i + j == 3) || i == 3)
                        a[i, j] = "*";
                    else
                        a[i, j] = null;     //null means there is nothing in here ,while " " means a character ....note:null does not give enough space like " "
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write(a[i, j] +" ");
                Console.WriteLine();
            }
            */

            /*
            int[] n = new int[] {1,2,3,4,5};
            foreach (int i in n)
                Console.WriteLine(i);
            Console.WriteLine();
            string s = "saaed salem";
            foreach (char i in s)
                Console.WriteLine(i);
            */

            /*
            try
            {
                int x = int.Parse(Console.ReadLine());
                int r = x / 0;
            }
            catch(System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */

            /* 
             int x;
             try
             {x = int.Parse(Console.ReadLine());}
             catch
             {}
             finally                //finally it accure wether a wrong happend or not in try/catch.....note:you have the right to make finally or not while catch is important after try
             {x = 0;}
             Console.WriteLine(x);
             */

            /*
            string n = Console.ReadLine();                 example       1
            try
            {
                print_throw(n);
            }
            catch(System.Exception e)
            {
                Console.WriteLine(e);
            }
            */

            //another way to the above example
            /* string n = Console.ReadLine();     
             try
             {
                 if (n == "")
                     throw new Exception("you enter null value");   //throwing an exeption should be in try
                 Console.WriteLine(n);
             }
             catch (System.Exception e)
             {
                 Console.WriteLine(e);
             }*/

            /*
            int y = 10;                            example        2
            Console.WriteLine(y);
            Console.WriteLine(Program.y);
            */

            /*
            List<int> A = new List<int>();          //here we havenot the choise to define the size of the list 
            List<int> B = new List<int>();
            A.Add(5);
            A.Add(3);
            A.Add(9);
            A.Add(4);
            foreach (int i in A)
                Console.Write(i + " ");
            Console.WriteLine();
            A.Sort();
            B.AddRange(A);                //used to copy one list to another
            A.ForEach(i => Console.Write(i+"  "));      //another way to use foreach ....it is specifically for lists
            Console.WriteLine();
            B.ForEach(i => Console.Write(i+"  "));
            Console.WriteLine();
            A.Insert(2, 15);        //to add an element in a specific location
            A.ForEach(i => Console.Write(i + "  "));
            Console.WriteLine();
            A.Reverse();
            A.ForEach(i => Console.Write(i + "  "));
            Console.WriteLine();
            A.Clear();      //to delte all the element in the list
            A.ForEach(i => Console.Write(i + "  "));
            Console.WriteLine();
            if (B.Contains(9))           //to search about a specific value.....and it returns a bollean number
                Console.WriteLine("found");
            else
                Console.WriteLine("not found");
            */

            /*
            ArrayList A = new ArrayList();          //here in arraylist we have not to define the size and the type
                                                    //the same function we use with list we can use it with arraylist
            A.Add(5);
            A.Add('a');
            A.Add("here");
            A.Add(9);
            A.Add(4.76);
            foreach (var i in A)         //we said var becuase it hase multiple types within it
                Console.Write(i+"  ");
            Console.WriteLine();
            */

            /*
            ArrayList B = new ArrayList();          //example             3
            B.Add(9);
            B.Add(4);
            B.Add(6);
            B.Add(7);
            B.Add(1);
            sort_array_list(B);
            foreach (var i in B)        
                Console.Write(i + "  ");
            Console.WriteLine();
            */


            /*
            SortedList A = new SortedList();   //it is simaliar to arraylist..there is no need to define the data type
            A.Add(1, "ahmed");        //the first value is for key and the second id for value
            A.Add(2, 's');             //the key sould not be repearted
            A.Add(7, 5.7);
            for(int i = 0; i < A.Count; i++)
                Console.WriteLine("{0}  ,  {1}",A.GetKey(i).ToString(),A.GetByIndex(i));
            foreach(DictionaryEntry i in A)      //dictionaryentry is simalir to var....but here we use dictionaryentry because we have two values(key,value)
                Console.WriteLine("{0}  ,  {1}", i.Key.ToString(),i.Value);
            */


            /*
              Dictionary<int, string> A = new Dictionary<int, string>();                           //it is aimliar to storedlist....but here we need to dfine the data type for the key and the value
              A.Add(1, "Ahmed");
              A.Add(9, "Belal");
              A.Add(3, "Khaled");
            foreach (KeyValuePair<int, string> i in A)                            //keyvaluepair is the word read the data from dictioanry
                Console.WriteLine(i);        //it prints [key, value]
            foreach (KeyValuePair<int, string> i in A)
                Console.WriteLine("{0}  , {1}",i.Key,i.Value);
            foreach (var i in A)
                Console.WriteLine("{0}  , {1}", i.Key, i.Value);

            Console.WriteLine();
            if (A.ContainsKey(3))         //the search is wether by key or by value
                Console.WriteLine("found"); 
            else
                Console.WriteLine("not found");
            if (A.ContainsValue("Belal"))
                Console.WriteLine("found");
            else
                Console.WriteLine("not found");

            Console.WriteLine();
            Boolean f = true;                        //another example for search
            Console.Write("enter a value to search for: ");
            string x = Console.ReadLine();
            foreach(var i in A)
            {
                if (i.Value.Equals(x))
                {
                    Console.WriteLine("the value is found");
                    Console.WriteLine("{0}  ,  {1}",i.Key,i.Value);
                    f = true;
                    break;
                }
            }
            if (f == false)
                Console.WriteLine("the value s not found");

            Console.WriteLine();
            foreach (var i in A.OrderBy(key => key.Value))     //example to order the dictionary whether bu key or value
                Console.WriteLine("key:{0},{1}", i.Key,i.Value) ;
            Console.WriteLine();
            foreach (var i in A.OrderBy(key => key.Key))
                Console.WriteLine("key:{0},{1}", i.Key, i.Value);

            Console.WriteLine();
            Dictionary<int, string> B = new Dictionary<int, string>(A);     //to copy one dictionary to another
            foreach (var i in B)
                Console.WriteLine("{0}  , {1}", i.Key, i.Value);

            Console.WriteLine();
            A.Remove(9);                  //to delte data from dictionary
            foreach (var i in A)
                Console.WriteLine("{0}  , {1}", i.Key, i.Value);

            Console.WriteLine();
            Dictionary<int, string> C = new Dictionary<int, string>()    //another way to make add to dictionary
            {
                {1,"ahmed" },{6,"belal"},{3,"karem"}
            };
            foreach (var i in C)
                Console.WriteLine("{0}  , {1}", i.Key, i.Value);
            */


            /*
            //stack adds number to the bottom by push ...and prints number from the top bu pop
            Stack A = new Stack();            //we dont need to define the type and the size for the stack
            A.Push(1);
            A.Push("he");
            A.Push('C');
            A.Push(4.5);
            Console.WriteLine( A.Pop());
            Console.WriteLine(A.Pop());
            Console.WriteLine(A.Pop());
            Console.WriteLine(A.Pop());
            */


            /*
            //queues....it add the values similar to stack.....(from bottom to top)
            //the diferences betwwen the stack and queues that is...stack is open from one side(the top)...while the queues is open from two sides
            //in stack the output happens from the top....but in queuse it output from the bottom
            Queue A = new Queue();
            A.Enqueue(12);
            A.Enqueue("he");
            A.Enqueue('C');
            Console.WriteLine(A.Dequeue());
            Console.WriteLine(A.Dequeue());
            Console.WriteLine(A.Dequeue());
            */

            /*                                 //example       4
            //delegate is apointer that points at functions...the benifit og delegate is that we can call more than one function synchronously and that the calling is safe
            fun A = divid;    //that means delegate points at this function -divid-
            A(10, 5);
            A = product;
            A(10, 5);
            */

            /*
            string a = "saaed";
            string b = "ali";
            int s = string.Compare(a, b);   //it will return 1 if a larger and 0 if they are equal or -1 if b lareger
            int c = a.CompareTo(b);         //anotner way to compare
            Console.WriteLine(s);
            Console.WriteLine(c);
            */

            /*
            string a = "saaed";
            string b = "ali";
            a = a + " "+ b;       //to merge
            string s = string.Concat(a,b);   //aonter way to merge
            Console.WriteLine(a);
            Console.WriteLine(s);
            */


            /*
            string s1 = "Mohammed saaed";
            if (s1.Contains("saaed") == true)    //to search
                Console.WriteLine("found");
            else
                Console.WriteLine("not found");
            */


            /*
            string s1 = "Go To School";
            if(s1.StartsWith("Go")==true)         //to search from the start
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
            if (s1.EndsWith("School") == true)         //to search from the start
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
            */


            /*
            string s1 = "Go To School";
            Console.WriteLine(s1.IndexOf("To"));     //give us the index of the start of the word we are looking for...if it is not found it will return -1
            */


            /*
            string s1 = "Go To School";
            s1=s1.Remove(3);           //to delete parts for a string
            Console.WriteLine(s1);
            string s2 = "Go To School";
            s2 = s2.Remove(3, 3);
            Console.WriteLine(s2);
            */


            /*
            string s1 = "Go To School";
            s1=s1.Replace("To","For");
            Console.WriteLine(s1);
            string s2 = "Go% %To% Sc%hoo%l";
            s2 = s2.Replace("%", "");
            Console.WriteLine(s2);
            */


            /*
            string s1 = "";
            if (string.IsNullOrEmpty(s1))
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
            */


            /*
            DateTime d = DateTime.Now;
            Console.WriteLine(d.ToString());
            Console.WriteLine(d.ToString("dd/mm/yyyy"));
            Console.WriteLine(d.ToString("dd/mm/yy"));
            Console.WriteLine(d.ToString("HH:MM:ss"));
            */


            /*
            DateTime d = new DateTime();
            string s = "21/08/2018";
            d = DateTime.Parse(s);
            Console.WriteLine(d.ToString("dd-MM-yyyy HH:MM:ss"));
            Console.WriteLine(d.Year);
            Console.WriteLine(d.Month);
            Console.WriteLine(d.Day);
            Console.WriteLine(d.Hour);
            */


            /*
            DateTime d = DateTime.Now;
            Console.WriteLine("enter your birthday");
            int n = int.Parse(Console.ReadLine());
            int n1 = d.Year-n;
            Console.WriteLine(n1);
            */



            /*
            DateTime d1 = new DateTime();
            DateTime d2 = new DateTime();
            d1 = DateTime.Parse("01/01/2018");
            d2 = DateTime.Parse("03/03/2018");
            Console.WriteLine(d1 < d2);
            Console.WriteLine(d2.Subtract(d1).TotalDays);
            Console.WriteLine(d2.Subtract(d1).TotalSeconds);
            */


            /*
            try
            {
                StreamWriter sw = new StreamWriter(@"C:\C#\c#.txt");
                sw.WriteLine("hello world");
                sw.Close();
            }
            catch { }
            */



            
            try
            {
                StreamReader sw = new StreamReader(@"C:\C#\c#.txt");
                string s;
                while ((s = sw.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            catch { }
            



            Console.ReadKey();
        }

        /*                //example 1
        static void print_throw(string s)
        {
            if (s == "")
                throw new Exception("you enter null value");
            Console.WriteLine(s);
        }
        */


        /*
        public static void sort_array_list(ArrayList x)                example     3
        {
            x.Sort();
        }
        */



        /*
        public delegate void fun(int var1,int var2);               //example         4
        public static void divid(int x,int y) { Console.WriteLine(x / y); }
        public static void product(int x, int y) { Console.WriteLine(x * y); }
        */
    }
        
}
