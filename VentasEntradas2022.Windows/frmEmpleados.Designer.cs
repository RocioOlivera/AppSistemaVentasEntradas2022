
namespace VentasEntradas2022.Windows
{
    partial class frmEmpleados
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnBORRAR = new System.Windows.Forms.Button();
            this.btnEDITAR = new System.Windows.Forms.Button();
            this.btnNUEVO = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.cmnApellidoYNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnTipoDeDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnNroDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnTelFijo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnTelMovil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnBORRAR);
            this.splitContainer1.Panel1.Controls.Add(this.btnEDITAR);
            this.splitContainer1.Panel1.Controls.Add(this.btnNUEVO);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDatos);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 94;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnBORRAR
            // 
            this.btnBORRAR.Location = new System.Drawing.Point(615, 29);
            this.btnBORRAR.Name = "btnBORRAR";
            this.btnBORRAR.Size = new System.Drawing.Size(122, 50);
            this.btnBORRAR.TabIndex = 2;
            this.btnBORRAR.Text = "BORRAR";
            this.btnBORRAR.UseVisualStyleBackColor = true;
            this.btnBORRAR.Click += new System.EventHandler(this.btnBORRAR_Click);
            // 
            // btnEDITAR
            // 
            this.btnEDITAR.Location = new System.Drawing.Point(345, 29);
            this.btnEDITAR.Name = "btnEDITAR";
            this.btnEDITAR.Size = new System.Drawing.Size(122, 50);
            this.btnEDITAR.TabIndex = 1;
            this.btnEDITAR.Text = "EDITAR";
            this.btnEDITAR.UseVisualStyleBackColor = true;
            this.btnEDITAR.Click += new System.EventHandler(this.btnEDITAR_Click);
            // 
            // btnNUEVO
            // 
            this.btnNUEVO.Location = new System.Drawing.Point(55, 29);
            this.btnNUEVO.Name = "btnNUEVO";
            this.btnNUEVO.Size = new System.Drawing.Size(122, 50);
            this.btnNUEVO.TabIndex = 0;
            this.btnNUEVO.Text = "NUEVO";
            this.btnNUEVO.UseVisualStyleBackColor = true;
            this.btnNUEVO.Click += new System.EventHandler(this.btnNUEVO_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnApellidoYNombres,
            this.cmnTipoDeDoc,
            this.cmnNroDoc,
            this.cmnTelFijo,
            this.cmnTelMovil,
            this.cmnCorreo,
            this.cmnActivo});
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 0);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(800, 352);
            this.dgvDatos.TabIndex = 0;
            // 
            // cmnApellidoYNombres
            // 
            this.cmnApellidoYNombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnApellidoYNombres.HeaderText = "Apellido y Nombres";
            this.cmnApellidoYNombres.MinimumWidth = 6;
            this.cmnApellidoYNombres.Name = "cmnApellidoYNombres";
            this.cmnApellidoYNombres.ReadOnly = true;
            // 
            // cmnTipoDeDoc
            // 
            this.cmnTipoDeDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnTipoDeDoc.HeaderText = "Tipo de Doc.";
            this.cmnTipoDeDoc.MinimumWidth = 6;
            this.cmnTipoDeDoc.Name = "cmnTipoDeDoc";
            this.cmnTipoDeDoc.ReadOnly = true;
            // 
            // cmnNroDoc
            // 
            this.cmnNroDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnNroDoc.HeaderText = "Num. Documento";
            this.cmnNroDoc.MinimumWidth = 6;
            this.cmnNroDoc.Name = "cmnNroDoc";
            this.cmnNroDoc.ReadOnly = true;
            // 
            // cmnTelFijo
            // 
            this.cmnTelFijo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnTelFijo.HeaderText = "Tel. Fijo";
            this.cmnTelFijo.MinimumWidth = 6;
            this.cmnTelFijo.Name = "cmnTelFijo";
            this.cmnTelFijo.ReadOnly = true;
            // 
            // cmnTelMovil
            // 
            this.cmnTelMovil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnTelMovil.HeaderText = "Tel. Móvil";
            this.cmnTelMovil.MinimumWidth = 6;
            this.cmnTelMovil.Name = "cmnTelMovil";
            this.cmnTelMovil.ReadOnly = true;
            // 
            // cmnCorreo
            // 
            this.cmnCorreo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnCorreo.HeaderText = "Correo electrónico";
            this.cmnCorreo.MinimumWidth = 6;
            this.cmnCorreo.Name = "cmnCorreo";
            this.cmnCorreo.ReadOnly = true;
            // 
            // cmnActivo
            // 
            this.cmnActivo.HeaderText = "Activo";
            this.cmnActivo.MinimumWidth = 6;
            this.cmnActivo.Name = "cmnActivo";
            this.cmnActivo.ReadOnly = true;
            this.cmnActivo.Width = 125;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmEmpleados";
            this.Text = "Empleados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnBORRAR;
        private System.Windows.Forms.Button btnEDITAR;
        private System.Windows.Forms.Button btnNUEVO;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnApellidoYNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnTipoDeDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnNroDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnTelFijo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnTelMovil;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnActivo;
    }
}

