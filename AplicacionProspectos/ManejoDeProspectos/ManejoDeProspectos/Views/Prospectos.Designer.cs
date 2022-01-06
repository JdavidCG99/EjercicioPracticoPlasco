namespace ManejoDeProspectos.Views
{
	partial class Prospectos
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvProspectos = new System.Windows.Forms.DataGridView();
			this.btnCrear = new System.Windows.Forms.Button();
			this.btnVer = new System.Windows.Forms.Button();
			this.btnEvaluar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvProspectos)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvProspectos
			// 
			this.dgvProspectos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Coral;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProspectos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvProspectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tomato;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvProspectos.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvProspectos.Location = new System.Drawing.Point(27, 96);
			this.dgvProspectos.Name = "dgvProspectos";
			this.dgvProspectos.ReadOnly = true;
			this.dgvProspectos.RowTemplate.Height = 24;
			this.dgvProspectos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProspectos.Size = new System.Drawing.Size(859, 507);
			this.dgvProspectos.TabIndex = 0;
			this.dgvProspectos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProspectos_CellContentClick);
			// 
			// btnCrear
			// 
			this.btnCrear.BackColor = System.Drawing.Color.LawnGreen;
			this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCrear.Location = new System.Drawing.Point(27, 29);
			this.btnCrear.Name = "btnCrear";
			this.btnCrear.Size = new System.Drawing.Size(220, 37);
			this.btnCrear.TabIndex = 5;
			this.btnCrear.Text = "Agregar nuevo";
			this.btnCrear.UseVisualStyleBackColor = false;
			this.btnCrear.UseWaitCursor = true;
			this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
			// 
			// btnVer
			// 
			this.btnVer.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVer.Location = new System.Drawing.Point(630, 29);
			this.btnVer.Name = "btnVer";
			this.btnVer.Size = new System.Drawing.Size(220, 37);
			this.btnVer.TabIndex = 6;
			this.btnVer.Text = "Ver prospecto";
			this.btnVer.UseVisualStyleBackColor = false;
			this.btnVer.UseWaitCursor = true;
			this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
			// 
			// btnEvaluar
			// 
			this.btnEvaluar.BackColor = System.Drawing.Color.DimGray;
			this.btnEvaluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEvaluar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnEvaluar.Location = new System.Drawing.Point(921, 179);
			this.btnEvaluar.Name = "btnEvaluar";
			this.btnEvaluar.Size = new System.Drawing.Size(220, 43);
			this.btnEvaluar.TabIndex = 7;
			this.btnEvaluar.Text = "Evaluar";
			this.btnEvaluar.UseVisualStyleBackColor = false;
			this.btnEvaluar.UseWaitCursor = true;
			this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
			// 
			// Prospectos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.ClientSize = new System.Drawing.Size(1178, 649);
			this.Controls.Add(this.btnEvaluar);
			this.Controls.Add(this.btnVer);
			this.Controls.Add(this.btnCrear);
			this.Controls.Add(this.dgvProspectos);
			this.Name = "Prospectos";
			this.Text = "Prospectos";
			this.Load += new System.EventHandler(this.Prospectos_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvProspectos)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvProspectos;
		private System.Windows.Forms.Button btnCrear;
		private System.Windows.Forms.Button btnVer;
		private System.Windows.Forms.Button btnEvaluar;
	}
}