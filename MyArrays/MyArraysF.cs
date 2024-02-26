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
            ArrayProcessor = new ArrayProcessing();
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
            ArrayProcessor.Show(dataGridView, resultLabel);
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            ArrayProcessor.Update(dataGridView, resultLabel);
        }

        private void length_TextChanged(object sender, EventArgs e)
        {
        }

        private void range_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
