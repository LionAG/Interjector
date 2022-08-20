namespace Interjector.Interface
{
    partial class ProcessWindow
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
            this.panel_Content = new System.Windows.Forms.Panel();
            this.label_Header = new System.Windows.Forms.Label();
            this.flowLayoutPanel_Buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Select = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.listBox_Processes = new System.Windows.Forms.ListBox();
            this.panel_Content.SuspendLayout();
            this.flowLayoutPanel_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Content
            // 
            this.panel_Content.Controls.Add(this.label_Header);
            this.panel_Content.Controls.Add(this.flowLayoutPanel_Buttons);
            this.panel_Content.Controls.Add(this.listBox_Processes);
            this.panel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Content.Location = new System.Drawing.Point(0, 0);
            this.panel_Content.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(410, 580);
            this.panel_Content.TabIndex = 0;
            // 
            // label_Header
            // 
            this.label_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Header.ForeColor = System.Drawing.Color.Red;
            this.label_Header.Location = new System.Drawing.Point(0, 0);
            this.label_Header.Name = "label_Header";
            this.label_Header.Size = new System.Drawing.Size(410, 78);
            this.label_Header.TabIndex = 5;
            this.label_Header.Text = "SELECT THE PROCESS";
            this.label_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel_Buttons
            // 
            this.flowLayoutPanel_Buttons.Controls.Add(this.button_Select);
            this.flowLayoutPanel_Buttons.Controls.Add(this.button_Refresh);
            this.flowLayoutPanel_Buttons.Controls.Add(this.button_Close);
            this.flowLayoutPanel_Buttons.Location = new System.Drawing.Point(13, 492);
            this.flowLayoutPanel_Buttons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel_Buttons.Name = "flowLayoutPanel_Buttons";
            this.flowLayoutPanel_Buttons.Size = new System.Drawing.Size(383, 74);
            this.flowLayoutPanel_Buttons.TabIndex = 4;
            // 
            // button_Select
            // 
            this.button_Select.BackColor = System.Drawing.Color.Black;
            this.button_Select.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.button_Select.Location = new System.Drawing.Point(22, 23);
            this.button_Select.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.button_Select.Name = "button_Select";
            this.button_Select.Size = new System.Drawing.Size(83, 30);
            this.button_Select.TabIndex = 1;
            this.button_Select.Text = "Select";
            this.button_Select.UseVisualStyleBackColor = false;
            this.button_Select.Click += new System.EventHandler(this.Button_Select_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.BackColor = System.Drawing.Color.Black;
            this.button_Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.button_Refresh.Location = new System.Drawing.Point(149, 23);
            this.button_Refresh.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(83, 30);
            this.button_Refresh.TabIndex = 2;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = false;
            this.button_Refresh.Click += new System.EventHandler(this.Button_Refresh_Click);
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.Black;
            this.button_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.button_Close.Location = new System.Drawing.Point(276, 23);
            this.button_Close.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(83, 30);
            this.button_Close.TabIndex = 3;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // listBox_Processes
            // 
            this.listBox_Processes.BackColor = System.Drawing.Color.Black;
            this.listBox_Processes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.listBox_Processes.ItemHeight = 21;
            this.listBox_Processes.Location = new System.Drawing.Point(13, 82);
            this.listBox_Processes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox_Processes.Name = "listBox_Processes";
            this.listBox_Processes.Size = new System.Drawing.Size(383, 403);
            this.listBox_Processes.TabIndex = 0;
            this.listBox_Processes.SelectedIndexChanged += new System.EventHandler(this.ListBox_Processes_SelectedIndexChanged);
            // 
            // ProcessWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 580);
            this.Controls.Add(this.panel_Content);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProcessWindow";
            this.Text = "ProcessWindow";
            this.Load += new System.EventHandler(this.ProcessWindow_Load);
            this.panel_Content.ResumeLayout(false);
            this.flowLayoutPanel_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_Content;
        private ListBox listBox_Processes;
        private FlowLayoutPanel flowLayoutPanel_Buttons;
        private Button button_Select;
        private Button button_Refresh;
        private Label label_Header;
        private Button button_Close;
    }
}