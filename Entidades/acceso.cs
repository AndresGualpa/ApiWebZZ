using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class acceso
    {

        public string usr_cod { get; set; }
        public string emp_cod { get; set; }
        public string niv_cod { get; set; }
        public string pry_cod { get; set; }
        public string emp_nom { get; set; }
        public string emp_est { get; set; }
        public string emp_db { get; set; }

        /*--------------------------------------------**** CONSULTAs ****--------------------------------------------*/
        //Seleccionar 
        public const string SQL1 = "SELECT"
                                          + " A.[usr_cod]"
                                          + " ,A.[emp_cod]"
                                          + " ,A.[niv_cod]"
                                          + " ,A.[pry_cod]"
                                          + " ,E.[emp_db]"
                                          + " ,E.[emp_est]"
                                          + " ,E.[emp_nom]"
                                          + "  FROM[ZEUZ_SYS].[dbo].[acceso] AS A WITH(NOLOCK)"
                                          + "  INNER JOIN[ZEUZ_SYS].[dbo].[empresa] AS E WITH(NOLOCK)"
                                          + "  ON A.emp_cod = E.emp_cod "
                                          + " WHERE  A.usr_cod = @usuario ";

    }
}
