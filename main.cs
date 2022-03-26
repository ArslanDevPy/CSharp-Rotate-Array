using System;

class ArrayRotate{
    static void RotateLeft(int[] arr, int d,int n)
    {
        for (int i = 0; i < d; i++)
            {
                RotateLeftbyOne(arr, n);
            }
    }

    static void RotateLeftbyOne(int[] arr, int n)
    {
        int i, temp = arr[0];
        for (i = 0; i < n - 1; i++)
        {
            arr[i] = arr[i + 1];
        }
        arr[n-1] = temp;
    }

    static void RotateRight(int[] arr, int d,int n)
    {
      	for (int i = 0; i < d; i++) {
          	RotateRightbyOne(arr, n);
        }
    }

    static void RotateRightbyOne(int[] arr, int n)
    {
      	int last = arr[n - 1];
        for (int i = n-2; i >= 0; i--) {
            arr[i + 1] = arr[i];
    	}
	    arr[0] = last;
    }

    static void printArray(int[] arr, int size)
    {
        for (int i = 0; i < size; i++)
        Console.Write(arr[i] + " ");
    }

    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int size = arr.Length;
        int rotateTime = 3;
        // if Rotate right
		// RotateRight(arr, rotateTime, size);
        // printArray(arr, size);
        // if Rotate Left
		RotateLeft(arr, rotateTime, size);
        printArray(arr, size);
    }
}
