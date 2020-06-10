namespace Worldyachts.View
{
    partial class WorldyachtsMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainScreenFormPictureBox = new System.Windows.Forms.PictureBox();
            this.mainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.персоналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.яхтыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.реализацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наПечатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.сотрудникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.специализацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продуктToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видПродукцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйЗаказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрЗаказовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыПоСотрудникамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПродажуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продажиПоТоварамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прайслистToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стоймостьЗаказаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainScreenFormPictureBox)).BeginInit();
            this.mainFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainScreenFormPictureBox
            // 
            this.mainScreenFormPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainScreenFormPictureBox.Image = global::Worldyachts.Properties.Resources.worldyachtsMainScreen_png;
            this.mainScreenFormPictureBox.Location = new System.Drawing.Point(0, 28);
            this.mainScreenFormPictureBox.Name = "mainScreenFormPictureBox";
            this.mainScreenFormPictureBox.Size = new System.Drawing.Size(804, 431);
            this.mainScreenFormPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainScreenFormPictureBox.TabIndex = 0;
            this.mainScreenFormPictureBox.TabStop = false;
            // 
            // mainFormMenuStrip
            // 
            this.mainFormMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.персоналToolStripMenuItem,
            this.яхтыToolStripMenuItem,
            this.заказыToolStripMenuItem,
            this.реализацияToolStripMenuItem,
            this.наПечатьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.mainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainFormMenuStrip.Name = "mainFormMenuStrip";
            this.mainFormMenuStrip.Size = new System.Drawing.Size(804, 28);
            this.mainFormMenuStrip.TabIndex = 1;
            this.mainFormMenuStrip.Text = "menuStrip1";
            // 
            // персоналToolStripMenuItem
            // 
            this.персоналToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникToolStripMenuItem,
            this.списокСотрудниковToolStripMenuItem,
            this.специализацияToolStripMenuItem});
            this.персоналToolStripMenuItem.Name = "персоналToolStripMenuItem";
            this.персоналToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.персоналToolStripMenuItem.Text = "Персонал";
            // 
            // яхтыToolStripMenuItem
            // 
            this.яхтыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.продуктToolStripMenuItem,
            this.видПродукцииToolStripMenuItem});
            this.яхтыToolStripMenuItem.Name = "яхтыToolStripMenuItem";
            this.яхтыToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.яхтыToolStripMenuItem.Text = "Яхты";
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйЗаказToolStripMenuItem,
            this.просмотрЗаказовToolStripMenuItem,
            this.заказыПоСотрудникамToolStripMenuItem});
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.заказыToolStripMenuItem.Text = "Бронирование";
            // 
            // реализацияToolStripMenuItem
            // 
            this.реализацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПродажуToolStripMenuItem,
            this.продажиПоТоварамToolStripMenuItem});
            this.реализацияToolStripMenuItem.Name = "реализацияToolStripMenuItem";
            this.реализацияToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.реализацияToolStripMenuItem.Text = "Реализация";
            // 
            // наПечатьToolStripMenuItem
            // 
            this.наПечатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прайслистToolStripMenuItem,
            this.стоймостьЗаказаToolStripMenuItem});
            this.наПечатьToolStripMenuItem.Name = "наПечатьToolStripMenuItem";
            this.наПечатьToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.наПечатьToolStripMenuItem.Text = "На печать";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.dateTimeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimeLabel.Location = new System.Drawing.Point(586, 7);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(0, 17);
            this.dateTimeLabel.TabIndex = 2;
            // 
            // сотрудникToolStripMenuItem
            // 
            this.сотрудникToolStripMenuItem.Name = "сотрудникToolStripMenuItem";
            this.сотрудникToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.сотрудникToolStripMenuItem.Text = "Сотрудник";
            // 
            // списокСотрудниковToolStripMenuItem
            // 
            this.списокСотрудниковToolStripMenuItem.Name = "списокСотрудниковToolStripMenuItem";
            this.списокСотрудниковToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.списокСотрудниковToolStripMenuItem.Text = "Список сотрудников";
            // 
            // специализацияToolStripMenuItem
            // 
            this.специализацияToolStripMenuItem.Name = "специализацияToolStripMenuItem";
            this.специализацияToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.специализацияToolStripMenuItem.Text = "Специализация";
            // 
            // продуктToolStripMenuItem
            // 
            this.продуктToolStripMenuItem.Name = "продуктToolStripMenuItem";
            this.продуктToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.продуктToolStripMenuItem.Text = "Продукт";
            // 
            // видПродукцииToolStripMenuItem
            // 
            this.видПродукцииToolStripMenuItem.Name = "видПродукцииToolStripMenuItem";
            this.видПродукцииToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.видПродукцииToolStripMenuItem.Text = "Вид продукции";
            // 
            // новыйЗаказToolStripMenuItem
            // 
            this.новыйЗаказToolStripMenuItem.Name = "новыйЗаказToolStripMenuItem";
            this.новыйЗаказToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.новыйЗаказToolStripMenuItem.Text = "Новый заказ";
            // 
            // просмотрЗаказовToolStripMenuItem
            // 
            this.просмотрЗаказовToolStripMenuItem.Name = "просмотрЗаказовToolStripMenuItem";
            this.просмотрЗаказовToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.просмотрЗаказовToolStripMenuItem.Text = "Просмотр заказов";
            // 
            // заказыПоСотрудникамToolStripMenuItem
            // 
            this.заказыПоСотрудникамToolStripMenuItem.Name = "заказыПоСотрудникамToolStripMenuItem";
            this.заказыПоСотрудникамToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.заказыПоСотрудникамToolStripMenuItem.Text = "Заказы по сотрудникам";
            // 
            // добавитьПродажуToolStripMenuItem
            // 
            this.добавитьПродажуToolStripMenuItem.Name = "добавитьПродажуToolStripMenuItem";
            this.добавитьПродажуToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.добавитьПродажуToolStripMenuItem.Text = "Добавить продажу";
            // 
            // продажиПоТоварамToolStripMenuItem
            // 
            this.продажиПоТоварамToolStripMenuItem.Name = "продажиПоТоварамToolStripMenuItem";
            this.продажиПоТоварамToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.продажиПоТоварамToolStripMenuItem.Text = "Продажи по товарам";
            // 
            // прайслистToolStripMenuItem
            // 
            this.прайслистToolStripMenuItem.Name = "прайслистToolStripMenuItem";
            this.прайслистToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.прайслистToolStripMenuItem.Text = "Прайс-лист";
            // 
            // стоймостьЗаказаToolStripMenuItem
            // 
            this.стоймостьЗаказаToolStripMenuItem.Name = "стоймостьЗаказаToolStripMenuItem";
            this.стоймостьЗаказаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.стоймостьЗаказаToolStripMenuItem.Text = "Стоймость заказа";
            // 
            // WorldyachtsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 459);
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.mainScreenFormPictureBox);
            this.Controls.Add(this.mainFormMenuStrip);
            this.MainMenuStrip = this.mainFormMenuStrip;
            this.MaximumSize = new System.Drawing.Size(822, 506);
            this.MinimumSize = new System.Drawing.Size(822, 506);
            this.Name = "WorldyachtsMainForm";
            this.Text = "Worldyachts";
            ((System.ComponentModel.ISupportInitialize)(this.mainScreenFormPictureBox)).EndInit();
            this.mainFormMenuStrip.ResumeLayout(false);
            this.mainFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainScreenFormPictureBox;
        private System.Windows.Forms.MenuStrip mainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem персоналToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem яхтыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem реализацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наПечатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.ToolStripMenuItem сотрудникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокСотрудниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem специализацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продуктToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видПродукцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйЗаказToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрЗаказовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыПоСотрудникамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПродажуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продажиПоТоварамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прайслистToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стоймостьЗаказаToolStripMenuItem;
    }
}