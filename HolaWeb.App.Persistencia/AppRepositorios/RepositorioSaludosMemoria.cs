using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HolaWeb.App.Dominio;

namespace HolaWeb.App.Persistencia.AppRepositorios
{
    public class RepositorioSaludosMemoria : IRepositorioSaludo
    {
        List<Saludo> saludos;
        public RepositorioSaludosMemoria()
        {
            saludos = new List<Saludo>()
            {
                new Saludo{Id=1,EnEspañol="Buenos dias",EnIngles="Good morning", EnItaliano="Bungiorno"},
                new Saludo{Id=2,EnEspañol="Buenas tardes",EnIngles="Good Afternoon", EnItaliano="Buon pomeriggio"},
                new Saludo{Id=2,EnEspañol="Buenas Noches",EnIngles="Good Evening", EnItaliano="Buona notte"}
            };
        }
        public IEnumerable<Saludo> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}