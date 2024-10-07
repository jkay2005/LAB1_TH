using System;
using System.Windows.Forms;

namespace bai02
{
    public partial class Form1 : Form
    {
        int a, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tinh_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(boxA.Text);
                int b = int.Parse(boxB.Text);
                if (bangchon.SelectedItem ==null)
                {
                    MessageBox.Show("Bạn chưa chọn dạng phép tính, hãy chọn lại!");
                    return;
                }
                    if (bangchon.SelectedItem.ToString() == "Bảng Cửu Chương")
                {
                    if (b - a < 0)
                    {
                        MessageBox.Show("Không có bảng cửu chương cho số âm!");
                        return;
                    }
                    TinhBangCuuChuong(a, b);
                }
                else if (bangchon.SelectedItem.ToString() == "Tính Các Giá Trị")
                {
                    TinhCacGiaTri(a, b);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }
        private void TinhBangCuuChuong(int a, int b)
        {
            int hieu = b - a;
            string ketQua = $"Bảng cửu chương của {hieu}:\n";

            for (int i = 1; i <= 10; i++)
            {
                ketQua += $"{hieu} x {i} = {hieu * i}\n";
            }
            bangkq.Text = ketQua;
        }

        private void TinhCacGiaTri(int a, int b)
        {
            int hieu = a - b;
            int giaiThua = TinhGiaiThua(hieu);
            int tongS = TinhTongS(a, b);

            bangkq.Text = $"(A - B)! = {giaiThua}\nTổng S=A^1 + A^2 + A^3 + ... + A^B = {tongS}";
        }

        private int TinhGiaiThua(int n)
        {
            int giaiThua = 1;
            for (int i = 1; i <= n; i++)
            {
                giaiThua *= i;
            }
            return giaiThua;
        }

        private int TinhTongS(int a, int b)
        {
            int tongS = 0;
            for (int i = 1; i <= b; i++)
            {
                tongS += (int)Math.Pow(a, i); ;
            }
            return tongS;
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            boxA.Text = "";
            boxB.Text = "";
            bangkq.Text = "";
        }

        private void bangchon_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bangchon.Items.Add("Bảng Cửu Chương");
            //bangchon.Items.Add("Tính Toán Giá Trị");
        }

        private void boxB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
