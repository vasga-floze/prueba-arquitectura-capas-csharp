using Proyecto.BE;
using Proyecto.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaMulticapa
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrarNombre_Click(object sender, EventArgs e)
        {
            EmpleadoBL logica = new EmpleadoBL();
            EmpleadoBE empleado = new EmpleadoBE();

            empleado = logica.GetEmpleado();

            txtNombre.Text = empleado.Nombre;
            txtEdad.Text = empleado.Edad.ToString();

        }
    }
}