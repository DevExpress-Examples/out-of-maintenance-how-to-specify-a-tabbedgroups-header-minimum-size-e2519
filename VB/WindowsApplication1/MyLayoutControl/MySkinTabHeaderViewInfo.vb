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
	Public Class MySkinTabHeaderViewInfo
		Inherits SkinTabHeaderViewInfo
		Public Sub New(ByVal viewInfo As BaseTabControlViewInfo)
			MyBase.New(viewInfo)

		End Sub

	Public Overrides Function CalcMinPageSize(ByVal info As BaseTabPageViewInfo) As Size
		Return MyPageMinSizeHelper.PageMinimumSize
	End Function

	End Class
End Namespace
