namespace MyArrays
{
    partial class MyArraysF
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            createButton = new Button();
            lengthInput = new TextBox();
            rangeInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            showButton = new Button();
            saveButton = new Button();
            dataGridView = new DataGridView();
            Array = new DataGridViewTextBoxColumn();
            resultLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            ShellSort = new Button();
            bubbleSort = new Button();
            insertionSort = new Button();
            label5 = new Label();
            searchInput = new TextBox();
            searchButton = new Button();
            dichotomyButton = new Button();
            label6 = new Label();
            sequentialSumButton = new Button();
            parallelSumButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 52;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 92;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 8;
            // 
            // createButton
            // 
            createButton.ForeColor = SystemColors.ControlText;
            createButton.Location = new Point(593, 255);
            createButton.Name = "createButton";
            createButton.Size = new Size(220, 52);
            createButton.TabIndex = 1;
            createButton.Text = "Create Array";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // lengthInput
            // 
            lengthInput.Location = new Point(851, 112);
            lengthInput.Name = "lengthInput";
            lengthInput.Size = new Size(225, 43);
            lengthInput.TabIndex = 2;
            lengthInput.TextChanged += length_TextChanged;
            // 
            // rangeInput
            // 
            rangeInput.Location = new Point(851, 186);
            rangeInput.Name = "rangeInput";
            rangeInput.Size = new Size(225, 43);
            rangeInput.TabIndex = 3;
            rangeInput.TextChanged += range_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(590, 112);
            label1.Name = "label1";
            label1.Size = new Size(174, 37);
            label1.TabIndex = 4;
            label1.Text = "Array Length:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(590, 186);
            label2.Name = "label2";
            label2.Size = new Size(198, 37);
            label2.TabIndex = 5;
            label2.Text = "Random range:";
            // 
            // showButton
            // 
            showButton.ForeColor = SystemColors.ControlText;
            showButton.Location = new Point(851, 255);
            showButton.Name = "showButton";
            showButton.Size = new Size(270, 52);
            showButton.TabIndex = 6;
            showButton.Text = "Show Array";
            showButton.UseVisualStyleBackColor = true;
            showButton.Click += showButton_Click;
            // 
            // saveButton
            // 
            saveButton.ForeColor = SystemColors.ControlText;
            saveButton.Location = new Point(1163, 255);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(270, 52);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save array";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeight = 52;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Array });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 92;
            dataGridView.Size = new Size(560, 1180);
            dataGridView.TabIndex = 0;
            // 
            // Array
            // 
            dataGridViewCellStyle1.ForeColor = Color.Black;
            Array.DefaultCellStyle = dataGridViewCellStyle1;
            Array.HeaderText = "Array";
            Array.MinimumWidth = 11;
            Array.Name = "Array";
            Array.Width = 225;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.BorderStyle = BorderStyle.FixedSingle;
            resultLabel.Font = new Font("Segoe UI", 12F);
            resultLabel.Location = new Point(593, 333);
            resultLabel.Name = "resultLabel";
            resultLabel.Padding = new Padding(3);
            resultLabel.Size = new Size(478, 56);
            resultLabel.TabIndex = 9;
            resultLabel.Text = "Result will be displayed here";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(580, 459);
            label3.Name = "label3";
            label3.Size = new Size(227, 81);
            label3.TabIndex = 10;
            label3.Text = "Sorting";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(586, 9);
            label4.Name = "label4";
            label4.Size = new Size(259, 81);
            label4.TabIndex = 11;
            label4.Text = "Creating";
            // 
            // ShellSort
            // 
            ShellSort.ForeColor = SystemColors.ControlText;
            ShellSort.Location = new Point(1155, 561);
            ShellSort.Name = "ShellSort";
            ShellSort.Size = new Size(270, 56);
            ShellSort.TabIndex = 14;
            ShellSort.Text = "Shell";
            ShellSort.UseVisualStyleBackColor = true;
            ShellSort.Click += ShellSort_Click;
            // 
            // bubbleSort
            // 
            bubbleSort.ForeColor = SystemColors.ControlText;
            bubbleSort.Location = new Point(845, 561);
            bubbleSort.Name = "bubbleSort";
            bubbleSort.Size = new Size(270, 56);
            bubbleSort.TabIndex = 13;
            bubbleSort.Text = "Bubble";
            bubbleSort.UseVisualStyleBackColor = true;
            bubbleSort.Click += bubbleSort_Click;
            // 
            // insertionSort
            // 
            insertionSort.ForeColor = SystemColors.ControlText;
            insertionSort.Location = new Point(597, 561);
            insertionSort.Name = "insertionSort";
            insertionSort.Size = new Size(220, 56);
            insertionSort.TabIndex = 12;
            insertionSort.Text = "Insertion";
            insertionSort.UseVisualStyleBackColor = true;
            insertionSort.Click += insertionSort_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(580, 661);
            label5.Name = "label5";
            label5.Size = new Size(212, 81);
            label5.TabIndex = 15;
            label5.Text = "Search";
            // 
            // searchInput
            // 
            searchInput.Location = new Point(597, 759);
            searchInput.Name = "searchInput";
            searchInput.Size = new Size(225, 43);
            searchInput.TabIndex = 16;
            // 
            // searchButton
            // 
            searchButton.ForeColor = SystemColors.ControlText;
            searchButton.Location = new Point(841, 754);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(148, 56);
            searchButton.TabIndex = 17;
            searchButton.Text = "Find";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // dichotomyButton
            // 
            dichotomyButton.ForeColor = SystemColors.ControlText;
            dichotomyButton.Location = new Point(1004, 754);
            dichotomyButton.Name = "dichotomyButton";
            dichotomyButton.Size = new Size(253, 56);
            dichotomyButton.TabIndex = 18;
            dichotomyButton.Text = "Dichotomy";
            dichotomyButton.UseVisualStyleBackColor = true;
            dichotomyButton.Click += dichotomyButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(581, 839);
            label6.Name = "label6";
            label6.Size = new Size(340, 81);
            label6.TabIndex = 19;
            label6.Text = "Summation";
            // 
            // sequentialSumButton
            // 
            sequentialSumButton.ForeColor = SystemColors.ControlText;
            sequentialSumButton.Location = new Point(597, 936);
            sequentialSumButton.Name = "sequentialSumButton";
            sequentialSumButton.Size = new Size(225, 56);
            sequentialSumButton.TabIndex = 20;
            sequentialSumButton.Text = "Sequential sum";
            sequentialSumButton.UseVisualStyleBackColor = true;
            sequentialSumButton.Click += sequentialSumButton_Click;
            // 
            // parallelSumButton
            // 
            parallelSumButton.ForeColor = SystemColors.ControlText;
            parallelSumButton.Location = new Point(845, 936);
            parallelSumButton.Name = "parallelSumButton";
            parallelSumButton.Size = new Size(270, 56);
            parallelSumButton.TabIndex = 21;
            parallelSumButton.Text = "Parallel sum";
            parallelSumButton.UseVisualStyleBackColor = true;
            parallelSumButton.Click += parallelSumButton_Click;
            // 
            // MyArraysF
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1564, 1181);
            Controls.Add(parallelSumButton);
            Controls.Add(sequentialSumButton);
            Controls.Add(label6);
            Controls.Add(dichotomyButton);
            Controls.Add(searchButton);
            Controls.Add(searchInput);
            Controls.Add(label5);
            Controls.Add(ShellSort);
            Controls.Add(bubbleSort);
            Controls.Add(insertionSort);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(resultLabel);
            Controls.Add(dataGridView);
            Controls.Add(saveButton);
            Controls.Add(showButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rangeInput);
            Controls.Add(lengthInput);
            Controls.Add(createButton);
            Controls.Add(dataGridView1);
            ForeColor = SystemColors.ControlLight;
            Name = "MyArraysF";
            Text = "My arrays";
            Load += MyArraysF_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button createButton;
        private TextBox lengthInput;
        private TextBox rangeInput;
        private Label label1;
        private Label label2;
        private Button showButton;
        private Button saveButton;
        private DataGridView dataGridView;
        private Label resultLabel;
        private Label label3;
        private Label label4;
        private Button ShellSort;
        private Button bubbleSort;
        private Button insertionSort;
        private Label label5;
        private TextBox searchInput;
        private Button searchButton;
        private Button dichotomyButton;
        private DataGridViewTextBoxColumn Array;
        private Label label6;
        private Button sequentialSumButton;
        private Button parallelSumButton;
    }
}
