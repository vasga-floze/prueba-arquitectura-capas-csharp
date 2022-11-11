using Proyecto.BE;
using Proyecto.DA;

namespace Proyecto.BL
{
    public class EmpleadoBL
    {
        public EmpleadoBE GetEmpleado()
        {
            EmpleadoDA dataAccess= new EmpleadoDA();
            EmpleadoBE empleado = new EmpleadoBE();

            empleado = dataAccess.GetEmpleado();

            //si está nulo que le asigne 17
            if (!empleado.Edad.HasValue)
                empleado.Edad = 17;

            return empleado;
        }
    }
}
