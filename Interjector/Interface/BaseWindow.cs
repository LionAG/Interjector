using System.Drawing.Text;
using System.Reflection;

namespace Interjector.Interface
{
    public class BaseWindow : Form
    {
        // wingdi.h
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont,
                                                          uint cbFont,
                                                          IntPtr pdv,
                                                          [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new();
        public string? AssemblyName => Assembly.GetExecutingAssembly().GetName().Name;
        protected Font GetFontFromMemory(byte[] data, float size, FontStyle style = FontStyle.Regular)
        {
            // Loading fonts, credits to knighter (https://stackoverflow.com/questions/556147/how-do-i-embed-my-own-fonts-in-a-winforms-app)

            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(data.Length);
            System.Runtime.InteropServices.Marshal.Copy(data, 0, fontPtr, data.Length);

            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, data.Length);
            AddFontMemResourceEx(fontPtr, (uint)data.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            return new Font(fonts.Families[0], size, style);
        }

        public BaseWindow()
        {
            this.Text = AssemblyName;
            this.BackColor = Color.Black;
            this.ForeColor = Color.FromArgb(222, 222, 222);
            this.Font = GetFontFromMemory(Resource.Lato_Regular, 10.0f);

            // Disable window resizing & maximizing

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Icon

            this.Icon = Resource.shield;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseWindow
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "BaseWindow";
            this.Load += new System.EventHandler(this.BaseWindow_Load);
            this.ResumeLayout(false);

        }

        private void BaseWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
