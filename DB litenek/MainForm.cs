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
			DateTime data = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, dateTimePicker1.Value.Hour,dateTimePicker1.Value.Minute, dateTimePicker1.Value.Second);
			data = dateTimePicker1.Value;
//			String[] forDate = maskedTextBox1.Text.Split(':');
//			data.Hour = forDate[0];
			pridatLetenky(textBox1.Text, textBox2.Text, textBox3.Text,  int.Parse(textBox5.Text), data);
		}
		
		void pridatLetenky(String spolecnost, String odkud, String kam, int PocetVolnychMist, DateTime date) {
			if(iObsahuje(spolecnost)) {
				
			}
		}
		
		bool iObsahuje(String nazev) {
			LinkedListNode<Spolecnost> temp = SeznamLSploecnost.First;
			while(temp.Next!=null) {
				if(temp.Value.Nazev == nazev) {
					return true;
				}
				temp = temp.Next;
			}
			return false;
		}
		
	}
}
