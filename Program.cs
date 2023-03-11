using System;
using System.Collections;

namespace Arrays
{
    class Program
    {
        public static void Main (string[] args)
        {
            ArrayList liste = new ArrayList();

            liste.Add("Murat");
            liste.Add(22);
            liste.Add(true);
            liste.Add('A');

            Console.WriteLine(liste[1]);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*************************");
            
            string [] isimler = {"HAKAN","ALEV","MELİH"};
            List<int> sayilar = new List<int>(){2,5,7,3,8,9};
            liste.AddRange(isimler);
            liste.AddRange(sayilar);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

        }
    }
}