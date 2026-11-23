namespace _04_5Oper_Foms_Parametros
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtIDEmployee = new TextBox();
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtBirthDate = new TextBox();
            btnInsertar = new Button();
            btnConsultar = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            lstResultados = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 35);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 35);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(412, 35);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 2;
            label3.Text = "Apellidos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(614, 35);
            label4.Name = "label4";
            label4.Size = new Size(178, 25);
            label4.TabIndex = 3;
            label4.Text = "FEcha de nacimiento:";
            // 
            // txtIDEmployee
            // 
            txtIDEmployee.Location = new Point(2, 92);
            txtIDEmployee.Name = "txtIDEmployee";
            txtIDEmployee.Size = new Size(110, 31);
            txtIDEmployee.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(146, 92);
            txtName.Name = "txtName";
            txtName.Size = new Size(215, 31);
            txtName.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(392, 92);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(180, 31);
            txtLastName.TabIndex = 6;
            // 
            // txtBirthDate
            // 
            txtBirthDate.Location = new Point(638, 92);
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.PlaceholderText = "dd/mm/aa";
            txtBirthDate.Size = new Size(154, 31);
            txtBirthDate.TabIndex = 7;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(176, 129);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(148, 49);
            btnInsertar.TabIndex = 8;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(367, 129);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(148, 49);
            btnConsultar.TabIndex = 9;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(176, 195);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(148, 49);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(367, 195);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(148, 49);
            btnBorrar.TabIndex = 11;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(12, 274);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(828, 379);
            lstResultados.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 673);
            Controls.Add(lstResultados);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnConsultar);
            Controls.Add(btnInsertar);
            Controls.Add(txtBirthDate);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(txtIDEmployee);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtIDEmployee;
        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtBirthDate;
        private Button btnInsertar;
        private Button btnConsultar;
        private Button btnModificar;
        private Button btnBorrar;
        private ListBox lstResultados;
    }
}
