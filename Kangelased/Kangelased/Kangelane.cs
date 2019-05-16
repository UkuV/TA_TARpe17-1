using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
	abstract class Kangelane
	{
		private string _Nimi;
		private string _Asukoht;
        private string _SuperNimi;
        private string _Võime;

        public Kangelane(string Nimi, string Asukoht, string SuperNimi, string Võime)
		{
			this.Nimi = Nimi;
			this.Asukoht = Asukoht;
            this.SuperNimi = SuperNimi;
            this.Võime = Võime;
		}

		public string Nimi { get => _Nimi; set => _Nimi = value; }
		public string Asukoht { get => _Asukoht; set => _Asukoht = value; }
        public string SuperNimi { get => _SuperNimi; set => _SuperNimi = value; }
        public string Võime { get => _Võime; set => _Võime = value; }

        public virtual int Päästa(int Ohustatuid)
		{
			return (int)Math.Round(Ohustatuid * .95);
		}
		public override string ToString()
		{
			return Nimi + " hoiab " + Asukoht + " turvalisena.";
		}
        public string AnnaNimi(string Nimi) {
            return Nimi;
        }
        public string AnnaSuperNimi( string SuperNimi) {
            return SuperNimi;
        }
        public string AnnaVõime(string Võime ) {
            return Võime;
        }
        public abstract void VõiduKõne();
        
        
        
	}
}
