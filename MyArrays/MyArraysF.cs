using System.Diagnostics;

namespace MyArrays
{
    public partial class MyArraysF : Form
    {

        ArrayProcessing ArrayProcessor;

        public MyArraysF()
        {
            InitializeComponent();

            // Add events
            createButton.Click += createButton_Click;
        }

        private void MyArraysF_Load(object sender, EventArgs e)
        {
            ArrayProcessor = new ArrayProcessing(
                dataGridView,
                resultLabel
            );
        }

        private void createButton_Click(object? sender, EventArgs e)
        {
            bool result = ArrayProcessor.Init(lengthInput.Text, rangeInput.Text);

            if (!result)
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = "Data error";
            }
            else
            {
                resultLabel.Text = "Success";
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ArrayProcessor.Show();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            ArrayProcessor.Update();
        }

        private void length_TextChanged(object sender, EventArgs e)
        {

        }

        private void range_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertionSort_Click(object sender, EventArgs e)
        {
            ArrayProcessor.InsertingSort();
        }

        private void bubbleSort_Click(object sender, EventArgs e)
        {
            ArrayProcessor.BubbleSort();
        }

        private void ShellSort_Click(object sender, EventArgs e)
        {
            ArrayProcessor.ShellSort();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            int searchFor, result;
            if (Int32.TryParse(searchInput.Text, out searchFor))
                result = ArrayProcessor.SearchFirst(searchFor);
            else
                result = -1;

            if (result >= 0)
            {
                resultLabel.Text = "Element found: " + (result + 1).ToString();
            }
            else
            {
                resultLabel.Text = "Such an element not found";
            }
        }

        private void dichotomyButton_Click(object sender, EventArgs e)
        {
            int searchFor, result;
            if (Int32.TryParse(searchInput.Text, out searchFor))
                result = ArrayProcessor.BinarySearch(searchFor);
            else
                result = -1;

            if (result >= 0)
            {
                resultLabel.Text = "Element found: " + (result + 1).ToString();
            }
            else
            {
                resultLabel.Text = "Such an element not found";
            }
        }

        private void sequentialSumButton_Click(object sender, EventArgs e)
        {
            ArrayProcessor.sequentialSum();
        }

        private void parallelSumButton_Click(object sender, EventArgs e)
        {

        }
    }
}
