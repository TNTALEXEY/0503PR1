namespace Lab1
{
	partial class Lab1Form
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
	private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab1Form));
			this.AskAndAnswerLabel = new System.Windows.Forms.Label();
			this.Side1Input = new System.Windows.Forms.TextBox();
			this.Side2Input = new System.Windows.Forms.TextBox();
			this.Side3Input = new System.Windows.Forms.TextBox();
			this.CheckAndResetButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// AskAndAnswerLabel
			// 
			this.AskAndAnswerLabel.AutoSize = true;
			this.AskAndAnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AskAndAnswerLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.AskAndAnswerLabel.Location = new System.Drawing.Point(147, 104);
			this.AskAndAnswerLabel.Name = "AskAndAnswerLabel";
			this.AskAndAnswerLabel.Size = new System.Drawing.Size(295, 20);
			this.AskAndAnswerLabel.TabIndex = 0;
			this.AskAndAnswerLabel.Text = "Введите длины сторон треугольника";
			// 
			// Side1Input
			// 
			this.Side1Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Side1Input.Location = new System.Drawing.Point(57, 147);
			this.Side1Input.Name = "Side1Input";
			this.Side1Input.Size = new System.Drawing.Size(114, 38);
			this.Side1Input.TabIndex = 1;
			this.Side1Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyBannerInt);
			// 
			// Side2Input
			// 
			this.Side2Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Side2Input.Location = new System.Drawing.Point(226, 147);
			this.Side2Input.Name = "Side2Input";
			this.Side2Input.Size = new System.Drawing.Size(114, 38);
			this.Side2Input.TabIndex = 2;
			this.Side2Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyBannerInt);
			// 
			// Side3Input
			// 
			this.Side3Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Side3Input.Location = new System.Drawing.Point(391, 147);
			this.Side3Input.Name = "Side3Input";
			this.Side3Input.Size = new System.Drawing.Size(114, 38);
			this.Side3Input.TabIndex = 3;
			this.Side3Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyBannerInt);
			// 
			// CheckAndResetButton
			// 
			this.CheckAndResetButton.BackColor = System.Drawing.Color.Yellow;
			this.CheckAndResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CheckAndResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CheckAndResetButton.Location = new System.Drawing.Point(188, 207);
			this.CheckAndResetButton.Name = "CheckAndResetButton";
			this.CheckAndResetButton.Size = new System.Drawing.Size(188, 51);
			this.CheckAndResetButton.TabIndex = 4;
			this.CheckAndResetButton.Text = "Проверить";
			this.CheckAndResetButton.UseVisualStyleBackColor = false;
			this.CheckAndResetButton.Click += new System.EventHandler(this.CheckAndResetButton_Click);
			// 
			// Lab1Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(624, 321);
			this.Controls.Add(this.CheckAndResetButton);
			this.Controls.Add(this.Side3Input);
			this.Controls.Add(this.Side2Input);
			this.Controls.Add(this.Side1Input);
			this.Controls.Add(this.AskAndAnswerLabel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(640, 360);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(640, 360);
			this.Name = "Lab1Form";
			this.Text = "Lab1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label AskAndAnswerLabel;
		private System.Windows.Forms.TextBox Side1Input;
		private System.Windows.Forms.TextBox Side2Input;
		private System.Windows.Forms.TextBox Side3Input;
		private System.Windows.Forms.Button CheckAndResetButton;
	}
}

