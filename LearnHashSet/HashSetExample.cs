using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnHashSet
{
    public class HashSetExample
    {


        public void HashSetInteger()
        {

            HashSet<int> temp = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            temp.Add(11);
            temp.Add(12);
            temp.Add(13);

            temp.RemoveWhere(r => r % 2 == 0);

            Console.WriteLine($"Total number of elements {temp.Count}");

            foreach (var item in temp)
            {
                Console.WriteLine($"{item}");
            }

            int value=-1;
            temp.TryGetValue(5,out value);
            Console.WriteLine($"5 = { value}");

            value = -1;
            temp.TryGetValue(6, out value);
            Console.WriteLine($"6 = { value}");
        }


        public void SetOperationUnionWith()
        {
            HashSet<int> set1 = new HashSet<int>();
            set1.Add(1);
            set1.Add(2);
            set1.Add(3);

            HashSet<int> set2 = new HashSet<int>();
            set2.Add(1);
            set2.Add(2);
            set2.Add(4);

           
            // combine set1 and set2
            // into a distinct, unique single results set
            // set1 = 1,2,3
            // set2 = 1,2,4

            // result = 1,2,3,4

            set1.UnionWith(set2);

        }







        public void SetOperationExceptWith()
        {
            HashSet<int> set1 = new HashSet<int>();
            set1.Add(1);
            set1.Add(2);
            set1.Add(3);
            set1.Add(5);

            HashSet<int> set2 = new HashSet<int>();

            set2.Add(2);
            set2.Add(4);

            // remove all elements from set1 that were in set2
            // into a distinct single results set
            // set1 = 1,2,3,5
            // set2 = 2,4

            // result = 1,3,5

            set1.ExceptWith(set2);

        }















        public void SetOperationIntersectWith()
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5, 6 };

            HashSet<int> set2 = new HashSet<int>();
            set2.Add(2);
            set2.Add(5);
            set2.Add(7);

            // contain only elements in both sets set1 and set2
            // into a distinct single results set
            // set1 = 1,2,3,4,5,6
            // set2 = 2,5,7

            //result = 2,5

            set1.IntersectWith(set2);

        }














        public void IsProperSubsetEx1()
        {
            // remember this, the sets cannot be equal

            HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5, 6 };

            HashSet<int> set2 = new HashSet<int> { 2, 5 };
            

            // are all the elements in set2 in set1
            // AND   set1 != set2
            // set1 = 1,2,3,4,5,6
            // set2 = 2,5


            if (set2.IsProperSubsetOf(set1))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

        }












        public void IsProperSubsetEx2()
        {
            // remember this, the sets cannot be equal

            HashSet<int> set1 = new HashSet<int>();
            
            set1.Add(2);
            set1.Add(5);

            HashSet<int> set2 = new HashSet<int>();

            set2.Add(2);
            set2.Add(5);

            // does set1 contain all elements from set2
            // set1 = set2       it is NOT a proper subset
            // set1 = 2,5
            // set2 = 2,5


            if (set2.IsProperSubsetOf(set1))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

        }









        public void IsSubsetOf()
        {


            HashSet<int> set1 = new HashSet<int>() { 2, 4, 6, 8, 10 };
            HashSet<int> set2 = new HashSet<int>() { 2, 4, 6, 8 };


            // are the values of set2 contained in set1
            // if set1 = set2  then it is NOT a proper subset
            


            if (set2.IsSubsetOf(set1))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            if(set2.IsProperSubsetOf(set1))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

        }





        public void IsSuperSetOf_Ex1()
        {

            HashSet<int> set1 = new HashSet<int>() { 2, 4, 6, 8 };
            HashSet<int> set2 = new HashSet<int>() { 2, 8  };


            // does set2 contain all elements in set1
            // if set1 = set2  then it is NOT a proper subset



            if (set2.IsSubsetOf(set1))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            if (set1.IsSupersetOf(set2))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");


            if(set1.IsProperSupersetOf(set2))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }







        public void IsSuperSetOf_Ex2()
        {

            HashSet<int> set1 = new HashSet<int>() { 2, 8 };
            HashSet<int> set2 = new HashSet<int>() { 2, 8 };


            if (set2.IsSubsetOf(set1))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            if (set1.IsSupersetOf(set2))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");


            // when proper is used, the sets cannot be equal 
            if (set1.IsProperSupersetOf(set2))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }


        

    }
}
