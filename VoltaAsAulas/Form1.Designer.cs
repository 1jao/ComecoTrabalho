namespace VoltaAsAulas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btmnetflix = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.lblnum = new System.Windows.Forms.Label();
            this.TxtNum = new System.Windows.Forms.TextBox();
            this.TxtCard = new System.Windows.Forms.TextBox();
            this.lblcard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btmnetflix
            // 
            this.btmnetflix.BackgroundImage = global::VoltaAsAulas.Properties.Resources.Metflix;
            this.btmnetflix.ForeColor = System.Drawing.Color.Crimson;
            this.btmnetflix.Location = new System.Drawing.Point(347, 237);
            this.btmnetflix.Name = "btmnetflix";
            this.btmnetflix.Size = new System.Drawing.Size(823, 325);
            this.btmnetflix.TabIndex = 0;
            this.btmnetflix.Text = "netflix";
            this.btmnetflix.UseVisualStyleBackColor = true;
            this.btmnetflix.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.ForeColor = System.Drawing.Color.Black;
            this.lblname.Location = new System.Drawing.Point(344, 106);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(42, 13);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "NOME:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(338, 122);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(130, 20);
            this.TxtName.TabIndex = 2;
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.ForeColor = System.Drawing.Color.Black;
            this.lblnum.Location = new System.Drawing.Point(344, 145);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(55, 13);
            this.lblnum.TabIndex = 3;
            this.lblnum.Text = "NÚMERO";
            // 
            // TxtNum
            // 
            this.TxtNum.Location = new System.Drawing.Point(338, 161);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.Size = new System.Drawing.Size(130, 20);
            this.TxtNum.TabIndex = 4;
            // 
            // TxtCard
            // 
            this.TxtCard.Location = new System.Drawing.Point(338, 203);
            this.TxtCard.Name = "TxtCard";
            this.TxtCard.Size = new System.Drawing.Size(130, 20);
            this.TxtCard.TabIndex = 5;
            // 
            // lblcard
            // 
            this.lblcard.AutoSize = true;
            this.lblcard.ForeColor = System.Drawing.Color.Black;
            this.lblcard.Location = new System.Drawing.Point(338, 184);
            this.lblcard.Name = "lblcard";
            this.lblcard.Size = new System.Drawing.Size(132, 13);
            this.lblcard.TabIndex = 6;
            this.lblcard.Text = "CARTÃO DE CREDITO =)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1487, 826);
            this.Controls.Add(this.lblcard);
            this.Controls.Add(this.TxtCard);
            this.Controls.Add(this.TxtNum);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btmnetflix);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Name = "Form1";
            this.Text = "netnet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmnetflix;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.TextBox TxtNum;
        private System.Windows.Forms.TextBox TxtCard;
        private System.Windows.Forms.Label lblcard;
    }
}

