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
        string version = "v1.0.1";
        public MainForm()
        {
            InitializeComponent();
            vERSIONToolStripMenuItem.Text = version;
        }
        List<byte> data = new List<byte>();
        String path;
        private void B_OpenFile_Click(object sender, EventArgs e)
        {
        }

        private void PopulateList()
        {
            if (data[0] == 1)
            {
                checkBox1.Checked = true;
            }
            if (data[1] == 1)
                checkBox2.Checked = true;
            if (data[2] == 1)
                checkBox3.Checked = true;
            if (data[3] == 1)
                checkBox4.Checked = true;
            byte cheatsCount = data[0x34];

            cheatList.Items.Clear();
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
                byte[] tmp;
                tmp = data.ToArray();
                TB_CheatAddress.Text = BitConverter.ToInt32(tmp, 0x42 + (index * 0x40)).ToString("X");
                TB_CheatValue.Text = BitConverter.ToInt32(tmp, 0x46 + (index * 0x40)).ToString("X");
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
            if (data.Count < 0x30)
            {
                MessageBox.Show("Please load a CTRPFData.bin first.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            byte cheatCount = data[0x34];
            byte[] CheatData = {
            0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x6E, 0x65, 0x77, 0x20, 0x63, 0x68, 0x65, 0x61, 0x74, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00
        };
            for (int i = 0; i < 0x40; i++)
            {
                data.Insert(0x40 + (0x40 * cheatCount) + i, CheatData[i]);
            }
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
                    data.Clear();
                    byte[] tmp;
                    path = openFileDialog.FileName;
                    tmp = File.ReadAllBytes(path);
                    if (tmp.Length > 0x80 && tmp.Length == 0x80 + tmp[0x34] * 0x40 && tmp.Length % 0x40 == 0) //check the integrity of the file
                    {
                        data.AddRange(tmp);
                        PopulateList();
                    }
                    else
                    {
                        MessageBox.Show("Your file seems to invalid. Please make sure it's a CTRPFData.bin first.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
            if (cheatList.SelectedItem == null)
            {
                MessageBox.Show("Please select a cheat from the cheatlist first.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            byte[] CheatData = {
            0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x6E, 0x65, 0x77, 0x20, 0x63, 0x68, 0x65, 0x61, 0x74, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00
            };
            int index = cheatList.Items.IndexOf(cheatList.SelectedItem);

            if (RB_8.Checked)
                CheatData[0] = 1;
            if (RB_16.Checked)
                CheatData[0] = 2;
            if (RB_32.Checked)
                CheatData[0] = 4;

            Int32 address = Int32.Parse(TB_CheatAddress.Text, System.Globalization.NumberStyles.HexNumber);
            Int32 value = Int32.Parse(TB_CheatValue.Text, System.Globalization.NumberStyles.HexNumber);
            byte[] tmp;
            tmp = BitConverter.GetBytes(address);
            for (int i = 0; i < tmp.Length; i++)
            {
                CheatData[5 - i] = tmp[i]; //use little endian
            }
            tmp = BitConverter.GetBytes(value);
            for (int i = 0; i < tmp.Length; i++)
            {
                CheatData[9 - i] = tmp[i]; //use little endian
            }

            tmp = Encoding.ASCII.GetBytes(TB_CheatName.Text);
            for (int i = 0; i < tmp.Length; i++)
            {
                CheatData[0xE + i] = tmp[i];
            }
            for (int i = 0; i < CheatData.Length; i++)
            {
                data[0x40 + (0x40 * index) + i] = CheatData[i];
            }
            MessageBox.Show("Cheat saved!");
            PopulateList();
        }

        private void RB_8_CheckedChanged(object sender, EventArgs e)
        {
            TB_CheatValue.MaxLength = 2;
        }

        private void TB_CheatAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_CheatValue_TextChanged(object sender, EventArgs e)
        {

        }


        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] tmp;
            tmp = data.ToArray();
            File.WriteAllBytes(path, tmp);
        }

        private void B_RemoveCheat_Click(object sender, EventArgs e)
        {
            if (cheatList.SelectedItem == null)
            {
                MessageBox.Show("Please select a cheat from the cheatlist first.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int index = cheatList.Items.IndexOf(cheatList.SelectedItem);
            for (int i = 0; i < 0x40; i++)
            {
                data.RemoveAt(0x40 + (0x40 * index) + i);
            }
            data[0x34]--;
            PopulateList();
        }

        private void RB_16_CheckedChanged(object sender, EventArgs e)
        {
            TB_CheatValue.MaxLength = 4;
        }

        private void RB_32_CheckedChanged(object sender, EventArgs e)
        {
            TB_CheatValue.MaxLength = 8;
        }

        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/RyDog199/ctrpf-editor");
        }

        private void gBATempThreadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://gbatemp.net/threads/release-ctrpf-data-tool-a-ctrpfdata-bin-editor.483864/");
        }

        private void vERSIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/RyDog199/ctrpf-editor/releases/");
        }
    }
}
