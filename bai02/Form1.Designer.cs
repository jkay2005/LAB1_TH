namespace bai02
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
            boxA = new TextBox();
            boxB = new TextBox();
            bangkq = new RichTextBox();
            tinh = new Button();
            xoa = new Button();
            thoat = new Button();
            label1 = new Label();
            tenb = new Label();
            label3 = new Label();
            bangchon = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // boxA
            // 
            boxA.Location = new Point(158, 22);
            boxA.Name = "boxA";
            boxA.Size = new Size(100, 23);
            boxA.TabIndex = 0;
            // 
            // boxB
            // 
            boxB.Location = new Point(523, 27);
            boxB.Name = "boxB";
            boxB.Size = new Size(100, 23);
            boxB.TabIndex = 1;
            boxB.TextChanged += boxB_TextChanged;
            // 
            // bangkq
            // 
            bangkq.ForeColor = Color.Navy;
            bangkq.Location = new Point(22, 211);
            bangkq.Name = "bangkq";
            bangkq.ReadOnly = true;
            bangkq.Size = new Size(749, 153);
            bangkq.TabIndex = 2;
            bangkq.Text = "";
            bangkq.TextChanged += richTextBox1_TextChanged;
            // 
            // tinh
            // 
            tinh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tinh.ForeColor = Color.MidnightBlue;
            tinh.Location = new Point(142, 139);
            tinh.Name = "tinh";
            tinh.Size = new Size(137, 43);
            tinh.TabIndex = 3;
            tinh.Text = "Tính Toán GIá Trị";
            tinh.UseVisualStyleBackColor = true;
            tinh.Click += tinh_Click;
            // 
            // xoa
            // 
            xoa.ForeColor = Color.Navy;
            xoa.Location = new Point(342, 149);
            xoa.Name = "xoa";
            xoa.Size = new Size(75, 23);
            xoa.TabIndex = 4;
            xoa.Text = "Xóa ";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // thoat
            // 
            thoat.ForeColor = Color.Red;
            thoat.Location = new Point(534, 150);
            thoat.Name = "thoat";
            thoat.Size = new Size(75, 23);
            thoat.TabIndex = 5;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(71, 30);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 6;
            label1.Text = "Nhập A:";
            // 
            // tenb
            // 
            tenb.AutoSize = true;
            tenb.ForeColor = Color.DarkBlue;
            tenb.Location = new Point(468, 30);
            tenb.Name = "tenb";
            tenb.Size = new Size(49, 15);
            tenb.TabIndex = 7;
            tenb.Text = "Nhập B:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 317);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 8;
            // 
            // bangchon
            // 
            bangchon.FormattingEnabled = true;
            bangchon.Items.AddRange(new object[] { "Bảng Cửu Chương", "Tính Các Giá Trị" });
            bangchon.Location = new Point(313, 76);
            bangchon.Name = "bangchon";
            bangchon.Size = new Size(121, 23);
            bangchon.TabIndex = 9;
            bangchon.SelectedIndexChanged += bangchon_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(22, 191);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 10;
            label2.Text = "Kết Quả";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(bangchon);
            Controls.Add(label3);
            Controls.Add(tenb);
            Controls.Add(label1);
            Controls.Add(thoat);
            Controls.Add(xoa);
            Controls.Add(tinh);
            Controls.Add(bangkq);
            Controls.Add(boxB);
            Controls.Add(boxA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox boxA;
        private TextBox boxB;
        private RichTextBox bangkq;
        private Button tinh;
        private Button xoa;
        private Button thoat;
        private Label label1;
        private Label tenb;
        private Label label3;
        private ComboBox bangchon;
        private Label label2;
    }
}
