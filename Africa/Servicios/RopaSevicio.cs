using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Africa.Modelo;


namespace Africa.Servicios
{
    public class RopaSevicio : IRopaServicio
    {

        public RopaSevicio()
        {
            Ropas = new List<Ropa>(){
                new Ropa(){ID=1,NombrePrenda="Rocio", Prenda="Pantalon",Stock=true,CantidadStock=10},
                new Ropa(){ID=2,NombrePrenda="Africa", Prenda="Pantalon",Stock=true,CantidadStock=19},
                new Ropa(){ID=3,NombrePrenda="Joana", Prenda="Pantalon",Stock=false,CantidadStock=10},
                new Ropa(){ID=4,NombrePrenda="Coni", Prenda="Pantalon",Stock=true,CantidadStock=15},
                new Ropa(){ID=5,NombrePrenda="Rocio Shirt", Prenda="Remera",Stock=true,CantidadStock=20},
                new Ropa(){ID=6,NombrePrenda="Africa Shirt", Prenda="Remera",Stock=true,CantidadStock=10},
                new Ropa(){ID=7,NombrePrenda="Joana Shirt", Prenda="Remera",Stock=true,CantidadStock=1},
                new Ropa(){ID=8,NombrePrenda="Coni Shirt", Prenda="Remera",Stock=true,CantidadStock=16}
            };
        }
        public List<Ropa> Ropas;
        public List<Ropa> MostrarTodos()
        {
            return Ropas;
        }
        public void Agregar(Ropa ropa)
        {
            Ropas.Add(ropa);

        }
        public void Eliminar(Ropa ropa)
        {
            var ropaAnterior = Ropas.Where(x => x.ID == ropa.ID).First();
            Ropas.Remove(ropaAnterior);
        }
        public void Modificar(Ropa ropa)
        {
            var ropaAnterior = Ropas.Where(x => x.ID == ropa.ID).First();
            Ropas.Remove(ropaAnterior);
            Ropas.Add(ropa);
        }


    }
}