namespace pryDisenoLavadero
{
    partial class frmLavados
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
            label1 = new Label();
            grpBoxRegistroLavados = new GroupBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(186, 20);
            label1.Name = "label1";
            label1.Size = new Size(149, 21);
            label1.TabIndex = 0;
            label1.Text = "Lavadero Los Andes";
            // 
            // grpBoxRegistroLavados
            // 
            grpBoxRegistroLavados.Location = new Point(14, 61);
            grpBoxRegistroLavados.Name = "grpBoxRegistroLavados";
            grpBoxRegistroLavados.Size = new Size(222, 224);
            grpBoxRegistroLavados.TabIndex = 1;
            grpBoxRegistroLavados.TabStop = false;
            grpBoxRegistroLavados.Text = "Registro Lavados";
            // 
            // frmLavados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 470);
            Controls.Add(grpBoxRegistroLavados);
            Controls.Add(label1);
            Name = "frmLavados";
            Text = "frmLavados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox grpBoxRegistroLavados;
    }
}