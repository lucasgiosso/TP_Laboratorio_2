using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        List<string> listaOperaciones = new List<string>();

        /// <summary>
        /// Inicializa el formulario.
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa el formulario con datos preseteados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            cmbOperador.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperador.Items.Add(' ');
            cmbOperador.Items.Add('+');
            cmbOperador.Items.Add('-');
            cmbOperador.Items.Add('/');
            cmbOperador.Items.Add('*');
            Limpiar();
        }

        /// <summary>
        /// Boton que cierra el formulario cuando el usuario lo desee.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Boton que convierte el numero a binario cuando el usuario lo desee.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtNumero1.Text) && !string.IsNullOrEmpty(this.txtNumero2.Text) && !string.IsNullOrEmpty(this.cmbOperador.Text))
            {
                if (!string.IsNullOrEmpty(this.lblResultado.Text))
                {
                    Operando numero = new Operando();
                    this.lblResultado.Text = numero.DecimalBinario(this.lblResultado.Text);
                    this.btnConvertirABinario.Enabled = false;
                    this.btnConvertirADecimal.Enabled = true;
                    ConversionesHistorial(this.lblResultado.Text);
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un numero y un operador", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Boton que convierte el numero a decimal cuando el usuario lo desee.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtNumero1.Text) && !string.IsNullOrEmpty(this.txtNumero2.Text) && !string.IsNullOrEmpty(this.cmbOperador.Text))
            {
                if (!string.IsNullOrEmpty(this.lblResultado.Text))
                {
                    Operando numero = new Operando();
                    this.lblResultado.Text = numero.BinarioDecimal(this.lblResultado.Text);
                    this.btnConvertirABinario.Enabled = true;
                    this.btnConvertirADecimal.Enabled = false;
                    ConversionesHistorial(this.lblResultado.Text);
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un numero y un operador", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        /// <summary>
        /// Boton que limpia los campos en el formulario cuando el usuario lo desee.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Boton que realiza la operación que el usuario desee.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtNumero1.Text) && !string.IsNullOrEmpty(this.txtNumero2.Text))
            {
                this.lblResultado.Text = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text).ToString();
                this.btnConvertirABinario.Enabled = true;
                this.btnConvertirADecimal.Enabled = false;
                OperacionesHistorial(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
            }
            else
            {
                MessageBox.Show("Por favor ingrese un numero y un operador. En el caso de no elegir un operador, y los numeros esten completos se sumaran ambos numeros.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Método creado para mostrar el historial en el listbox.
        /// </summary>
        private void OperacionesHistorial(string historialNumero1, string historialNumero2, string historialOperador)
        {
            if (!string.IsNullOrWhiteSpace(historialOperador))
            {
                listaOperaciones.Add(historialNumero1 + " " + historialOperador + " " + historialNumero2 + " = " + Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text).ToString());

                lstOperaciones.DataSource = null;
                lstOperaciones.DataSource = listaOperaciones;

            }
            else
            {
                listaOperaciones.Add(historialNumero1 + " + " + historialNumero2 + " = " + Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text).ToString());

                lstOperaciones.DataSource = null;
                lstOperaciones.DataSource = listaOperaciones;
            }

        }
        /// <summary>
        ///Metodo que devuelve el Historial de conversiones.
        /// </summary>
        /// <param name="resultado"></param>
        private void ConversionesHistorial(string resultado)
        {
            listaOperaciones.Add(resultado);
            lstOperaciones.DataSource = null;
            lstOperaciones.DataSource = listaOperaciones;
        }

        /// <summary>
        /// Método creado para limpiar los campos del formulario.
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = string.Empty;
            this.txtNumero2.Text = string.Empty;
            this.cmbOperador.SelectedIndex = -1;
            this.lblResultado.Text = "0.";
            this.cmbOperador.SelectedItem = ' ';
            this.lstOperaciones.Text = " ";
        }

        /// <summary>
        /// Método creado para recibir 2 numeros(validados) y su operando recibido como tipo string. 
        /// </summary>
        /// <param name="numero1">Primer numero a recibir de tipo string</param>
        /// <param name="numero2">Segundo numero a recibir de tipo string</param>
        /// <param name="operador">Operador de tipo string</param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            char operadorChar;

            Operando operador1 = new Operando(numero1);
            Operando operador2 = new Operando(numero2);

            char.TryParse(operador, out operadorChar);

            return Calculadora.Operar(operador1, operador2, operadorChar);
        }

        /// <summary>
        /// Valida que el usuario no ingrese cualquier caracter de la tabla ASCII en el primer operando, salvo numeros y comas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Campo a validar</param>
        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 46 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo numeros. Utilizar comas ( , ) no puntos ( . )", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Valida que el usuario no ingrese cualquier caracter de la tabla ASCII en el segundo operando, salvo numeros y comas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Campo a validar</param>
        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 46 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo numeros. Utilizar comas ( , ) no puntos ( . )", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        /// <summary>
        /// Mensaje que aparece al cerrar la pantalla.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
