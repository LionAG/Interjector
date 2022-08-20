namespace Interjector.Interface
{
    public partial class MainWindow : BaseWindow
    {
        private string? DllPath { get; set; }
        private string? ProcessName { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SetDllFilePathName(string dllFilePath)
        {
            if (Path.GetExtension(dllFilePath) != ".dll")
            {
                MessageBox.Show("Only .dll files are accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DllPath = dllFilePath;
            textBox_Dll.Text = Path.GetFileName(dllFilePath);
        }

        // EVENTS

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.Text = this.AssemblyName;
            this.button_SelectDll.Font = GetFontFromMemory(Resource.Lato_Regular, 9.0f);
            this.button_SelectProcess.Font = GetFontFromMemory(Resource.Lato_Regular, 9.0f);
        }

        private void Panel_Middle_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                SetDllFilePathName(files[0]);
            }
        }

        private void Panel_Middle_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void TextBox_Dll_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                SetDllFilePathName(files[0]);
            }
        }

        private void TextBox_Dll_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Button_SelectDll_Click(object sender, EventArgs e)
        {
            openFileDialog_SelectDll.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (openFileDialog_SelectDll.ShowDialog() == DialogResult.OK)
            {
                SetDllFilePathName(openFileDialog_SelectDll.FileName);
            }
        }

        private void Button_SelectProcess_Click(object sender, EventArgs e)
        {
            var PW = new ProcessWindow();

            PW.ProcessSelected += PW_ProcessSelected;

            PW.ShowDialog();

            PW.ProcessSelected -= PW_ProcessSelected;
        }

        private void PW_ProcessSelected(string name, int id)
        {
            ProcessName = name;
            textBox_Process.Text = name;
        }

        private void Button_Inject_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(DllPath))
            {
                MessageBox.Show("Select the dll file first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(ProcessName))
            {
                MessageBox.Show("Select the process first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Inject the dll.

            try
            {
                if (Injector.DllInjector.Inject(ProcessName, DllPath))
                {
                    MessageBox.Show("Process completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Process failed! See the log file for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("Injecting requires elevated privileges. Please restart the program as administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBox_Process_TextChanged(object sender, EventArgs e)
        {
            ProcessName = ((TextBox)sender).Text;
        }
    }
}
