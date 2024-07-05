using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace NT106.M21._1_20520924_LAB2
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            listViewFileInfo.Items.Clear();
            FolderBrowserDialog opf = new FolderBrowserDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {

                string[] pathList = Directory.GetFiles(opf.SelectedPath, "*", SearchOption.AllDirectories);
                List<FileInfo> ListFileInfo = new List<FileInfo>();

                foreach (string item in pathList)
                {
                    ListFileInfo.Add(new FileInfo(item));
                }


                foreach (FileInfo fi in ListFileInfo)
                {
                    ListViewItem item = new ListViewItem
                    {
                        Text = fi.Name
                    };
                    listViewFileInfo.Items.Add(item);

                    ListViewItem.ListViewSubItem kichthuoc = new ListViewItem.ListViewSubItem(item, ((fi.Length)).ToString());
                    ListViewItem.ListViewSubItem DuoiMoRong = new ListViewItem.ListViewSubItem(item, ((fi.Extension)).ToString());
                    ListViewItem.ListViewSubItem NgayTao = new ListViewItem.ListViewSubItem(item, ((fi.CreationTime)).ToString());
                    item.SubItems.Add(kichthuoc);
                    item.SubItems.Add(DuoiMoRong);
                    item.SubItems.Add(NgayTao);

                }

            }


        }

        private void listViewFileInfo_ColumnClick(object sender, ColumnClickEventArgs e)
        {

            ListViewColumnSorter sorter = listViewFileInfo.ListViewItemSorter as ListViewColumnSorter;

            if (sorter == null)
            {
                sorter = new ListViewColumnSorter(e.Column);
                sorter.Order = SortOrder.Ascending;
                listViewFileInfo.ListViewItemSorter = sorter;
            }
            // if clicked column is already the column that is being sorted
            if (e.Column == sorter.Column)
            {
                // Reverse the current sort direction
                if (sorter.Order == SortOrder.Ascending)
                    sorter.Order = SortOrder.Descending;
                else
                    sorter.Order = SortOrder.Ascending;
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                sorter.Column = e.Column;
                sorter.Order = SortOrder.Ascending;
            }
            listViewFileInfo.Sort();
        }
    }
}
