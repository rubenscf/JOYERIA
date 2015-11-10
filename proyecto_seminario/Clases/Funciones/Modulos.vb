Imports System.Data.SqlClient

Module Modulos


    'Metodo para cargar la coleccion de datos para el AutoComplete
    'Public Sub Autocompletar(ByVal miTextBox As TextBox, ByVal campo As String, ByVal tabla As String)
    '    'autocompletar("Columna a buscar")
    '    Try
    '        If miTextBox.Text.Length = 0 Then
    '        Else
    '            Dim dt As DataTable = CargarDatos("select codProducto from tb_producto where codProducto like '" + miTextBox.Text + "%' order by codProducto limit 10 ")

    '            Dim coleccion As New AutoCompleteStringCollection()
    '            'Recorrer y cargar los items para el Autocompletado
    '            For Each row As DataRow In dt.Rows
    '                coleccion.Add(Convert.ToString(row(campo)))
    '            Next
    '            miTextBox.AutoCompleteCustomSource = coleccion
    '            miTextBox.AutoCompleteMode = AutoCompleteMode.Suggest
    '            miTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

End Module
