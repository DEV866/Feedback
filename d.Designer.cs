
namespace Feedback
{
    partial class d
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
            this.dgvApplicant = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicant)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvApplicant
            // 
            this.dgvApplicant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicant.Location = new System.Drawing.Point(12, 98);
            this.dgvApplicant.Name = "dgvApplicant";
            this.dgvApplicant.RowHeadersWidth = 82;
            this.dgvApplicant.RowTemplate.Height = 33;
            this.dgvApplicant.Size = new System.Drawing.Size(1111, 417);
            this.dgvApplicant.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(922, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Applicant Data Grid";
            // 
            // d
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 652);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvApplicant);
            this.Name = "d";
            this.Text = "d";
            this.Load += new System.EventHandler(this.d_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvApplicant;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}