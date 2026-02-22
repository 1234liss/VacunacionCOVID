using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Crear 500 ciudadanos
        HashSet<string> ciudadanos = new HashSet<string>();

        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add("Ciudadano " + i);
        }

        // 2. Crear conjunto Pfizer (75)
        HashSet<string> pfizer = new HashSet<string>();
        for (int i = 1; i <= 75; i++)
        {
            pfizer.Add("Ciudadano " + i);
        }

        // 3. Crear conjunto AstraZeneca (75)
        HashSet<string> astra = new HashSet<string>();
        for (int i = 50; i < 125; i++)
        {
            astra.Add("Ciudadano " + i);
        }

        // 4. Ciudadanos con ambas dosis (intersección)
        var ambas = pfizer.Intersect(astra);

        // 5. Ciudadanos vacunados (unión)
        var vacunados = pfizer.Union(astra);

        // 6. No vacunados
        var noVacunados = ciudadanos.Except(vacunados);

        // 7. Solo Pfizer
        var soloPfizer = pfizer.Except(astra);

        // 8. Solo AstraZeneca
        var soloAstra = astra.Except(pfizer);

        // MOSTRAR RESULTADOS
        Console.WriteLine("No vacunados: " + noVacunados.Count());
        Console.WriteLine("Ambas dosis: " + ambas.Count());
        Console.WriteLine("Solo Pfizer: " + soloPfizer.Count());
        Console.WriteLine("Solo AstraZeneca: " + soloAstra.Count());
    }
}