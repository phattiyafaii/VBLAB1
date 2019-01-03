﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Header

Public Class frmLab7
    Private Sub frmLab7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAdd.Enabled = False
    End Sub

    Private Sub txtAdd_TextChanged(sender As Object, e As EventArgs) Handles txtAdd.TextChanged
        If txtAdd.Text = "" Then
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstAdd.Items.Add(txtAdd.Text)
        txtAdd.Focus()
        txtAdd.Text = ""
        Dim n As Integer
        n = lstAdd.Items.Count
        lstAdd.SelectedIndex = n - 1

    End Sub


    Private Sub btnMoveAll_Click(sender As Object, e As EventArgs) Handles btnMoveAll.Click
        If lstAdd.SelectedIndex = -1 Then
            MessageBox.Show("เติมข้อมูล")
            Exit Sub
        Else
            For Each item In lstAdd.Items
                cboOutput.Items.Add(item)
            Next
            lstAdd.Items.Clear()
            lblOutput.Text = ""
            Dim n As Integer
            n = cboOutput.Items.Count
            cboOutput.SelectedIndex = n - 1
        End If
    End Sub


    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        If lstAdd.SelectedIndex = -1 Then
            MessageBox.Show("เติ่มข้อมูล")
        Else

            Dim a As Integer = lstAdd.SelectedIndex
            cboOutput.Items.Add(lstAdd.SelectedItem)
            cboOutput.SelectedIndex = cboOutput.Items.Count - 1
            lstAdd.Items.Remove(lstAdd.SelectedItem)
            If lstAdd.Items.Count <> 0 Then
                If lstAdd.Items.Count <= a Then
                    lstAdd.SelectedIndex = lstAdd.Items.Count - 1
                Else
                    lstAdd.SelectedIndex = a
                End If
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If cboOutput.SelectedIndex = -1 Then
            MessageBox.Show("เติมข้อมูล")
            Exit Sub
        Else
            lstAdd.Items.Add(cboOutput.Text)
            cboOutput.Items.Remove(cboOutput.Text)
            Dim n As Integer
            n = lstAdd.Items.Count
            lstAdd.SelectedIndex = n - 1
            n = cboOutput.Items.Count
            cboOutput.SelectedIndex = n - 1
        End If
    End Sub

    Private Sub btnBackAll_Click(sender As Object, e As EventArgs) Handles btnBackAll.Click
        If cboOutput.SelectedIndex = -1 Then
            MessageBox.Show("เติมข้อมูล")
            Exit Sub
        Else
            For Each item In cboOutput.Items
                lstAdd.Items.Add(item)
            Next
            cboOutput.Items.Clear()
            lblOutput.Text = ""
            Dim n As Integer
            n = lstAdd.Items.Count
            cboOutput.Text = ""
            lstAdd.SelectedIndex = n - 1
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstAdd.Items.Clear()
        cboOutput.Items.Clear()
        txtAdd.Text = ""
        lblOutput.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub cboOutput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOutput.SelectedIndexChanged
        lblOutput.Text = cboOutput.Text
    End Sub
End Class