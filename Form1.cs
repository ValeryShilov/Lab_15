using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_15
{
    public partial class Form1 : Form
    {
        private Thread sortAscendingThread;
        private Thread sortDiscendingThread;
        private Thread displayThread;
        private bool stopRequested;

        private int[] array = new int[10];
        private int[] array2 = new int[10];
        public Form1()
        {
            InitializeComponent();

            InitializeArray(array, array2);
        }

        private void InitializeArray(int[] arr, int[] arr2)
        {
            Random rnd = new();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-20, 20);
                arr2[i] = rnd.Next(-20, 20);
            }
            //array2 = array;
            string arrayString = string.Join("   ", array);
            labelArray.Text = arrayString;
            string arrayString2 = string.Join("   ", array2);
            labelArray2.Text = arrayString2;
        }

        private void SortingASC()
        {
            labelStatusSort1.Invoke(new Action(() => { labelStatusSort1.Text = "Идет сортировка"; }));
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        string arrayString = string.Join("   ", array);
                        if (labelArray.InvokeRequired)
                        {
                            labelArray.Invoke(new Action(() => { labelArray.Text = arrayString; }));
                        }
                        else
                        {
                            labelArray.Text = arrayString;
                        }
                        Thread.Sleep(200);

                    }
                }
            }
            labelStatusSort1.Invoke(new Action(() => { labelStatusSort1.Text =  "Сортировка завершена"; }));
        }

        //private void SortInsertion()
        //{
        //    for (int i = 1; i < array.Length && !stopRequested; i++)
        //    {
        //        int key = array[i];
        //        int j = i - 1;

        //        while (j >= 0 && array[j] > key && !stopRequested)
        //        {
        //            array[j + 1] = array[j];
        //            // Обновляем интерфейс в основном потоке
        //            Invoke(new Action(() =>
        //            {
        //                UpdateUI();
        //            }));

        //            Thread.Sleep(100); // Для визуализации процесса

        //            j = j - 1;
        //        }
        //        array[j + 1] = key;

        //        // Обновляем интерфейс в основном потоке
        //        Invoke(new Action(() =>
        //        {
        //            UpdateUI();
        //        }));

        //        Thread.Sleep(100); // Для визуализации процесса

        //        // Обновляем интерфейс в основном потоке
        //        Invoke(new Action(() =>
        //        {
        //            UpdateUI();
        //        }));
        //    }
        //}

        private void SortingDESC()
        {
            labelStatusSort2.Invoke(new Action(() => { labelStatusSort2.Text = "Идет сортировка"; }));
            int n = array2.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (array2[j] < array2[j + 1])
                    {
                        int temp = array2[j];
                        array2[j] = array2[j + 1];
                        array2[j + 1] = temp;

                        string arrayString2 = string.Join("   ", array2);
                        if (labelArray2.InvokeRequired)
                        {
                            labelArray2.Invoke(new Action(() => { labelArray2.Text = arrayString2; }));
                        }
                        else
                        {
                            labelArray2.Text = arrayString2;
                        }
                        Thread.Sleep(200);
                    }
                }
            }
            labelStatusSort2.Invoke(new Action(() => { labelStatusSort2.Text = "Сортировка завершена"; }));
        }

        private void StartSortingbutton_Click(object sender, EventArgs e)
        {
            if ((comboBoxSortAsc.Text == "") || (comboBoxSortDesc.Text == ""))
            {
                MessageBox.Show("Не выбраны приоритеты потоков");
            }
            else
            {
                sortAscendingThread = new(SortingASC);
                //sortAscendingThread = new(SortInsertion);
                sortDiscendingThread = new(SortingDESC);
                //displayThread = new(DisplayArray);

                sortAscendingThread.Priority = (ThreadPriority)Enum.Parse(typeof(ThreadPriority), comboBoxSortAsc.SelectedItem.ToString());
                sortDiscendingThread.Priority = (ThreadPriority)Enum.Parse(typeof(ThreadPriority), comboBoxSortDesc.SelectedItem.ToString());
                //displayThread.Priority = (ThreadPriority)Enum.Parse(typeof(ThreadPriority), comboBoxDisplayArray.SelectedItem.ToString());
                
                
                stopRequested = false;
                sortAscendingThread.Start();
                sortDiscendingThread.Start();
                //displayThread.Start();
            }
        }

        //private void UpdateUI()
        //{
        //    string arrayString = string.Join("   ", array);
        //    if (labelArray.InvokeRequired)
        //    {
        //        labelArray.Invoke(new Action(() => { labelArray.Text = arrayString; }));
        //    }
        //    else
        //    {
        //        labelArray.Text = arrayString;
        //    }
        //}

        //private void DisplayArray()
        //{
        //    while (!stopRequested)
        //    {
        //        UpdateUI();
        //        Thread.Sleep(100);
        //    }


        //}

        private void StopSortingButton_Click(object sender, EventArgs e)
        {
            stopRequested = true;
            sortAscendingThread.Abort();
            sortDiscendingThread.Abort();
            displayThread.Abort();
        }

        private void GenerateArrButton_Click(object sender, EventArgs e)
        {
            labelStatusSort1.Invoke(new Action(() => { labelStatusSort1.Text = "Ожидание сортировки"; }));
            labelStatusSort2.Invoke(new Action(() => { labelStatusSort2.Text = "Ожидание сортировки"; }));
            InitializeArray(array, array2);

        }
    }
}