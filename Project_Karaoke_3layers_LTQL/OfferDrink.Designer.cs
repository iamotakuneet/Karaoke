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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfferDrink));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearchDrink = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.buttonSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.dgvOfferDrink = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.paneOfferDrinkLeft = new System.Windows.Forms.Panel();
            this.comboBox = new MetroFramework.Controls.MetroComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfferDrink)).BeginInit();
            this.paneOfferDrinkLeft.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchDrink
            // 
            this.txtSearchDrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.txtSearchDrink.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.txtSearchDrink.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.txtSearchDrink.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.txtSearchDrink.BorderThickness = 1;
            this.txtSearchDrink.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchDrink.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearchDrink.ForeColor = System.Drawing.Color.White;
            this.txtSearchDrink.isPassword = false;
            this.txtSearchDrink.Location = new System.Drawing.Point(178, 8);
            this.txtSearchDrink.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchDrink.Name = "txtSearchDrink";
            this.txtSearchDrink.Size = new System.Drawing.Size(370, 44);
            this.txtSearchDrink.TabIndex = 2;
            this.txtSearchDrink.Text = "           Search drink here...";
            this.txtSearchDrink.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchDrink.OnValueChanged += new System.EventHandler(this.txtSearchDrink_OnValueChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.ImageActive = null;
            this.buttonSearch.Location = new System.Drawing.Point(555, 8);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(44, 44);
            this.buttonSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.TabStop = false;
            this.buttonSearch.Zoom = 10;
            this.buttonSearch.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // dgvOfferDrink
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvOfferDrink.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOfferDrink.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(164)))), ((int)(((byte)(174)))));
            this.dgvOfferDrink.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOfferDrink.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOfferDrink.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOfferDrink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOfferDrink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOfferDrink.DoubleBuffered = true;
            this.dgvOfferDrink.EnableHeadersVisualStyles = false;
            this.dgvOfferDrink.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvOfferDrink.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvOfferDrink.Location = new System.Drawing.Point(0, 0);
            this.dgvOfferDrink.Name = "dgvOfferDrink";
            this.dgvOfferDrink.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOfferDrink.Size = new System.Drawing.Size(1075, 697);
            this.dgvOfferDrink.TabIndex = 4;
            this.dgvOfferDrink.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // paneOfferDrinkLeft
            // 
            this.paneOfferDrinkLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.paneOfferDrinkLeft.Controls.Add(this.bunifuFlatButton1);
            this.paneOfferDrinkLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.paneOfferDrinkLeft.Location = new System.Drawing.Point(944, 0);
            this.paneOfferDrinkLeft.Name = "paneOfferDrinkLeft";
            this.paneOfferDrinkLeft.Size = new System.Drawing.Size(131, 697);
            this.paneOfferDrinkLeft.TabIndex = 5;
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.comboBox.ForeColor = System.Drawing.Color.White;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.ItemHeight = 23;
            this.comboBox.Location = new System.Drawing.Point(767, 15);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(171, 29);
            this.comboBox.TabIndex = 6;
            this.comboBox.UseSelectable = true;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(619, 17);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(142, 24);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "Select Room";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.txtSearchDrink);
            this.panelHeader.Controls.Add(this.comboBox);
            this.panelHeader.Controls.Add(this.buttonSearch);
            this.panelHeader.Controls.Add(this.bunifuCustomLabel1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(944, 60);
            this.panelHeader.TabIndex = 8;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Cặc";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 60);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(249)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(131, 48);
            this.bunifuFlatButton1.TabIndex = 0;
            this.bunifuFlatButton1.Text = "Cặc";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // OfferDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.paneOfferDrinkLeft);
            this.Controls.Add(this.dgvOfferDrink);
            this.Name = "OfferDrink";
            this.Size = new System.Drawing.Size(1075, 697);
            this.Load += new System.EventHandler(this.OfferDrink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfferDrink)).EndInit();
            this.paneOfferDrinkLeft.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSearchDrink;
        private Bunifu.Framework.UI.BunifuImageButton buttonSearch;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvOfferDrink;
        private System.Windows.Forms.Panel paneOfferDrinkLeft;
        private MetroFramework.Controls.MetroComboBox comboBox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panelHeader;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}
