#r "Winterleaf.Demo.Full.dll"
#r "WinterLeaf.Engine.Omni.dll"
#r "System.Windows.Forms.dll"
#r "System.Drawing.dll"

using System;
using System.Diagnostics;
using System.Drawing;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using WinterLeaf.Engine;

private static Omni omni;

Application.EnableVisualStyles();
Application.SetCompatibleTextRenderingDefault(false);
try
{
    //Application.Run(new main_window());
    omni = new Omni(Process.GetCurrentProcess().Handle);
    //Initialize Torque, pass a handle to this form into T3D so it knows where to rendor the screen to.
    //If you don't do this, you can't pass the mouse and key strokes, w/out the mouse and keystrokes
    //being redirected the application will hang intermittently.
    omni.Initialize(new[] {""}, "OmniBones_DEBUG", "WinterLeaf.Demo.Full.dll", "WinterLeaf.Demo.Full", "csScripts");

    omni.Debugging = false;
    omni.ScriptExtensions_Allow = true;
    omni.ScriptExtensions_HandleExceptions = true;

    omni.DebuggingShowScriptCalls = false;
    omni.WindowIcon = new Icon("Omni.ico");
    while (omni.IsRunning)
    Thread.Sleep(1000);

    if (omni.LastError != null)
    MessageBox.Show("An Error has occurred in the application.  " + omni.LastError);
    omni = null;
}
catch (Exception err)
{
    MessageBox.Show("An Error has occurred in the application.  " + err.Message);
}
Application.Exit();
