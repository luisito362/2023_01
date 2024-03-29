using S1_Lab02___Manejo_de_Clases.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Lab02___Manejo_de_Clases.Controllers
{
    internal class EmpleadoController
    {
        public Empleado ProcesarEmpleado(Empleado empleado)
        {
            // DEFINIR PAGO BASE
            switch (empleado.Categoria)
            {
                case "A": empleado.Pago = 2500; break;
                case "B": empleado.Pago = 1500; break;
                case "C": empleado.Pago = 1000; break;
                case "D": empleado.Pago = 900; break;
            }

            // AUMENTO % DESCUENTO
            if (empleado.MinutosTardanza == 0 && empleado.LlamadasAtencion == 0)
            {
                empleado.Pago *= 1.15;

            } else
            {
                double descuentoMinutoTardanza = empleado.MinutosTardanza = 5;
                double descientoLLamadasAtencion = empleado.LlamadasAtencion = 10;
                empleado.Pago = empleado.Pago - descuentoMinutoTardanza - descientoLLamadasAtencion;

            }
            return empleado;

        }
    }
}
