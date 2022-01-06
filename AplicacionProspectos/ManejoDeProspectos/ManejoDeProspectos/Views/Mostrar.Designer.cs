namespace ManejoDeProspectos.Views
{
	partial class Mostrar
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
			this.btnSalir = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbObservaciones = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbEstatus = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbCodigoPostal = new System.Windows.Forms.TextBox();
			this.tbNumero = new System.Windows.Forms.TextBox();
			this.tbRfc = new System.Windows.Forms.TextBox();
			this.tbColonia = new System.Windows.Forms.TextBox();
			this.tbCalle = new System.Windows.Forms.TextBox();
			this.tbTelefono = new System.Windows.Forms.TextBox();
			this.tbApellido2 = new System.Windows.Forms.TextBox();
			this.tbApellido1 = new System.Windows.Forms.TextBox();
			this.tbNombre = new System.Windows.Forms.TextBox();
			this.lblRfc = new System.Windows.Forms.Label();
			this.lblTelefono = new System.Windows.Forms.Label();
			this.lblCp = new System.Windows.Forms.Label();
			this.lblColonia = new System.Windows.Forms.Label();
			this.lblNumero = new System.Windows.Forms.Label();
			this.lblApellido1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblCalle = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.gbDocuments = new System.Windows.Forms.GroupBox();
			this.dgvDocuments = new System.Windows.Forms.DataGridView();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblDocumentos = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.gbDocuments.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.IndianRed;
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Location = new System.Drawing.Point(841, 30);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(116, 37);
			this.btnSalir.TabIndex = 13;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.UseWaitCursor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbObservaciones);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tbEstatus);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.tbCodigoPostal);
			this.groupBox1.Controls.Add(this.tbNumero);
			this.groupBox1.Controls.Add(this.tbRfc);
			this.groupBox1.Controls.Add(this.tbColonia);
			this.groupBox1.Controls.Add(this.tbCalle);
			this.groupBox1.Controls.Add(this.tbTelefono);
			this.groupBox1.Controls.Add(this.tbApellido2);
			this.groupBox1.Controls.Add(this.tbApellido1);
			this.groupBox1.Controls.Add(this.tbNombre);
			this.groupBox1.Controls.Add(this.lblRfc);
			this.groupBox1.Controls.Add(this.lblTelefono);
			this.groupBox1.Controls.Add(this.lblCp);
			this.groupBox1.Controls.Add(this.lblColonia);
			this.groupBox1.Controls.Add(this.lblNumero);
			this.groupBox1.Controls.Add(this.lblApellido1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.lblCalle);
			this.groupBox1.Controls.Add(this.lblNombre);
			this.groupBox1.Location = new System.Drawing.Point(17, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(770, 456);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			// 
			// tbObservaciones
			// 
			this.tbObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbObservaciones.Location = new System.Drawing.Point(176, 374);
			this.tbObservaciones.Multiline = true;
			this.tbObservaciones.Name = "tbObservaciones";
			this.tbObservaciones.ReadOnly = true;
			this.tbObservaciones.Size = new System.Drawing.Size(574, 61);
			this.tbObservaciones.TabIndex = 28;
			this.tbObservaciones.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(21, 375);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(142, 24);
			this.label2.TabIndex = 27;
			this.label2.Text = "Observaciones:";
			this.label2.UseWaitCursor = true;
			this.label2.Visible = false;
			// 
			// tbEstatus
			// 
			this.tbEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbEstatus.Location = new System.Drawing.Point(139, 324);
			this.tbEstatus.Name = "tbEstatus";
			this.tbEstatus.ReadOnly = true;
			this.tbEstatus.Size = new System.Drawing.Size(217, 27);
			this.tbEstatus.TabIndex = 26;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(21, 324);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 24);
			this.label1.TabIndex = 25;
			this.label1.Text = "Estatus:";
			this.label1.UseWaitCursor = true;
			// 
			// tbCodigoPostal
			// 
			this.tbCodigoPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCodigoPostal.Location = new System.Drawing.Point(533, 209);
			this.tbCodigoPostal.Name = "tbCodigoPostal";
			this.tbCodigoPostal.ReadOnly = true;
			this.tbCodigoPostal.Size = new System.Drawing.Size(217, 27);
			this.tbCodigoPostal.TabIndex = 24;
			// 
			// tbNumero
			// 
			this.tbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNumero.Location = new System.Drawing.Point(533, 150);
			this.tbNumero.Name = "tbNumero";
			this.tbNumero.ReadOnly = true;
			this.tbNumero.Size = new System.Drawing.Size(217, 27);
			this.tbNumero.TabIndex = 23;
			// 
			// tbRfc
			// 
			this.tbRfc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbRfc.Location = new System.Drawing.Point(533, 279);
			this.tbRfc.Name = "tbRfc";
			this.tbRfc.ReadOnly = true;
			this.tbRfc.Size = new System.Drawing.Size(217, 27);
			this.tbRfc.TabIndex = 22;
			// 
			// tbColonia
			// 
			this.tbColonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbColonia.Location = new System.Drawing.Point(139, 206);
			this.tbColonia.Name = "tbColonia";
			this.tbColonia.ReadOnly = true;
			this.tbColonia.Size = new System.Drawing.Size(217, 27);
			this.tbColonia.TabIndex = 21;
			// 
			// tbCalle
			// 
			this.tbCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCalle.Location = new System.Drawing.Point(139, 147);
			this.tbCalle.Name = "tbCalle";
			this.tbCalle.ReadOnly = true;
			this.tbCalle.Size = new System.Drawing.Size(217, 27);
			this.tbCalle.TabIndex = 20;
			// 
			// tbTelefono
			// 
			this.tbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbTelefono.Location = new System.Drawing.Point(139, 276);
			this.tbTelefono.Name = "tbTelefono";
			this.tbTelefono.ReadOnly = true;
			this.tbTelefono.Size = new System.Drawing.Size(217, 27);
			this.tbTelefono.TabIndex = 19;
			// 
			// tbApellido2
			// 
			this.tbApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbApellido2.Location = new System.Drawing.Point(217, 79);
			this.tbApellido2.Name = "tbApellido2";
			this.tbApellido2.ReadOnly = true;
			this.tbApellido2.Size = new System.Drawing.Size(217, 27);
			this.tbApellido2.TabIndex = 18;
			// 
			// tbApellido1
			// 
			this.tbApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbApellido1.Location = new System.Drawing.Point(533, 27);
			this.tbApellido1.Name = "tbApellido1";
			this.tbApellido1.ReadOnly = true;
			this.tbApellido1.Size = new System.Drawing.Size(217, 27);
			this.tbApellido1.TabIndex = 17;
			// 
			// tbNombre
			// 
			this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNombre.Location = new System.Drawing.Point(139, 27);
			this.tbNombre.Name = "tbNombre";
			this.tbNombre.ReadOnly = true;
			this.tbNombre.Size = new System.Drawing.Size(217, 27);
			this.tbNombre.TabIndex = 16;
			// 
			// lblRfc
			// 
			this.lblRfc.AutoSize = true;
			this.lblRfc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRfc.Location = new System.Drawing.Point(389, 276);
			this.lblRfc.Name = "lblRfc";
			this.lblRfc.Size = new System.Drawing.Size(53, 24);
			this.lblRfc.TabIndex = 15;
			this.lblRfc.Text = "RFC:";
			this.lblRfc.UseWaitCursor = true;
			// 
			// lblTelefono
			// 
			this.lblTelefono.AutoSize = true;
			this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTelefono.Location = new System.Drawing.Point(21, 276);
			this.lblTelefono.Name = "lblTelefono";
			this.lblTelefono.Size = new System.Drawing.Size(90, 24);
			this.lblTelefono.TabIndex = 14;
			this.lblTelefono.Text = "Telefono:";
			this.lblTelefono.UseWaitCursor = true;
			// 
			// lblCp
			// 
			this.lblCp.AutoSize = true;
			this.lblCp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCp.Location = new System.Drawing.Point(389, 209);
			this.lblCp.Name = "lblCp";
			this.lblCp.Size = new System.Drawing.Size(131, 24);
			this.lblCp.TabIndex = 13;
			this.lblCp.Text = "Codigo Postal:";
			this.lblCp.UseWaitCursor = true;
			// 
			// lblColonia
			// 
			this.lblColonia.AutoSize = true;
			this.lblColonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblColonia.Location = new System.Drawing.Point(21, 209);
			this.lblColonia.Name = "lblColonia";
			this.lblColonia.Size = new System.Drawing.Size(79, 24);
			this.lblColonia.TabIndex = 12;
			this.lblColonia.Text = "Colonia:";
			this.lblColonia.UseWaitCursor = true;
			// 
			// lblNumero
			// 
			this.lblNumero.AutoSize = true;
			this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumero.Location = new System.Drawing.Point(389, 150);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(84, 24);
			this.lblNumero.TabIndex = 11;
			this.lblNumero.Text = "Numero:";
			this.lblNumero.UseWaitCursor = true;
			// 
			// lblApellido1
			// 
			this.lblApellido1.AutoSize = true;
			this.lblApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblApellido1.Location = new System.Drawing.Point(376, 27);
			this.lblApellido1.Name = "lblApellido1";
			this.lblApellido1.Size = new System.Drawing.Size(144, 24);
			this.lblApellido1.TabIndex = 10;
			this.lblApellido1.Text = "Primer Apellido:";
			this.lblApellido1.UseWaitCursor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(21, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(167, 24);
			this.label3.TabIndex = 9;
			this.label3.Text = "Segundo Apellido:";
			this.label3.UseWaitCursor = true;
			// 
			// lblCalle
			// 
			this.lblCalle.AutoSize = true;
			this.lblCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCalle.Location = new System.Drawing.Point(21, 150);
			this.lblCalle.Name = "lblCalle";
			this.lblCalle.Size = new System.Drawing.Size(57, 24);
			this.lblCalle.TabIndex = 8;
			this.lblCalle.Text = "Calle:";
			this.lblCalle.UseWaitCursor = true;
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.Location = new System.Drawing.Point(21, 27);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(105, 24);
			this.lblNombre.TabIndex = 7;
			this.lblNombre.Text = "Nombre(s):";
			this.lblNombre.UseWaitCursor = true;
			// 
			// gbDocuments
			// 
			this.gbDocuments.Controls.Add(this.dgvDocuments);
			this.gbDocuments.Controls.Add(this.lblDocumentos);
			this.gbDocuments.Location = new System.Drawing.Point(18, 490);
			this.gbDocuments.Name = "gbDocuments";
			this.gbDocuments.Size = new System.Drawing.Size(809, 232);
			this.gbDocuments.TabIndex = 11;
			this.gbDocuments.TabStop = false;
			// 
			// dgvDocuments
			// 
			this.dgvDocuments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDocuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.documento});
			this.dgvDocuments.Location = new System.Drawing.Point(17, 67);
			this.dgvDocuments.Name = "dgvDocuments";
			this.dgvDocuments.ReadOnly = true;
			this.dgvDocuments.RowTemplate.Height = 24;
			this.dgvDocuments.Size = new System.Drawing.Size(792, 139);
			this.dgvDocuments.TabIndex = 6;
			this.dgvDocuments.UseWaitCursor = true;
			// 
			// nombre
			// 
			this.nombre.FillWeight = 101.5228F;
			this.nombre.HeaderText = "Nombre";
			this.nombre.Name = "nombre";
			this.nombre.ReadOnly = true;
			// 
			// documento
			// 
			this.documento.FillWeight = 98.47716F;
			this.documento.HeaderText = "Documento";
			this.documento.Name = "documento";
			this.documento.ReadOnly = true;
			// 
			// lblDocumentos
			// 
			this.lblDocumentos.AutoSize = true;
			this.lblDocumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDocumentos.Location = new System.Drawing.Point(20, 21);
			this.lblDocumentos.Name = "lblDocumentos";
			this.lblDocumentos.Size = new System.Drawing.Size(117, 24);
			this.lblDocumentos.TabIndex = 0;
			this.lblDocumentos.Text = "Documentos";
			this.lblDocumentos.UseWaitCursor = true;
			// 
			// Mostrar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.ClientSize = new System.Drawing.Size(1006, 734);
			this.ControlBox = false;
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gbDocuments);
			this.Name = "Mostrar";
			this.Text = "Mostrar";
			this.Load += new System.EventHandler(this.Mostrar_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.gbDocuments.ResumeLayout(false);
			this.gbDocuments.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tbCodigoPostal;
		private System.Windows.Forms.TextBox tbNumero;
		private System.Windows.Forms.TextBox tbRfc;
		private System.Windows.Forms.TextBox tbColonia;
		private System.Windows.Forms.TextBox tbCalle;
		private System.Windows.Forms.TextBox tbTelefono;
		private System.Windows.Forms.TextBox tbApellido2;
		private System.Windows.Forms.TextBox tbApellido1;
		private System.Windows.Forms.TextBox tbNombre;
		private System.Windows.Forms.Label lblRfc;
		private System.Windows.Forms.Label lblTelefono;
		private System.Windows.Forms.Label lblCp;
		private System.Windows.Forms.Label lblColonia;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.Label lblApellido1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblCalle;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.GroupBox gbDocuments;
		private System.Windows.Forms.DataGridView dgvDocuments;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn documento;
		private System.Windows.Forms.Label lblDocumentos;
		private System.Windows.Forms.TextBox tbObservaciones;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbEstatus;
		private System.Windows.Forms.Label label1;
	}
}