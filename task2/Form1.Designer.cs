namespace task2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.showArray = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.valueOfElement = new System.Windows.Forms.TextBox();
            this.findByElement = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.findById = new System.Windows.Forms.Button();
            this.valueOfIndex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showSortArray = new System.Windows.Forms.TextBox();
            this.sort = new System.Windows.Forms.ComboBox();
            this.searchArray = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Оновити масив";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showArray
            // 
            this.showArray.Location = new System.Drawing.Point(33, 109);
            this.showArray.Multiline = true;
            this.showArray.Name = "showArray";
            this.showArray.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.showArray.Size = new System.Drawing.Size(91, 345);
            this.showArray.TabIndex = 2;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(338, 59);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 16);
            this.result.TabIndex = 4;
            // 
            // valueOfElement
            // 
            this.valueOfElement.Enabled = false;
            this.valueOfElement.Location = new System.Drawing.Point(340, 102);
            this.valueOfElement.Name = "valueOfElement";
            this.valueOfElement.Size = new System.Drawing.Size(100, 20);
            this.valueOfElement.TabIndex = 5;
            // 
            // findByElement
            // 
            this.findByElement.Enabled = false;
            this.findByElement.Location = new System.Drawing.Point(340, 128);
            this.findByElement.Name = "findByElement";
            this.findByElement.Size = new System.Drawing.Size(75, 23);
            this.findByElement.TabIndex = 6;
            this.findByElement.Text = "Знайти";
            this.findByElement.UseVisualStyleBackColor = true;
            this.findByElement.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(337, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введіть значення елемента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(338, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Введіть  індекс";
            // 
            // findById
            // 
            this.findById.Enabled = false;
            this.findById.Location = new System.Drawing.Point(341, 224);
            this.findById.Name = "findById";
            this.findById.Size = new System.Drawing.Size(75, 23);
            this.findById.TabIndex = 9;
            this.findById.Text = "Знайти";
            this.findById.UseVisualStyleBackColor = true;
            this.findById.Click += new System.EventHandler(this.button3_Click);
            // 
            // valueOfIndex
            // 
            this.valueOfIndex.Enabled = false;
            this.valueOfIndex.Location = new System.Drawing.Point(340, 198);
            this.valueOfIndex.Name = "valueOfIndex";
            this.valueOfIndex.Size = new System.Drawing.Size(100, 20);
            this.valueOfIndex.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Знайти";
            // 
            // showSortArray
            // 
            this.showSortArray.Location = new System.Drawing.Point(175, 108);
            this.showSortArray.Multiline = true;
            this.showSortArray.Name = "showSortArray";
            this.showSortArray.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.showSortArray.Size = new System.Drawing.Size(91, 345);
            this.showSortArray.TabIndex = 12;
            // 
            // sort
            // 
            this.sort.FormattingEnabled = true;
            this.sort.Items.AddRange(new object[] {
            "Bouble",
            "Insertion",
            "Selection",
            "Shell",
            "Sort"});
            this.sort.Location = new System.Drawing.Point(160, 29);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(121, 21);
            this.sort.TabIndex = 15;
            this.sort.SelectedIndexChanged += new System.EventHandler(this.sort_SelectedIndexChanged);
            // 
            // searchArray
            // 
            this.searchArray.FormattingEnabled = true;
            this.searchArray.Items.AddRange(new object[] {
            "minimal",
            "maximal",
            "by_value_of_item",
            "by_index"});
            this.searchArray.Location = new System.Drawing.Point(340, 29);
            this.searchArray.Name = "searchArray";
            this.searchArray.Size = new System.Drawing.Size(121, 21);
            this.searchArray.TabIndex = 16;
            this.searchArray.SelectedIndexChanged += new System.EventHandler(this.searchArray_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 39);
            this.label5.TabIndex = 18;
            this.label5.Text = "Масив, що заповнений\r\n випадковими числами\r\n в діапазоні від -50 до100";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Виберіть метод сортування";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Відсортований масив";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 465);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchArray);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.showSortArray);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.findByElement);
            this.Controls.Add(this.valueOfIndex);
            this.Controls.Add(this.valueOfElement);
            this.Controls.Add(this.findById);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.showArray);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Операції з масивами";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button fillArrayAgain1;
        private System.Windows.Forms.TextBox showArray;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox valueOfElement;
        private System.Windows.Forms.Button findByElement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button findById;
        private System.Windows.Forms.TextBox valueOfIndex;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox showSortArray;
        private System.Windows.Forms.ComboBox sort;
        private System.Windows.Forms.ComboBox searchArray;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

