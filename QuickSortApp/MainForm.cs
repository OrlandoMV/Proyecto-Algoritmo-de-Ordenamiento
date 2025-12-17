using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace QuickSortApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Puedes inicializar valores por defecto aquí si quieres
            if (cmbAlgorithm.Items.Count > 0)
                cmbAlgorithm.SelectedIndex = 0; // Seleccionar el primero por defecto
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un algoritmo
            if (cmbAlgorithm.SelectedItem == null)
            {
                MessageBox.Show("Please select an algorithm.");
                return;
            }

            // 1. Preparation
            int size = (int)nudSize.Value;
            int[] numbers = GenerateRandomArray(size);

            // borra los listboxes y muestra el array original
            lbOriginal.Items.Clear();
            lbSorted.Items.Clear();
            lblStats.Text = "Processing...";
            lblSortedTitle.Text = $"Sorted Array ({cmbAlgorithm.SelectedItem})";

            int displayLimit = 1000; // limite max de elementos a mostrar

            // Display Original
            lbOriginal.BeginUpdate();  // carga los elementos array
            for (int i = 0; i < Math.Min(size, displayLimit); i++)
            {
                lbOriginal.Items.Add($"[{i}]: {numbers[i]}");
            }
            if (size > displayLimit) lbOriginal.Items.Add($"... {size - displayLimit} more items hidden ...");
            lbOriginal.EndUpdate();

            // 2. Reset Statistics (Asegúrate de que la clase Order sea estática o accesible)
            Order.SwapCount = 0;
            Order.ComparisonCount = 0;
            Order.Divisiones = 0;
            Order.Mezclas = 0;

            // 3. Execution & Measurement
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // SWITCH PARA ELEGIR EL ALGORITMO
            string selectedAlgo = cmbAlgorithm.SelectedItem.ToString();

            switch (selectedAlgo)
            {
                case "Quick Sort":
                    Order.QuickSort(numbers, 0, numbers.Length - 1);
                    break;
                case "Bubble Sort":
                    Order.BubbleSort(numbers);
                    break;
                case "Cocktail Sort":
                    Order.CocktailSort(numbers);
                    break;
                case "Insert Sort":
                    Order.InsertSort(numbers);
                    break;
                case "Selection Sort":
                    Order.SelectionSort(numbers);
                    break;
                case "Merge Sort D":
                    Order.MergeSortDirect(numbers);
                    break;
                case "Merge Sort N":
                    Order.MergeSortNatural(numbers);
                    break;
                case "Gnome Sort":
                    Order.GnomeSort(numbers);
                    break;
                case "Bucket Sort":
                    Order.BucketSort(numbers);
                    break;
                case "Counting Sort":
                    Order.CountingSort(numbers);
                    break;
                case "Radix Sort":
                    Order.RadixSort(numbers);
                    break;
                case "Heap Sort":
                    Order.HeapSort(numbers);
                    break;
                case "Shell Sort":
                    Order.ShellSort(numbers);
                    break;
            }
            stopwatch.Stop();

            // 4. Display Sorted Results
            lbSorted.BeginUpdate();
            for (int i = 0; i < Math.Min(size, displayLimit); i++)
            {
                lbSorted.Items.Add($"[{i}]: {numbers[i]}");
            }
            if (size > displayLimit) lbSorted.Items.Add($"... {size - displayLimit} more items hidden ...");
            lbSorted.EndUpdate();

            // 5. MOSTRAR ESTADÍSTICAS
            // Construimos el mensaje base
            string statsText = $"Algorithm: {selectedAlgo}\n" +
                               $"Time Elapsed: {stopwatch.Elapsed.TotalMilliseconds:F4} ms\n";

            // Si es Merge Sort, mostramos SUS variables específicas (Divisiones y Mezclas)
            if (selectedAlgo == "Merge Sort D" || selectedAlgo == "Merge Sort N")
            {
                statsText += $"Divisiones: {Order.Divisiones:N0}\n" +
                             $"Mezclas: {Order.Mezclas:N0}\n";
            }
            else
            {
                // Para los demás, mostramos Swaps y Comparisons
                statsText += $"Total Swaps: {Order.SwapCount:N0}\n" +
                             $"Comparisons: {Order.ComparisonCount:N0}\n";
            }

            statsText += $"Array Size: {size}";
            lblStats.Text = statsText;
        }

        private int[] GenerateRandomArray(int size)
        {
            Random rnd = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(0, 101);
            }
            return arr;
        }
    }
}