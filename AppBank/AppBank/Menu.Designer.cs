
namespace AppBank
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.convertBtn = new System.Windows.Forms.Button();
            this.verserBtn = new System.Windows.Forms.Button();
            this.debiterBtn = new System.Windows.Forms.Button();
            this.crediterBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nvclientBtn = new System.Windows.Forms.Button();
            this.consulterBtn = new System.Windows.Forms.Button();
            this.creationBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nbrClt = new System.Windows.Forms.Label();
            this.nbrCpt = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nbrCpt);
            this.groupBox1.Controls.Add(this.nbrClt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.convertBtn);
            this.groupBox3.Controls.Add(this.verserBtn);
            this.groupBox3.Controls.Add(this.debiterBtn);
            this.groupBox3.Controls.Add(this.crediterBtn);
            this.groupBox3.Location = new System.Drawing.Point(136, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(124, 186);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opérations";
            // 
            // convertBtn
            // 
            this.convertBtn.Location = new System.Drawing.Point(6, 136);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(106, 33);
            this.convertBtn.TabIndex = 3;
            this.convertBtn.Text = "Convertisseur";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // verserBtn
            // 
            this.verserBtn.Location = new System.Drawing.Point(6, 97);
            this.verserBtn.Name = "verserBtn";
            this.verserBtn.Size = new System.Drawing.Size(106, 33);
            this.verserBtn.TabIndex = 2;
            this.verserBtn.Text = "Verser";
            this.verserBtn.UseVisualStyleBackColor = true;
            this.verserBtn.Click += new System.EventHandler(this.verserBtn_Click);
            // 
            // debiterBtn
            // 
            this.debiterBtn.Location = new System.Drawing.Point(6, 58);
            this.debiterBtn.Name = "debiterBtn";
            this.debiterBtn.Size = new System.Drawing.Size(106, 33);
            this.debiterBtn.TabIndex = 1;
            this.debiterBtn.Text = "Débiter";
            this.debiterBtn.UseVisualStyleBackColor = true;
            this.debiterBtn.Click += new System.EventHandler(this.debiterBtn_Click);
            // 
            // crediterBtn
            // 
            this.crediterBtn.Location = new System.Drawing.Point(6, 19);
            this.crediterBtn.Name = "crediterBtn";
            this.crediterBtn.Size = new System.Drawing.Size(106, 33);
            this.crediterBtn.TabIndex = 0;
            this.crediterBtn.Text = "Créditer";
            this.crediterBtn.UseVisualStyleBackColor = true;
            this.crediterBtn.Click += new System.EventHandler(this.crediterBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nvclientBtn);
            this.groupBox2.Controls.Add(this.consulterBtn);
            this.groupBox2.Controls.Add(this.creationBtn);
            this.groupBox2.Location = new System.Drawing.Point(7, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comptes";
            // 
            // nvclientBtn
            // 
            this.nvclientBtn.Location = new System.Drawing.Point(6, 97);
            this.nvclientBtn.Name = "nvclientBtn";
            this.nvclientBtn.Size = new System.Drawing.Size(106, 33);
            this.nvclientBtn.TabIndex = 4;
            this.nvclientBtn.Text = "Nouveau client";
            this.nvclientBtn.UseVisualStyleBackColor = true;
            this.nvclientBtn.Click += new System.EventHandler(this.nvclientBtn_Click);
            // 
            // consulterBtn
            // 
            this.consulterBtn.Location = new System.Drawing.Point(6, 58);
            this.consulterBtn.Name = "consulterBtn";
            this.consulterBtn.Size = new System.Drawing.Size(106, 33);
            this.consulterBtn.TabIndex = 2;
            this.consulterBtn.Text = "Consulter";
            this.consulterBtn.UseVisualStyleBackColor = true;
            this.consulterBtn.Click += new System.EventHandler(this.consulterBtn_Click);
            // 
            // creationBtn
            // 
            this.creationBtn.Location = new System.Drawing.Point(6, 19);
            this.creationBtn.Name = "creationBtn";
            this.creationBtn.Size = new System.Drawing.Size(106, 33);
            this.creationBtn.TabIndex = 0;
            this.creationBtn.Text = "Création";
            this.creationBtn.UseVisualStyleBackColor = true;
            this.creationBtn.Click += new System.EventHandler(this.creationBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre Clients:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre Comptes:";
            // 
            // nbrClt
            // 
            this.nbrClt.AutoSize = true;
            this.nbrClt.Location = new System.Drawing.Point(95, 165);
            this.nbrClt.Name = "nbrClt";
            this.nbrClt.Size = new System.Drawing.Size(13, 13);
            this.nbrClt.TabIndex = 5;
            this.nbrClt.Text = "0";
            // 
            // nbrCpt
            // 
            this.nbrCpt.AutoSize = true;
            this.nbrCpt.Location = new System.Drawing.Point(107, 192);
            this.nbrCpt.Name = "nbrCpt";
            this.nbrCpt.Size = new System.Drawing.Size(13, 13);
            this.nbrCpt.TabIndex = 6;
            this.nbrCpt.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 223);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.Text = "AppBank";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button debiterBtn;
        private System.Windows.Forms.Button crediterBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.Button verserBtn;
        private System.Windows.Forms.Button consulterBtn;
        private System.Windows.Forms.Button nvclientBtn;
        private System.Windows.Forms.Button creationBtn;
        private System.Windows.Forms.Label nbrCpt;
        private System.Windows.Forms.Label nbrClt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

