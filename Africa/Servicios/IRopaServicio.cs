using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Africa.Modelo;
using Africa.Servicios;

namespace Africa.Servicios
{
    public interface IRopaServicio
    {
        List<Ropa> MostrarTodos();
        void Agregar(Ropa ropa);
        void Eliminar(Ropa ropa);
        void Modificar(Ropa ropa);


    }
}