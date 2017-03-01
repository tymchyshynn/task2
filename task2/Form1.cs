using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int[] array = new int[100];

        void FillArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-50, 100);
                showArray.Text += i.ToString() + ")  " + array[i].ToString() + "\r\n";
            }
          
        }

        void FindByValueOfElement()
        {
            int index = Array.IndexOf(array, Convert.ToInt32(valueOfElement.Text));

            if (index == -1)
            {
                MessageBox.Show("Такого елемента в масиві немає");
                valueOfElement.Clear();
            }
            else
            {
                result.Text = "Даний елемент знаходиться під індексами: ";

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[index] == array[i])
                    {
                        result.Text += i.ToString() + ";  ";
                    }
                }
            }

        }

        void FindByIndex()
        {
            int index = Convert.ToInt32(valueOfIndex.Text);

            if (index > array.Length - 1)
            {
                MessageBox.Show("Значення індексу виходить за розмір масиву");
                valueOfIndex.Clear();
            }
            else
            {
                result.Text = "Значення елементу в даному індексі: " + array[index].ToString();
            }
        }

        public int[] CloneArray()
        {
            int[] arr = new int[array.Length];

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = array[i];
                }

            return arr;
        }

        void Bouble()
        {
            int[] mas = new int[array.Length];
            mas = CloneArray();

            int temp;
            for (int i = 0; i < mas.Length ; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
                showSortArray.Text += i.ToString() + ")  " + mas[i].ToString() + "\r\n";
            }

        }

        void Insertion()
        {
            int[] mas = new int[array.Length];
            mas = CloneArray();

            int index, temp;
            for (int i = 0; i < mas.Length; ++i)
            {
                index = i;
                temp = mas[i];

                for (int j = i + 1; j < mas.Length; ++j)
                {
                    if (mas[j] < temp)
                    {
                        index = j;
                        temp = mas[j];
                    }
                }
                mas[index] = mas[i];
                mas[i] = temp;
            
            showSortArray.Text += i.ToString() + ")  " + mas[i].ToString() + "\r\n";
            }

        }

        void Selection()
        {
            int[] mas = new int[array.Length];
            mas = CloneArray();

            int min, temp;
           
            for (int i = 0; i < mas.Length; i++)
            {
                min = i;

                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[j] < mas[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    temp = mas[i];
                    mas[i] = mas[min];
                    mas[min] = temp;
                }

                showSortArray.Text += i.ToString() + ")  " + mas[i].ToString() + "\r\n";
            }
        }

        void Shell()
        {
            int[] mas = new int[array.Length];
            mas = CloneArray();

            int j;
            int step = mas.Length / 2;
            while (step > 0)
            {
                for (int i = 0; i < (mas.Length - step); i++)
                {
                    j = i;
                    while ((j >= 0) && (mas[j] > mas[j + step]))
                    {
                        int tmp = mas[j];
                        mas[j] = mas[j + step];
                        mas[j + step] = tmp;
                        j -= step;
                    }
                   
                }
                step = step / 2;
            }

            for (int i = 0; i < mas.Length; i++)
            {
                showSortArray.Text += i.ToString() + ")  " + mas[i].ToString() + "\r\n";
            }

        }

        void Sort()
        {
            int[] mas = new int[array.Length];
            mas = CloneArray();

            Array.Sort(mas);

            for (int i = 0; i < mas.Length; i++)
            {             
                showSortArray.Text += i.ToString() + ")  " + mas[i].ToString() + "\r\n";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showArray.Clear();
            FillArray();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result.Text = null;
            FindByValueOfElement();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result.Text = null;
            FindByIndex();
        }

        private void searchArray_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (searchArray.Text)
            {
                case "minimal":
                    result.Text = "Мінімальний елемент: " + array.Min().ToString();
                    break;

                case "maximal":
                    result.Text = "Максимальний елемент: " + array.Max().ToString();
                    break;

                case "by_value_of_item":
                    result.Text = null;
                    valueOfIndex.Clear();

                    label2.Enabled = true;
                    valueOfElement.Enabled = true;
                    findByElement.Enabled = true;

                    valueOfIndex.Enabled = false;
                    findById.Enabled = false;
                    label3.Enabled = false;

                    break;

                case "by_index":
                    result.Text = null;
                    valueOfElement.Clear();

                    label3.Enabled = true;
                    valueOfIndex.Enabled = true;
                    findById.Enabled = true;

                    label2.Enabled = false;
                    valueOfElement.Enabled = false;
                    findByElement.Enabled = false;
                    break;
            }
        }

        private void sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (sort.Text)
            {
                case "Bouble":
                    showSortArray.Clear();
                    Bouble();
                    break; 

                case "Insertion":
                    showSortArray.Clear();
                    Insertion();
                break;

                case "Selection":
                    showSortArray.Clear();
                    Selection();
                    break;

                case "Shell":
                    showSortArray.Clear();
                    Shell();
                    break;

                case "Sort":
                    showSortArray.Clear();
                    Sort();
                    break; 
               
            }
        }
     
    }
}
