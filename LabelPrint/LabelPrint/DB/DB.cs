using LabelPrint.Models;
using System.Collections.Generic;
using System.Linq;

namespace LabelPrint.Services
{
    public class DB
    {
        public DB() 
        {
            Clients = (new List<ClientModel>()
            {
                new ClientModel() 
                {
                    Id = 1,
                    Name = "Контракс АД", 
                    Address = "1113 София, ул. \"Тинтява\" 13",
                    Email = "office@kontrax.bg",
                    Fax = "(02) 960 97 97",
                    Phone = "(02) 960 97 77"
                },
                new ClientModel()
                {
                    Id = 2,
                    Name = "Фирма 2 ЕООД",
                    Address = "1574 София, ул. \"Теменуга\" 1",
                    Email = "office@firma2.bg",
                    Fax = "(02) 123 45 56",
                    Phone = "(02) 543 77 88"
                },
                new ClientModel()
                {
                    Id = 3,
                    Name = "Гларус ООД",
                    Address = "8000 Бургас, ул. \"Крайбрежна\" 22",
                    Email = "sales@glarus.bg",
                    Fax = "(56) 23 73 41",
                    Phone = "(56) 45 89 02"
                },
                new ClientModel()
                {
                    Id = 4,
                    Name = "Тепето ЕАД",
                    Address = "4000 Пловдив, ул. \"Княз Борис\" 54",
                    Email = "office@tepeto.bg",
                    Fax = "(32) 03 33 15",
                    Phone = "(32) 83 72 07"
                },
                new ClientModel()
                {
                    Id = 5,
                    Name = "Загорка АД",
                    Address = "6000 Ст. Загора, ул. \"Хр. Ботев\" 1",
                    Email = "office@zagorka.bg",
                    Fax = "(42) 23  44 62",
                    Phone = "(42) 45 53 22"
                },
            }) as IQueryable<ClientModel>;    
        }

        public IQueryable<ClientModel> Clients { get; private set; }
    }
}
