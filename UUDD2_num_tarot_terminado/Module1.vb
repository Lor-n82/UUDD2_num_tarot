Module Module1

    Sub Main()
        'Realizar un programa que calcule el número Tarot de una persona. 
        'El programa debe estar solicitar al usuario su fecha de nacimiento y en función de esta fecha, realizar el cálculo correspondiente.
        'Una vez mostrado un número Tarot, se solicitará la siguiente fecha hasta que el usuario teclee la fecha '1/1/1, caso con en el que debe finalizar el programa.

        Dim fechanac As Date
        Dim fechanacStr, a, b, c, d, e, f, g, h, i, j, k, respuesta As String
        Dim fnac1, fnac2, fnac3, fnac4, fnac5, fnac6, fnac7, fnac8, fnac9, operacion1, operacion2, operacion3 As Integer
        Dim sw As Boolean = False

        Do
            sw = False
            Console.Write("Introduce tu fecha de nacimiento: ")
            fechanac = Console.ReadLine()

            fechanacStr = CStr(fechanac)    'Convierto la fecha de tipo DATE a String

            If fechanacStr <> "01/01/2001" Then   'Si la fecha no es 1/1/1 continua

                a = Mid(fechanacStr, 1, 2)      'Almaceno cada grupo en un String y despues lo convierto a un valor entero
                fnac1 = CInt(a)
                b = Mid(fechanacStr, 4, 2)
                fnac2 = CInt(b)
                c = Mid(fechanacStr, 7, 4)
                fnac3 = CInt(c)

                operacion1 = fnac1 + fnac2 + fnac3

                Console.WriteLine("El primer numero es: " & a & " - " + b & " - " & +c & " y su suma es: " & operacion1)

                d = CStr(operacion1)    'Convierto el valor entero a un String

                e = Mid(d, 1, 1)        'Saco el numero que necesito y lo vuelvo a convertir a entero
                fnac4 = CInt(e)
                f = Mid(d, 2, 1)
                fnac5 = CInt(f)
                g = Mid(d, 3, 1)
                fnac6 = CInt(g)
                h = Mid(d, 4, 1)
                fnac7 = CInt(h)

                operacion2 = fnac4 + fnac5 + fnac6 + fnac7



                If operacion2 <= 9 Then                                 'Si la cifra es de solo un numero entra
                    Console.WriteLine("Tu tarot es: " & operacion2)

                Else                                                    'Si no sigo descomponiendo

                    Console.WriteLine("Tu numero tenia dos cifras y es " & operacion2)
                    Console.Write("Calculando...")

                    i = CStr(operacion2)

                    j = Mid(i, 1, 1)
                    fnac8 = CInt(j)
                    k = Mid(i, 2, 1)
                    fnac9 = CInt(k)

                    operacion3 = fnac8 + fnac9

                    Console.WriteLine("Tu tarot es: " & operacion3)

                End If

                Do

                    Console.WriteLine("¿Deseas volver a cargar el programa? (Si/No): ")
                    respuesta = Console.ReadLine.ToLower()

                    If respuesta = "si" Then
                        sw = True
                    ElseIf respuesta = "no" Then
                        sw = False
                    Else
                        Console.WriteLine("Error has introducido un valor no valido")
                    End If

                Loop While Not (respuesta = "si" Or respuesta = "no")
            Else
                Console.WriteLine("Has introducido la fecha 1/1/1, fin del programa")
            End If
        Loop While sw = True

        Console.ReadLine()

    End Sub

End Module
