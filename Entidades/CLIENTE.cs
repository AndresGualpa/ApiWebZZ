using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CLIENTE
    {
        public string emp_cod { get; set; }
        public string cli_cod { get; set; }
        public string cli_nom { get; set; }
        public string cli_est { get; set; }
        public string ccl_cod { get; set; }

        /*------------------------------------------**** CONSULTAS ****---------------------------------------------*/
        //Seleccionar
        public const string SQL1 = "SELECT * FROM [CLIENTE] WITH(NOLOCK)"; 

        //Insertar
        public const string SQL2 = "INSERT INTO [CLIENTE]"
                                                          + " ([emp_cod]"
                                                          + " ,[cli_cod]"
                                                          + " ,[cli_nom]"
                                                          + " ,[cli_est]"
                                                          + " ,[ccl_cod])"
                                                          + " VALUES "
                                                          + " ( @emp_cod"
                                                          + "  ,@cli_cod "
                                                          + "  ,@cli_nom "
                                                          + "  ,@cli_est "
                                                          + "  ,@ccl_cod )";

        
    }
}
