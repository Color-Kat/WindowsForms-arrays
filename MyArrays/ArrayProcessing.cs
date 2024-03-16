using System;
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
        private Stopwatch _timer = new Stopwatch();

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

            int index, currentNumber;

            // Iterate arrays
            for( int i = 0; i < _array.Length; i++ )
            {
                index = i;
                currentNumber = _array[i];

                // Iterate all elements before current element
                while (index > 0 && currentNumber < _array[index - 1])
                {
                    // Move all greater elements efter the current element
                    _array[index] = _array[index - 1];
                    index--;
                }

                // Insert current elemnt before all elements that are greater than it
                _array[index] = currentNumber;
            }

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

        public int BinarySearch(int searchFor)
        {
            int left = 0, middle, right = _length - 1; 

            while (left < right)
            {
                middle = (left + right) / 2;

                if (_array[middle] == searchFor) return middle;
                if (_array[middle] < searchFor) left = middle + 1;
                if (_array[middle] > searchFor) right = middle;
            }

            return -1;
        }

        public void sequentialSum()
        {
            _timer.Restart();

            int sum;
            sum = 0;
            for (int i = 0; i < _length; i++)
                sum += _array[i];

            _timer.Stop();

            ResultLabel.Text = $"Summa: {sum.ToString()}\nTime: {_timer.Elapsed}";
        }
    }
}
