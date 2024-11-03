Imports System.Diagnostics

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeListView()
    End Sub

    ' Initialize ListView columns
    Private Sub InitializeListView()
        listViewLogs.View = View.Details
        listViewLogs.Columns.Add("Event ID", 70)
        listViewLogs.Columns.Add("Log Type", 100)
        listViewLogs.Columns.Add("Source", 100)
        listViewLogs.Columns.Add("Message", 300)
        listViewLogs.FullRowSelect = True
    End Sub

    ' Load event logs into ListView
    Private Sub LoadEventLogs()
        listViewLogs.Items.Clear()

        Try
            ' Access the Application log (change to other logs if needed)
            Dim appLog As New EventLog("Application")

            For Each entry As EventLogEntry In appLog.Entries
                Dim item As New ListViewItem(entry.InstanceId.ToString())
                item.SubItems.Add(entry.EntryType.ToString())
                item.SubItems.Add(entry.Source)
                item.SubItems.Add(entry.Message)

                listViewLogs.Items.Add(item)
            Next
        Catch ex As Exception
            MessageBox.Show($"Error loading logs: {ex.Message}")
        End Try
    End Sub

    ' Button click event to refresh logs
    Private Sub btnRefreshLogs_Click(sender As Object, e As EventArgs) Handles btnRefreshLogs.Click
        LoadEventLogs()
    End Sub

    ' Delete selected logs (dummy function for example purposes)
    Private Sub btnDeleteLogs_Click(sender As Object, e As EventArgs) Handles btnDeleteLogs.Click
        Try
            For Each selectedItem As ListViewItem In listViewLogs.SelectedItems
                ' In a real scenario, you'd delete the log entry here
                ' Displaying a message for this example
                MessageBox.Show($"Deleting log with ID: {selectedItem.Text}")
            Next

            ' Refresh logs after deletion
            LoadEventLogs()
        Catch ex As Exception
            MessageBox.Show($"Error deleting logs: {ex.Message}")
        End Try
    End Sub

End Class
