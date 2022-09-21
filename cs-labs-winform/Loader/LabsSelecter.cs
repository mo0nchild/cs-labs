using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CSharpLabs.Supports;
using System.Reflection;

namespace CSharpLabs.Loader
{
    public partial class LabsSelecter : Form
    {
        private LoaderSupport labs_loader = new(Assembly.GetExecutingAssembly());

        public LabsSelecter()
        {
            this.InitializeComponent();
            this.RefreshButtonClick(this, EventArgs.Empty);

            this.load_button.Click += new EventHandler(LoadButtonClick);
            this.refresh_button.Click += new EventHandler(RefreshButtonClick);
        }

        private void LoadButtonClick(object? sender, EventArgs e)
        {
            this.labs_loader.InvokeTask(this.labs_listview.SelectedItems[0].Index);
        }

        private void RefreshButtonClick(object? sender, EventArgs e) 
        {
            this.labs_loader = new LoaderSupport(Assembly.GetExecutingAssembly());

            this.labs_listview.Items.Clear();
            foreach (var lab in this.labs_loader) 
            {
                ListViewItem new_row = new ListViewItem(lab.Type.Assembly.GetName().Name);
                new_row.SubItems.Add(lab.Type.FullName);
                new_row.SubItems.Add(lab.Name);
                this.labs_listview.Items.Add(new_row);
            }

            this.labs_listview.Refresh();
        }
    }
}
