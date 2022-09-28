using System.Reflection;

namespace CSharpLabs.TaskLoader
{
    public partial class TaskLoader : Form
    {
        private TaskLoaderLogic task_loader = new(Assembly.GetExecutingAssembly());

        public TaskLoader()
        {
            this.InitializeComponent();
            this.RefreshButtonClick(this, TreeViewCancelEventArgs.Empty);
            this.task_treeview.AfterSelect += new TreeViewEventHandler(TreeViewAfterSelect);

            this.load_button.Click += new System.EventHandler(LoadButtonClick);
            this.refresh_button.Click += new System.EventHandler(RefreshButtonClick);
            this.info_button.Click += new System.EventHandler(InfoButtonClick);
        }

        private void InfoButtonClick(object? sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.labname_textbox.Text) && !string.IsNullOrEmpty(this.taskname_textbox.Text))
            {
                MessageBox.Show(this.task_loader.GetTaskInfo(this.labname_textbox.Text, this.taskname_textbox.Text),
                    "Информация о задании");
            }
        }

        private void LoadButtonClick(object? sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.labname_textbox.Text) && !string.IsNullOrEmpty(this.taskname_textbox.Text)) 
            {
                this.task_loader.InvokeTask(this.labname_textbox.Text, this.taskname_textbox.Text);
            }
        }

        private void RefreshButtonClick(object? sender, EventArgs e)
        {
            this.task_treeview.Nodes.Clear();
            this.labname_textbox.Text = this.taskname_textbox.Text = string.Empty;

            this.task_loader = new(Assembly.GetExecutingAssembly());
            foreach (var lab in this.task_loader) 
            {
                var lab_node = new TreeNode(lab.Name);
                foreach (var task in lab.Tasks) lab_node.Nodes.Add(new TreeNode(task.Key));

                this.task_treeview.Nodes.Add(lab_node);
            }
        }

        private void TreeViewAfterSelect(object? sender, TreeViewEventArgs e)
        {
            string[] task_path = e.Node!.FullPath.Split('\\');
            if (task_path.Length < 2) return;

            this.labname_textbox.Text = task_path[0];
            this.taskname_textbox.Text = task_path[1];
        }
    }
}