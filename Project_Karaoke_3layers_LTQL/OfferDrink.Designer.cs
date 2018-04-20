namespace Project_Karaoke_3layers_LTQL
{
    partial class OfferDrink
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.plOfferLeft = new System.Windows.Forms.Panel();
            this.flpRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.plHeaderLeft = new System.Windows.Forms.Panel();
            this.buttonOfferMoreDish = new Bunifu.Framework.UI.BunifuFlatButton();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.plOfferMain = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.plOfferLeft.SuspendLayout();
            this.plHeaderLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.plOfferMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // plOfferLeft
            // 
            this.plOfferLeft.Controls.Add(this.plOfferMain);
            this.plOfferLeft.Controls.Add(this.plHeaderLeft);
            this.plOfferLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.plOfferLeft.Location = new System.Drawing.Point(603, 0);
            this.plOfferLeft.Name = "plOfferLeft";
            this.plOfferLeft.Size = new System.Drawing.Size(472, 697);
            this.plOfferLeft.TabIndex = 5;
            // 
            // flpRoom
            // 
            this.flpRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.flpRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpRoom.Location = new System.Drawing.Point(0, 0);
            this.flpRoom.Name = "flpRoom";
            this.flpRoom.Size = new System.Drawing.Size(603, 697);
            this.flpRoom.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(246, 29);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.White;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 43);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(246, 29);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // plHeaderLeft
            // 
            this.plHeaderLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.plHeaderLeft.Controls.Add(this.numericUpDown);
            this.plHeaderLeft.Controls.Add(this.buttonOfferMoreDish);
            this.plHeaderLeft.Controls.Add(this.comboBox1);
            this.plHeaderLeft.Controls.Add(this.comboBox2);
            this.plHeaderLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.plHeaderLeft.Location = new System.Drawing.Point(0, 0);
            this.plHeaderLeft.Name = "plHeaderLeft";
            this.plHeaderLeft.Size = new System.Drawing.Size(472, 80);
            this.plHeaderLeft.TabIndex = 2;
            // 
            // buttonOfferMoreDish
            // 
            this.buttonOfferMoreDish.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.buttonOfferMoreDish.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOfferMoreDish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.buttonOfferMoreDish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOfferMoreDish.BorderRadius = 0;
            this.buttonOfferMoreDish.ButtonText = "Thêm Món";
            this.buttonOfferMoreDish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOfferMoreDish.DisabledColor = System.Drawing.Color.Gray;
            this.buttonOfferMoreDish.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfferMoreDish.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonOfferMoreDish.Iconimage = null;
            this.buttonOfferMoreDish.Iconimage_right = null;
            this.buttonOfferMoreDish.Iconimage_right_Selected = null;
            this.buttonOfferMoreDish.Iconimage_Selected = null;
            this.buttonOfferMoreDish.IconMarginLeft = 0;
            this.buttonOfferMoreDish.IconMarginRight = 0;
            this.buttonOfferMoreDish.IconRightVisible = false;
            this.buttonOfferMoreDish.IconRightZoom = 0D;
            this.buttonOfferMoreDish.IconVisible = false;
            this.buttonOfferMoreDish.IconZoom = 90D;
            this.buttonOfferMoreDish.IsTab = false;
            this.buttonOfferMoreDish.Location = new System.Drawing.Point(264, 8);
            this.buttonOfferMoreDish.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.buttonOfferMoreDish.Name = "buttonOfferMoreDish";
            this.buttonOfferMoreDish.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.buttonOfferMoreDish.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.buttonOfferMoreDish.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonOfferMoreDish.selected = false;
            this.buttonOfferMoreDish.Size = new System.Drawing.Size(126, 64);
            this.buttonOfferMoreDish.TabIndex = 9;
            this.buttonOfferMoreDish.Text = "Thêm Món";
            this.buttonOfferMoreDish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonOfferMoreDish.Textcolor = System.Drawing.Color.White;
            this.buttonOfferMoreDish.TextFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfferMoreDish.Click += new System.EventHandler(this.buttonDrinkEdit_Click);
            // 
            // numericUpDown
            // 
            this.numericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.numericUpDown.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown.ForeColor = System.Drawing.Color.White;
            this.numericUpDown.Location = new System.Drawing.Point(402, 30);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(67, 27);
            this.numericUpDown.TabIndex = 10;
            this.numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // plOfferMain
            // 
            this.plOfferMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.plOfferMain.Controls.Add(this.dataGridView1);
            this.plOfferMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plOfferMain.Location = new System.Drawing.Point(0, 80);
            this.plOfferMain.Name = "plOfferMain";
            this.plOfferMain.Size = new System.Drawing.Size(472, 617);
            this.plOfferMain.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(472, 617);
            this.dataGridView1.TabIndex = 0;
            // 
            // OfferDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.Controls.Add(this.flpRoom);
            this.Controls.Add(this.plOfferLeft);
            this.Name = "OfferDrink";
            this.Size = new System.Drawing.Size(1075, 697);
            this.Load += new System.EventHandler(this.OfferDrink_Load);
            this.plOfferLeft.ResumeLayout(false);
            this.plHeaderLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.plOfferMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plOfferLeft;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.FlowLayoutPanel flpRoom;
        private System.Windows.Forms.Panel plHeaderLeft;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private Bunifu.Framework.UI.BunifuFlatButton buttonOfferMoreDish;
        private System.Windows.Forms.Panel plOfferMain;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
