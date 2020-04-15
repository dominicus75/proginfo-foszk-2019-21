using System;

namespace Szalamandra {

	public class Verseny {

		private int versenyzokSzama;
		private int[] lepesek = null;

		public Verseny(int szalamandrak) {

			this.versenyzokSzama = szalamandrak;
			lepesek = new int[this.versenyzokSzama];

			//Tömb feltöltése, minden versenyzőhöz 12-100 közötti szám hozzárendelése
			//Mivel a sorszámra később szükség van, így az indexelés 1-ről indul
			Random rand = new Random();
			for(int i = 0; i < versenyzokSzama; i++) {
				lepesek[i] = rand.Next(12, 100);
			}

		}

		//Indexelő
		public int this[int i] {

			get {
				if(i >= 0 || i <= versenyzokSzama) {
					return lepesek[i];
				} else {
					throw new IndexOutOfRangeException("Érvénytelen tömbindex");
				}
			}

			set {
				if(i >= 0 && i <= versenyzokSzama) {
					lepesek[i] = value;
				} else {
					throw new IndexOutOfRangeException("Érvénytelen tömbindex");
				}
			}

		}

		//Visszaadja a versenyzők számát - egyszerű getter
		public int VersenyzokSzama() {
			return versenyzokSzama;
		}

		//Visszaadja a távot 25 lépésnél kevesebből teljesítő versenyzők számát - megszámlálás tétele
		public int HuszonotLepesAlatt() {

			int result = 0;

			//Bejárjuk a lepesek tömböt és megszámoljuk hány eleme kisebb 25-nél
			for(int i = 0; i < versenyzokSzama; i++) {
				if(lepesek[i] < 25) { result++; }
			}

			return result;

		}


		//A nyertes indexének kiválasztása (minimum kiválasztás tétele)
		public int Nyertes() {

			//A legkisebb indexet 1-re állítjuk
			int minimumIndex = 1;

			//Bejárjuk a lepesek tömböt és minden 
			for(int i = 0; i < versenyzokSzama; i++) {
				if(lepesek[i] < lepesek[minimumIndex]) { minimumIndex = i; }
			}

			return minimumIndex;

		}

	}

}