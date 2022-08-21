namespace GeneradorAWS
{
    partial class FormMain
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
            this.tabControlPasos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxOutputPath = new System.Windows.Forms.TextBox();
            this.textBoxSolutionName = new System.Windows.Forms.TextBox();
            this.textBoxConnectionString = new System.Windows.Forms.TextBox();
            this.labelOutputPath = new System.Windows.Forms.Label();
            this.labelSolutionName = new System.Windows.Forms.Label();
            this.labelConnectionString = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonGenerar = new System.Windows.Forms.Button();
            this.linkLabelSave = new System.Windows.Forms.LinkLabel();
            this.tabControlPasos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPasos
            // 
            this.tabControlPasos.Controls.Add(this.tabPage1);
            this.tabControlPasos.Controls.Add(this.tabPage2);
            this.tabControlPasos.Location = new System.Drawing.Point(12, 12);
            this.tabControlPasos.Name = "tabControlPasos";
            this.tabControlPasos.SelectedIndex = 0;
            this.tabControlPasos.Size = new System.Drawing.Size(776, 403);
            this.tabControlPasos.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.linkLabelSave);
            this.tabPage1.Controls.Add(this.textBoxOutputPath);
            this.tabPage1.Controls.Add(this.textBoxSolutionName);
            this.tabPage1.Controls.Add(this.textBoxConnectionString);
            this.tabPage1.Controls.Add(this.labelOutputPath);
            this.tabPage1.Controls.Add(this.labelSolutionName);
            this.tabPage1.Controls.Add(this.labelConnectionString);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Paso1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxOutputPath
            // 
            this.textBoxOutputPath.Location = new System.Drawing.Point(177, 99);
            this.textBoxOutputPath.Name = "textBoxOutputPath";
            this.textBoxOutputPath.Size = new System.Drawing.Size(572, 31);
            this.textBoxOutputPath.TabIndex = 5;
            // 
            // textBoxSolutionName
            // 
            this.textBoxSolutionName.Location = new System.Drawing.Point(177, 56);
            this.textBoxSolutionName.Name = "textBoxSolutionName";
            this.textBoxSolutionName.Size = new System.Drawing.Size(572, 31);
            this.textBoxSolutionName.TabIndex = 4;
            // 
            // textBoxConnectionString
            // 
            this.textBoxConnectionString.Location = new System.Drawing.Point(177, 19);
            this.textBoxConnectionString.Name = "textBoxConnectionString";
            this.textBoxConnectionString.Size = new System.Drawing.Size(572, 31);
            this.textBoxConnectionString.TabIndex = 3;
            // 
            // labelOutputPath
            // 
            this.labelOutputPath.AutoSize = true;
            this.labelOutputPath.Location = new System.Drawing.Point(15, 99);
            this.labelOutputPath.Name = "labelOutputPath";
            this.labelOutputPath.Size = new System.Drawing.Size(114, 25);
            this.labelOutputPath.TabIndex = 2;
            this.labelOutputPath.Text = "Output path:";
            // 
            // labelSolutionName
            // 
            this.labelSolutionName.AutoSize = true;
            this.labelSolutionName.Location = new System.Drawing.Point(15, 56);
            this.labelSolutionName.Name = "labelSolutionName";
            this.labelSolutionName.Size = new System.Drawing.Size(131, 25);
            this.labelSolutionName.TabIndex = 1;
            this.labelSolutionName.Text = "Solution name:";
            // 
            // labelConnectionString
            // 
            this.labelConnectionString.AutoSize = true;
            this.labelConnectionString.Location = new System.Drawing.Point(15, 17);
            this.labelConnectionString.Name = "labelConnectionString";
            this.labelConnectionString.Size = new System.Drawing.Size(152, 25);
            this.labelConnectionString.TabIndex = 0;
            this.labelConnectionString.Text = "ConnectionString:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonGenerar);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Paso2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonGenerar
            // 
            this.buttonGenerar.Location = new System.Drawing.Point(149, 65);
            this.buttonGenerar.Name = "buttonGenerar";
            this.buttonGenerar.Size = new System.Drawing.Size(174, 82);
            this.buttonGenerar.TabIndex = 0;
            this.buttonGenerar.Text = "Generar";
            this.buttonGenerar.UseVisualStyleBackColor = true;
            this.buttonGenerar.Click += new System.EventHandler(this.buttonGenerar_Click);
            // 
            // linkLabelSave
            // 
            this.linkLabelSave.AutoSize = true;
            this.linkLabelSave.Location = new System.Drawing.Point(554, 170);
            this.linkLabelSave.Name = "linkLabelSave";
            this.linkLabelSave.Size = new System.Drawing.Size(49, 25);
            this.linkLabelSave.TabIndex = 6;
            this.linkLabelSave.TabStop = true;
            this.linkLabelSave.Text = "Save";
            this.linkLabelSave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSave_LinkClicked);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.tabControlPasos);
            this.Name = "FormMain";
            this.Text = "Generator AWS lambda";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlPasos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlPasos;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button buttonGenerar;
        private Label labelOutputPath;
        private Label labelSolutionName;
        private Label labelConnectionString;
        private TextBox textBoxOutputPath;
        private TextBox textBoxSolutionName;
        private TextBox textBoxConnectionString;
        private LinkLabel linkLabelSave;
    }
}