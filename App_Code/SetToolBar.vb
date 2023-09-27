Imports Microsoft.VisualBasic

Public Class SetToolBar

    Public Enum mDBType
        Add = 0
        Edit = 1
        NORMAL = 2
        NODATA = 3
        NoDataResign = 4
        NormalResign = 5
        ALLCOM = 6
        NODATADoor = 7
        EditOnly = 8
        NoEdit = 9
        SearchNoData = 10
        Editg8 = 11
    End Enum

    '+++++++++++ การ ตั้งค่าการกดปุ่ม +++++++++++++++++
    Sub SetToolsBar(ByVal tlb As Telerik.Web.UI.RadToolBar, ByVal A1 As Boolean, ByVal A2 As Boolean, ByVal A3 As Boolean, ByVal A4 As Boolean, ByVal A5 As Boolean, ByVal A6 As Boolean, ByVal A7 As Boolean, ByVal A8 As Boolean, Optional ByVal A9 As Boolean = True)


        If Sys.LoginWeb.Lang = "T" Then
            tlb.Items(0).ToolTip = "เพิ่ม"
            tlb.Items(1).ToolTip = "แก้ไข"
            tlb.Items(2).ToolTip = "ลบ"
            tlb.Items(3).ToolTip = "บันทึก"
            tlb.Items(4).ToolTip = "ยกเลิก"
            tlb.Items(5).ToolTip = "ค้นหา"
        Else
            tlb.Items(0).Text = Sys.TMsg.Insert
            tlb.Items(1).Text = Sys.TMsg.Update
            tlb.Items(2).Text = Sys.TMsg.Delete
            tlb.Items(3).Text = Sys.TMsg.Save
            tlb.Items(4).Text = Sys.TMsg.Cancel
            tlb.Items(5).Text = Sys.TMsg.Search
            tlb.Items(6).Text = Sys.TMsg.Previous
            tlb.Items(7).Text = Sys.TMsg.Nexts
            tlb.Items(8).Text = Sys.TMsg.Exits

            tlb.Items(0).ToolTip = Sys.TMsg.Insert
            tlb.Items(1).ToolTip = Sys.TMsg.Update
            tlb.Items(2).ToolTip = Sys.TMsg.Delete
            tlb.Items(3).ToolTip = Sys.TMsg.Save
            tlb.Items(4).ToolTip = Sys.TMsg.Cancel
            tlb.Items(5).ToolTip = Sys.TMsg.Search
            tlb.Items(6).ToolTip = Sys.TMsg.Previous
            tlb.Items(7).ToolTip = Sys.TMsg.Nexts
            tlb.Items(8).ToolTip = Sys.TMsg.Exits
        End If


        tlb.Items(0).Enabled = A1
        tlb.Items(1).Enabled = A2
        tlb.Items(2).Enabled = A3
        tlb.Items(3).Enabled = A4
        tlb.Items(4).Enabled = A5
        tlb.Items(5).Enabled = A6
        tlb.Items(6).Enabled = A7
        tlb.Items(7).Enabled = A8
        tlb.Items(8).Enabled = A9
    End Sub

    Sub ToolsBarADE(ByVal tlb As Telerik.Web.UI.RadToolBar, ByVal stCase As mDBType)

        Select Case stCase
            Case mDBType.Add
                SetToolsBar(tlb, 0, 0, 0, 1, 1, 0, 0, 0)
            Case mDBType.Edit
                SetToolsBar(tlb, 0, 0, 0, 1, 1, 0, 1, 1)
            Case mDBType.Editg8
                SetToolsBar(tlb, 0, 1, 0, 0, 0, 0, 0, 0)
            Case mDBType.NORMAL
                SetToolsBar(tlb, 1, 1, 1, 0, 0, 1, 1, 1)
            Case mDBType.NODATA
                SetToolsBar(tlb, 1, 0, 0, 0, 0, 0, 1, 1)
            Case mDBType.NoDataResign
                SetToolsBar(tlb, 0, 0, 0, 0, 0, 0, 1, 1)
            Case mDBType.NormalResign
                SetToolsBar(tlb, 0, 1, 1, 0, 0, 1, 1, 1)
            Case mDBType.ALLCOM
                SetToolsBar(tlb, 0, 0, 0, 0, 0, 1, 1, 1)
            Case mDBType.NODATADoor
                SetToolsBar(tlb, 1, 0, 0, 0, 0, 0, 1, 1)
            Case mDBType.EditOnly
                SetToolsBar(tlb, 0, 1, 0, 0, 0, 0, 1, 1)
            Case mDBType.NoEdit
                SetToolsBar(tlb, 1, 0, 1, 0, 0, 1, 1, 1)
            Case mDBType.SearchNoData
                SetToolsBar(tlb, 1, 0, 0, 0, 0, 1, 1, 1)
        End Select

    End Sub


End Class
