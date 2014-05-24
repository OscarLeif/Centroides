using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Centroides.Secciones;

namespace SeccionesForms
{
    public partial class puntosForm : DockContent
    {
        public Polygon _PoligSeleccionado;
        private FormPrincipal formPrincipal;

        public puntosForm(FormPrincipal formPrincipal)
        {
            // TODO: Complete member initialization
            this.formPrincipal = formPrincipal;
            InitializeComponent();
            listViewPuntos.View = View.Details;
            listViewPuntos.Columns.Add("File type", 20, HorizontalAlignment.Left);
            _PoligSeleccionado = new Polygon();
        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip cms = new ContextMenuStrip();
                cms.Items.Add("Agregar nuevo punto", null, mnuInsertarPunto_Click);
                //Button btnSender = (Button)sender;
                Point ptLowerLeft = new Point(0, listViewPuntos.Width);
                ptLowerLeft = listViewPuntos.PointToScreen(ptLowerLeft);
                cms.Show(ptLowerLeft);
                //cms.Show();
                
            }
        }
        private void mnuInsertarPunto_Click(object sender, EventArgs e)
        {
            FormPunto formPunto = new FormPunto(this);
            formPunto.Show();
        }
        int contadorLista = 0;
        public void Actualizar(Polygon PoligonoSeleccionado)
        {
            this._PoligSeleccionado = PoligonoSeleccionado;
            this.listViewPuntos.Items.Clear();
            contadorLista = 0;
            foreach (Punto current in this._PoligSeleccionado.Puntos)
            {
                ListViewItem listViewItem = this.listViewPuntos.Items.Add(contadorLista.ToString());
                listViewItem.SubItems.Add(current.x.ToString());
                listViewItem.SubItems.Add(current.y.ToString());
                contadorLista++;
            }
             formPrincipal._PolygonoPrincipal = _PoligSeleccionado ;
            formPrincipal.formGrafico.ActualizarVistaGrafica();
            formPrincipal.formGrafico.ResaltarCurva();
            formPrincipal.formProp.Actualizar(_PoligSeleccionado);
        }


        public void actualizarPolygono(Polygon poli)
        {
            _PoligSeleccionado = poli;
        }
    }
}
