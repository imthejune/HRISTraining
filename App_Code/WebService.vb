Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Diagnostics
' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class WebService
     Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function HelloWorld() As String

        Dim myProc As Process = New Process()
        '        myProc.StartInfo.FileName = "D:\\Test.Text"
        Dim str As String = "D:\\Test.txt"
        myProc.StartInfo.CreateNoWindow = False
        myProc.StartInfo.UseShellExecute = False
        myProc.StartInfo.RedirectStandardInput = False
        myProc.StartInfo.RedirectStandardError = True
        myProc.StartInfo.RedirectStandardOutput = True
        myProc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        myProc.EnableRaisingEvents = True
        System.Diagnostics.Process.Start("notepad.exe", str)


        Return "Hello World"
    End Function

End Class