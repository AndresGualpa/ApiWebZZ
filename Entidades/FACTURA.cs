using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class FACTURA
    {
        public string emp_cod { get; set; }
        public int fac_num { get; set; }
        public DateTime fac_fec { get; set; }
        public string fac_est { get; set; }
        public decimal fac_total { get; set; }
        public string cli_cod { get; set; }

        /*------------------------------------------**** CONSULTAS ****---------------------------------------------*/
        //Seleccionar
        public const string SQL1 = "SELECT * FROM [FACTURA] WITH(NOLOCK)";

        //Insertar 
        public const string SQL2 = "INSERT INTO [FACTURA]"
                                                  + " ([emp_cod]"
                                                  + " ,[fac_num]"
                                                  + " ,[fac_fec]"
                                                  + " ,[fac_est]"
                                                  + " ,[fac_total]"
                                                  + " ,[cli_cod])"
                                                  + " VALUES "
                                                  + " ( @emp_cod"
                                                  + "  ,@fac_num "
                                                  + "  ,@fac_fec "
                                                  + "  ,@fac_est "
                                                  + "  ,@fac_total "
                                                  + "  ,@cli_cod )";


    }
}
