Imports DevExpress.XtraEditors
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace WindowsApplication1
    Friend NotInheritable Class Program
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        Private Sub New()
        End Sub
        <STAThread>
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            WindowsFormsSettings.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.True
            Application.Run(New Form1())
        End Sub
    End Class
End Namespace