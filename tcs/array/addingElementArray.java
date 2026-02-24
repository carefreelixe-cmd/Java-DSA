package tcs.array;
import java.util.*;
public class addingElementArray {

    public static void AddElemntArray(int []arr,int index,int data)
    {
          //array is fixed size so we nned to create a anew array for adding elemnt
  int [] arr1=new int [arr.length+1];

  for(int i=0;i<index;i++)
  {
    arr1[i]=arr[i];
  }


  arr1[index]=data;

  // so new value added nned to run loop agaun

  for(int i=index;i<arr.length;i++)
  {
    arr1[i+1]=arr[i];
  }

    }

}
