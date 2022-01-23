using System; 
class Program
    {
        static void Main(string[] args)
        { 
            int[] arr;
          int len;
           Console.WriteLine("Enter length of Array");
           len=Convert.ToInt32(Console.ReadLine());
           arr=new int[len];
           Console.WriteLine("Enter array element");
           for(int i=0;i<len;i++)
             arr[i]=Convert.ToInt32(Console.ReadLine());
            int t; 
            for (int i = 0; i <= arr.Length - 2; i++)
            {
                for (int j = 0; j <= arr.Length - 2; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        t = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = t;
                    }
                } 
            }
            foreach (int aa in arr)       
            Console.Write(aa + " "); 
            Console.Read();
        }
    } 