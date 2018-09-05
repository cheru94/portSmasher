namespace portSmasher
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lstPorts = new System.Windows.Forms.ListBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarPort = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminarPort = new System.Windows.Forms.Button();
            this.btnSmash = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(139, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(50, 44);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(237, 20);
            this.txtHost.TabIndex = 1;
            this.txtHost.Leave += new System.EventHandler(this.txtHost_Leave);
            // 
            // lstPorts
            // 
            this.lstPorts.FormattingEnabled = true;
            this.lstPorts.Location = new System.Drawing.Point(91, 78);
            this.lstPorts.Name = "lstPorts";
            this.lstPorts.Size = new System.Drawing.Size(154, 238);
            this.lstPorts.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(91, 332);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(55, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(91, 40);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(145, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            // 
            // btnAgregarPort
            // 
            this.btnAgregarPort.Location = new System.Drawing.Point(208, 37);
            this.btnAgregarPort.Name = "btnAgregarPort";
            this.btnAgregarPort.Size = new System.Drawing.Size(37, 23);
            this.btnAgregarPort.TabIndex = 6;
            this.btnAgregarPort.Text = "+";
            this.btnAgregarPort.UseVisualStyleBackColor = true;
            this.btnAgregarPort.Click += new System.EventHandler(this.btnAgregarPort_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtHost);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 86);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnEliminarPort);
            this.panel2.Controls.Add(this.btnSmash);
            this.panel2.Controls.Add(this.btnAgregarPort);
            this.panel2.Controls.Add(this.txtPort);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.lstPorts);
            this.panel2.Location = new System.Drawing.Point(23, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 376);
            this.panel2.TabIndex = 8;
            // 
            // btnEliminarPort
            // 
            this.btnEliminarPort.Location = new System.Drawing.Point(273, 175);
            this.btnEliminarPort.Name = "btnEliminarPort";
            this.btnEliminarPort.Size = new System.Drawing.Size(37, 23);
            this.btnEliminarPort.TabIndex = 8;
            this.btnEliminarPort.Text = "-";
            this.btnEliminarPort.UseVisualStyleBackColor = true;
            this.btnEliminarPort.Click += new System.EventHandler(this.btnEliminarPort_Click);
            // 
            // btnSmash
            // 
            this.btnSmash.Location = new System.Drawing.Point(190, 332);
            this.btnSmash.Name = "btnSmash";
            this.btnSmash.Size = new System.Drawing.Size(55, 23);
            this.btnSmash.TabIndex = 7;
            this.btnSmash.Text = "Smash";
            this.btnSmash.UseVisualStyleBackColor = true;
            this.btnSmash.Click += new System.EventHandler(this.btnSmash_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::portSmasher.Properties.Resources._5;
            this.ClientSize = new System.Drawing.Size(410, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Port Smasher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.ListBox lstPorts;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarPort;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSmash;
        private System.Windows.Forms.Button btnEliminarPort;
    }
}

