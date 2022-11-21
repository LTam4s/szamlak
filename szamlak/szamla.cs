using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace szamlak
{
    internal class szamla
    {
        int id;
        string tulajdonosNeve;
        decimal egyenleg;
        DateTime nyitasdatum;

        public int Id { get => id; set => id = value; }
        public string TulajdonosNeve { get => tulajdonosNeve; set => tulajdonosNeve = value; }
        public decimal Egyenleg { get => egyenleg; set => egyenleg = value; }
        public DateTime Nyitasdatum { get => nyitasdatum; set => nyitasdatum = value; }

        public szamla(int id, string tulajdonosNeve, decimal egyenleg, DateTime nyitasdatum)
        {
            Id = id;
            TulajdonosNeve = tulajdonosNeve;
            Egyenleg = egyenleg;
            Nyitasdatum = nyitasdatum;
        }
        public override string ToString()
        {
            return tulajdonosNeve + " | " + egyenleg + "Ft | " + nyitasdatum;
        }
    }
}
