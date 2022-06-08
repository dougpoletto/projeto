namespace Sistema
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPageAtivos = new System.Windows.Forms.TabPage();
            this.buttonTeste = new System.Windows.Forms.Button();
            this.tabPrincipal.SuspendLayout();
            this.tabPageAtivos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabPageAtivos);
            this.tabPrincipal.Location = new System.Drawing.Point(8, 8);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(786, 306);
            this.tabPrincipal.TabIndex = 0;
            this.tabPrincipal.SelectedIndexChanged += new System.EventHandler(this.tabPrincipal_SelectedIndexChanged);
            // 
            // tabPageAtivos
            // 
            this.tabPageAtivos.Controls.Add(this.buttonTeste);
            this.tabPageAtivos.Location = new System.Drawing.Point(4, 24);
            this.tabPageAtivos.Name = "tabPageAtivos";
            this.tabPageAtivos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAtivos.Size = new System.Drawing.Size(778, 278);
            this.tabPageAtivos.TabIndex = 0;
            this.tabPageAtivos.Text = "Ativos";
            this.tabPageAtivos.UseVisualStyleBackColor = true;
            // 
            // buttonTeste
            // 
            this.buttonTeste.Location = new System.Drawing.Point(138, 179);
            this.buttonTeste.Name = "buttonTeste";
            this.buttonTeste.Size = new System.Drawing.Size(75, 23);
            this.buttonTeste.TabIndex = 0;
            this.buttonTeste.Text = "Ativo";
            this.buttonTeste.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabPrincipal);
            this.Name = "Main";
            this.Text = "Form1";
            this.tabPrincipal.ResumeLayout(false);
            this.tabPageAtivos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabPrincipal;
        private TabPage tabPageAtivos;
        private Button buttonTeste;
    }
}