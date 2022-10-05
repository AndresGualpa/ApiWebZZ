using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ARTICULO
    {

        public string emp_cod { get; set; }
        public string art_cod { get; set; }
        public string art_nom { get; set; }
        public string art_est { get; set; }
        public string car_cod { get; set; }
        public decimal art_prec { get; set; }

        /*------------------------------------------**** CONSULTAS ****---------------------------------------------*/
        //Seleccionar
        public const string SQL1 = " SELECT [emp_cod]  "
                                                      + ",[art_cod]"
                                                      + ",[art_nom]"
                                                      + ",[art_est]"
                                                      + ",[car_cod]"
                                                      + ",[art_prec]"
                                                      + "FROM [ARTICULO] WITH(NOLOCK)";
        //Insertar
        public const string SQL2 = " INSERT INTO [ARTICULO]"
                                                          + " ([emp_cod]"
                                                          + " ,[art_cod]"
                                                          + " ,[art_nom]"
                                                          + " ,[art_est]"
                                                          + " ,[car_cod]"
                                                          + " ,[art_prec])"
                                                          + " VALUES "
                                                          + " ( @emp_cod"
                                                          + "  ,@art_cod "
                                                          + "  ,@art_nom "
                                                          + "  ,@art_est "
                                                          + "  ,@car_cod "
                                                          + "  ,@art_prec)";
        //Actualizar
        public const string SQL3 = " UPDATE [ARTICULO] SET"
                                                          + "  [art_nom] = @art_nom"
                                                          + " ,[art_est] = @art_est"
                                                          + " ,[car_cod] = @car_cod"
                                                          + " ,[art_prec]= @art_prec"
                                                          + "  WHERE [art_cod] = @art_cod";
        //Eliminar 
        public const string SQL4 = " UPDATE [ARTICULO] SET [art_est] = 'uct'"                                                      
                                                          + "  WHERE [art_cod] = @art_cod";

    }

   


}
