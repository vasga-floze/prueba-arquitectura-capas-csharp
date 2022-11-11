using Proyecto.BE;

namespace Proyecto.DA
{
    public class EmpleadoDA
    {
        public EmpleadoBE GetEmpleado()
        { 
            //Simular acceso a la BD
            return new EmpleadoBE { Nombre = "Gabriela Flores" }; 
        }
    }
}
