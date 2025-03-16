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
			TextBox CurrentInput = sender as TextBox;
			if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127 && e.KeyChar != '-')//проверка на цифру или удалялку или минус
				e.Handled = true;//блокируем ввод знака
			if (CurrentInput.Text.Length > 0 && e.KeyChar == '-')//при попытке ввода минуса вне первой позиции:
				e.Handled = true;//блокируем ввод знака
		}

		private void CheckAndResetButton_Click(object sender, EventArgs e)//нажатие на кнопку
		{
			int a, b, c;//объявляем 3 стороны треугольника
			//проверялка на отсутствие цифр на вводе (прочих проверок на содержимое нет, т.к. прочее содержимое вводить нельзя)
			if (Side1Input.Text == "" || Side1Input.Text == "-")//если ввода нет, то программа интерепретирует это как ввод 0
				Side1Input.Text = "0";
			if (Side2Input.Text == "" || Side2Input.Text == "-")
				Side2Input.Text = "0";
			if (Side3Input.Text == "" || Side3Input.Text == "-")
				Side3Input.Text = "0";
			//конец проверялки
			a = Convert.ToInt32(Side1Input.Text);
			b = Convert.ToInt32(Side2Input.Text); 
			c = Convert.ToInt32(Side3Input.Text);
			//a-1я сторона
			//b-2я сторона
			//c-3я сторона
			if (CheckAndResetButton.Text == "Проверить")//если кнопка находится в положении проверить
			{
				if ((a + b > c && b + c > a && c + a > b) && (a > 0 && b > 0 && c > 0))//проверка возможности существования треугольника
				{
					if (a == b && b == c && c == a)// проверка что все пары сторон равны
						AskAndAnswerLabel.Text = "Полученный треугольник равностороний";
					else if (a == b || b == c || c == a)// проверка что хотябы одна пара сторон равна
						AskAndAnswerLabel.Text = "Полученный треугольник равнобедренный";
					else//нет равных сторон
						AskAndAnswerLabel.Text = "Полученный треугольник разносторонний";
				}
				else//существование треугольника невозможно
				{
					AskAndAnswerLabel.Text = "Данного треугольника не существует, увы";
				}
				CheckAndResetButton.Text = "Начать снова";//меняем текст кнопки, как в примере
				Side1Input.Visible = false;//прячем все поля ввода, как в примере
				Side2Input.Visible = false;//^
				Side3Input.Visible = false;//^
			}
			else//если кнопка находится в положении начать снова
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
