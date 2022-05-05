using System;

namespace Portafolio.DAOS
{
    public class Contacto
    {
        public Guid Id { get; set; }
        public string Nombre {get; set;}
        public string Motivo {get; set;}
        public DateTime Creacion {get; set;}

        public Contacto(Guid id,string nombre, string motivo,DateTime creacion)
        {
            Id = id;
            Nombre = nombre;
            Motivo = motivo;
            Creacion = creacion;
        }

        public static Contacto CrearNuevo(string nombre, string motivo)
        {
            return new Contacto(Guid.NewGuid(),nombre,motivo,DateTime.Now);
        }
    }
}
