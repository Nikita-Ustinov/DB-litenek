using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DB_litenek
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{	
		LinkedList<Spolecnost> SeznamLSploecnost = new LinkedList<Spolecnost>();
		
		public MainForm()
		{
			InitializeComponent();
		}
		void Button2Click(object sender, EventArgs e)
		{
			panel1.Visible = true;
		}
		void Button3Click(object sender, EventArgs e)
		{ 	
			DateTime data = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
//			data = dateTimePicker1.Value;
//			String[] forDate = maskedTextBox1.Text.Split(':');
//			data.Hour = forDate[0];
			pridatLetenky(textBox1.Text,"8879", textBox2.Text, textBox3.Text, maskedTextBox1.Text, int.Parse(textBox5.Text), data);
		}
		
		void pridatLetenky(String spolecnost,String cisloLetu, String odkud, String kam, String cas, int PocetVolnychMist, DateTime date) {
			if(iObsahuje(spolecnost)) {
				LinkedListNode<Spolecnost> temp = SeznamLSploecnost.First;
				while(temp.Next!=null) {
					if(temp.Value.Nazev==spolecnost) {
						temp.Value.newLitenka(cisloLetu , odkud, kam, cas, PocetVolnychMist, date);
					}
					temp= temp.Next;
				}
			}
			else  {
				SeznamLSploecnost.AddLast(new Spolecnost(spolecnost,cisloLetu , odkud, kam, cas, PocetVolnychMist, date));
			}
		}
		
		bool iObsahuje(String nazev) {
			LinkedListNode<Spolecnost> temp = SeznamLSploecnost.First;
			if(temp!=null) {
				while(temp.Next!=null) {
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
			hledatLitenky(textBoxOdkud.Text, textBoxKam.Text, dateTimePicker2.Value);
		}
		
		void hledatLitenky(String odkud, String kam, DateTime date ) {
			LinkedListNode<Spolecnost> templ = SeznamLSploecnost.First;
			if(templ != null) {
				while(templ.Next != null) {
					templ.Value.hledatLitenky(odkud, kam, date);
				}
			}
		}
	}
}
