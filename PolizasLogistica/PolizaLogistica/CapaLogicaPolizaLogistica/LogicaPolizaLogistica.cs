using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatosPolizaLogistica;
using System.Windows.Forms;

namespace CapaLogicaPolizaLogistica
{
    public class LogicaPolizaLogistica
    {
        public void ValidarInsertarDatosPoliza(string id, string fecha, string tipo)
        {
            DatosPolizaLogistica dmu = new DatosPolizaLogistica();
            if (id == "" || fecha == "" || tipo == "")
            {
                MessageBox.Show("Debe ingresar todos los campos");
            }
            else
            {
                dmu.InsertarDatosDePoliza(id, fecha, tipo);
            }
        }

        public void ValidarDatosPoliza(string inicio, string fin)
        {
            DatosPolizaLogistica dmu = new DatosPolizaLogistica();
            if (inicio == "" || fin == "" )
            {
                MessageBox.Show("Debe ingresar las dos fechas");
            }
            else
            {
                dmu.ConsultarDatos(inicio, fin);
            }
        }

    }
}


