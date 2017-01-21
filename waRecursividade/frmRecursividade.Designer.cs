namespace waRecursividade
{
    partial class frmRecursividade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecursividade));
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblFonte = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblNumeroFinal = new System.Windows.Forms.Label();
            this.nudNumeroFinal = new System.Windows.Forms.NumericUpDown();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.Location = new System.Drawing.Point(12, 9);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(408, 69);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = resources.GetString("lblDescricao.Text");
            // 
            // lblFonte
            // 
            this.lblFonte.Location = new System.Drawing.Point(12, 78);
            this.lblFonte.Name = "lblFonte";
            this.lblFonte.Size = new System.Drawing.Size(408, 17);
            this.lblFonte.TabIndex = 1;
            this.lblFonte.Text = "Fonte: http://wiki.icmc.usp.br/images/2/26/Aula_recursividade.pdf";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(345, 197);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "&Calcula";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblNumeroFinal
            // 
            this.lblNumeroFinal.AutoSize = true;
            this.lblNumeroFinal.Location = new System.Drawing.Point(12, 202);
            this.lblNumeroFinal.Name = "lblNumeroFinal";
            this.lblNumeroFinal.Size = new System.Drawing.Size(143, 13);
            this.lblNumeroFinal.TabIndex = 3;
            this.lblNumeroFinal.Text = "Número Final - Final Number:";
            // 
            // nudNumeroFinal
            // 
            this.nudNumeroFinal.Location = new System.Drawing.Point(192, 200);
            this.nudNumeroFinal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumeroFinal.Name = "nudNumeroFinal";
            this.nudNumeroFinal.Size = new System.Drawing.Size(58, 20);
            this.nudNumeroFinal.TabIndex = 5;
            this.nudNumeroFinal.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lstResultado
            // 
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(15, 226);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(235, 342);
            this.lstResultado.TabIndex = 6;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(320, 226);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 7;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(256, 229);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(40, 13);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Result:";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(12, 113);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(408, 58);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Source: http://wiki.icmc.usp.br/images/2/26/Aula_recursividade.pdf";
            // 
            // frmRecursividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 573);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.nudNumeroFinal);
            this.Controls.Add(this.lblNumeroFinal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblFonte);
            this.Controls.Add(this.lblDescricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRecursividade";
            this.ShowIcon = false;
            this.Text = "Recursividade - Recursion";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblFonte;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblNumeroFinal;
        private System.Windows.Forms.NumericUpDown nudNumeroFinal;
        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label1;
    }
}

