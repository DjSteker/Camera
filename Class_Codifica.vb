﻿



Public Class Class_Codifica

    Friend Shared Function LimpiarNombreArchivo(ByVal Texto As String)
        Dim NombreNuevo_0 As String = String.Empty
        Try
            NombreNuevo_0 = (Replace(Texto, "<", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, ">", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "(", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, ")", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "{", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "}", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "[", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "]", ""))

            NombreNuevo_0 = (Replace(NombreNuevo_0, "*", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "^", ""))


            NombreNuevo_0 = (Replace(NombreNuevo_0, "'", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "%", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "$", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "~", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "€", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, ".", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "-", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, ":", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, ";", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "'", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "=", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "+", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "-", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "*", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "&nbsp;", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "&", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "`", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "´", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "?", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "¿", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "¡", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "!", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "|", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "º", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "ª", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "@", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "/", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "\", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "·", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "#", ""))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "¨", ""))

            NombreNuevo_0 = (Replace(NombreNuevo_0, "Â", "A"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "Ê", "E"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "Î", "I"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "Ô", "O"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "Û", "U"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "â", "a"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "ê", "e"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "î", "i"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "ô", "o"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "û", "u"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "Ä", "A"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "Ë", "E"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "Ï", "I"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "Ö", "O"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "Ü", "U"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "ä", "a"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "ë", "e"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "ï", "i"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "ö", "o"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "ü", "u"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "Á", "A"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "É", "E"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "Í", "I"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "Ó", "O"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "Ú", "U"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "á", "a"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "é", "e"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "í", "i"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "ó", "o"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "ú", "u"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "à", "a"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "è", "e"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "ì", "i"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "ò", "o"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "ù", "u"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "À", "A"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "È", "E"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "Ì", "I"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "Ò", "O"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "Ù", "U"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "¨¨", "_"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "ñ", "ni"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "ñ", "ni"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "Ç", "C"))
            NombreNuevo_0 = (Replace(NombreNuevo_0, "ç", "c"))
            NombreNuevo_0 = Replace(NombreNuevo_0, " ", "_")
        Catch ex As Exception

        End Try
        Return NombreNuevo_0
    End Function

End Class
