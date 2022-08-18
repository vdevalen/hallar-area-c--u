using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPractica1
{
    public class clsPractica1
    {
        #region "Atributos"
        private float fltA, fltB, fltC, fltArea;
        private string strError;
        #endregion
        #region "Constructor"
        public clsPractica1()
        {
            fltA = 0;
            fltB = 0;
            fltC = 0;
            fltArea =0;
            strError = string.Empty;   
        }
        #endregion
        #region "Propiedades"
          public float ladoA
        {
           set  { fltA = value; }
        }

        public string Error
        {
            get { return strError; }
        }
        //crear las demas propiedades con modificadores de acceso y todo lo demas 

        #endregion
        #region "Metodos privados"
        private bool Validar()
        {
            if (fltA<=0)
            {
                strError = "vlr. del lado A, no es valido ";

                return false;
            }

            return true;
        }
        //validar los otros valores de los lados 
        
        #endregion
        #region "Metodos Publicos"
        public bool hallarArea ()
        {
            //logica negativa es preguntar por el error
            if (!Validar())
                return false;

            return true;
            {
                //compilar es hacer que el codigo lo interprete cualquier programa 

            }
        }
        #endregion

    }
}
