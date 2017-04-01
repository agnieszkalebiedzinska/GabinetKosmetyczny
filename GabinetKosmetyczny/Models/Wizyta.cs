using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;



namespace GabinetKosmetyczny.Models
{
    public class Wizyta
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }      
        public DateTime Data_od { get; set; }
        public DateTime Data_do { get; set; }
        public string RodzajZabiegu { get; set; }
        public Boolean Potwierdzona { get; set; }
    }
    public class WizytyDBCtxt : DbContext
    {
        public DbSet<Wizyta> Wizyty { get; set; }
    }

}
