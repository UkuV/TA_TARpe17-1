using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class PahaKangelane : Kangelane
    {
        public PahaKangelane(string Nimi, string Asukoht) : base(Nimi, Asukoht)
        {
        }

        public PahaKangelane(string Nimi, string SuperNimi, string Võime) : base(Nimi, SuperNimi, Võime)
        {
        }

        public override void KasutaVõimet()
        {
            throw new NotImplementedException();
        }

        public override void VõiduKõne()
        {
            throw new NotImplementedException();
        }
    }
}
