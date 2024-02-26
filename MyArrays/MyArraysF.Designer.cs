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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            createButton.Location = new Point(593, 197);
            createButton.Name = "createButton";
            createButton.Size = new Size(220, 52);
            createButton.TabIndex = 1;
            createButton.Text = "Create Array";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // lengthInput
            // 
            lengthInput.Location = new Point(851, 54);
            lengthInput.Name = "lengthInput";
            lengthInput.Size = new Size(225, 43);
            lengthInput.TabIndex = 2;
            lengthInput.TextChanged += length_TextChanged;
            // 
            // rangeInput
            // 
            rangeInput.Location = new Point(851, 128);
            rangeInput.Name = "rangeInput";
            rangeInput.Size = new Size(225, 43);
            rangeInput.TabIndex = 3;
            rangeInput.TextChanged += range_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(590, 54);
            label1.Name = "label1";
            label1.Size = new Size(174, 37);
            label1.TabIndex = 4;
            label1.Text = "Array Length:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(590, 128);
            label2.Name = "label2";
            label2.Size = new Size(198, 37);
            label2.TabIndex = 5;
            label2.Text = "Random range:";
            // 
            // showButton
            // 
            showButton.ForeColor = SystemColors.ControlText;
            showButton.Location = new Point(851, 197);
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
            saveButton.Location = new Point(1163, 197);
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 92;
            dataGridView.Size = new Size(560, 1180);
            dataGridView.TabIndex = 0;
            // 
            // Array
            // 
            Array.HeaderText = "Array";
            Array.MinimumWidth = 11;
            Array.Name = "Array";
            Array.Width = 225;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(590, 417);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(90, 37);
            resultLabel.TabIndex = 9;
            resultLabel.Text = "label3";
            // 
            // MyArraysF
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1564, 1177);
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
        private DataGridViewTextBoxColumn Array;
    }
}
