namespace DecoratorForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpboxCoffe = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.txtPrecioTotal = new Guna.UI.WinForms.GunaLineTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblPrecio = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPrecio = new Guna.UI.WinForms.GunaLineTextBox();
            this.btnComprar = new Guna.UI.WinForms.GunaButton();
            this.btnCafeDescafeinado = new Guna.UI.WinForms.GunaButton();
            this.btnCafeExpreso = new Guna.UI.WinForms.GunaButton();
            this.btnCafeSolo = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.btnDecoratorCrema = new Guna.UI.WinForms.GunaButton();
            this.btnDecoratorLeche = new Guna.UI.WinForms.GunaButton();
            this.btnDecoratorAzucar = new Guna.UI.WinForms.GunaButton();
            this.btnAtras = new Guna.UI.WinForms.GunaCircleButton();
            this.grpboxCoffe.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxCoffe
            // 
            this.grpboxCoffe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpboxCoffe.BackColor = System.Drawing.Color.Transparent;
            this.grpboxCoffe.BaseColor = System.Drawing.Color.White;
            this.grpboxCoffe.BorderColor = System.Drawing.Color.Gainsboro;
            this.grpboxCoffe.Controls.Add(this.btnAtras);
            this.grpboxCoffe.Controls.Add(this.gunaGroupBox2);
            this.grpboxCoffe.Controls.Add(this.panel1);
            this.grpboxCoffe.Controls.Add(this.lblPrecio);
            this.grpboxCoffe.Controls.Add(this.txtPrecio);
            this.grpboxCoffe.Controls.Add(this.btnComprar);
            this.grpboxCoffe.Controls.Add(this.btnCafeDescafeinado);
            this.grpboxCoffe.Controls.Add(this.btnCafeExpreso);
            this.grpboxCoffe.Controls.Add(this.btnCafeSolo);
            this.grpboxCoffe.LineColor = System.Drawing.Color.CornflowerBlue;
            this.grpboxCoffe.Location = new System.Drawing.Point(0, -2);
            this.grpboxCoffe.Name = "grpboxCoffe";
            this.grpboxCoffe.Size = new System.Drawing.Size(569, 309);
            this.grpboxCoffe.TabIndex = 0;
            this.grpboxCoffe.Text = "Cafe";
            this.grpboxCoffe.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.txtPrecioTotal);
            this.gunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Location = new System.Drawing.Point(387, 115);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(170, 72);
            this.gunaGroupBox2.TabIndex = 7;
            this.gunaGroupBox2.Text = "Precio Total";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioTotal.BackColor = System.Drawing.Color.White;
            this.txtPrecioTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioTotal.Enabled = false;
            this.txtPrecioTotal.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPrecioTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioTotal.LineColor = System.Drawing.Color.Brown;
            this.txtPrecioTotal.Location = new System.Drawing.Point(11, 35);
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.PasswordChar = '\0';
            this.txtPrecioTotal.Size = new System.Drawing.Size(142, 33);
            this.txtPrecioTotal.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.txtOutput);
            this.panel1.Location = new System.Drawing.Point(12, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 131);
            this.panel1.TabIndex = 6;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(6, 3);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(154, 98);
            this.txtOutput.TabIndex = 0;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Location = new System.Drawing.Point(208, 174);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.Enabled = false;
            this.txtPrecio.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.LineColor = System.Drawing.Color.Brown;
            this.txtPrecio.Location = new System.Drawing.Point(211, 190);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.Size = new System.Drawing.Size(160, 33);
            this.txtPrecio.TabIndex = 4;
            // 
            // btnComprar
            // 
            this.btnComprar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComprar.Animated = true;
            this.btnComprar.AnimationHoverSpeed = 0.07F;
            this.btnComprar.AnimationSpeed = 0.03F;
            this.btnComprar.BaseColor = System.Drawing.Color.Brown;
            this.btnComprar.BorderColor = System.Drawing.Color.Black;
            this.btnComprar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnComprar.FocusedColor = System.Drawing.Color.Empty;
            this.btnComprar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnComprar.ForeColor = System.Drawing.Color.White;
            this.btnComprar.Image = null;
            this.btnComprar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnComprar.Location = new System.Drawing.Point(211, 235);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnComprar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnComprar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnComprar.OnHoverImage = null;
            this.btnComprar.OnPressedColor = System.Drawing.Color.Black;
            this.btnComprar.Size = new System.Drawing.Size(160, 71);
            this.btnComprar.TabIndex = 3;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnCafeDescafeinado
            // 
            this.btnCafeDescafeinado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCafeDescafeinado.Animated = true;
            this.btnCafeDescafeinado.AnimationHoverSpeed = 0.07F;
            this.btnCafeDescafeinado.AnimationSpeed = 0.03F;
            this.btnCafeDescafeinado.BaseColor = System.Drawing.Color.Brown;
            this.btnCafeDescafeinado.BorderColor = System.Drawing.Color.Black;
            this.btnCafeDescafeinado.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCafeDescafeinado.FocusedColor = System.Drawing.Color.Empty;
            this.btnCafeDescafeinado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCafeDescafeinado.ForeColor = System.Drawing.Color.White;
            this.btnCafeDescafeinado.Image = null;
            this.btnCafeDescafeinado.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCafeDescafeinado.Location = new System.Drawing.Point(411, 55);
            this.btnCafeDescafeinado.Name = "btnCafeDescafeinado";
            this.btnCafeDescafeinado.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCafeDescafeinado.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCafeDescafeinado.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCafeDescafeinado.OnHoverImage = null;
            this.btnCafeDescafeinado.OnPressedColor = System.Drawing.Color.Black;
            this.btnCafeDescafeinado.Size = new System.Drawing.Size(146, 42);
            this.btnCafeDescafeinado.TabIndex = 2;
            this.btnCafeDescafeinado.Text = "Café descafeinado";
            this.btnCafeDescafeinado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCafeDescafeinado.Click += new System.EventHandler(this.btnCafeDescafeinado_Click);
            // 
            // btnCafeExpreso
            // 
            this.btnCafeExpreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCafeExpreso.Animated = true;
            this.btnCafeExpreso.AnimationHoverSpeed = 0.07F;
            this.btnCafeExpreso.AnimationSpeed = 0.03F;
            this.btnCafeExpreso.BaseColor = System.Drawing.Color.Brown;
            this.btnCafeExpreso.BorderColor = System.Drawing.Color.Black;
            this.btnCafeExpreso.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCafeExpreso.FocusedColor = System.Drawing.Color.Empty;
            this.btnCafeExpreso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCafeExpreso.ForeColor = System.Drawing.Color.White;
            this.btnCafeExpreso.Image = null;
            this.btnCafeExpreso.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCafeExpreso.Location = new System.Drawing.Point(211, 55);
            this.btnCafeExpreso.Name = "btnCafeExpreso";
            this.btnCafeExpreso.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCafeExpreso.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCafeExpreso.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCafeExpreso.OnHoverImage = null;
            this.btnCafeExpreso.OnPressedColor = System.Drawing.Color.Black;
            this.btnCafeExpreso.Size = new System.Drawing.Size(160, 42);
            this.btnCafeExpreso.TabIndex = 1;
            this.btnCafeExpreso.Text = "Café expreso";
            this.btnCafeExpreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCafeExpreso.Click += new System.EventHandler(this.btnCafeExpreso_Click);
            // 
            // btnCafeSolo
            // 
            this.btnCafeSolo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCafeSolo.Animated = true;
            this.btnCafeSolo.AnimationHoverSpeed = 0.07F;
            this.btnCafeSolo.AnimationSpeed = 0.03F;
            this.btnCafeSolo.BaseColor = System.Drawing.Color.Brown;
            this.btnCafeSolo.BorderColor = System.Drawing.Color.Black;
            this.btnCafeSolo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCafeSolo.FocusedColor = System.Drawing.Color.Empty;
            this.btnCafeSolo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCafeSolo.ForeColor = System.Drawing.Color.White;
            this.btnCafeSolo.Image = null;
            this.btnCafeSolo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCafeSolo.Location = new System.Drawing.Point(12, 55);
            this.btnCafeSolo.Name = "btnCafeSolo";
            this.btnCafeSolo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCafeSolo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCafeSolo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCafeSolo.OnHoverImage = null;
            this.btnCafeSolo.OnPressedColor = System.Drawing.Color.Black;
            this.btnCafeSolo.Size = new System.Drawing.Size(160, 42);
            this.btnCafeSolo.TabIndex = 0;
            this.btnCafeSolo.Text = "Café solo";
            this.btnCafeSolo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCafeSolo.Click += new System.EventHandler(this.btnCafeSolo_Click);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.btnDecoratorCrema);
            this.gunaGroupBox1.Controls.Add(this.btnDecoratorLeche);
            this.gunaGroupBox1.Controls.Add(this.btnDecoratorAzucar);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.LightSteelBlue;
            this.gunaGroupBox1.Location = new System.Drawing.Point(0, 313);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(569, 132);
            this.gunaGroupBox1.TabIndex = 1;
            this.gunaGroupBox1.Text = "Condimentos";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // btnDecoratorCrema
            // 
            this.btnDecoratorCrema.Animated = true;
            this.btnDecoratorCrema.AnimationHoverSpeed = 0.07F;
            this.btnDecoratorCrema.AnimationSpeed = 0.03F;
            this.btnDecoratorCrema.BaseColor = System.Drawing.Color.Brown;
            this.btnDecoratorCrema.BorderColor = System.Drawing.Color.Black;
            this.btnDecoratorCrema.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDecoratorCrema.FocusedColor = System.Drawing.Color.Empty;
            this.btnDecoratorCrema.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDecoratorCrema.ForeColor = System.Drawing.Color.White;
            this.btnDecoratorCrema.Image = null;
            this.btnDecoratorCrema.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDecoratorCrema.Location = new System.Drawing.Point(411, 67);
            this.btnDecoratorCrema.Name = "btnDecoratorCrema";
            this.btnDecoratorCrema.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDecoratorCrema.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDecoratorCrema.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDecoratorCrema.OnHoverImage = null;
            this.btnDecoratorCrema.OnPressedColor = System.Drawing.Color.Black;
            this.btnDecoratorCrema.Size = new System.Drawing.Size(146, 42);
            this.btnDecoratorCrema.TabIndex = 5;
            this.btnDecoratorCrema.Text = "Crema";
            this.btnDecoratorCrema.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDecoratorCrema.Click += new System.EventHandler(this.btnDecoratorCrema_Click);
            // 
            // btnDecoratorLeche
            // 
            this.btnDecoratorLeche.Animated = true;
            this.btnDecoratorLeche.AnimationHoverSpeed = 0.07F;
            this.btnDecoratorLeche.AnimationSpeed = 0.03F;
            this.btnDecoratorLeche.BaseColor = System.Drawing.Color.Brown;
            this.btnDecoratorLeche.BorderColor = System.Drawing.Color.Black;
            this.btnDecoratorLeche.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDecoratorLeche.FocusedColor = System.Drawing.Color.Empty;
            this.btnDecoratorLeche.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDecoratorLeche.ForeColor = System.Drawing.Color.White;
            this.btnDecoratorLeche.Image = null;
            this.btnDecoratorLeche.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDecoratorLeche.Location = new System.Drawing.Point(211, 67);
            this.btnDecoratorLeche.Name = "btnDecoratorLeche";
            this.btnDecoratorLeche.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDecoratorLeche.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDecoratorLeche.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDecoratorLeche.OnHoverImage = null;
            this.btnDecoratorLeche.OnPressedColor = System.Drawing.Color.Black;
            this.btnDecoratorLeche.Size = new System.Drawing.Size(160, 42);
            this.btnDecoratorLeche.TabIndex = 4;
            this.btnDecoratorLeche.Text = "Leche";
            this.btnDecoratorLeche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDecoratorLeche.Click += new System.EventHandler(this.btnDecoratorLeche_Click);
            // 
            // btnDecoratorAzucar
            // 
            this.btnDecoratorAzucar.Animated = true;
            this.btnDecoratorAzucar.AnimationHoverSpeed = 0.07F;
            this.btnDecoratorAzucar.AnimationSpeed = 0.03F;
            this.btnDecoratorAzucar.BaseColor = System.Drawing.Color.Brown;
            this.btnDecoratorAzucar.BorderColor = System.Drawing.Color.Black;
            this.btnDecoratorAzucar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDecoratorAzucar.FocusedColor = System.Drawing.Color.Empty;
            this.btnDecoratorAzucar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDecoratorAzucar.ForeColor = System.Drawing.Color.White;
            this.btnDecoratorAzucar.Image = null;
            this.btnDecoratorAzucar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDecoratorAzucar.Location = new System.Drawing.Point(12, 67);
            this.btnDecoratorAzucar.Name = "btnDecoratorAzucar";
            this.btnDecoratorAzucar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDecoratorAzucar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDecoratorAzucar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDecoratorAzucar.OnHoverImage = null;
            this.btnDecoratorAzucar.OnPressedColor = System.Drawing.Color.Black;
            this.btnDecoratorAzucar.Size = new System.Drawing.Size(160, 42);
            this.btnDecoratorAzucar.TabIndex = 3;
            this.btnDecoratorAzucar.Text = "Azucar";
            this.btnDecoratorAzucar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDecoratorAzucar.Click += new System.EventHandler(this.btnDecoratorAzucar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.AnimationHoverSpeed = 0.07F;
            this.btnAtras.AnimationSpeed = 0.03F;
            this.btnAtras.BaseColor = System.Drawing.Color.Brown;
            this.btnAtras.BorderColor = System.Drawing.Color.Black;
            this.btnAtras.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAtras.FocusedColor = System.Drawing.Color.Empty;
            this.btnAtras.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAtras.ForeColor = System.Drawing.Color.White;
            this.btnAtras.Image = null;
            this.btnAtras.ImageSize = new System.Drawing.Size(52, 52);
            this.btnAtras.Location = new System.Drawing.Point(352, 115);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAtras.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAtras.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAtras.OnHoverImage = null;
            this.btnAtras.OnPressedColor = System.Drawing.Color.Black;
            this.btnAtras.Size = new System.Drawing.Size(29, 28);
            this.btnAtras.TabIndex = 9;
            this.btnAtras.Text = "<";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 445);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.grpboxCoffe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpboxCoffe.ResumeLayout(false);
            this.grpboxCoffe.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox grpboxCoffe;
        private Guna.UI.WinForms.GunaButton btnCafeExpreso;
        private Guna.UI.WinForms.GunaButton btnCafeSolo;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaButton btnCafeDescafeinado;
        private Guna.UI.WinForms.GunaButton btnDecoratorCrema;
        private Guna.UI.WinForms.GunaButton btnDecoratorLeche;
        private Guna.UI.WinForms.GunaButton btnDecoratorAzucar;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPrecio;
        private Guna.UI.WinForms.GunaLineTextBox txtPrecio;
        private Guna.UI.WinForms.GunaButton btnComprar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtOutput;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaLineTextBox txtPrecioTotal;
        private Guna.UI.WinForms.GunaCircleButton btnAtras;
    }
}

