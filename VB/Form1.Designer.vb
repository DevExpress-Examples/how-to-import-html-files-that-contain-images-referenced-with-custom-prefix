﻿Namespace RichIUriStreamProviderExample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.btnImportFile = New DevExpress.XtraEditors.SimpleButton()
            Me.SuspendLayout()
            '
            'richEditControl1
            '
            Me.richEditControl1.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple
            Me.richEditControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.richEditControl1.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel
            Me.richEditControl1.Location = New System.Drawing.Point(10, 12)
            Me.richEditControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText
            Me.richEditControl1.Options.VerticalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden
            Me.richEditControl1.Size = New System.Drawing.Size(580, 427)
            Me.richEditControl1.TabIndex = 0
            '
            'btnImportFile
            '
            Me.btnImportFile.Location = New System.Drawing.Point(10, 446)
            Me.btnImportFile.Margin = New System.Windows.Forms.Padding(4)
            Me.btnImportFile.Name = "btnImportFile"
            Me.btnImportFile.Size = New System.Drawing.Size(118, 28)
            Me.btnImportFile.TabIndex = 2
            Me.btnImportFile.Text = "Import Test File"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(601, 489)
            Me.Controls.Add(Me.btnImportFile)
            Me.Controls.Add(Me.richEditControl1)
            Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
        Private WithEvents btnImportFile As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace

