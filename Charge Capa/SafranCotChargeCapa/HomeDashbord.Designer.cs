﻿namespace SafranCotChargeCapa
{
	partial class HomeDashbord
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
			this.FormPanel = new System.Windows.Forms.Panel();
			this.SideMenu = new System.Windows.Forms.Panel();
			this.MangPanel = new System.Windows.Forms.Panel();
			this.DashbordPanel = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.IlotPanel = new System.Windows.Forms.Panel();
			this.button10 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.Dashbord = new System.Windows.Forms.Button();
			this.LogoPanel = new System.Windows.Forms.Panel();
			this.SideMenu.SuspendLayout();
			this.MangPanel.SuspendLayout();
			this.DashbordPanel.SuspendLayout();
			this.IlotPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// FormPanel
			// 
			this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FormPanel.Location = new System.Drawing.Point(145, 0);
			this.FormPanel.Name = "FormPanel";
			this.FormPanel.Size = new System.Drawing.Size(1054, 450);
			this.FormPanel.TabIndex = 1;
			this.FormPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPanel_Paint);
			// 
			// SideMenu
			// 
			this.SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
			this.SideMenu.Controls.Add(this.MangPanel);
			this.SideMenu.Controls.Add(this.button5);
			this.SideMenu.Controls.Add(this.DashbordPanel);
			this.SideMenu.Controls.Add(this.Dashbord);
			this.SideMenu.Controls.Add(this.LogoPanel);
			this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.SideMenu.Location = new System.Drawing.Point(0, 0);
			this.SideMenu.Name = "SideMenu";
			this.SideMenu.Size = new System.Drawing.Size(145, 450);
			this.SideMenu.TabIndex = 0;
			// 
			// MangPanel
			// 
			this.MangPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
			this.MangPanel.Controls.Add(this.button10);
			this.MangPanel.Controls.Add(this.IlotPanel);
			this.MangPanel.Controls.Add(this.button4);
			this.MangPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.MangPanel.Location = new System.Drawing.Point(0, 197);
			this.MangPanel.Name = "MangPanel";
			this.MangPanel.Size = new System.Drawing.Size(145, 241);
			this.MangPanel.TabIndex = 8;
			// 
			// DashbordPanel
			// 
			this.DashbordPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
			this.DashbordPanel.Controls.Add(this.button3);
			this.DashbordPanel.Controls.Add(this.button2);
			this.DashbordPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.DashbordPanel.Location = new System.Drawing.Point(0, 102);
			this.DashbordPanel.Name = "DashbordPanel";
			this.DashbordPanel.Size = new System.Drawing.Size(145, 65);
			this.DashbordPanel.TabIndex = 4;
			// 
			// button3
			// 
			this.button3.Dock = System.Windows.Forms.DockStyle.Top;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Beige;
			this.button3.Location = new System.Drawing.Point(0, 30);
			this.button3.Name = "button3";
			this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button3.Size = new System.Drawing.Size(145, 30);
			this.button3.TabIndex = 6;
			this.button3.Text = "Drapage";
			this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Dock = System.Windows.Forms.DockStyle.Top;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Beige;
			this.button2.Location = new System.Drawing.Point(0, 0);
			this.button2.Name = "button2";
			this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button2.Size = new System.Drawing.Size(145, 30);
			this.button2.TabIndex = 5;
			this.button2.Text = "Ilot";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// IlotPanel
			// 
			this.IlotPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
			this.IlotPanel.Controls.Add(this.button1);
			this.IlotPanel.Controls.Add(this.button6);
			this.IlotPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.IlotPanel.Location = new System.Drawing.Point(0, 30);
			this.IlotPanel.Name = "IlotPanel";
			this.IlotPanel.Size = new System.Drawing.Size(145, 64);
			this.IlotPanel.TabIndex = 6;
			// 
			// button10
			// 
			this.button10.Dock = System.Windows.Forms.DockStyle.Top;
			this.button10.FlatAppearance.BorderSize = 0;
			this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button10.ForeColor = System.Drawing.Color.Beige;
			this.button10.Location = new System.Drawing.Point(0, 94);
			this.button10.Name = "button10";
			this.button10.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button10.Size = new System.Drawing.Size(145, 30);
			this.button10.TabIndex = 11;
			this.button10.Text = "Operation";
			this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Top;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Beige;
			this.button1.Image = global::SafranCotChargeCapa.Properties.Resources.edit_property_32px;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(0, 30);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(145, 30);
			this.button1.TabIndex = 8;
			this.button1.Text = "Modifier";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// button6
			// 
			this.button6.Dock = System.Windows.Forms.DockStyle.Top;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.ForeColor = System.Drawing.Color.Beige;
			this.button6.Image = global::SafranCotChargeCapa.Properties.Resources.add_32px;
			this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button6.Location = new System.Drawing.Point(0, 0);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(145, 30);
			this.button6.TabIndex = 7;
			this.button6.Text = "Ajouter";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button4
			// 
			this.button4.Dock = System.Windows.Forms.DockStyle.Top;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Beige;
			this.button4.Image = global::SafranCotChargeCapa.Properties.Resources.robot_32px;
			this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.Location = new System.Drawing.Point(0, 0);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(145, 30);
			this.button4.TabIndex = 5;
			this.button4.Text = "Ilot";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Dock = System.Windows.Forms.DockStyle.Top;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.Beige;
			this.button5.Image = global::SafranCotChargeCapa.Properties.Resources.settings_32px;
			this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button5.Location = new System.Drawing.Point(0, 167);
			this.button5.Name = "button5";
			this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button5.Size = new System.Drawing.Size(145, 30);
			this.button5.TabIndex = 7;
			this.button5.Text = "Management";
			this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// Dashbord
			// 
			this.Dashbord.Dock = System.Windows.Forms.DockStyle.Top;
			this.Dashbord.FlatAppearance.BorderSize = 0;
			this.Dashbord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Dashbord.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Dashbord.ForeColor = System.Drawing.Color.Beige;
			this.Dashbord.Image = global::SafranCotChargeCapa.Properties.Resources.icons8_dashboard_32;
			this.Dashbord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Dashbord.Location = new System.Drawing.Point(0, 72);
			this.Dashbord.Name = "Dashbord";
			this.Dashbord.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Dashbord.Size = new System.Drawing.Size(145, 30);
			this.Dashbord.TabIndex = 3;
			this.Dashbord.Text = "Dashbord";
			this.Dashbord.UseVisualStyleBackColor = true;
			this.Dashbord.Click += new System.EventHandler(this.Dashbord_Click);
			// 
			// LogoPanel
			// 
			this.LogoPanel.BackgroundImage = global::SafranCotChargeCapa.Properties.Resources.Logo_Safran;
			this.LogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.LogoPanel.Location = new System.Drawing.Point(0, 0);
			this.LogoPanel.Name = "LogoPanel";
			this.LogoPanel.Size = new System.Drawing.Size(145, 72);
			this.LogoPanel.TabIndex = 0;
			// 
			// HomeDashbord
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1199, 450);
			this.Controls.Add(this.FormPanel);
			this.Controls.Add(this.SideMenu);
			this.Name = "HomeDashbord";
			this.Text = "HomeDashbord";
			this.Load += new System.EventHandler(this.HomeDashbord_Load);
			this.SideMenu.ResumeLayout(false);
			this.MangPanel.ResumeLayout(false);
			this.DashbordPanel.ResumeLayout(false);
			this.IlotPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel FormPanel;
		private System.Windows.Forms.Panel LogoPanel;
		private System.Windows.Forms.Panel SideMenu;
		private System.Windows.Forms.Panel DashbordPanel;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button Dashbord;
		private System.Windows.Forms.Panel MangPanel;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Panel IlotPanel;
		private System.Windows.Forms.Button button1;
	}
}