namespace exercises
{
    partial class BeforeSortAndAfter
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
            label1 = new Label();
            BtnInsert = new Button();
            inputNumbers = new TextBox();
            labelArray = new Label();
            BtnSort = new Button();
            labelMax = new Label();
            labelMin = new Label();
            BTN_Prev = new Button();
            BTN_Next = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(374, 93);
            label1.Name = "label1";
            label1.Size = new Size(76, 19);
            label1.TabIndex = 2;
            label1.Text = "Insert ints";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnInsert
            // 
            BtnInsert.BackColor = Color.FromArgb(114, 137, 218);
            BtnInsert.FlatAppearance.BorderColor = Color.DimGray;
            BtnInsert.FlatStyle = FlatStyle.Popup;
            BtnInsert.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BtnInsert.ForeColor = Color.White;
            BtnInsert.Location = new Point(352, 143);
            BtnInsert.Name = "BtnInsert";
            BtnInsert.Size = new Size(120, 30);
            BtnInsert.TabIndex = 5;
            BtnInsert.Text = "Insert";
            BtnInsert.UseVisualStyleBackColor = false;
            BtnInsert.Click += BtnInsert_click;
            // 
            // inputNumbers
            // 
            inputNumbers.Location = new Point(362, 116);
            inputNumbers.Name = "inputNumbers";
            inputNumbers.Size = new Size(100, 23);
            inputNumbers.TabIndex = 6;
            // 
            // labelArray
            // 
            labelArray.AutoSize = true;
            labelArray.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelArray.ForeColor = SystemColors.ControlLight;
            labelArray.Location = new Point(387, 203);
            labelArray.Name = "labelArray";
            labelArray.Size = new Size(51, 19);
            labelArray.TabIndex = 7;
            labelArray.Text = "Array";
            labelArray.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnSort
            // 
            BtnSort.BackColor = Color.FromArgb(114, 137, 218);
            BtnSort.FlatAppearance.BorderColor = Color.DimGray;
            BtnSort.FlatStyle = FlatStyle.Popup;
            BtnSort.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BtnSort.ForeColor = Color.White;
            BtnSort.Location = new Point(352, 350);
            BtnSort.Name = "BtnSort";
            BtnSort.Size = new Size(120, 30);
            BtnSort.TabIndex = 10;
            BtnSort.Text = "Sort";
            BtnSort.UseVisualStyleBackColor = false;
            BtnSort.Click += BtnSort_Click;
            // 
            // labelMax
            // 
            labelMax.AutoSize = true;
            labelMax.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMax.ForeColor = SystemColors.ControlLight;
            labelMax.Location = new Point(391, 252);
            labelMax.Name = "labelMax";
            labelMax.Size = new Size(43, 19);
            labelMax.TabIndex = 9;
            labelMax.Text = "Max";
            labelMax.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelMin
            // 
            labelMin.AutoSize = true;
            labelMin.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMin.ForeColor = SystemColors.ControlLight;
            labelMin.Location = new Point(394, 301);
            labelMin.Name = "labelMin";
            labelMin.Size = new Size(37, 19);
            labelMin.TabIndex = 11;
            labelMin.Text = "Min";
            labelMin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BTN_Prev
            // 
            BTN_Prev.BackColor = Color.FromArgb(114, 137, 218);
            BTN_Prev.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BTN_Prev.ForeColor = Color.White;
            BTN_Prev.Location = new Point(12, 408);
            BTN_Prev.Name = "BTN_Prev";
            BTN_Prev.Size = new Size(120, 30);
            BTN_Prev.TabIndex = 13;
            BTN_Prev.Text = "<- Previous";
            BTN_Prev.UseVisualStyleBackColor = false;
            BTN_Prev.Click += BTN_Prev_Click;
            // 
            // BTN_Next
            // 
            BTN_Next.BackColor = Color.FromArgb(114, 137, 218);
            BTN_Next.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BTN_Next.ForeColor = Color.White;
            BTN_Next.Location = new Point(668, 408);
            BTN_Next.Name = "BTN_Next";
            BTN_Next.Size = new Size(120, 30);
            BTN_Next.TabIndex = 12;
            BTN_Next.Text = "Next ->";
            BTN_Next.UseVisualStyleBackColor = false;
            BTN_Next.Click += BTN_Next_Click;
            // 
            // beforeSortAndAfter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 39, 42);
            ClientSize = new Size(800, 450);
            Controls.Add(BTN_Prev);
            Controls.Add(BTN_Next);
            Controls.Add(labelMin);
            Controls.Add(BtnSort);
            Controls.Add(labelMax);
            Controls.Add(labelArray);
            Controls.Add(inputNumbers);
            Controls.Add(BtnInsert);
            Controls.Add(label1);
            Name = "beforeSortAndAfter";
            Text = "beforeSortAndAfter";
            Load += beforeSortAndAfter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnInsert;
        private TextBox inputNumbers;
        private Label labelArray;
        private Button BtnSort;
        private Label labelMax;
        private Label labelMin;
        private Button BTN_Prev;
        private Button BTN_Next;
    }
}