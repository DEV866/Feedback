
namespace Feedback
{
    partial class TemplateDGV
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
            this.dgvTemplate = new System.Windows.Forms.DataGridView();
            this.btnRefreshDB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTemplate
            // 
            this.dgvTemplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemplate.Location = new System.Drawing.Point(12, 89);
            this.dgvTemplate.Name = "dgvTemplate";
            this.dgvTemplate.RowHeadersWidth = 82;
            this.dgvTemplate.RowTemplate.Height = 33;
            this.dgvTemplate.Size = new System.Drawing.Size(835, 320);
            this.dgvTemplate.TabIndex = 0;
            // 
            // btnRefreshDB
            // 
            this.btnRefreshDB.Location = new System.Drawing.Point(13, 426);
            this.btnRefreshDB.Name = "btnRefreshDB";
            this.btnRefreshDB.Size = new System.Drawing.Size(244, 68);
            this.btnRefreshDB.TabIndex = 2;
            this.btnRefreshDB.Text = "Refresh Data";
            this.btnRefreshDB.UseVisualStyleBackColor = true;
            this.btnRefreshDB.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 68);
            this.button1.TabIndex = 3;
            this.button1.Text = "Clear data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Template Data Grid";
            // 
            // TemplateDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRefreshDB);
            this.Controls.Add(this.dgvTemplate);
            this.Name = "TemplateDGV";
            this.Text = "TemplateDGV";
            this.Load += new System.EventHandler(this.TemplateDGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemplate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTemplate;
        private System.Windows.Forms.Button btnRefreshDB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}