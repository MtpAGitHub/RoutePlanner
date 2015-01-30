Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports RoutePlanner

<TestClass()> Public Class TestTXTStationBuilder

    <TestMethod()> Public Sub TestBuildStationList1()
        Dim txtSB = New TXTStationBuilder()
        Dim stationData As String
        stationData = "ABC:First" & vbCr & "DEF:Second" & vbCr & "GHI:Third"
        Dim stationList = txtSB.buildStationList(stationData)
        Assert.AreEqual(3, stationList.Count)
    End Sub

End Class