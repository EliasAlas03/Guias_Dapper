﻿namespace DapperDemo_Programacion2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnObtenerTodos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxOBtenerID = new System.Windows.Forms.TextBox();
            this.btnObtenerId = new System.Windows.Forms.Button();
            this.txbCustomerId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCompanyName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbContactName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbContactTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(9, 23);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(746, 210);
            this.dgvCustomers.TabIndex = 0;
            // 
            // btnObtenerTodos
            // 
            this.btnObtenerTodos.BackColor = System.Drawing.Color.White;
            this.btnObtenerTodos.Location = new System.Drawing.Point(615, 249);
            this.btnObtenerTodos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnObtenerTodos.Name = "btnObtenerTodos";
            this.btnObtenerTodos.Size = new System.Drawing.Size(77, 41);
            this.btnObtenerTodos.TabIndex = 1;
            this.btnObtenerTodos.Text = "Obtener Todos";
            this.btnObtenerTodos.UseVisualStyleBackColor = false;
            this.btnObtenerTodos.Click += new System.EventHandler(this.btnObtenerTodos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 263);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 265);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id Cliente";
            // 
            // tboxOBtenerID
            // 
            this.tboxOBtenerID.Location = new System.Drawing.Point(120, 261);
            this.tboxOBtenerID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboxOBtenerID.Name = "tboxOBtenerID";
            this.tboxOBtenerID.Size = new System.Drawing.Size(112, 20);
            this.tboxOBtenerID.TabIndex = 4;
            // 
            // btnObtenerId
            // 
            this.btnObtenerId.BackColor = System.Drawing.Color.Bisque;
            this.btnObtenerId.Location = new System.Drawing.Point(257, 254);
            this.btnObtenerId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnObtenerId.Name = "btnObtenerId";
            this.btnObtenerId.Size = new System.Drawing.Size(68, 40);
            this.btnObtenerId.TabIndex = 5;
            this.btnObtenerId.Text = "Buscar";
            this.btnObtenerId.UseVisualStyleBackColor = false;
            this.btnObtenerId.Click += new System.EventHandler(this.btnObtenerId_Click);
            // 
            // txbCustomerId
            // 
            this.txbCustomerId.Location = new System.Drawing.Point(138, 324);
            this.txbCustomerId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbCustomerId.Name = "txbCustomerId";
            this.txbCustomerId.Size = new System.Drawing.Size(157, 20);
            this.txbCustomerId.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 331);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CustomerID";
            // 
            // txbCompanyName
            // 
            this.txbCompanyName.Location = new System.Drawing.Point(561, 351);
            this.txbCompanyName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbCompanyName.Name = "txbCompanyName";
            this.txbCompanyName.Size = new System.Drawing.Size(157, 20);
            this.txbCompanyName.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(478, 353);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Company Name";
            // 
            // txbContactName
            // 
            this.txbContactName.Location = new System.Drawing.Point(561, 374);
            this.txbContactName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbContactName.Name = "txbContactName";
            this.txbContactName.Size = new System.Drawing.Size(157, 20);
            this.txbContactName.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 376);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Contact Name";
            // 
            // txbContactTitle
            // 
            this.txbContactTitle.Location = new System.Drawing.Point(561, 396);
            this.txbContactTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbContactTitle.Name = "txbContactTitle";
            this.txbContactTitle.Size = new System.Drawing.Size(157, 20);
            this.txbContactTitle.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(496, 399);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Contact Title";
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(561, 419);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(157, 20);
            this.txbAddress.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(513, 422);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Address";
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnInsertar.Location = new System.Drawing.Point(377, 254);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(68, 40);
            this.btnInsertar.TabIndex = 27;
            this.btnInsertar.Text = "Insertar Cliente";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.BlueViolet;
            this.btnActualizar.Location = new System.Drawing.Point(388, 370);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(68, 40);
            this.btnActualizar.TabIndex = 28;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.Location = new System.Drawing.Point(388, 423);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(68, 40);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(764, 491);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbContactTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbContactName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbCompanyName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbCustomerId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnObtenerId);
            this.Controls.Add(this.tboxOBtenerID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObtenerTodos);
            this.Controls.Add(this.dgvCustomers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Dapper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnObtenerTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxOBtenerID;
        private System.Windows.Forms.Button btnObtenerId;
        private System.Windows.Forms.TextBox txbCustomerId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCompanyName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbContactName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbContactTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

