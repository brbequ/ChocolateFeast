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

class Solution
{

    // Complete the chocolateFeast function below.
    // n = money, c = cost, m = trade in cost
    // Chocolate bars cost 'c' money or 'm' wrappers
    static int chocolateFeast(int n, int c, int m)
    {
        // Initial purchase with money
        int bars = n / c;

        // Trade in the wrappers
        int w = bars;
        while (w / m > 0)
        {
            // How many bars from wrappers
            bars += w / m;

            // Subtract wrappers traded for bars
            w = (w / m) + (w % m);
        }

        return bars;
    }

    static void Main(string[] args)
    {
        List<int[]> testcases = new List<int[]>
        {
            new int[]{ 15, 3, 2 },
            new int[]{ 6, 2, 2 }
        };

        foreach(int[] testcase in testcases)
        {
            int n = testcase[0];
            int c = testcase[1];
            int m = testcase[2];
            int result = chocolateFeast(n, c, m);
            Console.WriteLine(result);
        }
    }
}
