namespace RegistroEstudianteForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            label11 = new Label();
            criteriotextBox = new TextBox();
            consultadataGridView = new DataGridView();
            consultabutton = new Button();
            label10 = new Label();
            filtrocomboBox = new ComboBox();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            label9 = new Label();
            BalancetextBox = new TextBox();
            label8 = new Label();
            TotalCreditostextBox = new TextBox();
            label2 = new Label();
            preciocreditotextBox = new TextBox();
            label1 = new Label();
            carreracomboBox = new ComboBox();
            groupBox1 = new GroupBox();
            actualizarbutton = new Button();
            salirbutton = new Button();
            guardarbutton = new Button();
            cancelarbutton = new Button();
            buscarbutton = new Button();
            label7 = new Label();
            matriculamaskedTextBox = new MaskedTextBox();
            telefonomaskedTextBox = new MaskedTextBox();
            label6 = new Label();
            direcciontextBox = new TextBox();
            label5 = new Label();
            cedulatextBox = new TextBox();
            label4 = new Label();
            nametextBox = new TextBox();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)consultadataGridView).BeginInit();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1268, 510);
            panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(criteriotextBox);
            groupBox3.Controls.Add(consultadataGridView);
            groupBox3.Controls.Add(consultabutton);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(filtrocomboBox);
            groupBox3.Location = new Point(816, 13);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(435, 483);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Consulta";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 110);
            label11.Name = "label11";
            label11.Size = new Size(62, 21);
            label11.TabIndex = 18;
            label11.Text = "Criterio";
            // 
            // criteriotextBox
            // 
            criteriotextBox.Location = new Point(92, 107);
            criteriotextBox.Name = "criteriotextBox";
            criteriotextBox.Size = new Size(309, 29);
            criteriotextBox.TabIndex = 4;
            criteriotextBox.KeyPress += criteriotextBox_KeyPress;
            // 
            // consultadataGridView
            // 
            consultadataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            consultadataGridView.Location = new Point(24, 152);
            consultadataGridView.Name = "consultadataGridView";
            consultadataGridView.RowHeadersWidth = 53;
            consultadataGridView.RowTemplate.Height = 31;
            consultadataGridView.Size = new Size(377, 300);
            consultadataGridView.TabIndex = 17;
            // 
            // consultabutton
            // 
            consultabutton.BackColor = Color.LightGreen;
            consultabutton.Location = new Point(281, 34);
            consultabutton.Name = "consultabutton";
            consultabutton.Size = new Size(131, 44);
            consultabutton.TabIndex = 16;
            consultabutton.Text = "Consultar";
            consultabutton.UseVisualStyleBackColor = false;
            consultabutton.Click += consultabutton_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 43);
            label10.Name = "label10";
            label10.Size = new Size(46, 21);
            label10.TabIndex = 4;
            label10.Text = "Filtro";
            label10.Click += label10_Click;
            // 
            // filtrocomboBox
            // 
            filtrocomboBox.FormattingEnabled = true;
            filtrocomboBox.Items.AddRange(new object[] { "Todo", "Nombre", "Matricula" });
            filtrocomboBox.Location = new Point(88, 43);
            filtrocomboBox.Name = "filtrocomboBox";
            filtrocomboBox.Size = new Size(170, 29);
            filtrocomboBox.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(preciocreditotextBox);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(carreracomboBox);
            groupBox2.Location = new Point(463, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(331, 483);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Balance";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(BalancetextBox);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(TotalCreditostextBox);
            groupBox4.Location = new Point(20, 174);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(289, 244);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Enter += groupBox4_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 110);
            label9.Name = "label9";
            label9.Size = new Size(135, 21);
            label9.TabIndex = 5;
            label9.Text = "Balance Pendiente";
            // 
            // BalancetextBox
            // 
            BalancetextBox.Enabled = false;
            BalancetextBox.Location = new Point(18, 143);
            BalancetextBox.Name = "BalancetextBox";
            BalancetextBox.Size = new Size(137, 29);
            BalancetextBox.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 24);
            label8.Name = "label8";
            label8.Size = new Size(125, 21);
            label8.TabIndex = 4;
            label8.Text = "Total de Créditos";
            // 
            // TotalCreditostextBox
            // 
            TotalCreditostextBox.Location = new Point(18, 57);
            TotalCreditostextBox.Name = "TotalCreditostextBox";
            TotalCreditostextBox.Size = new Size(137, 29);
            TotalCreditostextBox.TabIndex = 4;
            TotalCreditostextBox.TextChanged += TotalCreditostextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 115);
            label2.Name = "label2";
            label2.Size = new Size(136, 21);
            label2.TabIndex = 3;
            label2.Text = "Precio por Crédito";
            // 
            // preciocreditotextBox
            // 
            preciocreditotextBox.Enabled = false;
            preciocreditotextBox.Location = new Point(20, 152);
            preciocreditotextBox.Name = "preciocreditotextBox";
            preciocreditotextBox.Size = new Size(155, 29);
            preciocreditotextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 38);
            label1.Name = "label1";
            label1.Size = new Size(159, 21);
            label1.TabIndex = 1;
            label1.Text = "Seleccione su Carrera";
            // 
            // carreracomboBox
            // 
            carreracomboBox.FormattingEnabled = true;
            carreracomboBox.Location = new Point(20, 72);
            carreracomboBox.Name = "carreracomboBox";
            carreracomboBox.Size = new Size(204, 29);
            carreracomboBox.TabIndex = 0;
            carreracomboBox.SelectedIndexChanged += carreracomboBox_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(actualizarbutton);
            groupBox1.Controls.Add(salirbutton);
            groupBox1.Controls.Add(guardarbutton);
            groupBox1.Controls.Add(cancelarbutton);
            groupBox1.Controls.Add(buscarbutton);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(matriculamaskedTextBox);
            groupBox1.Controls.Add(telefonomaskedTextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(direcciontextBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cedulatextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(nametextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(435, 483);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Del Estudiante";
            // 
            // actualizarbutton
            // 
            actualizarbutton.BackColor = Color.RoyalBlue;
            actualizarbutton.Enabled = false;
            actualizarbutton.Location = new Point(259, 284);
            actualizarbutton.Name = "actualizarbutton";
            actualizarbutton.Size = new Size(115, 44);
            actualizarbutton.TabIndex = 17;
            actualizarbutton.Text = "Actualizar";
            actualizarbutton.UseVisualStyleBackColor = false;
            actualizarbutton.Visible = false;
            actualizarbutton.Click += actualizarbutton_Click;
            // 
            // salirbutton
            // 
            salirbutton.BackColor = Color.Crimson;
            salirbutton.Location = new Point(181, 433);
            salirbutton.Name = "salirbutton";
            salirbutton.Size = new Size(115, 44);
            salirbutton.TabIndex = 16;
            salirbutton.Text = "Salir";
            salirbutton.UseVisualStyleBackColor = false;
            salirbutton.Click += salirbutton_Click;
            // 
            // guardarbutton
            // 
            guardarbutton.BackColor = Color.DarkSeaGreen;
            guardarbutton.Location = new Point(302, 433);
            guardarbutton.Name = "guardarbutton";
            guardarbutton.Size = new Size(115, 44);
            guardarbutton.TabIndex = 15;
            guardarbutton.Text = "Guardar";
            guardarbutton.UseVisualStyleBackColor = false;
            guardarbutton.Click += guardarbutton_Click;
            // 
            // cancelarbutton
            // 
            cancelarbutton.BackColor = Color.RosyBrown;
            cancelarbutton.Location = new Point(302, 63);
            cancelarbutton.Name = "cancelarbutton";
            cancelarbutton.Size = new Size(105, 44);
            cancelarbutton.TabIndex = 14;
            cancelarbutton.Text = "Cancelar";
            cancelarbutton.UseVisualStyleBackColor = false;
            cancelarbutton.Click += cancelarbutton_Click;
            // 
            // buscarbutton
            // 
            buscarbutton.BackColor = SystemColors.GradientActiveCaption;
            buscarbutton.Location = new Point(191, 63);
            buscarbutton.Name = "buscarbutton";
            buscarbutton.Size = new Size(105, 44);
            buscarbutton.TabIndex = 4;
            buscarbutton.Text = "Buscar";
            buscarbutton.UseVisualStyleBackColor = false;
            buscarbutton.Click += buscarbutton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 354);
            label7.Name = "label7";
            label7.Size = new Size(68, 21);
            label7.TabIndex = 13;
            label7.Text = "Teléfono";
            // 
            // matriculamaskedTextBox
            // 
            matriculamaskedTextBox.Location = new Point(19, 72);
            matriculamaskedTextBox.Mask = "0000-0000";
            matriculamaskedTextBox.Name = "matriculamaskedTextBox";
            matriculamaskedTextBox.Size = new Size(149, 29);
            matriculamaskedTextBox.TabIndex = 12;
            // 
            // telefonomaskedTextBox
            // 
            telefonomaskedTextBox.Location = new Point(19, 389);
            telefonomaskedTextBox.Mask = "(999) 000-0000";
            telefonomaskedTextBox.Name = "telefonomaskedTextBox";
            telefonomaskedTextBox.Size = new Size(183, 29);
            telefonomaskedTextBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 275);
            label6.Name = "label6";
            label6.Size = new Size(75, 21);
            label6.TabIndex = 10;
            label6.Text = "Dirección";
            // 
            // direcciontextBox
            // 
            direcciontextBox.Location = new Point(19, 313);
            direcciontextBox.Name = "direcciontextBox";
            direcciontextBox.Size = new Size(183, 29);
            direcciontextBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 198);
            label5.Name = "label5";
            label5.Size = new Size(58, 21);
            label5.TabIndex = 8;
            label5.Text = "Cédula";
            // 
            // cedulatextBox
            // 
            cedulatextBox.Location = new Point(19, 231);
            cedulatextBox.Name = "cedulatextBox";
            cedulatextBox.Size = new Size(183, 29);
            cedulatextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 118);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 6;
            label4.Text = "Nombre";
            // 
            // nametextBox
            // 
            nametextBox.Location = new Point(19, 152);
            nametextBox.Name = "nametextBox";
            nametextBox.Size = new Size(380, 29);
            nametextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 38);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 4;
            label3.Text = "Matricula";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 534);
            Controls.Add(panel1);
            ForeColor = SystemColors.InfoText;
            Name = "Form1";
            Text = "Registro de Estudiantes";
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)consultadataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Label label1;
        private ComboBox carreracomboBox;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox preciocreditotextBox;
        private Label label3;
        private Label label4;
        private TextBox nametextBox;
        private Label label5;
        private TextBox cedulatextBox;
        private Label label6;
        private TextBox direcciontextBox;
        private Label label7;
        private MaskedTextBox matriculamaskedTextBox;
        private MaskedTextBox telefonomaskedTextBox;
        private Button guardarbutton;
        private Button cancelarbutton;
        private Button buscarbutton;
        private Button salirbutton;
        private ErrorProvider errorProvider1;
        private GroupBox groupBox4;
        private Label label8;
        private TextBox TotalCreditostextBox;
        private Label label9;
        private TextBox BalancetextBox;
        private Button actualizarbutton;
        private Label label10;
        private ComboBox filtrocomboBox;
        private Button consultabutton;
        private DataGridView consultadataGridView;
        private Label label11;
        private TextBox criteriotextBox;
    }
}