namespace Interjector.Interface
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Backdrop = new System.Windows.Forms.Panel();
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.button_Inject = new System.Windows.Forms.Button();
            this.panel_Middle = new System.Windows.Forms.Panel();
            this.button_SelectProcess = new System.Windows.Forms.Button();
            this.button_SelectDll = new System.Windows.Forms.Button();
            this.textBox_Process = new System.Windows.Forms.TextBox();
            this.textBox_Dll = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label_TopAppName = new System.Windows.Forms.Label();
            this.openFileDialog_SelectDll = new System.Windows.Forms.OpenFileDialog();
            this.panel_Backdrop.SuspendLayout();
            this.panel_Bottom.SuspendLayout();
            this.panel_Middle.SuspendLayout();
            this.panel_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Backdrop
            // 
            this.panel_Backdrop.Controls.Add(this.panel_Bottom);
            this.panel_Backdrop.Controls.Add(this.panel_Middle);
            this.panel_Backdrop.Controls.Add(this.panel_Top);
            this.panel_Backdrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Backdrop.Location = new System.Drawing.Point(0, 0);
            this.panel_Backdrop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_Backdrop.Name = "panel_Backdrop";
            this.panel_Backdrop.Size = new System.Drawing.Size(658, 333);
            this.panel_Backdrop.TabIndex = 0;
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.Controls.Add(this.button_Inject);
            this.panel_Bottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Bottom.Location = new System.Drawing.Point(0, 228);
            this.panel_Bottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(658, 106);
            this.panel_Bottom.TabIndex = 2;
            // 
            // button_Inject
            // 
            this.button_Inject.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Inject.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.button_Inject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.button_Inject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.button_Inject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Inject.ForeColor = System.Drawing.Color.Black;
            this.button_Inject.Location = new System.Drawing.Point(240, 32);
            this.button_Inject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Inject.Name = "button_Inject";
            this.button_Inject.Size = new System.Drawing.Size(178, 42);
            this.button_Inject.TabIndex = 0;
            this.button_Inject.Text = "INJECT";
            this.button_Inject.UseVisualStyleBackColor = false;
            this.button_Inject.Click += new System.EventHandler(this.Button_Inject_Click);
            // 
            // panel_Middle
            // 
            this.panel_Middle.AllowDrop = true;
            this.panel_Middle.Controls.Add(this.button_SelectProcess);
            this.panel_Middle.Controls.Add(this.button_SelectDll);
            this.panel_Middle.Controls.Add(this.textBox_Process);
            this.panel_Middle.Controls.Add(this.textBox_Dll);
            this.panel_Middle.Controls.Add(this.label2);
            this.panel_Middle.Controls.Add(this.label1);
            this.panel_Middle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Middle.Location = new System.Drawing.Point(0, 76);
            this.panel_Middle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_Middle.Name = "panel_Middle";
            this.panel_Middle.Size = new System.Drawing.Size(658, 152);
            this.panel_Middle.TabIndex = 1;
            this.panel_Middle.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel_Middle_DragDrop);
            this.panel_Middle.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel_Middle_DragEnter);
            // 
            // button_SelectProcess
            // 
            this.button_SelectProcess.BackColor = System.Drawing.Color.Black;
            this.button_SelectProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.button_SelectProcess.Location = new System.Drawing.Point(538, 97);
            this.button_SelectProcess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_SelectProcess.Name = "button_SelectProcess";
            this.button_SelectProcess.Size = new System.Drawing.Size(84, 28);
            this.button_SelectProcess.TabIndex = 5;
            this.button_SelectProcess.Text = "Select";
            this.button_SelectProcess.UseVisualStyleBackColor = false;
            this.button_SelectProcess.Click += new System.EventHandler(this.Button_SelectProcess_Click);
            // 
            // button_SelectDll
            // 
            this.button_SelectDll.BackColor = System.Drawing.Color.Black;
            this.button_SelectDll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.button_SelectDll.Location = new System.Drawing.Point(538, 35);
            this.button_SelectDll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_SelectDll.Name = "button_SelectDll";
            this.button_SelectDll.Size = new System.Drawing.Size(84, 28);
            this.button_SelectDll.TabIndex = 4;
            this.button_SelectDll.Text = "Select";
            this.button_SelectDll.UseVisualStyleBackColor = false;
            this.button_SelectDll.Click += new System.EventHandler(this.Button_SelectDll_Click);
            // 
            // textBox_Process
            // 
            this.textBox_Process.BackColor = System.Drawing.Color.Black;
            this.textBox_Process.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.textBox_Process.Location = new System.Drawing.Point(252, 96);
            this.textBox_Process.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Process.Name = "textBox_Process";
            this.textBox_Process.PlaceholderText = "Process name appears here";
            this.textBox_Process.Size = new System.Drawing.Size(254, 27);
            this.textBox_Process.TabIndex = 3;
            this.textBox_Process.TextChanged += new System.EventHandler(this.TextBox_Process_TextChanged);
            // 
            // textBox_Dll
            // 
            this.textBox_Dll.AllowDrop = true;
            this.textBox_Dll.BackColor = System.Drawing.Color.Black;
            this.textBox_Dll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.textBox_Dll.Location = new System.Drawing.Point(252, 34);
            this.textBox_Dll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Dll.Name = "textBox_Dll";
            this.textBox_Dll.PlaceholderText = "Dll name appears here";
            this.textBox_Dll.ReadOnly = true;
            this.textBox_Dll.Size = new System.Drawing.Size(254, 27);
            this.textBox_Dll.TabIndex = 2;
            this.textBox_Dll.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox_Dll_DragDrop);
            this.textBox_Dll.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBox_Dll_DragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select the target process:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select or drop the DLL:";
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.label_TopAppName);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(658, 76);
            this.panel_Top.TabIndex = 0;
            // 
            // label_TopAppName
            // 
            this.label_TopAppName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TopAppName.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_TopAppName.ForeColor = System.Drawing.Color.Red;
            this.label_TopAppName.Location = new System.Drawing.Point(0, 0);
            this.label_TopAppName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TopAppName.Name = "label_TopAppName";
            this.label_TopAppName.Size = new System.Drawing.Size(658, 76);
            this.label_TopAppName.TabIndex = 0;
            this.label_TopAppName.Text = "INTERJECTOR";
            this.label_TopAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog_SelectDll
            // 
            this.openFileDialog_SelectDll.Filter = "Dll files|*.dll";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 333);
            this.Controls.Add(this.panel_Backdrop);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel_Backdrop.ResumeLayout(false);
            this.panel_Bottom.ResumeLayout(false);
            this.panel_Middle.ResumeLayout(false);
            this.panel_Middle.PerformLayout();
            this.panel_Top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_Backdrop;
        private Panel panel_Top;
        private Label label_TopAppName;
        private Panel panel_Middle;
        private Label label1;
        private Label label2;
        private TextBox textBox_Process;
        private TextBox textBox_Dll;
        private Button button_SelectProcess;
        private Button button_SelectDll;
        private OpenFileDialog openFileDialog_SelectDll;
        private Panel panel_Bottom;
        private Button button_Inject;
    }
}