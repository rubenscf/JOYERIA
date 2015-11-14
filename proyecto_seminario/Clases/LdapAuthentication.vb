Imports System
Imports System.Text
Imports System.Collections
Imports System.DirectoryServices
Namespace FormsAuth
    Public Class LdapAuthentication
        Dim _path As String
        Dim _filterAttribute As String

        Public Sub New(ByVal path As String)
            _path = path
        End Sub
        Public Function IsAuthenticated(ByVal domain As String, ByVal username As String, ByVal pwd As String) As Boolean
            Dim domainAndUsername As String = domain & "\" & username
            Dim entry As DirectoryEntry = New DirectoryEntry(_path, domainAndUsername, pwd)

            Try
                'Bind to the native AdsObject to force authentication.			
                Dim obj As Object = entry.NativeObject
                Dim search As DirectorySearcher = New DirectorySearcher(entry)

                search.Filter = "(SAMAccountName=" & username & ")"
                search.PropertiesToLoad.Add("cn")
                Dim result As SearchResult = search.FindOne()

                If (result Is Nothing) Then
                    Return False
                End If

                'Update the new path to the user in the directory.
                _path = result.Path
                _filterAttribute = CType(result.Properties("cn")(0), String)

            Catch ex As Exception
                Throw New Exception("Error authenticating user. " & ex.Message)
            End Try
            Return True
        End Function
        Public Function GetGroups() As String
            Dim search As DirectorySearcher = New DirectorySearcher(_path)
            search.Filter = "(cn=" & _filterAttribute & ")"
            search.PropertiesToLoad.Add("memberOf")
            Dim groupNames As StringBuilder = New StringBuilder()
            Try
                Dim result As SearchResult = search.FindOne()
                Dim propertyCount As Integer = result.Properties("memberOf").Count
                Dim dn As String
                Dim equalsIndex, commaIndex
                Dim propertyCounter As Integer

                For propertyCounter = 0 To propertyCount - 1
                    dn = CType(result.Properties("memberOf")(propertyCounter), String)

                    equalsIndex = dn.IndexOf("=", 1)
                    commaIndex = dn.IndexOf(",", 1)
                    If (equalsIndex = -1) Then
                        Return Nothing
                    End If
                    groupNames.Append(dn.Substring((equalsIndex + 1), (commaIndex - equalsIndex) - 1))
                    groupNames.Append("|")
                Next
            Catch ex As Exception
                Throw New Exception("Error obtaining group names. " & ex.Message)
            End Try
            Return groupNames.ToString()
        End Function
    End Class
End Namespace