<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstFavorites = New System.Windows.Forms.ListView()
        Me.hdrName = New System.Windows.Forms.ColumnHeader()
        Me.hdrUrl = New System.Windows.Forms.ColumnHeader()
        Me.lnkURL = New System.Windows.Forms.LinkLabel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstFavorites
        '
        Me.lstFavorites.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.hdrName, Me.hdrUrl})
        Me.lstFavorites.Dock = System.Windows.Forms.DockStyle.Top
        Me.lstFavorites.FullRowSelect = True
        Me.lstFavorites.Location = New System.Drawing.Point(0, 0)
        Me.lstFavorites.Name = "lstFavorites"
        Me.lstFavorites.Size = New System.Drawing.Size(454, 225)
        Me.lstFavorites.TabIndex = 0
        Me.lstFavorites.UseCompatibleStateImageBehavior = False
        Me.lstFavorites.View = System.Windows.Forms.View.Details
        '
        'hdrName
        '
        Me.hdrName.Text = "Name"
        Me.hdrName.Width = 220
        '
        'hdrUrl
        '
        Me.hdrUrl.Text = "URL"
        Me.hdrUrl.Width = 230
        '
        'lnkURL
        '
        Me.lnkURL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkURL.AutoSize = True
        Me.lnkURL.Location = New System.Drawing.Point(12, 237)
        Me.lnkURL.Name = "lnkURL"
        Me.lnkURL.Size = New System.Drawing.Size(63, 15)
        Me.lnkURL.TabIndex = 1
        Me.lnkURL.TabStop = True
        Me.lnkURL.Text = "LinkLabel1"
        Me.lnkURL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(367, 231)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 261)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.lnkURL)
        Me.Controls.Add(Me.lstFavorites)
        Me.Name = "Form1"
        Me.Text = "My Favorites"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstFavorites As ListView
    Friend WithEvents hdrName As ColumnHeader
    Friend WithEvents hdrUrl As ColumnHeader
    Friend WithEvents lnkURL As LinkLabel
    Friend WithEvents btnRefresh As Button
End Class
