using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MvcApplication1.Views.ASP
{
    public partial class CargarLista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

          
        }

         /// <summary>
        /// Se ejecuta al hacer clic en la imagen agregar
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">ImageClickEventArgs e</param>
        protected void btnAddArvhicos_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                if (fuSubirArchivo.HasFile)
                {

                }
            }catch (Exception ae){

            }
        }

    }
}