namespace EAFIT_BaseDeDatos.UI
{
    partial class Productos
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
            BtnConsultarAvion = new Button();
            BtnNewAvion = new Button();
            CBEstadoAvion = new ComboBox();
            TxtEnsamble = new TextBox();
            BtnDeleteAvion = new Button();
            BtnUpdateAvion = new Button();
            TxtRefAvion = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            LblTitulo = new Label();
            TxtSize = new TextBox();
            TxtAforo = new TextBox();
            LblPassword = new Label();
            LblUsuario = new Label();
            BtnIngresarAvion = new Button();
            BtnSalirA = new Button();
            textMatricula = new TextBox();
            SuspendLayout();
            // 
            // BtnConsultarAvion
            // 
            BtnConsultarAvion.BackColor = Color.Navy;
            BtnConsultarAvion.Font = new Font("Candara", 9F);
            BtnConsultarAvion.ForeColor = Color.White;
            BtnConsultarAvion.Location = new Point(697, 231);
            BtnConsultarAvion.Margin = new Padding(4, 5, 4, 5);
            BtnConsultarAvion.Name = "BtnConsultarAvion";
            BtnConsultarAvion.Size = new Size(174, 60);
            BtnConsultarAvion.TabIndex = 43;
            BtnConsultarAvion.Text = "Consultar!!";
            BtnConsultarAvion.UseVisualStyleBackColor = false;
            BtnConsultarAvion.Click += BtnConsultarAvion_Click;
            // 
            // BtnNewAvion
            // 
            BtnNewAvion.BackColor = Color.Navy;
            BtnNewAvion.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnNewAvion.ForeColor = Color.White;
            BtnNewAvion.Location = new Point(925, 230);
            BtnNewAvion.Margin = new Padding(4, 5, 4, 5);
            BtnNewAvion.Name = "BtnNewAvion";
            BtnNewAvion.Size = new Size(162, 58);
            BtnNewAvion.TabIndex = 33;
            BtnNewAvion.Text = "Nuevo!!";
            BtnNewAvion.UseVisualStyleBackColor = false;
            BtnNewAvion.Click += BtnNewAvion_Click;
            // 
            // CBEstadoAvion
            // 
            CBEstadoAvion.Font = new Font("Candara Light", 10F);
            CBEstadoAvion.FormattingEnabled = true;
            CBEstadoAvion.Items.AddRange(new object[] { "--Seleccionar--", "   Activo", "   Inactivo" });
            CBEstadoAvion.Location = new Point(384, 616);
            CBEstadoAvion.Name = "CBEstadoAvion";
            CBEstadoAvion.Size = new Size(265, 29);
            CBEstadoAvion.TabIndex = 39;
            // 
            // TxtEnsamble
            // 
            TxtEnsamble.Font = new Font("Candara Light", 10F);
            TxtEnsamble.Location = new Point(384, 453);
            TxtEnsamble.Margin = new Padding(4, 5, 4, 5);
            TxtEnsamble.Name = "TxtEnsamble";
            TxtEnsamble.Size = new Size(265, 28);
            TxtEnsamble.TabIndex = 37;
            // 
            // BtnDeleteAvion
            // 
            BtnDeleteAvion.BackColor = Color.Navy;
            BtnDeleteAvion.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDeleteAvion.ForeColor = Color.White;
            BtnDeleteAvion.Location = new Point(1106, 517);
            BtnDeleteAvion.Margin = new Padding(4, 5, 4, 5);
            BtnDeleteAvion.Name = "BtnDeleteAvion";
            BtnDeleteAvion.Size = new Size(162, 58);
            BtnDeleteAvion.TabIndex = 45;
            BtnDeleteAvion.Text = "Inactivar!!";
            BtnDeleteAvion.UseVisualStyleBackColor = false;
            BtnDeleteAvion.Click += BtnDeleteAvion_Click;
            // 
            // BtnUpdateAvion
            // 
            BtnUpdateAvion.BackColor = Color.Navy;
            BtnUpdateAvion.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnUpdateAvion.ForeColor = Color.White;
            BtnUpdateAvion.Location = new Point(906, 516);
            BtnUpdateAvion.Margin = new Padding(4, 5, 4, 5);
            BtnUpdateAvion.Name = "BtnUpdateAvion";
            BtnUpdateAvion.Size = new Size(162, 58);
            BtnUpdateAvion.TabIndex = 44;
            BtnUpdateAvion.Text = "Actualizar!!";
            BtnUpdateAvion.UseVisualStyleBackColor = false;
            BtnUpdateAvion.Click += BtnUpdateAvion_Click;
            // 
            // TxtRefAvion
            // 
            TxtRefAvion.Font = new Font("Candara Light", 10F);
            TxtRefAvion.Location = new Point(384, 534);
            TxtRefAvion.Margin = new Padding(4, 5, 4, 5);
            TxtRefAvion.Name = "TxtRefAvion";
            TxtRefAvion.Size = new Size(265, 28);
            TxtRefAvion.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(122, 534);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 24);
            label4.TabIndex = 53;
            label4.Text = "Referencia:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(122, 615);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(154, 24);
            label3.TabIndex = 52;
            label3.Text = "Estado del Avion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(122, 244);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 24);
            label1.TabIndex = 51;
            label1.Text = "Matricula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(122, 453);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(175, 24);
            label2.TabIndex = 50;
            label2.Text = "Fecha de Ensamble:";
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = Color.Navy;
            LblTitulo.Location = new Point(672, 51);
            LblTitulo.Margin = new Padding(4, 0, 4, 0);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(76, 24);
            LblTitulo.TabIndex = 49;
            LblTitulo.Text = "Aviones";
            // 
            // TxtSize
            // 
            TxtSize.Font = new Font("Candara Light", 10F);
            TxtSize.Location = new Point(384, 376);
            TxtSize.Margin = new Padding(4, 5, 4, 5);
            TxtSize.Name = "TxtSize";
            TxtSize.Size = new Size(265, 28);
            TxtSize.TabIndex = 36;
            // 
            // TxtAforo
            // 
            TxtAforo.Font = new Font("Candara Light", 10F);
            TxtAforo.Location = new Point(384, 307);
            TxtAforo.Margin = new Padding(4, 5, 4, 5);
            TxtAforo.Name = "TxtAforo";
            TxtAforo.Size = new Size(265, 28);
            TxtAforo.TabIndex = 35;
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblPassword.ForeColor = Color.Navy;
            LblPassword.Location = new Point(122, 380);
            LblPassword.Margin = new Padding(4, 0, 4, 0);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(164, 24);
            LblPassword.TabIndex = 48;
            LblPassword.Text = "Tamaño del Avion:";
            // 
            // LblUsuario
            // 
            LblUsuario.AutoSize = true;
            LblUsuario.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblUsuario.ForeColor = Color.Navy;
            LblUsuario.Location = new Point(122, 309);
            LblUsuario.Margin = new Padding(4, 0, 4, 0);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(135, 24);
            LblUsuario.TabIndex = 47;
            LblUsuario.Text = "Aforo Maximo:";
            // 
            // BtnIngresarAvion
            // 
            BtnIngresarAvion.BackColor = Color.Navy;
            BtnIngresarAvion.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnIngresarAvion.ForeColor = Color.White;
            BtnIngresarAvion.Location = new Point(709, 516);
            BtnIngresarAvion.Margin = new Padding(4, 5, 4, 5);
            BtnIngresarAvion.Name = "BtnIngresarAvion";
            BtnIngresarAvion.Size = new Size(162, 58);
            BtnIngresarAvion.TabIndex = 42;
            BtnIngresarAvion.Text = "Guardar!!";
            BtnIngresarAvion.UseVisualStyleBackColor = false;
            BtnIngresarAvion.Click += BtnIngresarAvion_Click;
            // 
            // BtnSalirA
            // 
            BtnSalirA.BackColor = Color.Navy;
            BtnSalirA.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSalirA.ForeColor = Color.White;
            BtnSalirA.Location = new Point(1106, 630);
            BtnSalirA.Margin = new Padding(4, 5, 4, 5);
            BtnSalirA.Name = "BtnSalirA";
            BtnSalirA.Size = new Size(162, 58);
            BtnSalirA.TabIndex = 46;
            BtnSalirA.Text = "Salir";
            BtnSalirA.UseVisualStyleBackColor = false;
            BtnSalirA.Click += BtnSalir_Click;
            // 
            // textMatricula
            // 
            textMatricula.Font = new Font("Candara Light", 10F);
            textMatricula.Location = new Point(384, 240);
            textMatricula.Margin = new Padding(4, 5, 4, 5);
            textMatricula.Name = "textMatricula";
            textMatricula.Size = new Size(265, 28);
            textMatricula.TabIndex = 56;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1327, 738);
            Controls.Add(textMatricula);
            Controls.Add(BtnConsultarAvion);
            Controls.Add(BtnNewAvion);
            Controls.Add(CBEstadoAvion);
            Controls.Add(TxtEnsamble);
            Controls.Add(BtnDeleteAvion);
            Controls.Add(BtnUpdateAvion);
            Controls.Add(TxtRefAvion);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(LblTitulo);
            Controls.Add(TxtSize);
            Controls.Add(TxtAforo);
            Controls.Add(LblPassword);
            Controls.Add(LblUsuario);
            Controls.Add(BtnIngresarAvion);
            Controls.Add(BtnSalirA);
            Margin = new Padding(2);
            Name = "Productos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnConsultarAvion;
        private Button BtnNewAvion;
        private ComboBox CBEstadoAvion;
        private TextBox TxtEnsamble;
        private Button BtnDeleteAvion;
        private Button BtnUpdateAvion;
        private TextBox TxtRefAvion;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label LblTitulo;
        private TextBox TxtSize;
        private TextBox TxtAforo;
        private Label LblPassword;
        private Label LblUsuario;
        private Button BtnIngresarAvion;
        private Button BtnSalirA;
        private TextBox textMatricula;
    }


}