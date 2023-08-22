
namespace Geometry
{
    partial class frm_geometry
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
            this.kreisberechnung_btn = new System.Windows.Forms.Button();
            this.dreiecksberechnung_btn = new System.Windows.Forms.Button();
            this.parallelogrammberechnung_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kreisberechnung_btn
            // 
            this.kreisberechnung_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.kreisberechnung_btn.FlatAppearance.BorderSize = 0;
            this.kreisberechnung_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kreisberechnung_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kreisberechnung_btn.ForeColor = System.Drawing.Color.White;
            this.kreisberechnung_btn.Location = new System.Drawing.Point(70, 202);
            this.kreisberechnung_btn.Name = "kreisberechnung_btn";
            this.kreisberechnung_btn.Size = new System.Drawing.Size(180, 30);
            this.kreisberechnung_btn.TabIndex = 0;
            this.kreisberechnung_btn.Text = "Kreisberechnung";
            this.kreisberechnung_btn.UseVisualStyleBackColor = false;
            this.kreisberechnung_btn.Click += new System.EventHandler(this.kreisberechnung_btn_Click);
            // 
            // dreiecksberechnung_btn
            // 
            this.dreiecksberechnung_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.dreiecksberechnung_btn.FlatAppearance.BorderSize = 0;
            this.dreiecksberechnung_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dreiecksberechnung_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dreiecksberechnung_btn.ForeColor = System.Drawing.Color.White;
            this.dreiecksberechnung_btn.Location = new System.Drawing.Point(322, 202);
            this.dreiecksberechnung_btn.Name = "dreiecksberechnung_btn";
            this.dreiecksberechnung_btn.Size = new System.Drawing.Size(180, 30);
            this.dreiecksberechnung_btn.TabIndex = 1;
            this.dreiecksberechnung_btn.Text = "Dreiecksberechnung";
            this.dreiecksberechnung_btn.UseVisualStyleBackColor = false;
            this.dreiecksberechnung_btn.Click += new System.EventHandler(this.dreiecksberechnung_btn_Click);
            // 
            // parallelogrammberechnung_btn
            // 
            this.parallelogrammberechnung_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.parallelogrammberechnung_btn.FlatAppearance.BorderSize = 0;
            this.parallelogrammberechnung_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parallelogrammberechnung_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parallelogrammberechnung_btn.ForeColor = System.Drawing.Color.White;
            this.parallelogrammberechnung_btn.Location = new System.Drawing.Point(579, 203);
            this.parallelogrammberechnung_btn.Name = "parallelogrammberechnung_btn";
            this.parallelogrammberechnung_btn.Size = new System.Drawing.Size(180, 30);
            this.parallelogrammberechnung_btn.TabIndex = 2;
            this.parallelogrammberechnung_btn.Text = "Parallelogrammberechnung";
            this.parallelogrammberechnung_btn.UseVisualStyleBackColor = false;
            this.parallelogrammberechnung_btn.Click += new System.EventHandler(this.parallelogrammberechnung_btn_Click);
            // 
            // frm_geometry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.parallelogrammberechnung_btn);
            this.Controls.Add(this.dreiecksberechnung_btn);
            this.Controls.Add(this.kreisberechnung_btn);
            this.Name = "frm_geometry";
            this.Text = "7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kreisberechnung_btn;
        private System.Windows.Forms.Button dreiecksberechnung_btn;
        private System.Windows.Forms.Button parallelogrammberechnung_btn;
    }
}