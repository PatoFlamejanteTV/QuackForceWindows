namespace QuackForceWindows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WindowNameChooser = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.WindowCustomHex = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWParam = new System.Windows.Forms.TextBox();
            this.textBoxLParam = new System.Windows.Forms.TextBox();
            this.labelWParam = new System.Windows.Forms.Label();
            this.labelLParam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WindowNameChooser
            // 
            this.WindowNameChooser.Location = new System.Drawing.Point(13, 13);
            this.WindowNameChooser.Name = "WindowNameChooser";
            this.WindowNameChooser.Size = new System.Drawing.Size(195, 20);
            this.WindowNameChooser.TabIndex = 0;
            this.WindowNameChooser.Text = "testapp.exe";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WindowCustomHex
            // 
            this.WindowCustomHex.Location = new System.Drawing.Point(12, 39);
            this.WindowCustomHex.Name = "WindowCustomHex";
            this.WindowCustomHex.Size = new System.Drawing.Size(195, 20);
            this.WindowCustomHex.TabIndex = 2;
            this.WindowCustomHex.Text = "000c";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(478, 11);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(92, 20);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "statusLabel";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(215, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(257, 121);
            this.listBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 60);
            this.label1.TabIndex = 5;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxWParam
            // 
            this.textBoxWParam.Location = new System.Drawing.Point(12, 85);
            this.textBoxWParam.Name = "textBoxWParam";
            this.textBoxWParam.Size = new System.Drawing.Size(95, 20);
            this.textBoxWParam.TabIndex = 6;
            this.textBoxWParam.Text = "0";
            // 
            // textBoxLParam
            // 
            this.textBoxLParam.Location = new System.Drawing.Point(112, 85);
            this.textBoxLParam.Name = "textBoxLParam";
            this.textBoxLParam.Size = new System.Drawing.Size(96, 20);
            this.textBoxLParam.TabIndex = 7;
            this.textBoxLParam.Text = "0";
            // 
            // labelWParam
            // 
            this.labelWParam.AutoSize = true;
            this.labelWParam.Location = new System.Drawing.Point(12, 70);
            this.labelWParam.Name = "labelWParam";
            this.labelWParam.Size = new System.Drawing.Size(48, 13);
            this.labelWParam.TabIndex = 8;
            this.labelWParam.Text = "wParam:";
            // 
            // labelLParam
            // 
            this.labelLParam.AutoSize = true;
            this.labelLParam.Location = new System.Drawing.Point(112, 70);
            this.labelLParam.Name = "labelLParam";
            this.labelLParam.Size = new System.Drawing.Size(42, 13);
            this.labelLParam.TabIndex = 9;
            this.labelLParam.Text = "lParam:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 308);
            this.Controls.Add(this.labelLParam);
            this.Controls.Add(this.labelWParam);
            this.Controls.Add(this.textBoxLParam);
            this.Controls.Add(this.textBoxWParam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.WindowCustomHex);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WindowNameChooser);
            this.Name = "Form1";
            this.Text = " -= UltimateQuack\'s Force Windows HEX! =-";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WindowNameChooser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox WindowCustomHex;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWParam;
        private System.Windows.Forms.TextBox textBoxLParam;
        private System.Windows.Forms.Label labelWParam;
        private System.Windows.Forms.Label labelLParam;
    }
}

