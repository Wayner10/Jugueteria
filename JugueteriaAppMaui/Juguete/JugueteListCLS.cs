using System;
using System.Collections.Generic;
using System.Text;

namespace JugueteriaAppMaui.Juguete
{
    public class JugueteListCLS
    {
        public static List<JugueteCLS> listaJuguetes { get; set; } = new List<JugueteCLS>();

        static JugueteListCLS()
        {
            listaJuguetes.Add(new JugueteCLS { Id = 1, Nombre = "Carro", Marca = "Hot Wheels", EdadRecomendada = "3+" });
            listaJuguetes.Add(new JugueteCLS { Id = 2, Nombre = "Muñeca", Marca = "Barbie", EdadRecomendada = "5+" });
        }
    }
}
 