Friend Module modAPI

    Declare Function ShellExecuteA Lib "shell32.dll" ( _
    ByVal hWnd As IntPtr, _
    ByVal lpOperation As String, _
    ByVal lpFile As String, _
    ByVal lpParameters As String, _
    ByVal lpDirectory As String, _
    ByVal nShowCmd As Integer) As IntPtr

End Module
