using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class prestamo : Form
    {
        string nombre_cliente;
        string[] razas_disponibles = { "Balrog", "Elfo", "DK", "Druida", "Cazador", "Enano", "Goblin" };
        int[] cuotas_disponibles = { 12, 24, 36, 60, 120, 160, 240 };
        string[] lugares_disponinles;
        Dictionary<int, double> intereses_base;
        public prestamo(string nombre)
        {
            InitializeComponent();
            nombre_cliente = nombre;

            string listado_ciudades = Properties.Resources.files.ToString();
            lugares_disponinles = listado_ciudades.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            intereses_base = new Dictionary<int, double>();
            int i;
            double interes;
            for (i = 0, interes = 3.0; i < cuotas_disponibles.Length; i++, interes += 0.5)
            {
                intereses_base[cuotas_disponibles[i]] = interes;
            }
        }

        private void Prestamo_Load(object sender, EventArgs e)
        {
            popularCuotas();
            popularRazas();
            popularCiudades();
            saludo.Text += nombre_cliente;
        }
        void popularCuotas()
        {
            for (int i = 0; i < cuotas_disponibles.Length; i++)
            {
                cuotas.Items.Add(cuotas_disponibles[i]);
            }
        }
        void popularRazas()
        {
            for (int i = 0; i < razas_disponibles.Length; i++)
            {
                razas.Items.Add(razas_disponibles[i]);
            }
        }
        void popularCiudades()
        {
            for (int i = 0; i < lugares_disponinles.Length; i++)
            {
                lugares.Items.Add(lugares_disponinles[i]);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        double calcularInteres()
        {
            int cuotas_pedidas = (int)cuotas.SelectedItem;
            string raza_seleccionada = razas.SelectedItem.ToString().ToLower();
            string lugar_seleccionada = lugares.SelectedItem.ToString().ToLower();
            double interes = intereses_base[cuotas_pedidas];
            if (new[] { "Balrog", "Elfo", "DK" }.Contains(raza_seleccionada))
            {
                interes += 0.3;
            }
            if (new[] { "Druida", "Cazador", "Enano", "Goblin" }.Contains(lugar_seleccionada))
            {
                interes += 0.3;
            }
            return interes;

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            switch (validaciones())
            {
                case 0:
                    {
                        errorProvider1.SetError(datosPersonales, "");
                        errorProvider1.SetError(datosPrestamos, "");
                        double interes_mensual = calcularInteres();
                        double monto_pedido = double.Parse(txtMonto.Text);
                        int cuotas_pedidas = (int)cuotas.SelectedItem;
                        double interes_total = monto_pedido * (interes_mensual / 100) * cuotas_pedidas;
                        double monto_a_pagar = monto_pedido + interes_total;
                        string mensaje = "su prestamo por" + monto_pedido + " en" + cuotas_pedidas + "cuotas se concedera con un interes del" + interes_mensual + "el monto final es" + monto_a_pagar;
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(mensaje, "Calculo de intereses", buttons);
                        break;
                    }
                case 1:
                    {
                        errorProvider1.SetError(datosPersonales, "Debe de completar todos los datos");
                        errorProvider1.SetError(datosPrestamos, "");
                        break;
                    }
                case 2:
                    {
                        errorProvider1.SetError(datosPrestamos, "Debes de ingresar un monto y una cantidad de cuota");
                        errorProvider1.SetError(datosPersonales, "");
                        break;
                    }

            }
        }

        int validaciones()
        {
            if ((razas.SelectedIndex <= -1) || (lugares.SelectedIndex <= -1))
            {
                return 1;
            }
            else
            {
                if (!(txtMonto.Text.All(char.IsDigit)) || (txtMonto.Text =="") || (cuotas.SelectedIndex <= -1))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }

            }
        }

    }
}
