using Microsoft.VisualStudio.Shell;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using Task = System.Threading.Tasks.Task;

namespace MyFirstExtension
{
    
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [Guid("4f44aa2e-8ab4-413b-9dfd-549c86579db4")]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [ProvideToolWindow(typeof(MyToolWindow), Orientation = ToolWindowOrientation.Left, Style = VsDockStyle.AlwaysFloat)]

    public sealed class MyFirstExtensionPackage : AsyncPackage
    {                
        protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {            
            await JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);
            await MyToolWindowCommand.InitializeAsync(this);
        }
    }
}
