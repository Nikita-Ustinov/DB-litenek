using System;
using System.Collections.Generic;
namespace DB_litenek
{
	/// <summary>
	/// Description of Spolecnost.
	/// </summary>
	/// 
	[Serializable]
	struct Letenky {
			
		public  Letenky(string cisloLetu, string odkud, string kam, string cas, int pocetVolnychMist, DateTime date) {
				CisloLetu = cisloLetu;
				Odkud = odkud;
				Kam = kam;
				Cas = cas;
				PocetVolnyhMist = pocetVolnychMist;
				Date = date;
		}
				
		public	String CisloLetu;
		public  int PocetVolnyhMist;	
		public String Cas;
		public String Odkud;
		public String Kam;
		public DateTime Date;
	}
	
	[Serializable]
	public class Spolecnost
	{
		LinkedList<Letenky> SeznamLetemek = new LinkedList<Letenky>();
		
		
		public String Nazev;
		
		public Spolecnost() {}
		
		public Spolecnost(String spolecnost,String cisloLetu, String odkud, String kam, String cas, int PocetVolnychMist, DateTime date) {
			Nazev = spolecnost;
			newLitenka(cisloLetu , odkud, kam, cas, PocetVolnychMist, date);
		}
		
		public bool newLitenka(string cisloLetu, string odkud, string kam, string cas, int pocetVolnychMist, DateTime date)
		{
			LinkedListNode<Letenky> temp = SeznamLetemek.First;
			while(temp!=null) {
				if(temp.Value.CisloLetu == cisloLetu ) {
					return false;
				}
				temp = temp.Next;
			}
			SeznamLetemek.AddLast(new Letenky(cisloLetu, odkud,kam,cas,pocetVolnychMist,date));
			return true;
		}
		
		public String  hledatLitenky(String odkud, String kam, DateTime date ) {
			LinkedListNode<Letenky> templ = SeznamLetemek.First;
			String vypis= null;
			if(templ!=null) {
				while(templ!=null) {
					if((templ.Value.Odkud == odkud) && (templ.Value.Kam == kam) && (templ.Value.Date == date)) {
						vypis += "Cas vyletu: "+templ.Value.Cas +"  Spolecnost: " + this.Nazev +"  cislo Vyletu: "+templ.Value.CisloLetu + "&";
					}
					templ = templ.Next;
				}
			}
			return vypis;
		}
		
		public void Smaz(String cisloLetu) {
			LinkedListNode<Letenky> templ = SeznamLetemek.First;
			while(templ!=null) {
				if(templ.Value.CisloLetu == cisloLetu) {
					SeznamLetemek.Remove(templ);
				}
				templ = templ.Next;
			}
		}
	}
}
