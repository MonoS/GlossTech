Public Module Data
    'v4,0.30319
    'Dim startInfo As New ProcessStartInfo("TexBlend.exe")
    'startInfo.WorkingDirectory = "TexBlend/"
    'Process.Start(startInfo)

    Public Bool_FemaleGloss As Boolean
    Public Value_FemaleGloss As Integer

    Public Bool_ManGloss As Boolean
    Public Value_ManGloss As Integer

    Public Bool_HeadAll As Boolean
    Public Bool_HeadMesh As Boolean

    Public header_body As Byte() = New Byte() {68, 68, 83, 32, 124, 0, 0, 0, 15, 16, 0, 0, 8, 0, 0, 0, 8, 0, 0, 0, 24, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 32, 0, 0, 0, 64, 0, 0, 0, 0, 0, 0, 0, 24, 0, 0, 0, 0, 0, 255, 0, 0, 255, 0, 0, 255, 0, 0, 0, 0, 0, 0, 0, 0, 16, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Public header_head As Byte() = New Byte() {68, 68, 83, 32, 124, 0, 0, 0, 15, 16, 0, 0, 0, 8, 0, 0, 0, 8, 0, 0, 0, 32, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 32, 0, 0, 0, 65, 0, 0, 0, 0, 0, 0, 0, 32, 0, 0, 0, 0, 0, 255, 0, 0, 255, 0, 0, 255, 0, 0, 0, 0, 0, 0, 255, 0, 16, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}

    Public Const zero As Byte = 0
    Public Const max As Byte = 255

    Public Function Do_Head_Mesh(ByVal fem As Boolean, ByVal gloss As Byte)

        Dim i As Integer
        Dim c As Byte

        If fem = True Then
            FileOpen(1, "femalehead_base.dds", OpenMode.Random, OpenAccess.Read, , 1)
            FileOpen(2, "TexBlend/Library/Head/Specular/femalehead_s.dds", OpenMode.Binary)
        Else
            FileOpen(1, "malehead_base.dds", OpenMode.Random, OpenAccess.Read, , 1)
            FileOpen(2, "TexBlend/Library/Head/Specular/malehead_s.dds", OpenMode.Binary)
        End If


        Seek(1, 129)

        i = 0
        Do While i < 128
            FilePut(2, Data.header_head(i))
            i = i + 1
        Loop

        Do While Not EOF(1)
            FileGet(1, c)
            FileGet(1, c)
            FileGet(1, c)

            If c = 0 Then
                FilePut(2, gloss)
                FilePut(2, gloss)
                FilePut(2, gloss)
                FilePut(2, Data.max)
            Else
                FilePut(2, Data.zero)
                FilePut(2, Data.zero)
                FilePut(2, Data.zero)
                FilePut(2, Data.zero)
            End If
        Loop

        FileClose(1)
        FileClose(2)
    End Function
End Module
