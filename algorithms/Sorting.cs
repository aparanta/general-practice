using System;
namespace algorithms
{ 
public class Sorting
{


// O(n^2)
  public static void    InsertionSort (int[]  InputArr)
  { 
    int key;
    for (int j=2 ; j< InputArr.Length; j ++)
     {
       key = InputArr[j] ;      
       int i= j-1;
       while (i>=0 && InputArr[i]>key)
       {
       InputArr[i+1]= InputArr[i];
         i--;
       }
     InputArr[i+1]=key;
       
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

