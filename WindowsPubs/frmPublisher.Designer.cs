
namespace WindowsPubs
{
    partial class frmPublisher
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
            this.gridListPublishers = new System.Windows.Forms.DataGridView();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnTraerPorCiudad = new System.Windows.Forms.Button();
            this.btnTraerPorCiudadyEstado = new System.Windows.Forms.Button();
            this.btnTraerPorCiudadEstadoPais = new System.Windows.Forms.Button();
            this.lblCiudadEstadoPais = new System.Windows.Forms.Label();
            this.lblCityState = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtCityState = new System.Windows.Forms.TextBox();
            this.txtCityStateCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridListPublishers)).BeginInit();
            this.SuspendLayout();
            // 
            // gridListPublishers
            // 
            this.gridListPublishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListPublishers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridListPublishers.Location = new System.Drawing.Point(0, 107);
            this.gridListPublishers.Name = "gridListPublishers";
            this.gridListPublishers.Size = new System.Drawing.Size(1183, 343);
            this.gridListPublishers.TabIndex = 0;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(924, 12);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(247, 89);
            this.btnMostrarTodos.TabIndex = 1;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnTraerPorCiudad
            // 
            this.btnTraerPorCiudad.Location = new System.Drawing.Point(384, 12);
            this.btnTraerPorCiudad.Name = "btnTraerPorCiudad";
            this.btnTraerPorCiudad.Size = new System.Drawing.Size(192, 26);
            this.btnTraerPorCiudad.TabIndex = 2;
            this.btnTraerPorCiudad.Text = "Traer Por Ciudad";
            this.btnTraerPorCiudad.UseVisualStyleBackColor = true;
            this.btnTraerPorCiudad.Click += new System.EventHandler(this.btnTraerPorCiudad_Click);
            // 
            // btnTraerPorCiudadyEstado
            // 
            this.btnTraerPorCiudadyEstado.Location = new System.Drawing.Point(384, 43);
            this.btnTraerPorCiudadyEstado.Name = "btnTraerPorCiudadyEstado";
            this.btnTraerPorCiudadyEstado.Size = new System.Drawing.Size(192, 26);
            this.btnTraerPorCiudadyEstado.TabIndex = 3;
            this.btnTraerPorCiudadyEstado.Text = "Traer por Ciudad y Estado";
            this.btnTraerPorCiudadyEstado.UseVisualStyleBackColor = true;
            this.btnTraerPorCiudadyEstado.Click += new System.EventHandler(this.btnTraerPorCiudadyEstado_Click);
            // 
            // btnTraerPorCiudadEstadoPais
            // 
            this.btnTraerPorCiudadEstadoPais.Location = new System.Drawing.Point(384, 75);
            this.btnTraerPorCiudadEstadoPais.Name = "btnTraerPorCiudadEstadoPais";
            this.btnTraerPorCiudadEstadoPais.Size = new System.Drawing.Size(192, 26);
            this.btnTraerPorCiudadEstadoPais.TabIndex = 4;
            this.btnTraerPorCiudadEstadoPais.Text = "Traer por Ciudad, Estado y Pais";
            this.btnTraerPorCiudadEstadoPais.UseVisualStyleBackColor = true;
            this.btnTraerPorCiudadEstadoPais.Click += new System.EventHandler(this.btnTraerPorCiudadEstadoPais_Click);
            // 
            // lblCiudadEstadoPais
            // 
            this.lblCiudadEstadoPais.AutoSize = true;
            this.lblCiudadEstadoPais.Location = new System.Drawing.Point(53, 88);
            this.lblCiudadEstadoPais.Name = "lblCiudadEstadoPais";
            this.lblCiudadEstadoPais.Size = new System.Drawing.Size(107, 13);
            this.lblCiudadEstadoPais.TabIndex = 5;
            this.lblCiudadEstadoPais.Text = "Ciudad,Estado y Pais";
            // 
            // lblCityState
            // 
            this.lblCityState.AutoSize = true;
            this.lblCityState.Location = new System.Drawing.Point(53, 52);
            this.lblCityState.Name = "lblCityState";
            this.lblCityState.Size = new System.Drawing.Size(84, 13);
            this.lblCityState.TabIndex = 6;
            this.lblCityState.Text = "Ciudad y Estado";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(53, 23);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 7;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtCityState
            // 
            this.txtCityState.Location = new System.Drawing.Point(166, 45);
            this.txtCityState.Name = "txtCityState";
            this.txtCityState.Size = new System.Drawing.Size(212, 20);
            this.txtCityState.TabIndex = 8;
            // 
            // txtCityStateCountry
            // 
            this.txtCityStateCountry.Location = new System.Drawing.Point(166, 79);
            this.txtCityStateCountry.Name = "txtCityStateCountry";
            this.txtCityStateCountry.Size = new System.Drawing.Size(212, 20);
            this.txtCityStateCountry.TabIndex = 9;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(166, 16);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(212, 20);
            this.txtCity.TabIndex = 10;
            // 
            // frmPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 450);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtCityStateCountry);
            this.Controls.Add(this.txtCityState);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblCityState);
            this.Controls.Add(this.lblCiudadEstadoPais);
            this.Controls.Add(this.btnTraerPorCiudadEstadoPais);
            this.Controls.Add(this.btnTraerPorCiudadyEstado);
            this.Controls.Add(this.btnTraerPorCiudad);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.gridListPublishers);
            this.Name = "frmPublisher";
            this.Text = "frmPublisher";
            this.Load += new System.EventHandler(this.frmPublisher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridListPublishers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridListPublishers;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnTraerPorCiudad;
        private System.Windows.Forms.Button btnTraerPorCiudadyEstado;
        private System.Windows.Forms.Button btnTraerPorCiudadEstadoPais;
        private System.Windows.Forms.Label lblCiudadEstadoPais;
        private System.Windows.Forms.Label lblCityState;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtCityState;
        private System.Windows.Forms.TextBox txtCityStateCountry;
        private System.Windows.Forms.TextBox txtCity;
    }
}