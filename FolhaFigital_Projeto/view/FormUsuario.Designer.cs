namespace FolhaFigital_Projeto.view
{
    partial class FormUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtExcluir = new System.Windows.Forms.Button();
            this.BtAlterar = new System.Windows.Forms.Button();
            this.btInserir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.BtExcluir);
            this.panel1.Controls.Add(this.BtAlterar);
            this.panel1.Controls.Add(this.btInserir);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 642);
            this.panel1.TabIndex = 0;
            // 
            // BtExcluir
            // 
            this.BtExcluir.BackColor = System.Drawing.Color.Silver;
            this.BtExcluir.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtExcluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtExcluir.Location = new System.Drawing.Point(53, 367);
            this.BtExcluir.Name = "BtExcluir";
            this.BtExcluir.Size = new System.Drawing.Size(126, 46);
            this.BtExcluir.TabIndex = 11;
            this.BtExcluir.Text = "Excluir";
            this.BtExcluir.UseVisualStyleBackColor = false;
            // 
            // BtAlterar
            // 
            this.BtAlterar.BackColor = System.Drawing.Color.Silver;
            this.BtAlterar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAlterar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtAlterar.Location = new System.Drawing.Point(53, 293);
            this.BtAlterar.Name = "BtAlterar";
            this.BtAlterar.Size = new System.Drawing.Size(126, 46);
            this.BtAlterar.TabIndex = 10;
            this.BtAlterar.Text = "Alterar";
            this.BtAlterar.UseVisualStyleBackColor = false;
            // 
            // btInserir
            // 
            this.btInserir.BackColor = System.Drawing.Color.Silver;
            this.btInserir.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInserir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btInserir.Location = new System.Drawing.Point(53, 215);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(126, 46);
            this.btInserir.TabIndex = 9;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(266, 384);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(913, 177);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 642);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtExcluir;
        private System.Windows.Forms.Button BtAlterar;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.ListView listView1;
    }
}