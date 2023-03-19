using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;

namespace ClassLibrary1
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WebService1
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public List<string> MostrarDatos()
        {
            List<string> result = null;

            
            ConexionBBDD conexion = new ConexionBBDD();
            try
            {
                result = conexion.LeerDatos();
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return result;
        }
    }
}
