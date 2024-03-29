import dataFrame as d
import os
from msvcrt import getch

def menu():
    print("1. Generar y mostrar DF diccionario")
    print("2. Generar y mostrar DF lista")
    print("3. Salir")

objDF = d.dataFrame()
opcion = 0

while opcion != 3:
    menu()
    opcion = int(input("Ingrese una opcion: "))

    if opcion == 1:
        objDF.generarYMostrarDFDiccionario()
    elif opcion == 2:
        objDF.generarYMotrarDFLista()

    getch()
    os.system("cls")
