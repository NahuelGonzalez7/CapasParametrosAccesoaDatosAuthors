
namespace WindowsPubs
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
            this.gridListAuthor = new System.Windows.Forms.DataGridView();
            this.btnTraerPorCiudad = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.lblTraerPorCiudad = new System.Windows.Forms.Label();
            this.txtTraerPorCiudad = new System.Windows.Forms.TextBox();
            this.lblTraerxCiudadyEstado = new System.Windows.Forms.Label();
            this.txtBusquedaStateCity = new System.Windows.Forms.TextBox();
            this.txtBusquedaCityState = new System.Windows.Forms.TextBox();
            this.btnTraerCityState = new System.Windows.Forms.Button();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.lblBuscarCiudad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridListAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // gridListAuthor
            // 
            this.gridListAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListAuthor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridListAuthor.Location = new System.Drawing.Point(0, 206);
            this.gridListAuthor.Name = "gridListAuthor";
            this.gridListAuthor.Size = new System.Drawing.Size(1220, 244);
            this.gridListAuthor.TabIndex = 0;
            // 
            // btnTraerPorCiudad
            // 
            this.btnTraerPorCiudad.Location = new System.Drawing.Point(248, 52);
            this.btnTraerPorCiudad.Name = "btnTraerPorCiudad";
            this.btnTraerPorCiudad.Size = new System.Drawing.Size(117, 23);
            this.btnTraerPorCiudad.TabIndex = 1;
            this.btnTraerPorCiudad.Text = "Traer Por Ciudad";
            this.btnTraerPorCiudad.UseVisualStyleBackColor = true;
            this.btnTraerPorCiudad.Click += new System.EventHandler(this.btnTraerPorCiudad_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(960, 89);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(248, 99);
            this.btnMostrarTodos.TabIndex = 2;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // lblTraerPorCiudad
            // 
            this.lblTraerPorCiudad.AutoSize = true;
            this.lblTraerPorCiudad.Location = new System.Drawing.Point(40, 62);
            this.lblTraerPorCiudad.Name = "lblTraerPorCiudad";
            this.lblTraerPorCiudad.Size = new System.Drawing.Size(86, 13);
            this.lblTraerPorCiudad.TabIndex = 3;
            this.lblTraerPorCiudad.Text = "Traer por Ciudad";
            // 
            // txtTraerPorCiudad
            // 
            this.txtTraerPorCiudad.Location = new System.Drawing.Point(142, 55);
            this.txtTraerPorCiudad.Name = "txtTraerPorCiudad";
            this.txtTraerPorCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtTraerPorCiudad.TabIndex = 4;
            // 
            // lblTraerxCiudadyEstado
            // 
            this.lblTraerxCiudadyEstado.AutoSize = true;
            this.lblTraerxCiudadyEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraerxCiudadyEstado.Location = new System.Drawing.Point(39, 115);
            this.lblTraerxCiudadyEstado.Name = "lblTraerxCiudadyEstado";
            this.lblTraerxCiudadyEstado.Size = new System.Drawing.Size(230, 24);
            this.lblTraerxCiudadyEstado.TabIndex = 5;
            this.lblTraerxCiudadyEstado.Text = "Traer por Ciudad y Estado";
            // 
            // txtBusquedaStateCity
            // 
            this.txtBusquedaStateCity.Location = new System.Drawing.Point(149, 168);
            this.txtBusquedaStateCity.Name = "txtBusquedaStateCity";
            this.txtBusquedaStateCity.Size = new System.Drawing.Size(100, 20);
            this.txtBusquedaStateCity.TabIndex = 6;
            // 
            // txtBusquedaCityState
            // 
            this.txtBusquedaCityState.Location = new System.Drawing.Point(43, 168);
            this.txtBusquedaCityState.Name = "txtBusquedaCityState";
            this.txtBusquedaCityState.Size = new System.Drawing.Size(100, 20);
            this.txtBusquedaCityState.TabIndex = 7;
            // 
            // btnTraerCityState
            // 
            this.btnTraerCityState.Location = new System.Drawing.Point(255, 151);
            this.btnTraerCityState.Name = "btnTraerCityState";
            this.btnTraerCityState.Size = new System.Drawing.Size(147, 37);
            this.btnTraerCityState.TabIndex = 8;
            this.btnTraerCityState.Text = "Traer Por Ciudad y Estado";
            this.btnTraerCityState.UseVisualStyleBackColor = true;
            this.btnTraerCityState.Click += new System.EventHandler(this.btnTraerCityState_Click);
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(65, 152);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 9;
            this.lblCiudad.Text = "Ciudad";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(181, 152);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado";
            // 
            // cbCiudad
            // 
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(521, 52);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(268, 21);
            this.cbCiudad.TabIndex = 11;
//            this.cbCiudad.SelectedIndexChanged += new System.EventHandler(this.cbCiudad_SelectedIndexChanged);
            this.cbCiudad.SelectionChangeCommitted += new System.EventHandler(this.cbCiudad_SelectionChangeCommitted);
            // 
            // lblBuscarCiudad
            // 
            this.lblBuscarCiudad.AutoSize = true;
            this.lblBuscarCiudad.Location = new System.Drawing.Point(420, 60);
            this.lblBuscarCiudad.Name = "lblBuscarCiudad";
            this.lblBuscarCiudad.Size = new System.Drawing.Size(86, 13);
            this.lblBuscarCiudad.TabIndex = 12;
            this.lblBuscarCiudad.Text = "Filtrar por Ciudad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 450);
            this.Controls.Add(this.lblBuscarCiudad);
            this.Controls.Add(this.cbCiudad);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.btnTraerCityState);
            this.Controls.Add(this.txtBusquedaCityState);
            this.Controls.Add(this.txtBusquedaStateCity);
            this.Controls.Add(this.lblTraerxCiudadyEstado);
            this.Controls.Add(this.txtTraerPorCiudad);
            this.Controls.Add(this.lblTraerPorCiudad);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnTraerPorCiudad);
            this.Controls.Add(this.gridListAuthor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridListAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridListAuthor;
        private System.Windows.Forms.Button btnTraerPorCiudad;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Label lblTraerPorCiudad;
        private System.Windows.Forms.TextBox txtTraerPorCiudad;
        private System.Windows.Forms.Label lblTraerxCiudadyEstado;
        private System.Windows.Forms.TextBox txtBusquedaStateCity;
        private System.Windows.Forms.TextBox txtBusquedaCityState;
        private System.Windows.Forms.Button btnTraerCityState;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.Label lblBuscarCiudad;
    }
}

