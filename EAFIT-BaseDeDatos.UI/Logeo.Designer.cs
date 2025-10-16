namespace EAFIT_BaseDeDatos.UI
{
    partial class Logeo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logeo));
            LblTitulo = new Label();
            pictureBox1 = new PictureBox();
            TxtPassword = new TextBox();
            TxtUsuario = new TextBox();
            LblPassword = new Label();
            LblUsuario = new Label();
            BtnIngresar = new Button();
            BtnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = Color.Navy;
            LblTitulo.Location = new Point(186, 47);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(220, 48);
            LblTitulo.TabIndex = 15;
            LblTitulo.Text = "Aplicación Base De Datos\r\n                   Logeo ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 11);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // TxtPassword
            // 
            TxtPassword.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPassword.Location = new Point(186, 169);
            TxtPassword.Margin = new Padding(3, 4, 3, 4);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '&';
            TxtPassword.Size = new Size(194, 32);
            TxtPassword.TabIndex = 2;
            TxtPassword.UseSystemPasswordChar = true;
            TxtPassword.KeyPress += TxtPassword_KeyPress;
            // 
            // TxtUsuario
            // 
            TxtUsuario.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtUsuario.Location = new Point(186, 119);
            TxtUsuario.Margin = new Padding(3, 4, 3, 4);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(194, 32);
            TxtUsuario.TabIndex = 1;
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblPassword.ForeColor = Color.Navy;
            LblPassword.Location = new Point(70, 170);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(111, 24);
            LblPassword.TabIndex = 11;
            LblPassword.Text = "Contraseña:";
            // 
            // LblUsuario
            // 
            LblUsuario.AutoSize = true;
            LblUsuario.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblUsuario.ForeColor = Color.Navy;
            LblUsuario.Location = new Point(70, 121);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(80, 24);
            LblUsuario.TabIndex = 10;
            LblUsuario.Text = "Usuario:";
            // 
            // BtnIngresar
            // 
            BtnIngresar.BackColor = Color.Navy;
            BtnIngresar.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnIngresar.ForeColor = Color.White;
            BtnIngresar.Location = new Point(114, 247);
            BtnIngresar.Margin = new Padding(3, 4, 3, 4);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(118, 48);
            BtnIngresar.TabIndex = 3;
            BtnIngresar.Text = "Ingresar";
            BtnIngresar.UseVisualStyleBackColor = false;
            BtnIngresar.Click += BtnIngresar_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.Navy;
            BtnSalir.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSalir.ForeColor = Color.White;
            BtnSalir.Location = new Point(262, 247);
            BtnSalir.Margin = new Padding(3, 4, 3, 4);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(118, 48);
            BtnSalir.TabIndex = 4;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // Logeo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(430, 340);
            Controls.Add(LblTitulo);
            Controls.Add(pictureBox1);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUsuario);
            Controls.Add(LblPassword);
            Controls.Add(LblUsuario);
            Controls.Add(BtnIngresar);
            Controls.Add(BtnSalir);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "Logeo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Universidad EAFIT - Base De Datos - Login";
            Load += Logeo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTitulo;
        private PictureBox pictureBox1;
        private TextBox TxtPassword;
        private TextBox TxtUsuario;
        private Label LblPassword;
        private Label LblUsuario;
        private Button BtnIngresar;
        private Button BtnSalir;
    }
}