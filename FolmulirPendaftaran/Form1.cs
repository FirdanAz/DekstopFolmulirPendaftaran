using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolmulirPendaftaran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ini akan menyebabkan formulir yang anda isi tidak tersimpan ", "Yakin Ingin Keluar?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Ini akan menyebabkan formulir yang anda isi tidak tersimpan ", "Yakin Ingin MeReset?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                txtNoPendaftaran.Text = "";
                txtNamaLengkap.Text = "";
                txtAlamatLengkap.Text = "";
                txtNoWa.Text = "";
                rbLaki.Checked = false;
                rbPerempuan.Checked = false;
                txtTempatLahir.Text = "";
                comboBoxTanggal.Text = "";
                comboBoxBulan.Text = "";
                comboBoxTahun.Text = "";
                txtEmail.Text = "";
                txtTanggalDaftar.Text = "";
                resultPendaftaran.Text = "";
            }
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            string check = "";
            if (rbLaki.Checked == true)
                check = rbLaki.Text;
            else if (rbPerempuan.Checked == true)
                check = rbPerempuan.Text;
            else
                check = "";

            resultPendaftaran.Text =
                "No Pendaftaran    : " + txtNoPendaftaran.Text + "\n" +
                "Nama Lengkap      : " + txtNamaLengkap.Text + "\n" +
                "Alamat Lengkap    : " + txtAlamatLengkap.Text + "\n" +
                "Nomor Telepon     : " + txtNoWa.Text + "\n" +
                "Jenis Kelamin     : " + check + "\n" +
                "Tempat Lahir      : " + txtTempatLahir.Text + "\n" +
                "Tanggal Lahir     : " + comboBoxTanggal.Text + comboBoxBulan.Text + comboBoxTahun.Text + "\n" +
                "Alamat Email      : " + txtEmail.Text + "\n" +
                "Tanggal Pendaftaran     : " + txtTanggalDaftar.Text;
            
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            monthCalendar1.Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtTanggalDaftar.Text = monthCalendar1.SelectionRange.Start.ToString("dd MMM yyyy");
            monthCalendar1.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
