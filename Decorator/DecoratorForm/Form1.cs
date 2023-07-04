using DecoratorForm.Bebidas;
using DecoratorForm.Decorator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoratorForm
{
    public partial class Form1 : Form
    {
        Caretaker caretaker = new Caretaker();
        Originator originator = new Originator();
        public Form1()
        {
            InitializeComponent();
        }

        //Bebidas clase Component
        BebidasComponent bebida;


        private void btnCafeSolo_Click(object sender, EventArgs e)
        {
            bebida = new CafeSolo();
            txtPrecio.Text = bebida.Costo.ToString();
            txtOutput.Text = bebida.Descripcion;
            
        }

        private void btnCafeExpreso_Click(object sender, EventArgs e)
        {
            bebida = new CafeExpreso();
            txtPrecio.Text = bebida.Costo.ToString();
            txtOutput.Text = bebida.Descripcion;
        }

        private void btnCafeDescafeinado_Click(object sender, EventArgs e)
        {
            bebida = new CafeDescafeinado();   
            txtPrecio.Text = bebida.Costo.ToString();
            txtOutput.Text = bebida.Descripcion;
        }

        // Comprar
        private void btnComprar_Click(object sender, EventArgs e)
        {
            if(bebida != null)
            {
                if (string.IsNullOrEmpty(txtPrecioTotal.Text))
                {
                    txtPrecioTotal.Text = bebida.Costo.ToString();
                }
                else
                {
                    double x = Convert.ToDouble(txtPrecioTotal.Text);
                    txtPrecioTotal.Text = (x + bebida.Costo).ToString();
                }
                originator.Output = txtOutput.Text;
                originator.Precio = txtPrecio.Text;
                caretaker.Memento = originator.guardarEstado();

                txtPrecio.Text = "";
                txtOutput.Text = "";
            }
        }

        // Originator
        public class Originator
        {
            string txtOutput;
            string txtPrecio;
            
            public string Output
            {
                get { return txtOutput; }
                set { txtOutput = value; }
            }

            public string Precio
            {
                get { return txtPrecio; }
                set { txtPrecio = value; }
            }

            public Memento guardarEstado()
            {
                return new Memento(Output, Precio);
            }
           
        }


        // Memento
        public class Memento
        {
            string txtOutput;
            string txtPrecio;
            
            public Memento(string Output, string Precio)
            {
                txtOutput = Output;
                txtPrecio = Precio;
            }

            public string Output
            {
                get { return txtOutput; }
                set { txtOutput = value; }
            }

            public string Precio
            {
                get { return txtPrecio; }
                set { txtPrecio = value; }
            }
        }

        // Caretaker
        public class Caretaker
        {
            Memento _memento;

            public Memento Memento
            {
                get { return _memento; }
                set { _memento = value; }
            }
        }

        // Decorator
        private void btnDecoratorAzucar_Click(object sender, EventArgs e)
        {
            if(bebida != null)
            {
            bebida = new Azucar(bebida);
            txtPrecio.Text = bebida.Costo.ToString();
            txtOutput.Text = bebida.Descripcion;
            }
        }

        private void btnDecoratorLeche_Click(object sender, EventArgs e)
        {
            if (bebida != null)
            {
                bebida = new Leche(bebida);
                txtPrecio.Text = bebida.Costo.ToString();
                txtOutput.Text = bebida.Descripcion;
            }
        }

        private void btnDecoratorCrema_Click(object sender, EventArgs e)
        {
            if(bebida != null)
            {
                bebida = new Crema(bebida);
                txtPrecio.Text = bebida.Costo.ToString();
                txtOutput.Text = bebida.Descripcion;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if(bebida != null)
            {
            Memento m = caretaker.Memento;
            txtOutput.Text = m.Output.ToString();
            txtPrecio.Text = m.Precio.ToString();
                txtPrecioTotal.Text = "";
            }
        }
    }
}
