using System;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter iteration number: ");
        int n = int.Parse(Console.ReadLine());
        System.Console.WriteLine();
        int[] arr = new int[n];
        int max = 0;
        int i = 0;
        while(i<n)
        {
            System.Console.Write($"Array[{i}]: ");
            arr[i] = int.Parse(Console.ReadLine());
            System.Console.WriteLine();
            if(max<arr[i]) max = arr[i];
            i++;
        }
        System.Console.WriteLine(max);

        int j=max; //5
        while(j>0) 
        {
            int k=0; 
            while(k<n)
            {
                if(arr[k]>=j) System.Console.Write("* ");
                else {
                    System.Console.Write("  ");
                }
                k++;
            }
            System.Console.WriteLine();
            j--;
        }
    }
}