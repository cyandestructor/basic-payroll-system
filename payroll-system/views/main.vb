Public Class main
    Private Sub btnRegistrarEmpleado_Click(sender As Object, e As EventArgs) Handles btnRegistrarEmpleado.Click
        Dim empleado As New Empleado With {
            .RFC = "HNDL45XAF",
            .Nombre = "Juan",
            .ApellidoPaterno = "Perez",
            .ApellidoMaterno = "Magalla",
            .CURP = "JUPM010507HMXR7RAZ",
            .Correo = "myemail@mail.com",
            .FechaNacimiento = New Date(2001, 5, 7),
            .NSS = 1897289102,
            .Telefono = 8121182509,
            .Banco = New Banco With {.ID = 1},
            .CuentaBancaria = 13834781741
        }
        Dim domicilio As New Domicilio With {
            .Calle = "Macapa",
            .Numero = 189,
            .Colonia = "San Sebastian",
            .Ciudad = "Guadalupe",
            .Estado = "Nuevo Leon",
            .CodigoPostal = 67189
        }
        empleado.Domicilio = domicilio

        Dim empleadoDAO As New EmpleadoDAO
        empleadoDAO.Registrar(empleado)
    End Sub

    Private Sub btnEditarEmpleado_Click(sender As Object, e As EventArgs) Handles btnEditarEmpleado.Click
        Dim empleado As New Empleado With {
            .ID = 1004,
            .RFC = "HNDL45XAF",
            .Nombre = "Bryan",
            .ApellidoPaterno = "Torres",
            .ApellidoMaterno = "Magalla",
            .CURP = "JUPM010507HMXR7RAZ",
            .Correo = "myemail@mail.com",
            .FechaNacimiento = New Date(2001, 5, 7),
            .NSS = 1897289102,
            .Telefono = 8121182509,
            .Banco = New Banco With {.ID = 1},
            .CuentaBancaria = 13834781741
        }
        Dim empleadoDAO As New EmpleadoDAO
        empleadoDAO.Editar(empleado)
        Dim domicilio As New Domicilio With {
            .ID = 10,
            .Calle = "Nochebuena",
            .Numero = 189,
            .Colonia = "San Sebastian",
            .Ciudad = "Guadalupe",
            .Estado = "Nuevo Leon",
            .CodigoPostal = 67189
        }
        Dim domicilioDAO As New DomicilioDAO
        domicilioDAO.Editar(domicilio)
        Dim domicilio2 As New Domicilio With {
           .Calle = "Londres",
           .Numero = 189,
           .Colonia = "San Sebastian",
           .Ciudad = "Guadalupe",
           .Estado = "Nuevo Leon",
           .CodigoPostal = 67189
       }
        domicilioDAO.Registrar(domicilio2)
    End Sub

    Private Sub btnContratarEmpleado_Click(sender As Object, e As EventArgs) Handles btnContratarEmpleado.Click
        Dim empleadoDAO As New EmpleadoDAO
        empleadoDAO.AgregarEmpresa(1004, "APP4810391F2", Date.Today)
    End Sub

    Private Sub btnRegistrarEmpresa_Click(sender As Object, e As EventArgs) Handles btnRegistrarEmpresa.Click
        Dim empresa As New Empresa With {
            .RFC = "API25678HNL0",
            .Nombre = "Doritos",
            .RegistroPatronal = 1234559201,
            .RazonSocial = "Doritos S.A. de C.V",
            .Telefono = 8112509904,
            .Correo = "doritos@contacto.mx",
            .FrecuenciaPago = 15,
            .InicioOperaciones = New Date(1990, 9, 10)
        }
        Dim domicilio As New Domicilio With {
           .Calle = "Av. Revolucion",
           .Numero = 1890,
           .Colonia = "Contry",
           .Ciudad = "Monterrey",
           .Estado = "Nuevo Leon",
           .CodigoPostal = 67259
        }
        empresa.DomicilioFiscal = domicilio

        Dim empresaDAO As New EmpresaDAO
        If (empresaDAO.Registrar(empresa)) Then
            MsgBox("Registro exitoso")
        End If

    End Sub

    Private Sub btnEditarEmpresa_Click(sender As Object, e As EventArgs) Handles btnEditarEmpresa.Click
        Dim empresa As New Empresa With {
            .RFC = "API25678HNL0",
            .Nombre = "Doritos",
            .RegistroPatronal = 1234559201,
            .RazonSocial = "Doritos S.A. de C.V",
            .Telefono = 8112509904,
            .Correo = "doritos@ventas.mx",
            .FrecuenciaPago = 15,
            .InicioOperaciones = New Date(1990, 9, 10)
        }

        Dim empresaDAO As New EmpresaDAO
        If (empresaDAO.Editar(empresa)) Then
            MsgBox("Edición exitosa")
        End If
    End Sub

    Private Sub btnAsignarGerente_Click(sender As Object, e As EventArgs) Handles btnAsignarGerente.Click
        Dim empresaDAO As New EmpresaDAO
        If (empresaDAO.AsignarGerente("APP4810391F2", 1004)) Then
            MsgBox("Gerente exitoso")
        End If
    End Sub

    Private Sub btnAgregarDpto_Click(sender As Object, e As EventArgs) Handles btnAgregarDpto.Click
        Dim empresaDAO As New EmpresaDAO
        If (empresaDAO.AgregarDepartamento("APP4810391F2", 1, 500)) Then
            MsgBox("Departamento exitoso")
        End If
        If (empresaDAO.EditarDptoSueldo("APP4810391F2", 1, 200)) Then
            MsgBox("Departamento exitoso")
        End If
    End Sub

    Private Sub btnAgregarDptoEmpleado_Click(sender As Object, e As EventArgs) Handles btnAgregarDptoEmpleado.Click
        Dim empleadoDAO As New EmpleadoDAO
        If (empleadoDAO.AsignarDepartamento(1004, 1)) Then
            MsgBox("Departamento exitoso")
        End If
    End Sub

    Private Sub btnAgregarPuesto_Click(sender As Object, e As EventArgs) Handles btnAgregarPuesto.Click
        Dim empresaDAO As New EmpresaDAO
        If (empresaDAO.AgregarPuesto("APP4810391F2", 3)) Then
            MsgBox("Puesto exitoso")
        End If
    End Sub

    Private Sub btnAgregarPuestoDpto_Click(sender As Object, e As EventArgs) Handles btnAgregarPuestoDpto.Click
        Dim departamentoDAO As New DepartamentoDAO
        'If (departamentoDAO.AgregarPuesto(1, 3, 1.1)) Then
        '    MsgBox("Puesto exitoso")
        'End If
        If (departamentoDAO.EditarPorcentSueldoPuesto(1, 3, 1.5)) Then
            MsgBox("Puesto exitoso")
        End If
    End Sub

    Private Sub btnAsignarPuestoEmpleado_Click(sender As Object, e As EventArgs) Handles btnAsignarPuestoEmpleado.Click
        Dim empleadoDAO As New EmpleadoDAO
        If (empleadoDAO.AsignarPuesto(1004, 3)) Then
            MsgBox("Puesto exitoso")
        End If
    End Sub

    Private Sub btnRegistrarDpto_Click(sender As Object, e As EventArgs) Handles btnRegistrarDpto.Click
        Dim departamento As New Departamento With {
            .Nombre = "Gastronomia"
        }

        Dim departamentoDAO As New DepartamentoDAO
        If (departamentoDAO.Registrar(departamento)) Then
            MsgBox("Departamento exitoso")
        End If
    End Sub

    Private Sub btnEditarDpto_Click(sender As Object, e As EventArgs) Handles btnEditarDpto.Click
        Dim departamento As New Departamento With {
            .Nombre = "Deportivo",
            .ID = 7
        }

        Dim departamentoDAO As New DepartamentoDAO
        If (departamentoDAO.Editar(departamento)) Then
            MsgBox("Departamento exitoso")
        End If
    End Sub

    Private Sub btnAsignarGerenteDpto_Click(sender As Object, e As EventArgs) Handles btnAsignarGerenteDpto.Click
        Dim departamentoDAO As New DepartamentoDAO
        If (departamentoDAO.AsignarGerente("APP4810391F2", 1, 1004, 200)) Then
            MsgBox("Gerente exitoso")
        End If
    End Sub

    Private Sub btnRegistrarPuesto_Click(sender As Object, e As EventArgs) Handles btnRegistrarPuesto.Click
        Dim puesto As New Puesto With {
            .Nombre = "Ejecutivo"
        }

        Dim puestoDAO As New PuestoDAO
        If (puestoDAO.Registrar(puesto)) Then
            MsgBox("Puesto exitoso")
        End If
    End Sub

    Private Sub btnEditarPuesto_Click(sender As Object, e As EventArgs) Handles btnEditarPuesto.Click
        Dim puesto As New Puesto With {
            .ID = 5,
            .Nombre = "Socio de ventas"
        }

        Dim puestoDAO As New PuestoDAO
        If (puestoDAO.Editar(puesto)) Then
            MsgBox("Puesto exitoso")
        End If
    End Sub

    Private Sub btnGenerarPercepcion_Click(sender As Object, e As EventArgs) Handles btnGenerarPercepcion.Click
        Dim percepcion As New Percepcion With {
            .Descripcion = "Bono puntualidad",
            .CantidadFija = 100,
            .CantidadPorcentual = 0,
            .IDEmpleado = 1004
        }

        Dim percepcionDAO As New PercepcionDAO
        If (percepcionDAO.Generar(percepcion)) Then
            MsgBox("Percepcion exitosa")
        End If
    End Sub

    Private Sub btnVerTodasPercepciones_Click(sender As Object, e As EventArgs) Handles btnVerTodasPercepciones.Click
        Dim percepcionDAO As New PercepcionDAO
        Dim percepciones As List(Of Percepcion) = percepcionDAO.VerTodas()
        dgvResultados.DataSource = percepciones
    End Sub

    Private Sub btnVerPercepEmpleado_Click(sender As Object, e As EventArgs) Handles btnVerPercepEmpleado.Click
        Dim percepcionDAO As New PercepcionDAO
        Dim percepciones As List(Of Percepcion) = percepcionDAO.VerDeEmpleado(1004, "2020-1-1", "2020-12-31")
        dgvResultados.DataSource = percepciones
    End Sub

    Private Sub btnGenerarDeduccion_Click(sender As Object, e As EventArgs) Handles btnGenerarDeduccion.Click
        Dim deduccion As New Deduccion With {
            .Descripcion = "Bono puntualidad",
            .CantidadFija = 100,
            .CantidadPorcentual = 0,
            .IDEmpleado = 1004
        }

        Dim deduccionDAO As New DeduccionDAO
        If (deduccionDAO.Generar(deduccion)) Then
            MsgBox("Deduccion exitosa")
        End If
    End Sub

    Private Sub btnVerTodasDeducciones_Click(sender As Object, e As EventArgs) Handles btnVerTodasDeducciones.Click
        Dim deduccionDAO As New DeduccionDAO
        Dim deducciones As List(Of Deduccion) = deduccionDAO.VerTodas()
        dgvResultados.DataSource = deducciones
    End Sub

    Private Sub btnVerDeduccionesEmpleado_Click(sender As Object, e As EventArgs) Handles btnVerDeduccionesEmpleado.Click
        Dim deduccionDAO As New DeduccionDAO
        Dim deducciones As List(Of Deduccion) = deduccionDAO.VerDeEmpleado(1004, "2020-1-1", "2020-12-31")
        dgvResultados.DataSource = deducciones
    End Sub

    Private Sub btnGenerarNomina_Click(sender As Object, e As EventArgs) Handles btnGenerarNomina.Click
        Dim nomina As New Nomina With {
            .IDEmpleado = 1004,
            .InicioPeriodo = "2020-11-23",
            .FinPeriodo = "2020-11-30"
        }

        Dim nominaDAO As New NominaDAO
        If (nominaDAO.Generar(nomina)) Then
            MsgBox("Nomina exitosa")
        End If
    End Sub
End Class