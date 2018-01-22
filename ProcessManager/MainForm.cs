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
            long constant = 1024;
            var status = "";
            foreach (var process in localAll)
            {
                try
                {
                    if (process.Responding)
                    {
                        status = "Running";
                    }
                    else
                    {
                        status = "Not Responding";
                    }

                    var fileVersion = process.MainModule.FileVersionInfo;
                    //var driveImage = listViewImageList.Images.IndexOfKey(attr);
                    item = new ListViewItem(process.MainModule.ModuleName);
                    subItems = new ListViewItem.ListViewSubItem[]
                              {new ListViewItem.ListViewSubItem(item, fileVersion.FileDescription),
                                  new ListViewItem.ListViewSubItem(item, process.Id.ToString()),
                                  new ListViewItem.ListViewSubItem(item, (process.WorkingSet64/constant).ToString() + " K"),
                                  new ListViewItem.ListViewSubItem(item, status)
                              };
                    item.SubItems.AddRange(subItems);
                    listViewProcesses.Items.Add(item);
                    
                }
                catch
                {
                    //Omit processes where we do not have permission to read their details.
                }
                
            }
        }
    }
}
