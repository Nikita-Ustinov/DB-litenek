using System;
using System.Collections.Generic;
namespace DB_litenek
{
	/// <summary>
	/// Description of Spolecnost.
	/// </summary>
	public class Spolecnost
	{
		LinkedList<Letenky> SeznamLetemek = new LinkedList<Letenky>();
		
		struct Letenky {
			DateTime cas;
			String Odkud;
			String Kam;
			int PocetVolnyhMist;
		}
		
		public String Nazev;
		
		public Spolecnost()
		{
		}
		
		
	}
}
