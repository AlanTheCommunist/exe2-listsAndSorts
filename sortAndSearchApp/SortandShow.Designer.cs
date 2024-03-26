namespace sortAndSearchApp
{
    partial class SortandShow
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
            inputNumbers = new TextBox();
            label1 = new Label();
            BTN_Next = new Button();
            BTN_Prev = new Button();
            BtnInsert = new Button();
            label2 = new Label();
            BtnSort = new Button();
            SuspendLayout();
            // 
            // inputNumbers
            // 
            inputNumbers.Location = new Point(329, 192);
            inputNumbers.Name = "inputNumbers";
            inputNumbers.Size = new Size(100, 23);
            inputNumbers.TabIndex = 0;
            inputNumbers.MouseClick += inputNumbers_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(341, 169);
            label1.Name = "label1";
            label1.Size = new Size(76, 19);
            label1.TabIndex = 1;
            label1.Text = "Insert ints";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BTN_Next
            // 
            BTN_Next.BackColor = Color.FromArgb(114, 137, 218);
            BTN_Next.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BTN_Next.ForeColor = Color.White;
            BTN_Next.Location = new Point(652, 399);
            BTN_Next.Name = "BTN_Next";
            BTN_Next.Size = new Size(120, 30);
            BTN_Next.TabIndex = 2;
            BTN_Next.Text = "Next ->";
            BTN_Next.UseVisualStyleBackColor = false;
            BTN_Next.Click += BTN_Next_Click;
            // 
            // BTN_Prev
            // 
            BTN_Prev.BackColor = Color.FromArgb(114, 137, 218);
            BTN_Prev.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BTN_Prev.ForeColor = Color.White;
            BTN_Prev.Location = new Point(12, 399);
            BTN_Prev.Name = "BTN_Prev";
            BTN_Prev.Size = new Size(120, 30);
            BTN_Prev.TabIndex = 3;
            BTN_Prev.Text = "<- Previous";
            BTN_Prev.UseVisualStyleBackColor = false;
            BTN_Prev.Click += BTN_Prev_Click;
            // 
            // BtnInsert
            // 
            BtnInsert.BackColor = Color.FromArgb(114, 137, 218);
            BtnInsert.FlatAppearance.BorderColor = Color.DimGray;
            BtnInsert.FlatStyle = FlatStyle.Popup;
            BtnInsert.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BtnInsert.ForeColor = Color.White;
            BtnInsert.Location = new Point(319, 219);
            BtnInsert.Name = "BtnInsert";
            BtnInsert.Size = new Size(120, 30);
            BtnInsert.TabIndex = 4;
            BtnInsert.Text = "Insert";
            BtnInsert.UseVisualStyleBackColor = false;
            BtnInsert.Click += BtnInsert_click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(354, 253);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(51, 19);
            label2.TabIndex = 5;
            label2.Text = "Array";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnSort
            // 
            BtnSort.BackColor = Color.FromArgb(114, 137, 218);
            BtnSort.FlatAppearance.BorderColor = Color.DimGray;
            BtnSort.FlatStyle = FlatStyle.Popup;
            BtnSort.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BtnSort.ForeColor = Color.White;
            BtnSort.Location = new Point(319, 307);
            BtnSort.Name = "BtnSort";
            BtnSort.Size = new Size(120, 30);
            BtnSort.TabIndex = 6;
            BtnSort.Text = "Sort";
            BtnSort.UseVisualStyleBackColor = false;
            BtnSort.Click += BtnSort_Click;
            // 
            // SortandShow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 39, 42);
            ClientSize = new Size(784, 441);
            Controls.Add(BtnSort);
            Controls.Add(label2);
            Controls.Add(BtnInsert);
            Controls.Add(BTN_Prev);
            Controls.Add(BTN_Next);
            Controls.Add(label1);
            Controls.Add(inputNumbers);
            Name = "SortandShow";
            Text = "SortandSearch";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputNumbers;
        private Label label1;
        private Button BTN_Next;
        private Button BTN_Prev;
        private Button BtnInsert;
        private Label label2;
        private Button BtnSort;
    }
}
