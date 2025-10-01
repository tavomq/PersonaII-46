﻿Public Class FormPersona
    Inherits System.Web.UI.Page
    Public persona As New Persona()
    Protected dbHelper As New DataBaseHelper()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btn_guardar_Click(sender As Object, e As EventArgs)
        Persona.Nombre = txt_nombre.Text
        persona.Apellido = txt_apellido.Text
        persona.Edad = txt_edad.Text
        lbl_mensaje.Text = persona.Nombre + " " + persona.Apellido
        lbl_mensaje.Text += " " + persona.Edad.ToString()
        dbHelper.create(persona)

    End Sub
End Class