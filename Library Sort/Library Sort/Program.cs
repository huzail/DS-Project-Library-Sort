using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;       //initilize integer variable for size of your array
            Console.Write("Enter Size of an Array:  "); //taking size of your list/shelf
            size = Convert.ToInt16(Console.ReadLine());

            int[] arr = new int[size];                      //initilize array/shelf for inserting books/data
            Console.WriteLine("Enter Values in Array");
            for (int i = 0; i < arr.Length; i++)                //using loop for looking every index of array/shelf
            {
                arr[i] = Convert.ToInt16(Console.ReadLine()); //taking user defined values or taking books in library
            }

            project p = new project(arr);     //making object p of class project and pass array arr by constucter
        }
    }

    class project
    {
        public int[] arr1; //array 1 for gaping 
        public int[] arr2;   //array 2 for desire length of list
        private int gap = -1;  //as given in algorithm gap value is -1
        private int search;  //initilize interger variable search for serching position ,this variable use after inserting a new value in                       array or insert new book in shelf
        public project(int[] arr)
        {
            arr1 = new int[(arr.Length * 2) + 1];// double the lenght because of gap 
            arr2 = new int[arr.Length]; //initilize length
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i]; //taking values from arr to arr2
            }
            Console.WriteLine("Values given in arr");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);  //printing data of arr2
            }
            arr2 = insertion_sort();  //calling method of insertion sort because values/books which are given currently are not                                                       sorted thats why we implement insertion sort
            Console.WriteLine("Values after Sorting");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            insertiongap(arr2);   //calling method of insert gap because in library sort we need gap after every value for store                                            a new inserte value in array
            Console.WriteLine("Values of sorted array after gaps");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);   //pring value after sort and after include gaps
            }
            Console.Write("Enter Value to be inserted:  ");   //taking a new number to be inserted in sorted gapped array
            int value = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("After Insertion");

            insertion(value);     //calling a method of insert for insert a new data in our array
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            // printing array aftter inserting a new data but the array isn't in ballance                                               form ,eg: in libray sort we nedd gap after every data value but after inserting a new                                      number in gap ,we need another 2 gap for it ,for this reballancing method works for                                        ballance  the gap in array
            Console.WriteLine("After Rebalancing");
            rebalancing();


        }
        public int[] insertion_sort()  //initilize method of insertion sort ,it is 1st step of our algorithm
        {
            int j = 0;

            for (int i = 0; i < arr2.Length; i++)   //initilize loop for checking each value of array
            {
                int check = arr2[i];
                j = i;
                while (j > 0 && arr2[j - 1] >= check) //nested loop for checking the previous value with i
                {

                    arr2[j] = arr2[j - 1];  //swaping

                    j--;
                }
                arr2[j] = check;  //swapping
            }
            return arr2;  // return final array after sorting
        }

        private int[] insertion(int val)
        {
            for (int i = 0; i < arr1.Length; i++)  //using look for checking every index of array
            {
                if (val < arr1[i])  //condition if new value less than arr[i]then take loocation of its index
                {
                    search = binarysearch(arr1[i]);
                    break; //using break to terminate loop
                }
            }
            if (search == 0)
            {

                int p = arr1.Length;
                arr1[p - 1] = val;
            }
            else
            {
                arr1[search - 1] = val;
            }
            return arr1;  //returning array after inserting new value
        }
        public int[] insertiongap(int[] arr)  //initilize method for insertgap between book
        {
            int j = 0;
            for (int i = 0; i < arr1.Length; i++) //using loop for area spacing in shelf
            {
                if (i % 2 != 0)                     //checking if area/index  have not even value then set book at that place
                {
                    arr1[i] = arr[j];
                    j++;
                }
                else
                {
                    arr1[i] = gap;                 // other wise set gap

                }
            }
            return arr1;   //returning array after gapping
        }
        public int binarysearch(int val)
        {
            int up = arr1.Length, lb = 0, ir = 0;  //initilize method of binary searach for searching best place for new book  up=upper bound of array ,lb=lower bound of array

            int mid_point = (up - lb) / 2; //using formula of mid point
            for (int i = 0; i < 500; i++)
            {
                int mid_point_val = arr1[mid_point];  //getting value of index at middle
                if (val < mid_point_val)  //condition if new value less than midpointvalue then size array become half and mid point of array                         become upper bound
                {
                    up = mid_point;
                    mid_point = (up - lb) / 2;
                }
                else if (val > mid_point_val) //condition if new value less than midpointvalue then size array become half and mid point of array                         become lower bound
                {
                    lb = mid_point;
                    mid_point = (up + lb) / 2;
                }
                else if (mid_point_val == val)  //checking /comparing values
                {
                    ir = mid_point;
                }
            }
            return ir;  //return index


        }

        public void rebalancing()
        {
            List<int> l = new List<int>();  //initilize builinn class of linklist

            l = arr1.ToList();
            if
               (search == 0)  //condition for last index value
            {
                search = arr1.Length - 1;
            }

            //Console.WriteLine("k{0}", k); //changing array arr1 int link list form
            int k = binarysearch(arr1[search]);

            //index where new variable is suitale 
            if(search == arr1.Length - 1)  //condition for last index value
            {
                l.Insert(k + 1, -1);
                l.Insert(k, -1);
            }
            else
            {
                l.Insert(k - 1, -1);  //set index
                l.Insert(k + 1, -1);  //set index
            }

            int[] arr3 = new int[l.Count + 5]; //initilize new array
            arr3 = l.ToArray(); //convert into array
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine("{0}", arr3[i]);  //printing values after reballancing like in library
            }
        }
    }
}