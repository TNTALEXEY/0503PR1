using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
	public partial class Lab1Form : Form
	{
		public Lab1Form()
		{
			InitializeComponent();
		}
		public void KeyBannerInt(object sender, KeyPressEventArgs e)//блокировалка не цифр (2 аргумента чтоб его мог использовать текстбох как метод)
		{
			if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)//проверка на цифру или удалялку
			{
				e.Handled = true;//блокируем ввод
			}
		}

		private void CheckAndResetButton_Click(object sender, EventArgs e)
		{
			//if(Side1Input.Text == "")
			int a = Convert.ToInt32(Side1Input.Text);
			int b = Convert.ToInt32(Side2Input.Text); 
			int c = Convert.ToInt32(Side3Input.Text);
			//a-1я сторона
			//b-2я сторона
			//c-3я сторона
			if (CheckAndResetButton.Text == "Проверить")
			{
				if ((a+b > c && b + c > a && c + a > b) && (a != 0 && b != 0 && c != 0))
				{
					if (a == b && b == c && c == a)
					{
						AskAndAnswerLabel.Text = "Полученный треугольник равностороний";
					}
					else if (a == b || b == c || c == a)
					{
						AskAndAnswerLabel.Text = "Полученный треугольник равнобедренный";
					}
					else
					{
						AskAndAnswerLabel.Text = "Полученный треугольник разносторонний";
					}
				}
				else
				{
					AskAndAnswerLabel.Text = "Данного треугольника не существует, увы😭";
				}
				CheckAndResetButton.Text = "Начать снова";
				Side1Input.Visible = false;
				Side2Input.Visible = false;
				Side3Input.Visible = false;
			}
			else
			{
				AskAndAnswerLabel.Text = "Введите длины сторон треугольника";
				CheckAndResetButton.Text = "Проверить";
				Side1Input.Text = "";
				Side2Input.Text = "";
				Side3Input.Text = "";
				Side1Input.Visible = true;
				Side2Input.Visible = true;
				Side3Input.Visible = true;
			}
		}
	}
}
