import pandas as pd
import random as r

class dataFrame():
    def __init__(self):
        self.__dfDiccionario = {}
        self.__dfLista = []

    def generarYMostrarDFDiccionario(self):
        datos = {
                "Mes":["Enero","Febrero","Marzo","Abril"],
                "Ventas":[r.randint(1000,5000),r.randint(1000,5000),r.randint(1000,5000),r.randint(1000,5000)],
                "Gastos":[r.randint(1000,5000),r.randint(1000,5000),r.randint(1000,5000),r.randint(1000,5000)]
            }
        self.__dfDiccionario = pd.DataFrame(datos)
        print(self.__dfDiccionario)

    def generarYMotrarDFLista(self):
        datos = [
                ["Enero",r.randint(1000,5000),r.randint(1000,5000)],
                ["Febrero",r.randint(1000,5000),r.randint(1000,5000)],
                ["Marzo",r.randint(1000,5000),r.randint(1000,5000)],
                ["Abril",r.randint(1000,5000),r.randint(1000,5000)]
            ]
        self.__dfLista = pd.DataFrame(datos, columns = ["Mes","Ventas","Gastos"])
        print(self.__dfLista)
