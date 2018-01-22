using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProcessManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadProcesses();

            //Associating UI Components with the respective event method.
            //btnSchedule.Click += new EventHandler(ButtonSchedule_Click);
        }

        private void LoadProcesses()
        {
            // Get all processes running on the local computer.
            Process[] localAll = Process.GetProcesses();
            ListViewItem item;
            ListViewItem.ListViewSubItem[] subItems;
            foreach (var process in localAll)
            {
                //var driveImage = listViewImageList.Images.IndexOfKey(attr);
                item = new ListViewItem(process.ProcessName);
                subItems = new ListViewItem.ListViewSubItem[]
                          {new ListViewItem.ListViewSubItem(item, process.Id.ToString())
                              //new ListViewItem.ListViewSubItem(item,
                              //dirInfo.LastAccessTime.ToShortDateString())
                          };
                item.SubItems.AddRange(subItems);
                //item.Tag = dirInfo;
                listViewProcesses.Items.Add(item);
            }
        }
    }
}
