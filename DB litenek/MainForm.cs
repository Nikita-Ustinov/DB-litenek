using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace DB_litenek
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	
	
	[Serializable]
	public partial class MainForm : Form
	{	
		LinkedList<Spolecnost> SeznamLSploecnost;
		
		public MainForm()
		{
			InitializeComponent();
			deseralizace();
		}
		
		void Button2Click(object sender, EventArgs e)	// zobrazuje panel k pridani Letnky
		{
			panel1.Visible = true;
			panel2.Visible = false;
			button4.Visible = false;
		}
		
		void Button3Click(object sender, EventArgs e)
		{ 	
			try {
				DateTime data = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
				pridatLetenky(textBox1.Text, textBox4.Text, textBox2.Text, textBox3.Text, maskedTextBox1.Text, int.Parse(textBox5.Text), data);
			} catch {
				MessageBox.Show("Doslo k chybe");
			}
		}
		
		void pridatLetenky(String spolecnost,String cisloLetu, String odkud, String kam, String cas, int PocetVolnychMist, DateTime date) {
			if(iObsahuje(spolecnost)) {
				LinkedListNode<Spolecnost> temp = SeznamLSploecnost.First;
				while(temp!=null) {
					if(temp.Value.Nazev==spolecnost) {
						if(!temp.Value.newLitenka(cisloLetu , odkud, kam, cas, PocetVolnychMist, date)) {
							MessageBox.Show(" Tohle cislo letu uz v seznamu");
						}
					}
					temp= temp.Next;
				}
			}
			else  {
				SeznamLSploecnost.AddLast(new Spolecnost(spolecnost,cisloLetu , odkud, kam, cas, PocetVolnychMist, date));
			}
			serializace();
			MessageBox.Show("Letenka pridana");
		}
		
		bool iObsahuje(String nazev) {				//vraci true jestli v seznammu uz je dana spolcnost
			LinkedListNode<Spolecnost> temp = SeznamLSploecnost.First;
			if(temp!=null) {
				while(temp!=null) {
					if(temp.Value.Nazev == nazev) {
						return true;
					}
					temp = temp.Next;
				}
			}
			return false;
		}
		
		
		void ButtonHledatClick(object sender, EventArgs e)
		{	
			try {
			listBox1.Items.Clear();
			DateTime date = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day);
			if (!string.IsNullOrEmpty(textBoxKam.Text)) {
				hledatLitenky(textBoxOdkud.Text, textBoxKam.Text, date);
			}
			else {
				hledatLitenky(textBoxOdkud.Text,  date);
			}
			
			}
			catch(Exception ee) {
				MessageBox.Show("Doslo k chybe");
			}
		}
		
		void hledatLitenky(String odkud, String kam, DateTime date ) {	//hleda letenky a zapisuje jich do listBox1
			LinkedListNode<Spolecnost> templ = SeznamLSploecnost.First;
			int count=0;
			String[] vystup;
			while(templ != null) {
				try {
					vystup = new string[templ.Value.hledatLitenky(odkud, kam, date).Split('&').Length];
					vystup = templ.Value.hledatLitenky(odkud, kam, date).Split('&');
					for(int i=0; i<vystup.Length-1; i++) {
						listBox1.Items.Add(vystup[i]);
						count++;
					}
				}
				catch (Exception e) {}
				templ = templ.Next;
			}
			if(count==0) {
				MessageBox.Show("Nenaleznena zadna letenka");
			}
		}
		
		void hledatLitenky(String odkud, DateTime date ) {	//hleda letenky a zapisuje jich do listBox1
			LinkedListNode<Spolecnost> templ = SeznamLSploecnost.First;
			int count=0;
			String[] vystup;
			while(templ != null) {
				try {
					vystup = new string[templ.Value.hledatLitenky(odkud, date).Split('&').Length];
					vystup = templ.Value.hledatLitenky(odkud, date).Split('&');
					for(int i=0; i<vystup.Length-1; i++) {
						listBox1.Items.Add(vystup[i]);
						count++;
					}
				}
				catch (Exception e) {}
				templ = templ.Next;
			}
			if(count==0) {
				MessageBox.Show("Nenaleznena zadna letenka");
			}
		}
		
		void serializace() {
			BinaryFormatter formatter = new BinaryFormatter();
			using ( var fSream = new FileStream("DBLetenky.dat", FileMode.Create, FileAccess.Write, FileShare.None)) {
				formatter.Serialize(fSream, SeznamLSploecnost);
			}
		}
		
		void deseralizace() {
			try {
				using (var fStream = File.OpenRead("DBLetenky.dat")) {
					BinaryFormatter formatter = new BinaryFormatter();
					SeznamLSploecnost = (LinkedList<Spolecnost>)formatter.Deserialize(fStream);
				}
			}
			catch (Exception e) {
				 SeznamLSploecnost = new LinkedList<Spolecnost>();
			}
		}
		
		void Button4Click(object sender, EventArgs e)	
		{
			if(listBox1.SelectedItem!=null) {
				String[] zaznam = new string[13];
				zaznam = listBox1.SelectedItem.ToString().Split(' ');
				LinkedListNode<Spolecnost> templ = SeznamLSploecnost.First;
				while(templ!=null) {
					if(templ.Value.Nazev == zaznam[5]) {
						templ.Value.Smaz(zaznam[9]);			//maze letenku
					}
					templ = templ.Next;
				}
			}
			listBox1.Items.Clear();
			DateTime date = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day);
			if(!string.IsNullOrEmpty(textBoxKam.Text)) {
			   	hledatLitenky(textBoxOdkud.Text, textBoxKam.Text, date);
			}
		   hledatLitenky(textBoxOdkud.Text, date);
		   serializace();
		}
		
	}
}
