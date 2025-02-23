﻿
namespace biblioteca
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.biblionet = new System.Windows.Forms.PictureBox();
            this.btSair = new MetroFramework.Controls.MetroTile();
            this.btNotas = new MetroFramework.Controls.MetroTile();
            this.btSalas = new MetroFramework.Controls.MetroTile();
            this.btEquipamentos = new MetroFramework.Controls.MetroTile();
            this.btUtilizadores = new MetroFramework.Controls.MetroTile();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblionet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(918, 836);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(502, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Este programa foi desenvolvido por Anna Garcia para a Biblioteca Escolar da ESHN." +
    "";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 836);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(236, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Biblioteca Escolar - Gestão de recursos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(23, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 576);
            this.panel1.TabIndex = 0;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(1057, 714);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(216, 19);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Booking - Developed by Nαnα™ ©";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::biblioteca.Properties.Resources.booking3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.ErrorImage = global::biblioteca.Properties.Resources.biblio;
            this.pictureBox1.InitialImage = global::biblioteca.Properties.Resources.biblio;
            this.pictureBox1.Location = new System.Drawing.Point(374, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 82);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // biblionet
            // 
            this.biblionet.BackgroundImage = global::biblioteca.Properties.Resources.biblionet;
            this.biblionet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.biblionet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biblionet.ErrorImage = global::biblioteca.Properties.Resources.biblio;
            this.biblionet.InitialImage = global::biblioteca.Properties.Resources.biblio;
            this.biblionet.Location = new System.Drawing.Point(187, 36);
            this.biblionet.Name = "biblionet";
            this.biblionet.Size = new System.Drawing.Size(128, 93);
            this.biblionet.TabIndex = 15;
            this.biblionet.TabStop = false;
            this.biblionet.Click += new System.EventHandler(this.biblionet_Click);
            // 
            // btSair
            // 
            this.btSair.AccessibleName = "Sair";
            this.btSair.ActiveControl = null;
            this.btSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSair.Location = new System.Drawing.Point(1162, 36);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(111, 93);
            this.btSair.Style = MetroFramework.MetroColorStyle.Silver;
            this.btSair.TabIndex = 9;
            this.btSair.Text = "Fechar ";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSair.TileImage = global::biblioteca.Properties.Resources.sair11;
            this.btSair.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSair.UseSelectable = true;
            this.btSair.UseTileImage = true;
            this.btSair.Click += new System.EventHandler(this.metroTile2_Click_1);
            // 
            // btNotas
            // 
            this.btNotas.AccessibleName = "Notas";
            this.btNotas.ActiveControl = null;
            this.btNotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNotas.Location = new System.Drawing.Point(1045, 36);
            this.btNotas.Name = "btNotas";
            this.btNotas.Size = new System.Drawing.Size(111, 93);
            this.btNotas.Style = MetroFramework.MetroColorStyle.Purple;
            this.btNotas.TabIndex = 6;
            this.btNotas.Text = "Notas";
            this.btNotas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btNotas.TileImage = global::biblioteca.Properties.Resources.notas52;
            this.btNotas.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btNotas.UseSelectable = true;
            this.btNotas.UseTileImage = true;
            this.btNotas.Click += new System.EventHandler(this.btNotas_Click);
            // 
            // btSalas
            // 
            this.btSalas.AccessibleName = "Espaços";
            this.btSalas.ActiveControl = null;
            this.btSalas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalas.Location = new System.Drawing.Point(928, 36);
            this.btSalas.Name = "btSalas";
            this.btSalas.Size = new System.Drawing.Size(111, 93);
            this.btSalas.Style = MetroFramework.MetroColorStyle.Orange;
            this.btSalas.TabIndex = 4;
            this.btSalas.Text = "Espaços";
            this.btSalas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSalas.TileImage = global::biblioteca.Properties.Resources.salas61;
            this.btSalas.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSalas.UseSelectable = true;
            this.btSalas.UseTileImage = true;
            this.btSalas.Click += new System.EventHandler(this.btSalas_Click);
            // 
            // btEquipamentos
            // 
            this.btEquipamentos.AccessibleName = "Equipamentos";
            this.btEquipamentos.ActiveControl = null;
            this.btEquipamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEquipamentos.Location = new System.Drawing.Point(811, 36);
            this.btEquipamentos.Name = "btEquipamentos";
            this.btEquipamentos.Size = new System.Drawing.Size(111, 93);
            this.btEquipamentos.Style = MetroFramework.MetroColorStyle.Orange;
            this.btEquipamentos.TabIndex = 3;
            this.btEquipamentos.Text = "Equipamentos";
            this.btEquipamentos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEquipamentos.TileImage = global::biblioteca.Properties.Resources.equipamentos5;
            this.btEquipamentos.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEquipamentos.UseSelectable = true;
            this.btEquipamentos.UseTileImage = true;
            this.btEquipamentos.Click += new System.EventHandler(this.btEquipamentos_Click);
            // 
            // btUtilizadores
            // 
            this.btUtilizadores.AccessibleName = "Utilizadores";
            this.btUtilizadores.ActiveControl = null;
            this.btUtilizadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUtilizadores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btUtilizadores.Location = new System.Drawing.Point(694, 36);
            this.btUtilizadores.Name = "btUtilizadores";
            this.btUtilizadores.PaintTileCount = false;
            this.btUtilizadores.Size = new System.Drawing.Size(111, 93);
            this.btUtilizadores.Style = MetroFramework.MetroColorStyle.Orange;
            this.btUtilizadores.TabIndex = 2;
            this.btUtilizadores.Text = "Utilizadores";
            this.btUtilizadores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btUtilizadores.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btUtilizadores.TileImage = global::biblioteca.Properties.Resources.users5x64;
            this.btUtilizadores.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btUtilizadores.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btUtilizadores.UseCustomForeColor = true;
            this.btUtilizadores.UseSelectable = true;
            this.btUtilizadores.UseStyleColors = true;
            this.btUtilizadores.UseTileImage = true;
            this.btUtilizadores.Click += new System.EventHandler(this.btUtilizadores_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = global::biblioteca.Properties.Resources.biblio1;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picLogo.ErrorImage = global::biblioteca.Properties.Resources.biblio;
            this.picLogo.InitialImage = global::biblioteca.Properties.Resources.biblio;
            this.picLogo.Location = new System.Drawing.Point(23, 36);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(129, 93);
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 747);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.biblionet);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btNotas);
            this.Controls.Add(this.btSalas);
            this.Controls.Add(this.btEquipamentos);
            this.Controls.Add(this.btUtilizadores);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblionet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picLogo;
        private MetroFramework.Controls.MetroTile btUtilizadores;
        private MetroFramework.Controls.MetroTile btEquipamentos;
        private MetroFramework.Controls.MetroTile btSalas;
        private MetroFramework.Controls.MetroTile btNotas;
        private MetroFramework.Controls.MetroTile btSair;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox biblionet;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

