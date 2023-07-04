using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MementoWinForm
{
    public partial class mementoForm : Form
    {
        // Creamos el caretaker para guardar los mementos 
        static Caretaker caretaker = new Caretaker();

        public mementoForm()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text) && !string.IsNullOrEmpty(txtPresupuesto.Text))
            {
                var originator = new Originator();
                originator.Nombre = txtNombre.Text;
                originator.Apellido = txtApellido.Text;
                originator.Presupuesto = txtPresupuesto.Text;

                caretaker.Add(originator.GuardarMemento(), lstBoxMementos);
                // Limpiamos textbox para que el usuario pueda ingresar nuevos datos
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtPresupuesto.Text = "";

            }
            else
            {
                MessageBox.Show("Por favor, debe rellenar los campos vacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            // crear un if para verificar si se selecciono un item del listbox
            if(lstBoxMementos.SelectedIndex != -1)
            {
                Memento m = caretaker.GetMemento(lstBoxMementos.SelectedIndex);
                txtNombre.Text = m.Nombre;
                txtApellido.Text= m.Apellido;
                txtPresupuesto.Text = m.Presupuesto;
            }
           
        }
    }

    public class Originator
    {
        string nombre;
        string apellido;
        string presupuesto;

        // Creamos los getters y setters

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Presupuesto
        {
            get { return presupuesto; }
            set { presupuesto = value; }
        }

        // Creamos el método para crear el memento
        public Memento GuardarMemento()
        {
            return new Memento(nombre, apellido, presupuesto);
            
        }

        public void RecuperarMemento(Memento memento)
        {
            Nombre = memento.Nombre;
            Apellido = memento.Apellido;
            Presupuesto = memento.Presupuesto;
        }
    }

    public class Memento
    {
        string nombre;
        string apellido;
        string presupuesto;

        // Creamos el constructor
       public Memento(string nombre, string apellido, string presupuesto)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.presupuesto = presupuesto;
        }

        // Creamos los getters y setters
        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Presupuesto
        {
            get { return presupuesto; }
            set { presupuesto = value; }
        }

        
    }

    // Creamos la clase Caretaker
    public class Caretaker
    {
        private List<Memento> mementos = new List<Memento>();


        // Creamos una función para agregar mementos a la lista
        public void Add(Memento memento, ListBox list)
        {
            // Agregar memento a la lista
            mementos.Add(memento);
            
            string representacion = $"{memento.Nombre} {memento.Apellido}";          
            list.Items.Add(representacion);
            
            
        }

        public Memento GetMemento(int index)
        {
            // retorna la lista de mementos
            return mementos[index];

        }


    }
}
