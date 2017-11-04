﻿Public Class QGlobal

    Friend Shared BaseDir As String



    Public Enum DbType As Integer
        H2 = 0
        FireBird = 1
        pMariaDB = 2
        MariaDB = 3
    End Enum
    Public Enum AppNames As Integer
        Launcher = 0
        BRS = 1
        JavaInstalled = 2
        JavaPortable = 3
        MariaPortable = 4 'Maria DB Portable
        Import = 5 'Export / import db
        Export = 6
        DownloadFile = 7 'Download whatever
    End Enum
    Public Enum States
        Stopped = 0
        Running = 1
        Abort = 2
    End Enum
    Public Enum ProcOp As Integer
        Running = 1
        FoundSignal = 2
        Stopping = 3
        Stopped = 4
        Err = 5
        ConsoleErr = 6
        ConsoleOut = 7
    End Enum

End Class