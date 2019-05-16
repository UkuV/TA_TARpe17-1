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

        public Kangelane(string Nimi, string Asukoht)
		{
			this.Nimi = Nimi;
			this.Asukoht = Asukoht;

		}
        public Kangelane(string Nimi, string SuperNimi, string Võime)
        {
            _Nimi = Nimi;
            _SuperNimi = SuperNimi;
            _Võime = Võime;
        }

        public string AnnaNimi() {return _Nimi; }
        public string AnnaSuperNimi() {  return _SuperNimi; }
        public string AnnaVõime() { return _Võime; }

        public abstract void VõiduKõne();

        public string Nimi { get => _Nimi; set => _Nimi = value; }
		public string Asukoht { get => _Asukoht; set => _Asukoht = value; }
        


        public virtual int Päästa(int Ohustatuid)
		{
			return (int)Math.Round(Ohustatuid * .95);
		}
		public override string ToString()
		{
			return Nimi + " hoiab " + Asukoht + " turvalisena.";
		}

        public int Rünnak() {
            Random r = new Random();
            return r.Next();
        }
        
        
	}
}
