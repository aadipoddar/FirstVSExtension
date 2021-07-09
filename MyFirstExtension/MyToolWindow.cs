using Microsoft.VisualStudio.Imaging;
using Microsoft.VisualStudio.Shell;
using System;
using System.Runtime.InteropServices;

namespace MyFirstExtension
{
    
    [Guid("39309437-eb7d-40da-846c-7d9b245a56c8")]
    public class MyToolWindow : ToolWindowPane
    {
        
        public MyToolWindow() : base(null)
        {
            this.Caption = "MyToolWindow";
            this.BitmapImageMoniker = KnownMonikers.Save;
            this.Content = new MyToolWindowControl();
        }
    }
}
