using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace MNTPRODUCTO.Logica
{
    class logicLayer
    {

        Data.dataLayer dt = new Data.dataLayer();


        //GET GRUPO
        public DataTable getGrupo()
        {
            return dt.getGrupo();
        }


        //GET UNIDAD MEDIDA
        public DataTable getUnidadMedida()
        { return dt.getUnidadMedida(); }

        //GET TIPO
        public DataTable getTipo()
        { return dt.getTipo(); }


        //GET MARCA
        public DataTable getMarca()
        { return dt.getMarca(); }


        //OBTIENE EL NUMERO DE DOCUMENTO SIGUIENTE
        public int getNoSig()
        { return dt.getNoSig(); }

        //OBTIENE CODIGO DE GRUPO
        public int getCodGrupo(string name)
        { return dt.getCodGrupo(name);  }

        //OBTIENE COD UNIDAD MEDIDA
        public int getCodUMedida(string name)
        { return dt.getCodUMedida(name); }

        //OBTIENE CODIGO DE TIPO
        public int getCodTipo(string name)
        { return dt.getCodTipo(name); }

        //OBTIENE CODIGO DE MARCA
        public int getCodMarca(string name)
        { return dt.getCodMarca(name); }



            //
        }
}
