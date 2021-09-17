
namespace MiCalculadora
{
    partial class FrmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConvertirABinario = new System.Windows.Forms.Button();
            this.btnConvertirADecimal = new System.Windows.Forms.Button();
            this.lstOperaciones = new System.Windows.Forms.ListBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumero1.BackColor = System.Drawing.Color.SeaGreen;
            this.txtNumero1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero1.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNumero1.Location = new System.Drawing.Point(6, 124);
            this.txtNumero1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtNumero1.Multiline = true;
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(105, 32);
            this.txtNumero1.TabIndex = 0;
            this.txtNumero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumero1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero1_KeyPress);
            // 
            // txtNumero2
            // 
            this.txtNumero2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumero2.BackColor = System.Drawing.Color.SeaGreen;
            this.txtNumero2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero2.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNumero2.Location = new System.Drawing.Point(233, 124);
            this.txtNumero2.Multiline = true;
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(105, 32);
            this.txtNumero2.TabIndex = 2;
            this.txtNumero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumero2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero2_KeyPress);
            // 
            // cmbOperador
            // 
            this.cmbOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.Location = new System.Drawing.Point(118, 124);
            this.cmbOperador.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(105, 30);
            this.cmbOperador.TabIndex = 1;
            // 
            // btnOperar
            // 
            this.btnOperar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOperar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnOperar.FlatAppearance.BorderSize = 0;
            this.btnOperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOperar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnOperar.Location = new System.Drawing.Point(5, 172);
            this.btnOperar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(104, 32);
            this.btnOperar.TabIndex = 3;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = false;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpiar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLimpiar.Location = new System.Drawing.Point(117, 172);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(104, 32);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCerrar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCerrar.Location = new System.Drawing.Point(232, 172);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(104, 32);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnConvertirABinario
            // 
            this.btnConvertirABinario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConvertirABinario.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConvertirABinario.FlatAppearance.BorderSize = 0;
            this.btnConvertirABinario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertirABinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConvertirABinario.ForeColor = System.Drawing.SystemColors.Window;
            this.btnConvertirABinario.Location = new System.Drawing.Point(5, 222);
            this.btnConvertirABinario.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnConvertirABinario.Name = "btnConvertirABinario";
            this.btnConvertirABinario.Size = new System.Drawing.Size(160, 54);
            this.btnConvertirABinario.TabIndex = 6;
            this.btnConvertirABinario.Text = "Convertir a Binario";
            this.btnConvertirABinario.UseVisualStyleBackColor = false;
            this.btnConvertirABinario.Click += new System.EventHandler(this.btnConvertirABinario_Click);
            // 
            // btnConvertirADecimal
            // 
            this.btnConvertirADecimal.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConvertirADecimal.FlatAppearance.BorderSize = 0;
            this.btnConvertirADecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertirADecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConvertirADecimal.ForeColor = System.Drawing.SystemColors.Window;
            this.btnConvertirADecimal.Location = new System.Drawing.Point(177, 222);
            this.btnConvertirADecimal.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnConvertirADecimal.Name = "btnConvertirADecimal";
            this.btnConvertirADecimal.Size = new System.Drawing.Size(160, 54);
            this.btnConvertirADecimal.TabIndex = 7;
            this.btnConvertirADecimal.Text = "Convertir a Decimal";
            this.btnConvertirADecimal.UseVisualStyleBackColor = false;
            this.btnConvertirADecimal.Click += new System.EventHandler(this.btnConvertirADecimal_Click);
            // 
            // lstOperaciones
            // 
            this.lstOperaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstOperaciones.FormattingEnabled = true;
            this.lstOperaciones.ItemHeight = 15;
            this.lstOperaciones.Location = new System.Drawing.Point(342, 5);
            this.lstOperaciones.Name = "lstOperaciones";
            this.lstOperaciones.Size = new System.Drawing.Size(226, 272);
            this.lstOperaciones.TabIndex = 8;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblResultado.Location = new System.Drawing.Point(8, 4);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Padding = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.lblResultado.Size = new System.Drawing.Size(333, 103);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(571, 283);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lstOperaciones);
            this.Controls.Add(this.btnConvertirADecimal);
            this.Controls.Add(this.btnConvertirABinario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.cmbOperador);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Lucas Diaz Giosso del curso 2ºD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCalculadora_FormClosing);
            this.Load += new System.EventHandler(this.FrmCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConvertirABinario;
        private System.Windows.Forms.Button btnConvertirADecimal;
        private System.Windows.Forms.ListBox lstOperaciones;
        private System.Windows.Forms.Label lblResultado;
    }
}

