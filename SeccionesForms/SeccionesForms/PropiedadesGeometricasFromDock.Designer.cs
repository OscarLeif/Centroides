using System.Drawing;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
namespace SeccionesForms
{
    partial class PropiedadesGeometricasFromDock : DockContent
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
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(12, 12);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(260, 237);
            this.propertyGrid1.TabIndex = 0;
            // 
            // PropiedadesGeometricasFromDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.propertyGrid1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PropiedadesGeometricasFromDock";
            this.Text = "PropiedadesGeometricasFromDOck";
            this.ResumeLayout(false);

            //this.pgdPropsGeom = new PropertyGrid();
            this.SuspendLayout();
            //this.pgdPropsGeom.Dock = DockStyle.Fill;
            //this.pgdPropsGeom.Location = new Point(0, 2);
            //this.pgdPropsGeom.Name = "pgdPropsGeom";
          

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid1;
    }
}