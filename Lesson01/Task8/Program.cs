﻿int n = 10;
int[] arr = new int[n];
int i = 0;

while (i < arr.Length)
{
    arr[i] = i + 1;
    // Console.WriteLine(arr[i]);
    // Console.WriteLine(' ');
    Console.WriteLine($"{arr[i]} ");
    i = i + 1;
}