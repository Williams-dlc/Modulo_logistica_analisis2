using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Data;


namespace logic
{


    public class logicMA
    {
        dataMA dataL = new dataMA();


        //CREAR DOCUMENTO AUDITORIA
        public bool crearDocAuditoria(int no_audito, int cod_Bodega, string fecha, string descripcion)
        {
            return dataL.crearDocAuditoria(no_audito, cod_Bodega,  fecha, descripcion);
        }

        //OBTENER DOCUMENTO SIGUIENTE
        public int getNoDoc()
        {
            return dataL.getNoDoc();
        }

        //ACTUALIZA DOCUMENTO PARA REFERENCIAR LA AUDITORIA
        public bool actualizarDocAuditoria(int no_audito, int cod_Bodega, string fecha, string descripcion)
        {
            return dataL.actualizarDocAuditoria(no_audito, cod_Bodega, fecha, descripcion);
        }


        //GET BODEGAS
        public DataTable getBodegas()
        {
            return dataL.getBodegas();
        }

        //GET INDEX
        public int getIndex(int id)
        {
            return dataL.getIndex(id);
        }


        //OBTIENE CODIGO DE BODEGA
        public int getCodBodega(string name)
        {
            return dataL.getCodBodega(name);
        }




        //GET DATOS AUDITORIA
        public DataTable getDatosAudit()
        {
            return dataL.getDatosAudit();
        }


        //GET DETALLE AUDITORIA
        public DataTable getDetalleAudit(int no_Audit)
        {
            return dataL.getDetalleAudit(no_Audit);
        }




        }
}
