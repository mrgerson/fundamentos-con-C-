using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    class Escuela
    {

        string nombre;

        //encapsular para poder ser accedido
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value.ToUpper(); }
        }

        public int AñoDeCreación { get; set; }

        public string? Pais { get; set; }
        public string? Ciudad { get; set; }

        public TiposEscuela TiposEscuela {get; set;}

        //proviene de la clase curso
        /* public Curso[] Cursos { get; set; } */
        public List<Curso> Cursos {get; set;}

        //contructor de la clase
        public Escuela(string nombre, int año) => (Nombre, AñoDeCreación) = (nombre, año);

         public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TiposEscuela} {System.Environment.NewLine} Pais: {Pais}, Ciudad:{Ciudad}";
        }

        public Escuela(string nombre, int año, 
                       TiposEscuela tipo, 
                       string pais = "", string ciudad = "")
        {
            (Nombre, AñoDeCreación) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }

    }
}