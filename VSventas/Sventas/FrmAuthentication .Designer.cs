namespace Sventas
{
    partial class Authentication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentication));
            this.pcontiene = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbView = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pcontiene.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcontiene
            // 
            this.pcontiene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(196)))), ((int)(((byte)(213)))));
            this.pcontiene.Controls.Add(this.progressBar1);
            this.pcontiene.Controls.Add(this.btnCancelar);
            this.pcontiene.Controls.Add(this.btnAceptar);
            this.pcontiene.Controls.Add(this.txtPass);
            this.pcontiene.Controls.Add(this.txtUser);
            this.pcontiene.Controls.Add(this.flowLayoutPanel3);
            this.pcontiene.Controls.Add(this.flowLayoutPanel2);
            this.pcontiene.Controls.Add(this.flowLayoutPanel1);
            this.pcontiene.Controls.Add(this.cbView);
            this.pcontiene.Controls.Add(this.label2);
            this.pcontiene.Dock = System.Windows.Forms.DockStyle.Right;
            this.pcontiene.Location = new System.Drawing.Point(270, 0);
            this.pcontiene.Name = "pcontiene";
            this.pcontiene.Size = new System.Drawing.Size(489, 496);
            this.pcontiene.TabIndex = 0;
            this.pcontiene.Paint += new System.Windows.Forms.PaintEventHandler(this.pcontiene_Paint);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(68, 227);
            this.txtPass.Name = "txtPass";
            this.txtPass.ShortcutsEnabled = false;
            this.txtPass.Size = new System.Drawing.Size(372, 30);
            this.txtPass.TabIndex = 7;
            this.txtPass.Text = "Contraseña";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(68, 154);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(372, 30);
            this.txtUser.TabIndex = 6;
            this.txtUser.Text = "Usuario";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(68, 256);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(372, 1);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(68, 183);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(372, 1);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(78, 210);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(330, 1);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // cbView
            // 
            this.cbView.AutoSize = true;
            this.cbView.ForeColor = System.Drawing.Color.Black;
            this.cbView.Location = new System.Drawing.Point(388, 278);
            this.cbView.Name = "cbView";
            this.cbView.Size = new System.Drawing.Size(89, 24);
            this.cbView.TabIndex = 3;
            this.cbView.Text = "Mostrar";
            this.cbView.UseVisualStyleBackColor = true;
            this.cbView.CheckedChanged += new System.EventHandler(this.cbView_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(110, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Autenticación";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sventas";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 496);
            this.panel2.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.White;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(68, 333);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(168, 40);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(272, 333);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(168, 40);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(68, 423);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(372, 38);
            this.progressBar1.TabIndex = 9;
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(759, 496);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pcontiene);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Authentication";
            this.Text = "FrmAuthentication";
            this.pcontiene.ResumeLayout(false);
            this.pcontiene.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pcontiene;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox cbView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnCancelar;
    }
}