
namespace AppBank.Forms.Compte
{
    partial class NvClient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addrtextBox = new System.Windows.Forms.TextBox();
            this.prenomtextBox = new System.Windows.Forms.TextBox();
            this.nomtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 191);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Création d\'un client";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(191, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 33);
            this.button3.TabIndex = 7;
            this.button3.Text = "Annuler";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Quitter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Créer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addrtextBox);
            this.groupBox3.Controls.Add(this.prenomtextBox);
            this.groupBox3.Controls.Add(this.nomtextBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 122);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informations personnel:";
            // 
            // addrtextBox
            // 
            this.addrtextBox.Location = new System.Drawing.Point(19, 82);
            this.addrtextBox.Name = "addrtextBox";
            this.addrtextBox.Size = new System.Drawing.Size(280, 20);
            this.addrtextBox.TabIndex = 5;
            // 
            // prenomtextBox
            // 
            this.prenomtextBox.Location = new System.Drawing.Point(190, 43);
            this.prenomtextBox.Name = "prenomtextBox";
            this.prenomtextBox.Size = new System.Drawing.Size(109, 20);
            this.prenomtextBox.TabIndex = 4;
            // 
            // nomtextBox
            // 
            this.nomtextBox.Location = new System.Drawing.Point(19, 43);
            this.nomtextBox.Name = "nomtextBox";
            this.nomtextBox.Size = new System.Drawing.Size(109, 20);
            this.nomtextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prénom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresse:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom:";
            // 
            // NvClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 212);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "NvClient";
            this.ShowIcon = false;
            this.Text = "NvClient";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox addrtextBox;
        private System.Windows.Forms.TextBox prenomtextBox;
        private System.Windows.Forms.TextBox nomtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}