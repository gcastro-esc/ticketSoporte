using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing; 

namespace ticketSoporte
{

    public partial class frmResumen : Form
    {
        //Crear objetos (variables) que recibiran y almacenaran los datos del Form1
        public int numeroTicket { get; set; }
        public string cliente { get; set; }
        public string agente { get; set; }
        public string entorno { get; set; }
        public string prioridad { get; set; }
        public string fechaReporte { get; set; }
        public string falla { get; set; }

        string imagen = @"C:\Users\Docente\Downloads\imagenImpresion.png";

        public frmResumen()
        {
            InitializeComponent();
        }

        private void frmResumen_Load(object sender, EventArgs e)
        {
            gbResumen.Text = "Ticket # " + numeroTicket;
            lblCliente.Text = "Cliente: " + cliente;
            lblTecnico.Text = "Técnico asignado: " + agente;
            lblEntorno.Text = entorno;
            lblPrioridad.Text = prioridad;
            lblFecha.Text = fechaReporte;
            lblFalla.Text = "Descripción de la falla: \n\n" + falla;

            //Prioridades definidas en el comboBox: Normal  Alta  Urgente
            switch (prioridad)
            {
                case "Normal":
                    lblPrioridad.ForeColor = Color.Green;
                    break;
                case "Alta":
                    lblPrioridad.ForeColor = Color.Orange;
                    break;
                case "Urgente":
                    lblPrioridad.ForeColor = Color.Red;
                    break;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Boton Imprimir documento
            try
            {
                printDocument = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                printDocument.PrinterSettings = ps;
                printDocument.PrintPage += Imprimir;
                printDocument.Print();
            }
            catch
            {
                MessageBox.Show("Error al generar el archivo, verifica que no este en uso",
                                "Error de impresión",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        //Agregar este nuevo evento:
        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            //Crear tipo de letra
            Font fuente = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
            float anchoPagina = e.PageBounds.Width;     //Ancho total de la pagina
            float altoPagina = e.PageBounds.Height; //Alto de la pagina
            float x = 0;        //Variable para almacenar posicion en X
            SizeF medidaTexto = new SizeF(0, 0);
            string texto = "";

            //Imprimir un texto
            texto = "Solicitud de Atención - Ticket de Soporte";
            medidaTexto = e.Graphics.MeasureString(texto, fuente);
            x = (anchoPagina - medidaTexto.Width) / 2;
            e.Graphics.DrawString(texto, fuente, Brushes.Black, x, 30);
            //Imprimir nombre del cliente
            texto = "Cliente: " + cliente;
            medidaTexto = e.Graphics.MeasureString(texto, fuente);
            x = (anchoPagina - medidaTexto.Width) / 2;
            e.Graphics.DrawString(texto, fuente, Brushes.Black, x, 70);
            //Imprimir nombre del tecnico
            texto = "Técnico de soporte asignado: " + agente;
            medidaTexto = e.Graphics.MeasureString(texto, fuente);
            x = (anchoPagina - medidaTexto.Width) / 2;
            e.Graphics.DrawString(texto, fuente, Brushes.Black, x, 95);
            //Imprimir Entorno y Prioridad
            texto = "Entorno del reporte: " + entorno + ", ingresado con Prioridad: " + prioridad;
            medidaTexto = e.Graphics.MeasureString(texto, fuente);
            x = (anchoPagina - medidaTexto.Width) / 2;
            switch (prioridad)
            {
                case "Normal":
                    e.Graphics.DrawString(texto, fuente, Brushes.Green, x, 120);
                    break;
                case "Alta":
                    e.Graphics.DrawString(texto, fuente, Brushes.Orange, x, 120);
                    break;
                case "Urgente":
                    e.Graphics.DrawString(texto, fuente, Brushes.Red, x, 120);
                    break;
            }
            //Imprimir fecha del reporte
            texto = "Fecha de captura del reporte: " + fechaReporte;
            medidaTexto = e.Graphics.MeasureString(texto, fuente);
            x = (anchoPagina - medidaTexto.Width) / 2;
            e.Graphics.DrawString(texto, fuente, Brushes.Black, x, 145);
            //Imprimir descripcion de la falla
            texto = "Falla reportada: " + falla;
            medidaTexto = e.Graphics.MeasureString(texto, fuente);
            x = (anchoPagina - medidaTexto.Width) / 2;
            e.Graphics.DrawString(texto, fuente, Brushes.Black, x, 170);

            //Imprimir una imagen, debe estar importada en los recursos del proyecto
            //La imagen debe ser descargada de un tamaño adecuado - en este caso 96 x 96 px
            //Image img = ticketSoporte.Properties.Resources.imagenImpresion;
            //int xImg = (int)((anchoPagina - img.Width) / 2);
            //e.Graphics.DrawImage(img, new Rectangle(xImg, 220, img.Width, img.Height));

            Image img = Image.FromFile(imagen);
            int xImg = (int)((anchoPagina - img.Width) / 2);
            e.Graphics.DrawImage(img, new Rectangle(xImg, 220, img.Width, img.Height));


        }


    }

}
