namespace Lab_15
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
            StartSortingbutton = new Button();
            labelArray = new Label();
            StopSortingButton = new Button();
            comboBoxSortDesc = new ComboBox();
            comboBoxSortAsc = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            labelArray2 = new Label();
            GenerateArrButton = new Button();
            labelStatusSort1 = new Label();
            labelStatusSort2 = new Label();
            SuspendLayout();
            // 
            // StartSortingbutton
            // 
            StartSortingbutton.Location = new Point(136, 58);
            StartSortingbutton.Name = "StartSortingbutton";
            StartSortingbutton.Size = new Size(190, 29);
            StartSortingbutton.TabIndex = 3;
            StartSortingbutton.Text = "Начать сортировку";
            StartSortingbutton.UseVisualStyleBackColor = true;
            StartSortingbutton.Click += StartSortingbutton_Click;
            // 
            // labelArray
            // 
            labelArray.AutoSize = true;
            labelArray.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            labelArray.Location = new Point(136, 228);
            labelArray.Name = "labelArray";
            labelArray.Size = new Size(109, 46);
            labelArray.TabIndex = 5;
            labelArray.Text = "label1";
            // 
            // StopSortingButton
            // 
            StopSortingButton.Location = new Point(130, 104);
            StopSortingButton.Name = "StopSortingButton";
            StopSortingButton.Size = new Size(196, 29);
            StopSortingButton.TabIndex = 6;
            StopSortingButton.Text = "Остановить сортировку";
            StopSortingButton.UseVisualStyleBackColor = true;
            StopSortingButton.Click += StopSortingButton_Click;
            // 
            // comboBoxSortDesc
            // 
            comboBoxSortDesc.FormattingEnabled = true;
            comboBoxSortDesc.Items.AddRange(new object[] { "Highest", "AboveNormal", "Normal", "BelowNormal", "Lowest" });
            comboBoxSortDesc.Location = new Point(397, 89);
            comboBoxSortDesc.Name = "comboBoxSortDesc";
            comboBoxSortDesc.Size = new Size(128, 28);
            comboBoxSortDesc.TabIndex = 7;
            // 
            // comboBoxSortAsc
            // 
            comboBoxSortAsc.FormattingEnabled = true;
            comboBoxSortAsc.Items.AddRange(new object[] { "Highest", "AboveNormal", "Normal", "BelowNormal", "Lowest" });
            comboBoxSortAsc.Location = new Point(397, 55);
            comboBoxSortAsc.Name = "comboBoxSortAsc";
            comboBoxSortAsc.Size = new Size(128, 28);
            comboBoxSortAsc.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 224, 192);
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(531, 58);
            label1.Name = "label1";
            label1.Size = new Size(241, 25);
            label1.TabIndex = 10;
            label1.Text = "Сортировка по возрастаню";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 224, 192);
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(531, 89);
            label2.Name = "label2";
            label2.Size = new Size(229, 25);
            label2.TabIndex = 11;
            label2.Text = "Сортировка по убыванию";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 224, 192);
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(426, 9);
            label4.Name = "label4";
            label4.Size = new Size(302, 28);
            label4.TabIndex = 13;
            label4.Text = "Задание приоритета потокам";
            // 
            // labelArray2
            // 
            labelArray2.AutoSize = true;
            labelArray2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            labelArray2.Location = new Point(130, 349);
            labelArray2.Name = "labelArray2";
            labelArray2.Size = new Size(109, 46);
            labelArray2.TabIndex = 14;
            labelArray2.Text = "label5";
            // 
            // GenerateArrButton
            // 
            GenerateArrButton.Location = new Point(120, 154);
            GenerateArrButton.Name = "GenerateArrButton";
            GenerateArrButton.Size = new Size(206, 29);
            GenerateArrButton.TabIndex = 15;
            GenerateArrButton.Text = "Сгенерировать массивы";
            GenerateArrButton.UseVisualStyleBackColor = true;
            GenerateArrButton.Click += GenerateArrButton_Click;
            // 
            // labelStatusSort1
            // 
            labelStatusSort1.AutoSize = true;
            labelStatusSort1.Location = new Point(24, 208);
            labelStatusSort1.Name = "labelStatusSort1";
            labelStatusSort1.Size = new Size(180, 20);
            labelStatusSort1.TabIndex = 16;
            labelStatusSort1.Text = "В ожидании сортировки";
            // 
            // labelStatusSort2
            // 
            labelStatusSort2.AutoSize = true;
            labelStatusSort2.Location = new Point(24, 329);
            labelStatusSort2.Name = "labelStatusSort2";
            labelStatusSort2.Size = new Size(180, 20);
            labelStatusSort2.TabIndex = 17;
            labelStatusSort2.Text = "В ожидании сортировки";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(labelStatusSort2);
            Controls.Add(labelStatusSort1);
            Controls.Add(GenerateArrButton);
            Controls.Add(labelArray2);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxSortAsc);
            Controls.Add(comboBoxSortDesc);
            Controls.Add(StopSortingButton);
            Controls.Add(labelArray);
            Controls.Add(StartSortingbutton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button StartSortingbutton;
        private Label labelArray;
        private Button StopSortingButton;
        private ComboBox comboBoxSortDesc;
        private ComboBox comboBoxDisplayArray;
        private ComboBox comboBoxSortAsc;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelArray2;
        private Button GenerateArrButton;
        private Label labelStatusSort1;
        private Label labelStatusSort2;
    }
}