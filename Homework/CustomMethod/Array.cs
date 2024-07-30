using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System;

public static class Array
{
    public static void CustomResize<T>(ref T[] array, params T[] newElement)
    {
        int arrLength = array.Length;
        int newLength = arrLength + newElement.Length;
        T[] newArray = new T[newLength];

        for(int i = 0 ; i < arrLength; i++ )
        {
            newArray[i] = array[i];
        }
        for (int i = 0; i < newElement.Length; i++)
        {
            newArray[i + arrLength] = newElement[i];
        }
        array = newArray;

    }

}
