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


/*planteamiento hackerrank para ejercicio en donde se toma una lista y se imprimen dobles
    https://www.hackerrank.com/challenges/one-week-preparation-kit-plus-minus/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=one-week-preparation-kit&playlist_slugs%5B%5D=one-week-day-one
datos de entrada 
6
-4 3 -9 0 4 1

resultado esperado 
0.500000
0.333333
0.166667

el sistema hace la lectura con espacios.
 
 */
class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        double x = arr.Count;
        double positivos=0;
        double negativos=0;
        double ceros=0;
        //Array(float) y = new ArrayList();

        foreach (int elementos in arr)
        {
            if (elementos == 0)
            {
                ceros++;
            }
            if (elementos > 0)
            {
                positivos++;
            }
            if (elementos < 0)
            {
                negativos++;            }
        }
       
        Console.WriteLine("{0:N6}", positivos / x);
        Console.WriteLine("{0:N6}", negativos / x);
        Console.WriteLine("{0:N6}", ceros / x);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        try
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            if (n <= 100)
            {
                List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();


                Result.plusMinus(arr);
            }
            else
            {
                Console.WriteLine("El valor de la cantidad de numeros no esta dentro del rango");
            }
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }
}
