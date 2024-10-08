﻿using System.Windows.Forms;
using ATA_GUI.Utils;

namespace ATA_GUI
{
    public partial class ScrollableMessageBoxForm : Form
    {
        public ScrollableMessageBoxForm()
        {
            InitializeComponent();
        }

        public static void show(string text, string title)
        {
            ScrollableMessageBoxForm scrollableMessageBox = new()
            {
                Text = title
            };
            scrollableMessageBox.richTextBox.Text = text;
            scrollableMessageBox.Show();
        }

        private void richTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            ConsoleProcess.OpenLink(e.LinkText);
        }
    }
}
