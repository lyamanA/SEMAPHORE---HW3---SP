namespace SEMAPHORE___HW3___SP
{
    partial class Form1
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
            listBox_CreatedThreads = new ListBox();
            listBox_WaitingThreads = new ListBox();
            listBox_WorkingThreads = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button_CreateNew = new Button();
            numericUpDown_PlacesinSemaphore = new NumericUpDown();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_PlacesinSemaphore).BeginInit();
            SuspendLayout();
            // 
            // listBox_CreatedThreads
            // 
            listBox_CreatedThreads.FormattingEnabled = true;
            listBox_CreatedThreads.Location = new Point(539, 49);
            listBox_CreatedThreads.Name = "listBox_CreatedThreads";
            listBox_CreatedThreads.Size = new Size(185, 144);
            listBox_CreatedThreads.TabIndex = 0;
            listBox_CreatedThreads.DoubleClick += listBox_CreatedThreads_DoubleClick;
            // 
            // listBox_WaitingThreads
            // 
            listBox_WaitingThreads.FormattingEnabled = true;
            listBox_WaitingThreads.Location = new Point(290, 49);
            listBox_WaitingThreads.Name = "listBox_WaitingThreads";
            listBox_WaitingThreads.Size = new Size(182, 144);
            listBox_WaitingThreads.TabIndex = 1;
            // 
            // listBox_WorkingThreads
            // 
            listBox_WorkingThreads.FormattingEnabled = true;
            listBox_WorkingThreads.Location = new Point(38, 49);
            listBox_WorkingThreads.Name = "listBox_WorkingThreads";
            listBox_WorkingThreads.Size = new Size(194, 144);
            listBox_WorkingThreads.TabIndex = 2;
            listBox_WorkingThreads.DoubleClick += listBox_WorkingThreads_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(537, 14);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 3;
            label1.Text = "Created Threads";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 14);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 4;
            label2.Text = "Waiting Treads";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 14);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 5;
            label3.Text = "Working Threads";
            // 
            // button_CreateNew
            // 
            button_CreateNew.Location = new Point(552, 268);
            button_CreateNew.Name = "button_CreateNew";
            button_CreateNew.Size = new Size(172, 29);
            button_CreateNew.TabIndex = 6;
            button_CreateNew.Text = "Create New";
            button_CreateNew.UseVisualStyleBackColor = true;
            button_CreateNew.Click += button_CreateNew_Click;
            // 
            // numericUpDown_PlacesinSemaphore
            // 
            numericUpDown_PlacesinSemaphore.Location = new Point(38, 252);
            numericUpDown_PlacesinSemaphore.Name = "numericUpDown_PlacesinSemaphore";
            numericUpDown_PlacesinSemaphore.Size = new Size(150, 27);
            numericUpDown_PlacesinSemaphore.TabIndex = 7;
            numericUpDown_PlacesinSemaphore.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_PlacesinSemaphore.ValueChanged += numericUpDown_PlacesinSemaphore_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 212);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 8;
            label4.Text = "Places in Semaphore";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 323);
            Controls.Add(label4);
            Controls.Add(numericUpDown_PlacesinSemaphore);
            Controls.Add(button_CreateNew);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox_WorkingThreads);
            Controls.Add(listBox_WaitingThreads);
            Controls.Add(listBox_CreatedThreads);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_PlacesinSemaphore).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox_CreatedThreads;
        private ListBox listBox_WaitingThreads;
        private ListBox listBox_WorkingThreads;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button_CreateNew;
        private NumericUpDown numericUpDown_PlacesinSemaphore;
        private Label label4;
    }
}
