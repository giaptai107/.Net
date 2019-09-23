using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG12019
{
    public partial class frmThongTinhSinhVien : Form
    {
        string pathAvatarFolder;
        public frmThongTinhSinhVien()
        {
            InitializeComponent();
            pathAvatarFolder = Application.StartupPath + @"\avatar";
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh đại diện";
            openFileDialog.Filter = "Bạn phải chọn file ảnh (*.png, *.jpg| *.png;*.jpg)";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(fileName);

                if(!Directory.Exists(Application.StartupPath +"\\avatar"))
                    Directory.CreateDirectory(pathAvatarFolder);
                pictureBox1.Image.Save(pathAvatarFolder + @"\avatar.png");
            }
        }
    }
}
