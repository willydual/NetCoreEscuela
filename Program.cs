﻿using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.WriteTitle("Academia de programadores");
            Printer.Beep(10000, cantidad: 10);
            ImpimirCursosEscuela(engine.Escuela);
            
        }

        private static void ImpimirCursosEscuela(Escuela escuela)
        {

            Printer.WriteTitle("Cursos disponibles");


            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"CURSO {curso.Nombre  }, ID  {curso.UniqueId}");
                }
            }
        }
    }
}