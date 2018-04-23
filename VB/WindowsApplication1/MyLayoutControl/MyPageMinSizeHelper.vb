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
Imports DevExpress.LookAndFeel

Namespace WindowsApplication1
	<System.ComponentModel.DesignerCategory("")> _
	Public Class MyPageMinSizeHelper
		Inherits Component

		Public Shared PageMinimumSize As New Size(200, 50)

		Public Property PageMinSize() As Size
			Get
				Return PageMinimumSize
			End Get
			Set(ByVal value As Size)
				If PageMinimumSize <> value Then
					PageMinimumSize = value
				End If
				LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
			End Set
		End Property

		Public Sub New()
			DevExpress.XtraTab.Registrator.PaintStyleCollection.DefaultPaintStyles.Remove("Skin")
			DevExpress.XtraTab.Registrator.PaintStyleCollection.DefaultPaintStyles.Add(New MySkinViewInfoRegistrator())
			LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
		End Sub
	End Class
End Namespace
