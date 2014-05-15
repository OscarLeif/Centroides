using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centroides.Secciones;

namespace SeccionesForms
{
    public partial class FormPunto : Form
    {
        private puntosForm puntosForm;

        public FormPunto(puntosForm puntosForm)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.puntosForm = puntosForm;
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                //int index = int.Parse(puntosForm.listView1.SelectedItems[0].Text);
                //int index = int.Parse(this.lvwPuntos.SelectedItems[0].Text) - 1;
                double puntoX = Convert.ToDouble(textBoxX.Text);
                double puntoY = Convert.ToDouble(textBoxY.Text);

                Punto item = new Punto(puntoX, puntoY, 0);
                
                //poly.Puntos.Add(item);
                puntosForm._PoligSeleccionado.Puntos.Add(item);
                //this._PoligSeleccionado.Puntos.Add(item);
                Polygon poly = puntosForm._PoligSeleccionado;
                puntosForm.actualizarPolygono(poly);
                puntosForm.Actualizar(poly);
                Close();
                
            }
            catch (FormatException)
            { MessageBox.Show("Escribe datos numericos", "Informacion"); }
              
        }


        #region eventos TecladoTextBox
        private void textBoxX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
        && !char.IsDigit(e.KeyChar)
        && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void textBoxY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
       && !char.IsDigit(e.KeyChar)
       && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        #endregion 
    }
}
