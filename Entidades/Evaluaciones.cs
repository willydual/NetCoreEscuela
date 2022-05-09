using System;

namespace CoreEscuela.Entidades
{
    public class Evaluaciones
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }

        public Alumno Alumno { get; set; }
        public Asignatura Asignatura  { get; set; }

        public float Nota { get; set; }

        public Evaluaciones() => UniqueId = Guid.NewGuid().ToString();

        decimal getRandomMark()
        {
            Random random = new Random();
            decimal mark = random.Next(1, 50) / 10;
            // redondeamos a un decimal
            return decimal.Round(mark, 1);
        }

    }
}