using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { (211+2), (211*3), 211, 35, 220, 50, (2*211+4), 100};

            Console.WriteLine("Program to find the most frequent ocuuring element");
            Console.WriteLine("==================================================");

            if(mostFrequent(arr,arr.Length) == null)
            {
                Console.WriteLine($"There is no Most Frequent Occuring Element in the array");

            }else
            {
                Console.WriteLine($"Most Frequent Occuring Element in the array is {mostFrequent(arr, arr.Length)}");
            }

            Console.Read();
        }

        static int? mostFrequent(int[] arr, int n)
        {

            // Sort the array
            Array.Sort(arr);

            // find the max frequency using
            // linear traversal
            int max_count = 1, res = arr[0];
            int curr_count = 1;

            for (int i = 1; i < n; i++)
            {
                if (arr[i] == arr[i - 1])
                    curr_count++;
                else
                {
                    if (curr_count > max_count)
                    {
                        max_count = curr_count;
                        res = arr[i - 1];
                    }
                    curr_count = 1;
                }
            }

            // If last element is most frequent
            if (curr_count > max_count)
            {
                max_count = curr_count;
                res = arr[n - 1];
            }

            if(res == arr[0] && curr_count == 1)
            {
                return null;
            }

            return res;
        }
    }
}
