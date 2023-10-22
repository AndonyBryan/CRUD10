namespace CRUD10
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
            this.txtagregar = new System.Windows.Forms.Button();
            this.txtactualizar = new System.Windows.Forms.Button();
            this.txteliminar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textmatricula = new System.Windows.Forms.TextBox();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textcarrera = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtagregar
            // 
            this.txtagregar.Location = new System.Drawing.Point(30, 149);
            this.txtagregar.Name = "txtagregar";
            this.txtagregar.Size = new System.Drawing.Size(75, 23);
            this.txtagregar.TabIndex = 0;
            this.txtagregar.Text = "Agregar";
            this.txtagregar.UseVisualStyleBackColor = true;
            this.txtagregar.Click += new System.EventHandler(this.txtagregar_Click);
            // 
            // txtactualizar
            // 
            this.txtactualizar.Location = new System.Drawing.Point(121, 149);
            this.txtactualizar.Name = "txtactualizar";
            this.txtactualizar.Size = new System.Drawing.Size(75, 23);
            this.txtactualizar.TabIndex = 1;
            this.txtactualizar.Text = "Actualizar";
            this.txtactualizar.UseVisualStyleBackColor = true;
            this.txtactualizar.Click += new System.EventHandler(this.txtactualizar_Click);
            // 
            // txteliminar
            // 
            this.txteliminar.Location = new System.Drawing.Point(30, 196);
            this.txteliminar.Name = "txteliminar";
            this.txteliminar.Size = new System.Drawing.Size(75, 23);
            this.txteliminar.TabIndex = 2;
            this.txteliminar.Text = "Eliminar";
            this.txteliminar.UseVisualStyleBackColor = true;
            this.txteliminar.Click += new System.EventHandler(this.txteliminar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(121, 196);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(75, 23);
            this.txtbuscar.TabIndex = 3;
            this.txtbuscar.Text = "Buscar";
            this.txtbuscar.UseVisualStyleBackColor = true;
            this.txtbuscar.Click += new System.EventHandler(this.txtbuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // textmatricula
            // 
            this.textmatricula.Location = new System.Drawing.Point(100, 26);
            this.textmatricula.Name = "textmatricula";
            this.textmatricula.Size = new System.Drawing.Size(147, 20);
            this.textmatricula.TabIndex = 6;
            // 
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(100, 52);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(147, 20);
            this.textnombre.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Carrera";
            // 
            // textcarrera
            // 
            this.textcarrera.Location = new System.Drawing.Point(100, 86);
            this.textcarrera.Name = "textcarrera";
            this.textcarrera.Size = new System.Drawing.Size(147, 20);
            this.textcarrera.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(277, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(365, 193);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textcarrera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textnombre);
            this.Controls.Add(this.textmatricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.txteliminar);
            this.Controls.Add(this.txtactualizar);
            this.Controls.Add(this.txtagregar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtagregar;
        private System.Windows.Forms.Button txtactualizar;
        private System.Windows.Forms.Button txteliminar;
        private System.Windows.Forms.Button txtbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textmatricula;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textcarrera;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}

