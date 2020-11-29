﻿Public Class AsignarGerentes
    Private Sub AsignarGerentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateEmpresas()
    End Sub
    Private Sub UpdateEmpresas()
        Dim empresaDAO As New EmpresaDAO
        CbEmpresas.ValueMember = "RFC"
        CbEmpresas.DisplayMember = "Nombre"
        CbEmpresas.DataSource = empresaDAO.VerEmpresas()
    End Sub
    Private Sub CbEmpresas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbEmpresas.SelectedIndexChanged
        If CbEmpresas.SelectedIndex <> -1 Then
            Dim idEmpresa = CbEmpresas.SelectedValue

            Dim departamentoDAO As New DepartamentoDAO
            CbDepartamentos.ValueMember = "ID"
            CbDepartamentos.DisplayMember = "Nombre"
            Dim departamentos = departamentoDAO.VerDepartamentosEmpresa(idEmpresa)
            CbDepartamentos.DataSource = If(departamentos.Count, departamentos, Nothing)
        Else
            CbDepartamentos.DataSource = Nothing
        End If
    End Sub
    Private Sub CbDepartamentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbDepartamentos.SelectedIndexChanged
        If CbDepartamentos.SelectedIndex <> -1 Then
            Dim idDepartamento = CbDepartamentos.SelectedValue
            Dim idEmpresa = CbEmpresas.SelectedValue

            Dim empleadoDAO As New EmpleadoDAO
            CbEmpleados.ValueMember = "ID"
            CbEmpleados.DisplayMember = "NombreCompleto"
            Dim empleados = empleadoDAO.VerEmpleadosEmpresa(idEmpresa, idDepartamento)
            CbEmpleados.DataSource = If(empleados.Count, empleados, Nothing)
        Else
            CbEmpleados.DataSource = Nothing
        End If
    End Sub
    Private Sub BtnGerenteEmpresa_Click(sender As Object, e As EventArgs) Handles BtnGerenteEmpresa.Click
        Dim idEmpleado = CbEmpleados.SelectedValue
        Dim idEmpresa = CbEmpresas.SelectedValue

        Dim empresaDAO As New EmpresaDAO
        If empresaDAO.AsignarGerente(idEmpresa, idEmpleado) Then
            MsgBox("Se ha asignado un gerente de empresa")
        End If
    End Sub
    Private Sub BtnGerenteDpto_Click(sender As Object, e As EventArgs) Handles BtnGerenteDpto.Click
        Dim idDpto = CbDepartamentos.SelectedValue
        Dim idEmpleado = CbEmpleados.SelectedValue
        Dim idEmpresa = CbEmpresas.SelectedValue
        Dim bono = Double.Parse(TxtBonoGerente.Text)

        Dim departamentoDAO As New DepartamentoDAO
        If departamentoDAO.AsignarGerente(idEmpresa, idDpto, idEmpleado, bono) Then
            MsgBox("Se ha asignado un gerente de departamento")
        End If
    End Sub
End Class