using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticketSoporte
{
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            //Evento LOAD del Formulario 
            lvReportes.View = View.Details;
            lvReportes.Columns.Add("# Reporte", 60, HorizontalAlignment.Center);
            lvReportes.Columns.Add("Cliente", 150, HorizontalAlignment.Center);
            lvReportes.Columns.Add("Técnico Asignado", 150, HorizontalAlignment.Center);
            lvReportes.Columns.Add("Entorno", 80, HorizontalAlignment.Center);
            lvReportes.Columns.Add("Prioridad", 80, HorizontalAlignment.Center);
            lvReportes.Columns.Add("Fecha de Reporte", 100, HorizontalAlignment.Center);
            lvReportes.Columns.Add("Descripción de la falla", 200, HorizontalAlignment.Center);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //Boton GENERAR REPORTE
            int numeroReporte;
            string cliente, tecnico, entorno, prioridad, descripcion;
            DateTime fecha;

            //Validar datos de entrada
            if (string.IsNullOrWhiteSpace(txtCliente.Text) || cbTecnico.SelectedIndex < 0 || cbEntorno.SelectedIndex < 0 || cbPrioridad.SelectedIndex < 0)
            {
                MessageBox.Show("No se han completado todos los datos del reporte", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Generar numero aleatorio de reporte entre 1 y 1000
                Random aleatorio = new Random();
                numeroReporte = aleatorio.Next(1, 1000);
                //Guardar datos de entrada en variables
                cliente = txtCliente.Text;
                tecnico = cbTecnico.SelectedItem.ToString();
                entorno = cbEntorno.SelectedItem.ToString();
                prioridad = cbPrioridad.SelectedItem.ToString();
                descripcion = txtDescripcion.Text;
                fecha = dateFechaReporte.Value;
                //Enviar datos del reporte al listView
                ListViewItem reporte = new ListViewItem(numeroReporte.ToString());
                reporte.SubItems.Add(cliente);
                reporte.SubItems.Add(tecnico);
                reporte.SubItems.Add(entorno);
                reporte.SubItems.Add(prioridad);
                reporte.SubItems.Add(fecha.ToShortDateString());
                reporte.SubItems.Add(descripcion);

                //Verificar si el usuario esta seguro de generar el reporte
                DialogResult respuesta = MessageBox.Show(
                    "¿Estas seguro de generar el ticket de atención?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    lvReportes.Items.Add(reporte);
                    txtCliente.Clear();
                    cbTecnico.SelectedIndex = -1;
                    cbEntorno.SelectedIndex = -1;
                    cbPrioridad.SelectedIndex = -1;
                    dateFechaReporte.Value = DateTime.Now;
                    txtDescripcion.Clear();
                    MessageBox.Show("Se ha generado el reporte", "Reporte Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCliente.Focus();
                }
                else
                {
                    txtCliente.Focus();
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //boton CANCELAR (ELIMINAR) REPORTE
            if (lvReportes.SelectedItems.Count > 0) //Verificar si hay un elemento seleccionado
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Estas seguro de eliminar el reporte seleccionado?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    //Elimina el registro de la listView
                    lvReportes.Items.Remove(lvReportes.SelectedItems[0]);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un reporte a cancelar",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            if (lvReportes.SelectedItems.Count > 0)
            {
                ListViewItem elemento = lvReportes.SelectedItems[0];
                frmResumen resumen = new frmResumen();
                resumen.numeroTicket = Convert.ToInt32(elemento.Text);   //Columna 0
                resumen.cliente = elemento.SubItems[1].Text;            //Columna 1
                resumen.agente = elemento.SubItems[2].Text;             //Columna 3
                resumen.entorno = elemento.SubItems[3].Text;            //Columna 4
                resumen.prioridad = elemento.SubItems[4].Text;          //Columna 5
                resumen.fechaReporte = elemento.SubItems[5].Text;       //Columna 6
                resumen.falla = elemento.SubItems[6].Text;              //Columna 7
                resumen.Show();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún ticket", 
                                    "Error", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Error);
            }
        }



    }
}
