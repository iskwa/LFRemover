using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LFRemover
{
    public partial class NotifyIconWrapper : Component
    {
        public NotifyIconWrapper()
        {
            InitializeComponent();

            this.toolStripMenuItemOpen.Click += OnToolStripMenuItemOpenOnClick;
            this.toolStripMenuItemExit.Click += OnToolStripMenuItemExitOnClick;
        }

        public NotifyIconWrapper(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void OnToolStripMenuItemOpenOnClick(object sender, EventArgs args)
        {
            new MainWindow().Show();
        }

        private void OnToolStripMenuItemExitOnClick(object sender, EventArgs args)
        {
            Application.Current.Shutdown();
        }
    }
}
