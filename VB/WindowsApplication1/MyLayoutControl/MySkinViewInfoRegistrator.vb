Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting.Export
Imports DevExpress.XtraTab.Registrator
Imports DevExpress.XtraTab.ViewInfo

Namespace WindowsApplication1
	Public Class MySkinViewInfoRegistrator
		Inherits SkinViewInfoRegistrator

		Public Sub New()

		End Sub

		Public Overrides Function CreateHeaderViewInfo(ByVal viewInfo As DevExpress.XtraTab.ViewInfo.BaseTabControlViewInfo) As DevExpress.XtraTab.ViewInfo.BaseTabHeaderViewInfo
			Return New MySkinTabHeaderViewInfo(viewInfo)
		End Function



	End Class
End Namespace