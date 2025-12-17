using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortApp
{
    public class Order
    {
        public static long SwapCount = 0;
        public static long ComparisonCount = 0;
        public static int Divisiones = 0;
        public static int Mezclas = 0;

        // QUICK SORT
        public static void QuickSort(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;

            // Select pivot (middle element)
            var pivot = array[leftIndex + (rightIndex - leftIndex) / 2];

            while (i <= j)
            {
                // Increment comparison count for the while checks below
                ComparisonCount++;
                while (array[i] < pivot)
                {
                    i++;
                    ComparisonCount++;
                }

                ComparisonCount++;
                while (array[j] > pivot)
                {
                    j--;
                    ComparisonCount++;
                }

                if (i <= j)
                {
                    // Swap elements
                    Exchange(array, i, j);
                    i++;
                    j--;
                }
            }
            // Recursive calls
            if (leftIndex < j)
                QuickSort(array, leftIndex, j);

            if (i < rightIndex)
                QuickSort(array, i, rightIndex);
        }
        // BUBBLE SORT 
        public static void BubbleSort(int[] array)
        {
            int n = array.Length;
            bool swapped; 

            for (int i = 0; i < n - 1; i++) 
            {
                swapped = false; 

                for (int j = 0; j < n - i - 1; j++) 
                {
                    ComparisonCount++;
                    if (array[j] > array[j + 1])
                    {
                        Exchange(array, j, j + 1);    
                        swapped = true; 
                    }
                }
                if (!swapped) break;
            }
        }
        // COCKTAIL SORT-BURBUJA BIDIRECCIONAL
        public static void CocktailSort(int[] array)
        {
            bool swapped = true;
            int start = 0;
            int end = array.Length;

            while (swapped)
            {
                swapped = false; 

                // --- IDA (Izquierda -> Derecha) ---
                for (int i = start; i < end - 1; i++)
                {
                     ComparisonCount++;
                    if (array[i] > array[i + 1])
                    {
                        Exchange(array, i, i + 1);
                        swapped = true;
                    }
                }
                if (!swapped) break; 

                swapped = false;
                end = end - 1; 

                for (int i = end - 2; i >= start; i--)
                {
                     ComparisonCount++;
                    if (array[i] > array[i + 1])
                    {
                        Exchange(array, i, i + 1);
                        swapped = true;
                    }
                }
                start = start + 1; 
            }
        }
        // INSERT SORT
        public static void InsertSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int actual = array[i];
                int j = i - 1;

                while (j >= 0)
                {
                    ComparisonCount++;
                    if (array[j] > actual)
                    {
                        array[j + 1] = array[j];
                        SwapCount++;
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }
                array[j + 1] = actual;
            }
        }
        // SELECTION SORT
        public static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    ComparisonCount++;
                    if (arr[j] < arr[min_idx])
                    {
                        min_idx = j;
                    }
                }
                // Si encontramos un nuevo mínimo, intercambiamos
                if (min_idx != i)
                {
                    // Usamos el método Exchange existente que ya suma SwapCount
                    Exchange(arr, min_idx, i);
                }
            }
        }
        // MERGE SORT DIRECTO Y NATURAL 
        public static void MergeSortDirect(int[] array)
        {
            List<int> lista = array.ToList();
            SortRecursivo(lista);
            for (int i = 0; i < lista.Count; i++) array[i] = lista[i];
        }
        public static void MergeSortNatural(int[] array)
        {
            List<int> lista = array.ToList();
            SortNatural(lista);
            for (int i = 0; i < lista.Count; i++) array[i] = lista[i];
        }
        // Método Merge original
        private static void Merge(List<int> myList, List<int> left, List<int> right)
        {
            Mezclas++; // Variable original
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < left.Count && j < right.Count)
            {
                if (left[i] < right[j])
                {
                    myList[k] = left[i];
                    i++;
                }
                else
                {
                    myList[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < left.Count)
            {
                myList[k] = left[i];
                i++;
                k++;
            }

            while (j < right.Count)
            {
                myList[k] = right[j];
                j++;
                k++;
            }
        }
        // Sort Recursivo original
        private static void SortRecursivo(List<int> myList)
        {
            if (myList.Count <= 1) return;

            Divisiones++; // Variable original

            int mid = myList.Count / 2;

            List<int> leftHalf = new List<int>(myList.GetRange(0, mid));
            List<int> rightHalf = new List<int>(myList.GetRange(mid, myList.Count - mid));

            SortRecursivo(leftHalf);
            SortRecursivo(rightHalf);

            Merge(myList, leftHalf, rightHalf);
        }

        // Sort Natural original
        private static void SortNatural(List<int> myList)
        {
            bool ordenado = false;
            bool primeraVez = true;

            while (!ordenado)
            {
                var runs = GetNaturalRuns(myList);

                if (primeraVez)
                {
                    Divisiones = runs.Count; // Variable original
                    primeraVez = false;
                }

                if (runs.Count <= 1)
                {
                    ordenado = true;
                    return;
                }
                List<List<int>> nuevasSecuencias = new List<List<int>>();

                while (runs.Count > 1)
                {
                    var seq1 = runs[0]; runs.RemoveAt(0);
                    var seq2 = runs[0]; runs.RemoveAt(0);
                    int tamanoTotal = seq1.Count + seq2.Count;
                    List<int> mezclar = new List<int>(new int[tamanoTotal]);

                    Merge(mezclar, seq1, seq2);
                    nuevasSecuencias.Add(mezclar);
                }

                if (runs.Count == 1) nuevasSecuencias.Add(runs[0]);

                myList.Clear();
                foreach (var seq in nuevasSecuencias) myList.AddRange(seq);
            }
        }

        // GetNaturalRuns original
        private static List<List<int>> GetNaturalRuns(List<int> myList)
        {
            List<List<int>> runs = new List<List<int>>();

            if (myList.Count == 0) return runs;

            List<int> actual = new List<int> { myList[0] };

            for (int i = 1; i < myList.Count; i++)
            {
                if (myList[i] >= myList[i - 1])
                {
                    actual.Add(myList[i]);
                }
                else
                {
                    runs.Add(actual);
                    actual = new List<int> { myList[i] };
                }
            }

            runs.Add(actual);
            return runs;
        }
        // GNOME SORT
        private static readonly Random rnd = new Random();
        public static void GnomeSort(int[] array)
        {
            int index = 0;

            // Recorremos el array hasta ordenar
            while (index < array.Length)
            {
                // (opcional) contar la comprobación del while si quieres medirla:
                ComparisonCount++; // cuenta la comprobación index < array.Length

                // Si estamos en la primera posición, avanzamos
                if (index == 0)
                {
                    index++;
                    continue;
                }

                // Comparamos el elemento actual con el anterior
                ComparisonCount++; // cuenta la comparación array[index] >= array[index - 1]
                if (array[index] >= array[index - 1])
                {
                    // si está en orden, avanzamos
                    index++;
                }
                else
                {
                    // si no, intercambiamos y retrocedemos
                    Exchange(array, index, index - 1);
                    index--;
                }
            }
        }
        // COUNTING SORT
        public static void CountingSort(int[] array)
        {
            if (array.Length == 0) return;

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                ComparisonCount++; // Costo de buscar el mayor
                if (array[i] > max)
                    max = array[i];
            }

            int[] output = new int[array.Length];
            int[] count = new int[max + 1];

            // Paso 2: Conteo de ocurrencias
            for (int i = 0; i < array.Length; i++)
            {
                count[array[i]]++;
                ComparisonCount++; // (Siguiendo tu lógica original: contar lectura/iteración como comparación)
            }

            // Paso 3: Acumulación
            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
                ComparisonCount++;
            }

            // Paso 4: Construcción del array de salida
            for (int i = array.Length - 1; i >= 0; i--)
            {
                output[count[array[i]] - 1] = array[i];
                count[array[i]]--;
                SwapCount++; // Consideramos la asignación al array temporal como movimiento
            }

            // Paso 5: Copiar de vuelta al array original (para que sea "in-place" desde la vista del Form)
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = output[i];
                SwapCount++;
            }
        }
        // RADIX SORT
        public static void RadixSort(int[] array)
        {
            if (array.Length == 0) return;

            // Encontrar el máximo
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                ComparisonCount++;
                if (array[i] > max)
                    max = array[i];
            }

            // Aplicar Counting Sort para cada dígito (exp = 1, 10, 100...)
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountingSortByDigit(array, exp);
            }
        }
        private static void CountingSortByDigit(int[] array, int exp)
        {
            int[] output = new int[array.Length];
            int[] count = new int[10];

            // Conteo
            for (int i = 0; i < array.Length; i++)
            {
                count[(array[i] / exp) % 10]++;
                ComparisonCount++;
            }

            // Acumulación
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            // Construcción salida
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int digit = (array[i] / exp) % 10;
                output[count[digit] - 1] = array[i];
                count[digit]--;
                SwapCount++;
            }

            // Copiar al original
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = output[i];
                SwapCount++;
            }
        }
        // BUCKET SORT
        public static void BucketSort(int[] array)
        {
            if (array == null || array.Length == 0) return;

            // Encontrar máximo
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                ComparisonCount++;
                if (array[i] > max) max = array[i];
            }

            // Crear buckets
            List<int>[] buckets = new List<int>[max + 1];
            for (int i = 0; i <= max; i++)
                buckets[i] = new List<int>();

            // Distribuir en buckets
            for (int i = 0; i < array.Length; i++)
            {
                buckets[array[i]].Add(array[i]);
                SwapCount++; // Movimiento al bucket
            }

            // Recolectar de buckets al array original
            int idx = 0;
            for (int i = 0; i < buckets.Length; i++)
            {
                foreach (int num in buckets[i])
                {
                    array[idx++] = num;
                    SwapCount++; // Movimiento de regreso
                }
            }
        }
        // HEAP SORT
        public static void HeapSort(int[] arr)
        {
            int n = arr.Length;

            // 1. Construir Max-Heap
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }

            // 2. Extraer elementos del montículo
            for (int i = n - 1; i > 0; i--)
            {
                Exchange(arr, 0, i);

                // Llamar a max heapify en el montículo reducido
                Heapify(arr, i, 0);
            }
        }
        private static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < n)
            {
                ComparisonCount++;
                if (arr[l] > arr[largest])
                    largest = l;
            }

            if (r < n)
            {
                ComparisonCount++;
                if (arr[r] > arr[largest])
                    largest = r;
            }

            if (largest != i)
            {
                Exchange(arr, i, largest);

                Heapify(arr, n, largest);
            }
        }
        // SHELL SORT
        public static void ShellSort(int[] arr)
        {
            int n = arr.Length;

            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j = i;

                    while (j >= gap)
                    {
                        ComparisonCount++; 
                        if (arr[j - gap] > temp)
                        {
                            arr[j] = arr[j - gap];
                            SwapCount++; 
                            j -= gap;
                        }
                        else
                        {
                            break;
                        }
                    }
                    arr[j] = temp;
                    SwapCount++; 
                }
            }
        }
        private static void Exchange(int[] array, int index1, int index2)
        {
            if (index1 == index2) return; 
            int temp = array[index1]; 
            array[index1] = array[index2]; 
            array[index2] = temp;  
            SwapCount++; 
        }
    }
}
