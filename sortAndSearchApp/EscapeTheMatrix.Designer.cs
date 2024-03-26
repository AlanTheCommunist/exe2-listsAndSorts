namespace exercises
{
    partial class EscapeTheMatrix
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
            BTN_Prev = new Button();
            BTN_Next = new Button();
            dataGridView1 = new DataGridView();
            Btn_Transpose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BTN_Prev
            // 
            BTN_Prev.BackColor = Color.FromArgb(114, 137, 218);
            BTN_Prev.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BTN_Prev.ForeColor = Color.White;
            BTN_Prev.Location = new Point(12, 408);
            BTN_Prev.Name = "BTN_Prev";
            BTN_Prev.Size = new Size(120, 30);
            BTN_Prev.TabIndex = 7;
            BTN_Prev.Text = "<- Previous";
            BTN_Prev.UseVisualStyleBackColor = false;
            // 
            // BTN_Next
            // 
            BTN_Next.BackColor = Color.FromArgb(114, 137, 218);
            BTN_Next.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BTN_Next.ForeColor = Color.White;
            BTN_Next.Location = new Point(666, 408);
            BTN_Next.Name = "BTN_Next";
            BTN_Next.Size = new Size(120, 30);
            BTN_Next.TabIndex = 6;
            BTN_Next.Text = "Next ->";
            BTN_Next.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(300, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 18;
            dataGridView1.Size = new Size(200, 200);
            dataGridView1.TabIndex = 8;
            // 
            // Btn_Transpose
            // 
            Btn_Transpose.BackColor = Color.FromArgb(114, 137, 218);
            Btn_Transpose.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            Btn_Transpose.ForeColor = Color.White;
            Btn_Transpose.Location = new Point(340, 291);
            Btn_Transpose.Name = "Btn_Transpose";
            Btn_Transpose.Size = new Size(120, 30);
            Btn_Transpose.TabIndex = 10;
            Btn_Transpose.Text = "Transpose";
            Btn_Transpose.UseVisualStyleBackColor = false;
            Btn_Transpose.Click += BtnTranspose_Click;
            // 
            // EscapeTheMatrix
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 39, 42);
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_Transpose);
            Controls.Add(dataGridView1);
            Controls.Add(BTN_Prev);
            Controls.Add(BTN_Next);
            Name = "EscapeTheMatrix";
            Text = "EscapeTheMatrix";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BTN_Prev;
        private Button BTN_Next;
        private DataGridView dataGridView1;
        private Button Btn_Transpose;
    }
}