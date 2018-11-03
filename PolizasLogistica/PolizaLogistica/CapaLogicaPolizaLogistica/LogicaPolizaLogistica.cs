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
        public void ValidarInsertarDatosPoliza(string id, string fecha)
        {
            DatosPolizaLogistica dmu = new DatosPolizaLogistica();
            if (id == "" || fecha == "")
            {
                MessageBox.Show("Porfavor Ingresa Todos los campos");
            }
            else
            {
                dmu.InsertarDatosDePoliza(id, fecha);
            }
        }

    }
}


