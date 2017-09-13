using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Windows;

namespace CTRPFTool
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }
        byte[] data;
        String path;
        private void B_OpenFile_Click(object sender, EventArgs e)
        {
        }

        private void PopulateList()
        {
            if (data[0x0] == 1)
                checkBox1.Checked = true;
            if (data[1] == 1)
                checkBox2.Checked = true;
            if (data[2] == 1)
                checkBox3.Checked = true;
            if (data[3] == 1)
                checkBox4.Checked = true;
            byte cheatsCount = data[0x34];

            for (int i = 0; i < cheatsCount; i++)
            {
                byte[] name = new byte[50];
                for (int j = 0; j < 50; j++)
                {
                    name[j] = data[0x4E + (i * 0x40) + j];
                }
                cheatList.Items.Add(System.Text.Encoding.Default.GetString(name));
                
            }
        }


        private void cheatList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cheatList.SelectedItem != null)
            {
                int index;
                index = cheatList.Items.IndexOf(cheatList.SelectedItem);
                TB_CheatName.Text = cheatList.Items[index].ToString();
                TB_CheatAddress.Text = BitConverter.ToInt32(data, 0x42 + (index * 0x40)).ToString("X");
                TB_CheatValue.Text = BitConverter.ToInt32(data, 0x46 + (index * 0x40)).ToString("X");
                switch (data[0x40 + (index * 0x40)])
                {
                    case 1:
                        RB_8.Checked = true;
                        break;
                    case 2:
                        RB_16.Checked = true;
                        break;
                    case 4:
                        RB_32.Checked = true;
                        break;
                    default:
                        break;

                }
            }
        }

        private void B_AddCheat_Click(object sender, EventArgs e)
        {
            byte cheatCount = data[0x34];
            byte[] CheatData = {
            0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x6E, 0x65, 0x77, 0x20, 0x63, 0x68, 0x65, 0x61, 0x74, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00
        };
            List<byte> newCheat = new List<byte>();
            newCheat.AddRange(data);
            foreach (byte i in data)
            {
                newCheat.Add(data[i]);
            }

            for (int i = 0; i < 0x40; i++)
            {
                newCheat.Insert(0x40 + (0x40 * cheatCount), CheatData[i]);
            }
            data = newCheat.ToArray();
            data[0x34]++;
            PopulateList();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TB_CheatName_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CTR Plugin BIN|*.bin";
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;
                    data = File.ReadAllBytes(path);
                    PopulateList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message + "\n\nYour file propably doesn't have any cheats saved.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RB_8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TB_CheatAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_CheatValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllBytes(path, data);
        }
    }
}
