namespace sortAndSearchApp
{
    partial class nameSort
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
            BTN_Prev = new Button();
            BTN_Next = new Button();
            nameInsertionBox = new TextBox();
            BTN_Insert = new Button();
            BTN_Sort = new Button();
            nameArray = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(341, 67);
            label1.Name = "label1";
            label1.Size = new Size(118, 19);
            label1.TabIndex = 0;
            label1.Text = "name: (String)";
            // 
            // BTN_Prev
            // 
            BTN_Prev.BackColor = Color.FromArgb(114, 137, 218);
            BTN_Prev.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BTN_Prev.ForeColor = Color.White;
            BTN_Prev.Location = new Point(12, 408);
            BTN_Prev.Name = "BTN_Prev";
            BTN_Prev.Size = new Size(120, 30);
            BTN_Prev.TabIndex = 5;
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
            BTN_Next.TabIndex = 4;
            BTN_Next.Text = "Next ->";
            BTN_Next.UseVisualStyleBackColor = false;
            BTN_Next.Click += BTN_Next_Click;
            // 
            // nameInsertionBox
            // 
            nameInsertionBox.Location = new Point(350, 89);
            nameInsertionBox.Name = "nameInsertionBox";
            nameInsertionBox.Size = new Size(100, 23);
            nameInsertionBox.TabIndex = 6;
            // 
            // BTN_Insert
            // 
            BTN_Insert.BackColor = Color.FromArgb(114, 137, 218);
            BTN_Insert.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BTN_Insert.ForeColor = Color.White;
            BTN_Insert.Location = new Point(340, 118);
            BTN_Insert.Name = "BTN_Insert";
            BTN_Insert.Size = new Size(120, 30);
            BTN_Insert.TabIndex = 7;
            BTN_Insert.Text = "Insert to Array";
            BTN_Insert.UseVisualStyleBackColor = false;
            BTN_Insert.Click += BTN_Insert_Click;
            // 
            // BTN_Sort
            // 
            BTN_Sort.BackColor = Color.FromArgb(114, 137, 218);
            BTN_Sort.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BTN_Sort.ForeColor = Color.White;
            BTN_Sort.Location = new Point(340, 231);
            BTN_Sort.Name = "BTN_Sort";
            BTN_Sort.Size = new Size(120, 30);
            BTN_Sort.TabIndex = 8;
            BTN_Sort.Text = "Sort";
            BTN_Sort.UseVisualStyleBackColor = false;
            BTN_Sort.Click += BTN_Sort_Click;
            // 
            // nameArray
            // 
            nameArray.AutoSize = true;
            nameArray.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameArray.ForeColor = Color.White;
            nameArray.Location = new Point(369, 180);
            nameArray.Name = "nameArray";
            nameArray.Size = new Size(62, 19);
            nameArray.TabIndex = 9;
            nameArray.Text = "names";
            // 
            // nameSort
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 39, 42);
            ClientSize = new Size(800, 450);
            Controls.Add(nameArray);
            Controls.Add(BTN_Sort);
            Controls.Add(BTN_Insert);
            Controls.Add(nameInsertionBox);
            Controls.Add(BTN_Prev);
            Controls.Add(BTN_Next);
            Controls.Add(label1);
            Name = "nameSort";
            Text = "nameSort";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BTN_Prev;
        private Button BTN_Next;
        private TextBox nameInsertionBox;
        private Button BTN_Insert;
        private Button BTN_Sort;
        private Label nameArray;
    }
}