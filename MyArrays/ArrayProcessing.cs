﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MyArrays
{
    internal class ArrayProcessing
    {
        private static int[] _array = [];

        // Length of array
        private static int _length = 0;

        // Range of random numbers
        private static int _range = 0;

        // Timer
        Stopwatch timer = new Stopwatch();

        private DataGridView DataGridView;
        private Label ResultLabel;

        public ArrayProcessing(
            DataGridView dataGridView,
            Label resultLabel
        )
        {
            DataGridView = dataGridView;
            ResultLabel = resultLabel;
        }

        public bool Init(string length, string range)
        {
            if (
                (Int32.TryParse(length, out _length)) &&
                (Int32.TryParse(range, out _range))
            )
            {
                _array = new int[_length];
                Random rand = new Random();

                for (int i = 0; i<_length; i++)
                {
                    _array[i] = rand.Next(0, _range);
                }

                return true;
            }
            else 
                return false;
        }

        public void Show()
        {
            int length;
            if (_length > 100) length = 100;
            else length = _length;

            for (int i = 0; i < length; i++)
            {
                if(DataGridView.RowCount < length) DataGridView.Rows.Add();
                DataGridView.Rows[i].Cells[0].Value = _array[i].ToString();
            }

            ResultLabel.Text = "Display " + length.ToString() + " elements";

        }

        public bool Update()
        {
            bool result = true;

            for (int i = 0; i < DataGridView.RowCount; i++) {
                if (
                    !Int32.TryParse(
                        DataGridView.Rows[i].Cells[0].Value.ToString(),
                        out _array[i]
                    )
                )
                    result = false;
            }

            if (result)
                ResultLabel.Text = "Array was successfully updated";
            else
                ResultLabel.Text = "Can't update array: data error";

            return result;
        }

        public void InsertingSort()
        {
            _array[0] = 111;

            Show();
        }
        
        public void BubbleSort(int h = 1)
        {
            int tmp;
            int offset = _length - h - 1;
            bool isFinished = false;

            int j = offset;

            do
            {
                isFinished = true;

                for (int i = 0; i <= offset; i++)
                {
                    if (_array[i] > _array[i + h])
                    {
                        // Swap values
                        tmp = _array[i];
                        _array[i] = _array[i + h];
                        _array[i + h] = tmp;

                        j = i;
                        isFinished = false; // The array is still not ordered
                    }
                }
            } while (!isFinished);

            Show();
        }

        public void ShellSort()
        {
            int h = _length / 2;

            while(h > 0)
            {
                BubbleSort(h);
                h = h / 2;
            }

            Show();
        }

        public int SearchFirst(int serachFor)
        {
            for (int i = 0; i < _length; i++)
            {
                if (_array[i] == serachFor) return i; 
            }

            return -1;
        }
    }
}
