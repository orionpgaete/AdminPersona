using AdminPersona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPersonasModel.DAL
{
    public interface IPersonasDAL
    {
        void AgregarPersonas(Persona persona);
        List<Persona> ObtenerPersonas();
        List<Persona> FiltrarPersonas(string nombre);
    }
}
