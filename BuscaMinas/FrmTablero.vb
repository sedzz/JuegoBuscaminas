Imports System.IO
Imports ClasesBM

Public Class FrmTablero
    Public matriz(dificultad.AnchoX - 1, dificultad.LargoY - 1) As Button
    Private posicionDeBombas(dificultad.Bombas - 1) As String
    Private posicionesDeZonaSegura(9) As String
    Dim x As Integer = 25
    Dim y As Integer = 50
    Private BombasGeneradas As Boolean = False
    Dim totalBombas As List(Of Button) = New List(Of Button)
    Dim zonaSeguraCreada As Boolean = False
    Dim tiempoTranscurrido As Integer = 1000
    'Dim ruta = "./Recursos/Ficheros/usuarios.txt"

    Private Sub Form1_Show(sender As Object, e As EventArgs) Handles MyBase.Load

        Select Case dificultad.Bombas

            Case 10
                Me.Width = 307
                Me.Height = 400

            Case 40
                Me.Width = 550
                Me.Height = 600
            Case Else
                Me.Width = 970
                Me.Height = 600
        End Select
        CrearTablero()
        tm1.Start()
        lblNumeroDeBombas.Text = dificultad.Bombas
        Dim rutaImagen As String = "./Recursos/Imagenes/bomba.png"
        Dim imagenBomba As Image = Image.FromFile(rutaImagen)
        lblFotoBomba.Image = imagenBomba

    End Sub

    Private Sub Form1_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        FrmEleccionDificultad.Show()
    End Sub


    Private Sub Boton_Click(sender As Object, e As EventArgs)

        Dim boton As Button = TryCast(sender, Button)
        Dim rnd As New Random
        Dim posicionX, posicionY As Integer

        ' FOR PARA VER TODOS LOS NÚMEROS E IR MÁS RÁPIDO
        'For i = 0 To dificultad.AnchoX - 1
        '    For j = 0 To dificultad.LargoY - 1
        '        matriz(i, j).Text = matriz(i, j).Tag
        '    Next
        'Next

        If boton.BackColor <> Color.White Then
            If TypeOf boton Is Button And BombasGeneradas = False Then
                ZonaSegura(boton)
                BombasGeneradas = True
                'For i = 0 To dificultad.Bombas - 1
                Dim contBombas As Integer = 0
                Do

                    posicionX = rnd.Next(dificultad.AnchoX)
                    posicionY = rnd.Next(dificultad.LargoY)
                    If Not posicionDeBombas.Contains(posicionX & posicionY) AndAlso Not posicionesDeZonaSegura.Contains(posicionX & posicionY) AndAlso Not $"btn{posicionX}_{posicionY}".Equals(boton.Name) Then
                        totalBombas.Add(matriz(posicionX, posicionY))
                        posicionDeBombas(contBombas) = posicionX & posicionY
                        matriz(posicionX, posicionY).Tag = -1
                        contBombas += 1

                    End If
                Loop Until dificultad.Bombas = contBombas


                Numeros()

                ZonaSegura(boton)

            End If


            boton.Enabled = False

            If Terminar() = True Then
                MessageBox.Show("Has ganado felicidades, volveras al menú")
                Close()
                FrmEleccionDificultad.Show()
            End If


            Select Case boton.Tag
                Case -1
                    Dim imagePath As String = "./Recursos/Imagenes/bomba.png" ' todo María: Esto queda pendiente, ya os contaré más tarde donde deben ir las imágenes....
                    Dim Image As Image = Image.FromFile(imagePath)
                    boton.Image = Image

                    For i = 0 To dificultad.AnchoX - 1
                        For j = 0 To dificultad.LargoY - 1
                            If matriz(i, j).Tag = -1 Then
                                matriz(i, j).Image = Image
                            End If
                        Next
                    Next
                    tm1.Stop()
                    MessageBox.Show("Has explotado una bomba, volveras al menú")
                    Close()
                    FrmEleccionDificultad.Show()
                Case 0
                    boton.BackColor = Color.LightGray
                Case 1
                    boton.BackColor = Color.Blue
                    tiempoTranscurrido += 10
                Case 2
                    boton.BackColor = Color.Green
                    tiempoTranscurrido += 20
                Case 3
                    boton.BackColor = Color.Red
                    tiempoTranscurrido += 30
                Case 4
                    boton.BackColor = Color.DarkBlue
                    tiempoTranscurrido += 40
                Case 5
                    boton.BackColor = Color.DarkRed
                    tiempoTranscurrido += 50
                Case 6
                    boton.BackColor = Color.Yellow
                    tiempoTranscurrido += 40
                Case 7
                    boton.BackColor = Color.Cyan
                    tiempoTranscurrido += 40
                Case 8
                    boton.BackColor = Color.DarkCyan
                    tiempoTranscurrido += 40
            End Select

            boton.Text = boton.Tag
            If boton.Text = "0" Then
                boton.Text = ""
            End If
        End If
    End Sub

    Function SacarPosicion(boton As Button, quieresX As String) As Integer
        If quieresX = "X" Then Return boton.Name.Substring(3, 2)
        Return boton.Name.Substring(6)
    End Function

    Sub Numeros()
        For Each bom In totalBombas
            For xP = SacarPosicion(bom, "X") - 1 To SacarPosicion(bom, "X") + 1
                For yP = SacarPosicion(bom, "") - 1 To SacarPosicion(bom, "") + 1
                    If Not (xP = -1 OrElse yP = -1) AndAlso Not (xP = dificultad.AnchoX OrElse yP = dificultad.LargoY) Then
                        If matriz(xP, yP).Tag <> -1 Then
                            matriz(xP, yP).Tag += 1
                        End If
                    End If
                Next

            Next
        Next

    End Sub
    Function Terminar() As Boolean
        Dim contadorHabilitados As Integer = 0
        Dim btn As New Button
        For i = 0 To dificultad.AnchoX - 1 'Recorre las filas

            For j = 0 To dificultad.LargoY - 1 'Recorre las columnas
                btn = matriz(i, j)
                If btn.Enabled = True Then
                    contadorHabilitados += 1
                End If
            Next
        Next
        If contadorHabilitados = dificultad.Bombas Then
            tm1.Stop()
            Dim usuarios As New Usuarios
            MessageBox.Show($"Puntuación obtenida: {usuarios.CalcularPuntuacion(New Usuario(FrmEleccionDificultad.txtJugadorActual.Text), tiempoTranscurrido, dificultad.Bombas)}")
            File.WriteAllLines(usuarios.rutaFicheroUsuarios, usuarios.UsuariosTotales)
            Return True
        End If
        ' contadorHabilitados = 0
        Return False
    End Function


    Private Sub MarcarBandera(sender As Object, e As MouseEventArgs)
        Dim boton As Button = TryCast(sender, Button)
        If boton.BackColor = Color.White AndAlso e.Button = Windows.Forms.MouseButtons.Right Then


            boton.BackColor = Color.WhiteSmoke
            boton.Image = Nothing
            Exit Sub
        End If

        If e.Button = Windows.Forms.MouseButtons.Right AndAlso zonaSeguraCreada Then
            Dim imageBandera As Image = Image.FromFile("./Recursos/Imagenes/bandera.png")
            boton.Image = imageBandera
            boton.BackColor = Color.White
        End If


    End Sub
    Sub ZonaSegura(boton As Button)
        Dim posicionParaLaPosicionX As Integer = boton.Name.LastIndexOf("n") + 1
        Dim posicionParaLaPosicionY As Integer = 6
        Dim posicionX, posicionY As Integer
        Dim comprobador As Boolean = True


        Do Until comprobador = False

            If Not boton.Name.ElementAt(posicionParaLaPosicionX).ToString = "_" Then
                posicionX = posicionX & boton.Name.ElementAt(posicionParaLaPosicionX).ToString
                posicionParaLaPosicionX += 1
            ElseIf posicionParaLaPosicionY <> 8 Then
                posicionY = posicionY & boton.Name.ElementAt(posicionParaLaPosicionY).ToString
                posicionParaLaPosicionY += 1
            Else
                comprobador = False
            End If

        Loop

        posicionParaLaPosicionX = 0

        If BombasGeneradas Then
            For x As Integer = posicionX - 1 To posicionX + 1
                For y As Integer = posicionY - 1 To posicionY + 1
                    If Not (x = -1 OrElse y = -1) And Not (x = dificultad.AnchoX OrElse y = dificultad.LargoY) Then
                        matriz(x, y).Text = matriz(x, y).Tag
                        If matriz(x, y).Text = "0" Then matriz(x, y).Text = ""
                        Select Case matriz(x, y).Tag
                            Case 0
                                matriz(x, y).BackColor = Color.LightGray
                            Case 1
                                matriz(x, y).BackColor = Color.Blue
                            Case 2
                                matriz(x, y).BackColor = Color.Green
                            Case 3
                                matriz(x, y).BackColor = Color.Red
                            Case 4
                                matriz(x, y).BackColor = Color.DarkBlue
                            Case 5
                                matriz(x, y).BackColor = Color.DarkRed
                            Case 6
                                matriz(x, y).BackColor = Color.Yellow
                            Case 7
                                matriz(x, y).BackColor = Color.Cyan
                            Case 8
                                matriz(x, y).BackColor = Color.DarkCyan
                        End Select
                        matriz(x, y).Enabled = False
                    End If
                Next
            Next
        Else
            For x As Integer = posicionX - 1 To posicionX + 1
                For y As Integer = posicionY - 1 To posicionY + 1
                    If Not (x = -1 OrElse y = -1) And Not (x = dificultad.AnchoX OrElse y = dificultad.LargoY) Then
                        'matriz(x, y).Enabled = False

                        posicionesDeZonaSegura(posicionParaLaPosicionX) = x & y
                        posicionParaLaPosicionX += 1
                        '  Boton_Click(matriz(x, y), EventArgs.Empty)
                        ' matriz(x, y).Text = matriz(x, y).Tag
                    End If
                Next
            Next
        End If


    End Sub

    Sub CrearTablero()
        For i = 0 To dificultad.AnchoX - 1 'Recorre las filas

            For j = 0 To dificultad.LargoY - 1 'Recorre las columnas
                Dim btn As New Button
                matriz(i, j) = btn
                If i >= 10 And j >= 10 Then matriz(i, j).Name = $"btn{i}_{j}"
                If i < 10 Then matriz(i, j).Name = $"btn0{i}_{j}"
                If j < 10 Then matriz(i, j).Name = $"btn{i}_0{j}"
                If i < 10 And j < 10 Then matriz(i, j).Name = $"btn0{i}_0{j}"
                matriz(i, j).Tag = 0
                matriz(i, j).Size = New Size(30, 30)
                matriz(i, j).Location = New Point(x, y)
                matriz(i, j).BackColor = Color.Azure
                matriz(i, j).Font = New Font("Cooper", 10, FontStyle.Bold, GraphicsUnit.Point)
                y += matriz(i, j).Size.Height
                Controls.Add(matriz(i, j))
                AddHandler matriz(i, j).Click, AddressOf Boton_Click
                AddHandler matriz(i, j).MouseDown, AddressOf MarcarBandera
            Next j
            x += 30
            y = 50
        Next i
        zonaSeguraCreada = True
    End Sub

    Private Sub tm1_Tick(sender As Object, e As EventArgs) Handles tm1.Tick
        tiempoTranscurrido -= 1
        lblTimer.Text = (tiempoTranscurrido).ToString("D2")
        If tiempoTranscurrido = 0 Then
            tm1.Stop()
            MessageBox.Show("Se acabo el tiempo :(, volveras al menú")
            Close()
            FrmEleccionDificultad.Show()
        End If

    End Sub

    Private Sub lblTimer_Click(sender As Object, e As EventArgs) Handles lblTimer.Click

    End Sub
End Class
