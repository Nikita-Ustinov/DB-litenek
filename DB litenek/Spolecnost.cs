using System;
using System.Collections.Generic;
namespace DB_litenek
{
	/// <summary>
	/// Description of Spolecnost.
	/// </summary>
	/// 
	
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
		public	int PocetVolnyhMist;	
		public String Cas;
		public String Odkud;
		public String Kam;
		public DateTime Date;
	}
	
	public class Spolecnost
	{
		 LinkedList<Letenky> SeznamLetemek = new LinkedList<Letenky>();
		
		
		
		public String Nazev;
		
		public Spolecnost() {}
		
		public Spolecnost(String spolecnost,String cisloLetu, String odkud, String kam, String cas, int PocetVolnychMist, DateTime date) {
			Nazev = spolecnost;
			newLitenka(cisloLetu , odkud, kam, cas, PocetVolnychMist, date);
		}
		
		
		
		public void newLitenka(string cisloLetu, string odkud, string kam, string cas, int pocetVolnychMist, DateTime date)
		{
			LinkedListNode<Letenky> temp = SeznamLetemek.First;
			bool uzTam = false;
//			while(temp.Next!=null) {
//				if(temp.Value.CisloLetu == cisloLetu) {
//					temp.Value.PocetVolnyhMist = pocetVolnychMist;
//					uzTam = true;
//				}
//				temp = temp.Next;
//			}


			if(!uzTam) {
				SeznamLetemek.AddLast(new Letenky(cisloLetu, odkud,kam,cas,pocetVolnychMist,date));
			}
			
		}
		
		public String  hledatLitenky(String odkud, String kam, DateTime date ) {
			LinkedListNode<Letenky> templ = SeznamLetemek.First;
			String vypis= null;
			if(templ!=null) {
				while(templ.Next!=null) {
					if((templ.Value.Odkud == odkud) || (templ.Value.Kam == kam) || (templ.Value.Date == date)) {
						vypis += "Cas vyletu: "+templ.Value.Cas +"  Spolecnost: " + this.Nazev +"  cislo Vyletu: "+templ.Value.CisloLetu + "\r\n";
					}
					templ = templ.Next;
				}
			}
			return vypis;
		}
	}
}
