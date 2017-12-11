using System;
namespace algorithms
{ 
public class Sorting
{


// O(n^2)
  public static int[] InsertionSort (int[]  InputArr)
  { 
    int key;
   
   for (int i = 1 ; i<InputArr.Length ;i++)
   {
     key = InputArr[i];
     int j = i-1;
     while (j>=0 && InputArr[j]>key)
     {//shift
       InputArr[j+1] = InputArr[j];

      j--;
     }
     InputArr[j+1] = key;

   }
   return InputArr;
  }

 
  public static void    MergeSort (int[]  InputArr, int p, int r)
  { int q =0;
    if (p<r)
    q = (p+r)/2 ;
    MergeSort(InputArr, p,q);
    MergeSort(InputArr,q+1, r);
    Merge (InputArr, p,q,r);
  }



public static void Merge(int [] InputArr, int p, int q, int r)
{
  int n1 = q-p +1;
  int n2 = r-q ;
  //Create temp arrays
  int[] Right = new int[n2+1];
  int [] Left = new int[n1+1];
  for(int i=0; i<n1; i++)
  {
    Left[i] = InputArr[p+i];
    
  }


}

   
   public static void  PrintArray (int[]  InputArr)
  {  
    for (int i=0 ; i< InputArr.Length; i ++)
     {
       Console.WriteLine(InputArr[i]);
     }
      
  }


}
  
}

