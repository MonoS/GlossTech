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

    Public String_CustomBody As String
    Public String_CustomHands As String
    Public String_CustomHead As String

    Public Value_CustomGloss As Integer
    Public Int_CustomType As Integer
    Public Int_CustomHeadType As Integer
    Public Bool_Custom As Boolean

    Public header_body As Byte() = New Byte() {68, 68, 83, 32, 124, 0, 0, 0, 15, 16, 0, 0, 8, 0, 0, 0, 8, 0, 0, 0, 24, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 32, 0, 0, 0, 64, 0, 0, 0, 0, 0, 0, 0, 24, 0, 0, 0, 0, 0, 255, 0, 0, 255, 0, 0, 255, 0, 0, 0, 0, 0, 0, 0, 0, 16, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Public header_head As Byte() = New Byte() {68, 68, 83, 32, 124, 0, 0, 0, 15, 16, 0, 0, 0, 8, 0, 0, 0, 8, 0, 0, 0, 32, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 32, 0, 0, 0, 65, 0, 0, 0, 0, 0, 0, 0, 32, 0, 0, 0, 0, 0, 255, 0, 0, 255, 0, 0, 255, 0, 0, 0, 0, 0, 0, 255, 0, 16, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}

    Public Const zero As Byte = 0
    Public Const max As Byte = 255

    Public Function Do_Head_Mesh(ByVal type As Integer, ByVal gloss As Byte)

        Dim i As Integer
        Dim c As Byte

        Select Case type
            Case 1
                FileOpen(1, "femalehead_base.dds", OpenMode.Random, OpenAccess.Read, , 1)
                FileOpen(2, "TexBlend/Library/Head/Specular/femalehead_s.dds", OpenMode.Binary)
            Case 2
                FileOpen(1, "malehead_base.dds", OpenMode.Random, OpenAccess.Read, , 1)
                FileOpen(2, "TexBlend/Library/Head/Specular/malehead_s.dds", OpenMode.Binary)
            Case 3
                FileOpen(1, "customhead_base.dds", OpenMode.Random, OpenAccess.Read, , 1)
                FileOpen(2, "TexBlend/Library/Head/Specular/customhead_s.dds", OpenMode.Binary)
            Case 4
                FileOpen(1, "femalehead_base.dds", OpenMode.Random, OpenAccess.Read, , 1)
                FileOpen(2, "TexBlend/Library/Head/Specular/customhead_s.dds", OpenMode.Binary)
            Case 5
                FileOpen(1, "malehead_base.dds", OpenMode.Random, OpenAccess.Read, , 1)
                FileOpen(2, "TexBlend/Library/Head/Specular/customhead_s.dds", OpenMode.Binary)
        End Select

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
