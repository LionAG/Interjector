using System.Data;
using System.Diagnostics;

namespace Interjector.Interface
{
    public delegate void ProcessSelectedHandler(string name, int id);
    public partial class ProcessWindow : BaseWindow
    {
        public event ProcessSelectedHandler? ProcessSelected;

        public ProcessWindow()
        {
            InitializeComponent();
        }

        private void PopulateProcessList()
        {
            listBox_Processes.Items.Clear();

            Process.GetProcesses().OrderBy(p => p.ProcessName).ToList().ForEach((p) =>
            {
                listBox_Processes.Items.Add(new ListableProcess(p));
            });
        }

        private void ProcessWindow_Load(object sender, EventArgs e)
        {
            Text = $"{AssemblyName} - Processes";
            label_Header.Font = GetFontFromMemory(Resource.Lato_Regular, 12.0f);

            var fontLato9 = GetFontFromMemory(Resource.Lato_Regular, 9.0f);

            button_Close.Font = fontLato9;
            button_Refresh.Font = fontLato9;
            button_Select.Font = fontLato9;

            PopulateProcessList();
        }

        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            PopulateProcessList();
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Select_Click(object sender, EventArgs e)
        {
            if (listBox_Processes.SelectedItem != null)
            {
                var LP = (ListableProcess)this.listBox_Processes.SelectedItem;
                ProcessSelected?.Invoke(LP.p.ProcessName, LP.p.Id);

                this.Close();
            }
        }

        private void ListBox_Processes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var LP = (ListableProcess)this.listBox_Processes.SelectedItem;
            ProcessSelected?.Invoke(LP.p.ProcessName, LP.p.Id);
        }
    }

    internal class ListableProcess
    {
        public Process p;

        public override string ToString()
        {
            return $"{p.ProcessName} ({p.Id})";
        }

        public ListableProcess(Process p)
        {
            this.p = p;
        }
    }

}
