using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MAServer
{
    public partial class MAServer : Form
    {
        Server server = new Server();
        public MAServer()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
        }
        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                DownloadList.Add_to_List(file);
            }
            List<Label> lbls = FileTabPage.Controls.OfType<Label>().ToList();
            foreach (Label lbl in lbls)
            {
                FileTabPage.Controls.Remove(lbl);
            }
            List<Button> btns = FileTabPage.Controls.OfType<Button>().ToList();
            foreach (Button btn in btns)
            {
                if (btn.Text != "Add")
                    FileTabPage.Controls.Remove(btn);
            }
            int x = 0;
            int y = 25;
            foreach (String file in DownloadList.download_list)
            {
                int index = DownloadList.Get_File_Index(file);
                String[] fileDirectories = file.Split('\\');
                String Filename = fileDirectories[fileDirectories.Length - 1];
                Label label = new Label
                {
                    Size = new Size(266, 23),
                    Location = new Point(x, y),
                    Text = index + " : " + Filename,
                    TextAlign = ContentAlignment.MiddleLeft,
                    BackColor = Color.GreenYellow

                };

                Button btn = new Button
                {
                    Size = new Size(20, 23),
                    Location = new Point(266, y),
                    Text = "X",
                    FlatStyle = FlatStyle.Popup,
                    BackColor = Color.OrangeRed

                };
                FileTabPage.Controls.Add(label);
                FileTabPage.Controls.Add(btn);

                btn.Click += (object s, EventArgs ev) =>
                {
                    DownloadList.Remove_By_Index(index);
                    FileTabPage.Controls.Remove(label);
                    FileTabPage.Controls.Remove(btn);
                    lbls = FileTabPage.Controls.OfType<Label>().ToList();

                    foreach (Label lbl in lbls)
                    {
                        if (lbl.TabIndex > label.TabIndex)
                        {
                            lbl.Location = new Point(x, lbl.Location.Y - 25);
                            string[] text = lbl.Text.Split(':');
                            int idx = Convert.ToInt32(text[0]);
                            lbl.Text = idx - 1 + " : " + text[1];
                        }
                    }
                    btns = FileTabPage.Controls.OfType<Button>().ToList();
                    foreach (Button button in btns)
                    {
                        if (button.Text != "Add")
                            if (button.TabIndex > btn.TabIndex)
                                button.Location = new Point(266, button.Location.Y - 25);
                    }
                };
                y += 25;
                FileTabPage.AutoScroll = true;

            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string IP = Server.GetIPAddress()[0];
            string PORT = "80";
            string MachineName = Environment.MachineName;
            NetworkNameLabel.Text += "\n" + Server.GetIPAddress()[1];
            IP_PORTLabel.Text += IP + ":" + PORT;
            DeviceNameLabel.Text += MachineName;
            IPLabel.Text += IP + ":" + PORT;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            server.Start_Server();
            while (panel1.Size.Height != 0 & panel1.Size.Width != 0)
            {
                Size size = new Size();
                size.Height = panel1.Size.Height - 2;
                size.Width = panel1.Size.Width - 1;

                panel1.Size = size;
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            server.Stop_Server();
            Size size = new Size();
            size.Height = 532;
            size.Width = 307;
            panel1.Size = size;
        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "F:\\";
            openFileDialog.Filter = "All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String File_Path = openFileDialog.FileName;
                FilesTextBox.Text = File_Path;
                DownloadList.Add_to_List(File_Path);
                List<Label> lbls = FileTabPage.Controls.OfType<Label>().ToList();
                foreach (Label lbl in lbls)
                {
                    FileTabPage.Controls.Remove(lbl);
                }
                List<Button> btns = FileTabPage.Controls.OfType<Button>().ToList();
                foreach (Button btn in btns)
                {
                    if (btn.Text != "Add")
                        FileTabPage.Controls.Remove(btn);
                }
                int x = 0;
                int y = 25;
                foreach (String file in DownloadList.download_list)
                {
                    int index = DownloadList.Get_File_Index(file);
                    String[] fileDirectories = file.Split('\\');
                    String Filename = fileDirectories[fileDirectories.Length - 1];
                    Label label = new Label
                    {
                        Size = new Size(266, 23),
                        Location = new Point(x, y),
                        Text = index + " : " + Filename,
                        TextAlign = ContentAlignment.MiddleLeft,
                        BackColor = Color.GreenYellow

                    };

                    Button btn = new Button
                    {
                        Size = new Size(20, 23),
                        Location = new Point(266, y),
                        Text = "X",
                        FlatStyle = FlatStyle.Popup,
                        BackColor = Color.OrangeRed

                    };
                    FileTabPage.Controls.Add(label);
                    FileTabPage.Controls.Add(btn);

                    btn.Click += (object s, EventArgs ev) =>
                    {
                        DownloadList.Remove_By_Index(index);
                        FileTabPage.Controls.Remove(label);
                        FileTabPage.Controls.Remove(btn);
                        lbls = FileTabPage.Controls.OfType<Label>().ToList();

                        foreach (Label lbl in lbls)
                        {
                            if (lbl.TabIndex > label.TabIndex)
                            {
                                lbl.Location = new Point(x, lbl.Location.Y - 25);
                                string[] text = lbl.Text.Split(':');
                                int idx = Convert.ToInt32(text[0]);
                                lbl.Text = idx - 1 + " : " + text[1];
                            }
                        }
                        btns = FileTabPage.Controls.OfType<Button>().ToList();
                        foreach (Button button in btns)
                        {
                            if (button.Text != "Add")
                                if (button.TabIndex > btn.TabIndex)
                                    button.Location = new Point(266, button.Location.Y - 25);
                        }
                    };
                    y += 25;
                    FileTabPage.AutoScroll = true;

                }

            }
        }//EOF AddFileButton_Click

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            List<Label> lbls = UsersTabPage.Controls.OfType<Label>().ToList();
            foreach (Label lbl in lbls)
            {
                UsersTabPage.Controls.Remove(lbl);
            }

            int y = 25;
            int index = 1;
            foreach (String user in Users.user_list)
            {
                Label label = new Label
                {
                    Size = new Size(305, 48),
                    Location = new Point(1, y),
                    Text = index + " : " + user,
                    TextAlign = ContentAlignment.MiddleLeft,
                    BackColor = Color.Snow

                };

                UsersTabPage.Controls.Add(label);
                y += 50;
                index += 1;
                UsersTabPage.AutoScroll = true;
            }

        }


    }
}
