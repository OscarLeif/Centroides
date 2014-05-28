using System;
using System.Windows.Forms;
namespace SeccionesForms
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private ToolStripMenuItem mnuInsertarPunto;

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
            WeifenLuo.WinFormsUI.Docking.DockPanelSkin dockPanelSkin3 = new WeifenLuo.WinFormsUI.Docking.DockPanelSkin();
            WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin autoHideStripSkin3 = new WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient7 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient15 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin dockPaneStripSkin3 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient dockPaneStripGradient3 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient16 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient8 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient17 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient dockPaneStripToolWindowGradient3 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient18 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient19 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient9 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient20 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient21 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.mnuInsertarPunto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(964, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dockPanel
            // 
            this.dockPanel.AccessibleName = "DockPanel";
            this.dockPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.Location = new System.Drawing.Point(0, 24);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(964, 515);
            dockPanelGradient7.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient7.StartColor = System.Drawing.SystemColors.ControlLight;
            autoHideStripSkin3.DockStripGradient = dockPanelGradient7;
            tabGradient15.EndColor = System.Drawing.SystemColors.Control;
            tabGradient15.StartColor = System.Drawing.SystemColors.Control;
            tabGradient15.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            autoHideStripSkin3.TabGradient = tabGradient15;
            autoHideStripSkin3.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            dockPanelSkin3.AutoHideStripSkin = autoHideStripSkin3;
            tabGradient16.EndColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient16.StartColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient16.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient3.ActiveTabGradient = tabGradient16;
            dockPanelGradient8.EndColor = System.Drawing.SystemColors.Control;
            dockPanelGradient8.StartColor = System.Drawing.SystemColors.Control;
            dockPaneStripGradient3.DockStripGradient = dockPanelGradient8;
            tabGradient17.EndColor = System.Drawing.SystemColors.ControlLight;
            tabGradient17.StartColor = System.Drawing.SystemColors.ControlLight;
            tabGradient17.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient3.InactiveTabGradient = tabGradient17;
            dockPaneStripSkin3.DocumentGradient = dockPaneStripGradient3;
            dockPaneStripSkin3.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            tabGradient18.EndColor = System.Drawing.SystemColors.ActiveCaption;
            tabGradient18.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient18.StartColor = System.Drawing.SystemColors.GradientActiveCaption;
            tabGradient18.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            dockPaneStripToolWindowGradient3.ActiveCaptionGradient = tabGradient18;
            tabGradient19.EndColor = System.Drawing.SystemColors.Control;
            tabGradient19.StartColor = System.Drawing.SystemColors.Control;
            tabGradient19.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripToolWindowGradient3.ActiveTabGradient = tabGradient19;
            dockPanelGradient9.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient9.StartColor = System.Drawing.SystemColors.ControlLight;
            dockPaneStripToolWindowGradient3.DockStripGradient = dockPanelGradient9;
            tabGradient20.EndColor = System.Drawing.SystemColors.InactiveCaption;
            tabGradient20.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient20.StartColor = System.Drawing.SystemColors.GradientInactiveCaption;
            tabGradient20.TextColor = System.Drawing.SystemColors.InactiveCaptionText;
            dockPaneStripToolWindowGradient3.InactiveCaptionGradient = tabGradient20;
            tabGradient21.EndColor = System.Drawing.Color.Transparent;
            tabGradient21.StartColor = System.Drawing.Color.Transparent;
            tabGradient21.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            dockPaneStripToolWindowGradient3.InactiveTabGradient = tabGradient21;
            dockPaneStripSkin3.ToolWindowGradient = dockPaneStripToolWindowGradient3;
            dockPanelSkin3.DockPaneStripSkin = dockPaneStripSkin3;
            this.dockPanel.Skin = dockPanelSkin3;
            this.dockPanel.TabIndex = 4;
            // 
            // mnuInsertarPunto
            // 
            this.mnuInsertarPunto.Name = "mnuInsertarPunto";
            this.mnuInsertarPunto.Size = new System.Drawing.Size(32, 19);
            this.mnuInsertarPunto.Text = "Insertar punto";
            this.mnuInsertarPunto.Click += new System.EventHandler(this.mnuInsertarPunto_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(964, 561);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(980, 600);
            this.Name = "FormPrincipal";
            this.Text = "Centroides";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        public void mnuInsertarPunto_Click(object sender, EventArgs e)
        { 
        }
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;

    }
}

