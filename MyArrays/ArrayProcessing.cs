using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Show(DataGridView dataGridView, Label resultLabel)
        {
            int length;
            if (_length > 100) length = 100;
            else length = _length;

            for (int i = 0; i < length; i++)
            {
                if(dataGridView.RowCount < length) dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells[0].Value = _array[i].ToString();
            }

            resultLabel.Text = "Display " + length.ToString() + " elements";

        }

        public bool Update(DataGridView dataGridView, Label resultLabel)
        {
            bool result = true;

            for (int i = 0; i < dataGridView.RowCount; i++) {
                if (
                    !Int32.TryParse(
                        dataGridView.Rows[i].Cells[0].Value.ToString(),
                        out _array[i]
                    )
                )
                    result = false;
            }

            if (result)
                resultLabel.Text = "Array was successfully updated";
            else
                resultLabel.Text = "Can't update array: data error";

            return result;
        }
    }
}
