using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7
{
    class Program
    {
        static void Main(string[] args)
        {

        }


        abstract class SortStrategy 
        { 
            public abstract void Sort(double[] array); 
            protected void Swap(ref double a, ref double b)
            { 
                double temp = a;
                a = b;
                b = temp; 
            }
        }
        class NumberSequence
        {
            private double[] sequence;
            private int sequenceSize;
            private SortStrategy sortStrategy;

            public NumberSequence(int sequenceSize)
            { 
                this.sequenceSize = sequenceSize;
                this.sequence = new double[sequenceSize];
            }     
            
            public NumberSequence(double[] array) : this(array.Length) 
            {
                array.CopyTo(this.sequence, 0);
            }       
            
            public void InsertAt(int index, double value) 
            {
                this.sequence[index] = value;
            }       
            
            public void SetSortStrategy(SortStrategy strategy)
            { 
                this.sortStrategy = strategy; 
            }       
            
            public void Sort()
            {
                this.sortStrategy.Sort(this.sequence);
            }

            public override string ToString() 
            {
                StringBuilder builder = new StringBuilder();
                foreach (double element in this.sequence) 
                { 
                    builder.Append(element).Append(Environment.NewLine); 
                } 
                return builder.ToString(); 
            }
        }

        class LinearSearch : SortStrategy
        {
            private double[] array; 
            private int arraySize;
            
            public double LinearSearch(double[] array, int size)
            {
                this.array=array;
                this.arraySize=size;
            }
            int n, pronasli = 0, br = 0; 
            n = sizeof(niz) / sizeof(int);   
            // broj elemenata polja 
            while(!pronasli && br<n) 
            { 
                // prolazak kroz polje dok  
                if (niz[br] == a) pronasli = 1; // se element ne nađe ili dok   
                else br++;    // se ne dođe do kraja polja  
            }   
        }

        class SequentialSort : SortStrategy 
        { 
            public override void Sort(double[] array)
            { 
                int arraySize = array.Length;
                for (int i = 0; i < arraySize - 1; i++)
                {
                    for (int j = i + 1; j < arraySize; j++) 
                    { 
                        if (array[i] > array[j]) 
                        { 
                            Swap(ref array[i], ref array[j]); } } } } }
        class BubbleSort : SortStrategy
        {
            public override void Sort(double[] array)
            {             //implementation missing!         }     }      class CombSort : SortStrategy     {         public override void Sort(double[] array) {             int arraySize = array.Length;             int gap = arraySize;             const double shrink = 1.3; 

                bool sorted; do
                {
                    sorted = true; gap = (int)(gap / shrink); if (gap > 1) { sorted = false; }

                    for (int i = 0; i + gap < arraySize; i++) { if (array[i] > array[i + gap]) { Swap(ref array[i], ref array[i + gap]); sorted = false; } }
                } while (!sorted);
            }
        } 
         class BubbleSort : SortStrategy   
         {
             void swap(int *x, int* y)
             {
                 int aux;
                 aux = *x;
                 *x = *y;
                 *y = aux;
             }

             public override void Sort(double[] array) 
             {             //implementation missing! 
                 int i, j
                 bool flag = false;
                 int length = array.Length;
                 for (i = 0, flag = true; flag; i++)
                 {
                     flag = false;
                     for (j = 0; j < length - 1 - i; j++)
                     {
                         if (array[j + 1] < array[j])
                         {
                             Swap(&array[j], &array[j+1]);
                             flag=true;
                         }
                     }
                 }
             }     
         } 
    }

}
