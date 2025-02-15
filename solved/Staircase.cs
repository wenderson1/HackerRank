using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
        List<string> tree = new List<string>();

        if(n is 0)
        {
            Console.WriteLine(string.Empty);
            return;
        }
        for(int i = 1; i <= n; i++)
        {
            tree.Add("*" + tree.LastOrDefault());
        }

        foreach(var item in tree)
        {
            Console.WriteLine(item.PadLeft(n));
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine()!.Trim());

        Result.staircase(n);
    }
}
