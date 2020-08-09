namespace WheelOnCharge
{
    partial class LogScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogScreen));
            this.comboBox1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.dateTimePicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.button1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Transparent;
            this.comboBox1.BorderRadius = 3;
            this.comboBox1.DisabledColor = System.Drawing.Color.Gray;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.Items = new string[] {
        "Filters Change",
        "Break Service",
        "Tyres Replace",
        "Wheel Alignment",
        "Battery Check",
        "Spark Plug Service",
        "Belts and Hoses Service",
        "Oil Change"};
            this.comboBox1.Location = new System.Drawing.Point(267, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.NomalColor = System.Drawing.Color.Teal;
            this.comboBox1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox1.selectedIndex = -1;
            this.comboBox1.Size = new System.Drawing.Size(217, 35);
            this.comboBox1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.BackColor = System.Drawing.Color.Teal;
            this.dateTimePicker1.BorderRadius = 0;
            this.dateTimePicker1.ForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker1.FormatCustom = null;
            this.dateTimePicker1.Location = new System.Drawing.Point(267, 147);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 36);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2019, 2, 6, 22, 17, 23, 524);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(82, 111);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(171, 27);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "SERVICED PART";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(82, 152);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(171, 27);
            this.bunifuCustomLabel2.TabIndex = 9;
            this.bunifuCustomLabel2.Text = "SERVICED DATE";
            // 
            // button1
            // 
            this.button1.Activecolor = System.Drawing.Color.Teal;
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.BorderRadius = 0;
            this.button1.ButtonText = "ENTER";
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DisabledColor = System.Drawing.Color.Gray;
            this.button1.Iconcolor = System.Drawing.Color.Transparent;
            this.button1.Iconimage = ((System.Drawing.Image)(resources.GetObject("button1.Iconimage")));
            this.button1.Iconimage_right = null;
            this.button1.Iconimage_right_Selected = null;
            this.button1.Iconimage_Selected = null;
            this.button1.IconMarginLeft = 0;
            this.button1.IconMarginRight = 0;
            this.button1.IconRightVisible = true;
            this.button1.IconRightZoom = 0D;
            this.button1.IconVisible = true;
            this.button1.IconZoom = 90D;
            this.button1.IsTab = false;
            this.button1.Location = new System.Drawing.Point(221, 204);
            this.button1.Name = "button1";
            this.button1.Normalcolor = System.Drawing.Color.Teal;
            this.button1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.OnHoverTextColor = System.Drawing.Color.White;
            this.button1.selected = false;
            this.button1.Size = new System.Drawing.Size(126, 48);
            this.button1.TabIndex = 10;
            this.button1.Text = "ENTER";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Textcolor = System.Drawing.Color.White;
            this.button1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Activecolor = System.Drawing.Color.Teal;
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.BorderRadius = 0;
            this.button3.ButtonText = "BACK";
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.DisabledColor = System.Drawing.Color.Gray;
            this.button3.Iconcolor = System.Drawing.Color.Transparent;
            this.button3.Iconimage = ((System.Drawing.Image)(resources.GetObject("button3.Iconimage")));
            this.button3.Iconimage_right = null;
            this.button3.Iconimage_right_Selected = null;
            this.button3.Iconimage_Selected = null;
            this.button3.IconMarginLeft = 0;
            this.button3.IconMarginRight = 0;
            this.button3.IconRightVisible = true;
            this.button3.IconRightZoom = 0D;
            this.button3.IconVisible = true;
            this.button3.IconZoom = 90D;
            this.button3.IsTab = false;
            this.button3.Location = new System.Drawing.Point(221, 301);
            this.button3.Name = "button3";
            this.button3.Normalcolor = System.Drawing.Color.Teal;
            this.button3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.OnHoverTextColor = System.Drawing.Color.White;
            this.button3.selected = false;
            this.button3.Size = new System.Drawing.Size(126, 48);
            this.button3.TabIndex = 12;
            this.button3.Text = "BACK";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Textcolor = System.Drawing.Color.White;
            this.button3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LogScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Name = "LogScreen";
            this.Text = "Manage Wheels - Serviced Part Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDropdown comboBox1;
        private Bunifu.Framework.UI.BunifuDatepicker dateTimePicker1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton button1;
        private Bunifu.Framework.UI.BunifuFlatButton button3;
    }
}