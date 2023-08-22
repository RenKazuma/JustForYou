
namespace Mathematics_Functions
{
    partial class frm_MathematicsFunctions
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
            this.fak_btn = new System.Windows.Forms.Button();
            this.sqrt_btn = new System.Windows.Forms.Button();
            this.pow_btn = new System.Windows.Forms.Button();
            this.prime_btn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fak_btn
            // 
            this.fak_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.fak_btn.FlatAppearance.BorderSize = 0;
            this.fak_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fak_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fak_btn.ForeColor = System.Drawing.Color.White;
            this.fak_btn.Location = new System.Drawing.Point(45, 122);
            this.fak_btn.Name = "fak_btn";
            this.fak_btn.Size = new System.Drawing.Size(220, 30);
            this.fak_btn.TabIndex = 0;
            this.fak_btn.Text = "Fakultät";
            this.fak_btn.UseVisualStyleBackColor = false;
            this.fak_btn.Click += new System.EventHandler(this.fak_onClick);
            // 
            // sqrt_btn
            // 
            this.sqrt_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.sqrt_btn.FlatAppearance.BorderSize = 0;
            this.sqrt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqrt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrt_btn.ForeColor = System.Drawing.Color.White;
            this.sqrt_btn.Location = new System.Drawing.Point(292, 122);
            this.sqrt_btn.Name = "sqrt_btn";
            this.sqrt_btn.Size = new System.Drawing.Size(220, 30);
            this.sqrt_btn.TabIndex = 1;
            this.sqrt_btn.Text = "Quadratwurzel";
            this.sqrt_btn.UseVisualStyleBackColor = true;
            this.sqrt_btn.Click += new System.EventHandler(this.sqrt_btn_Click);
            // 
            // pow_btn
            // 
            this.pow_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.pow_btn.FlatAppearance.BorderSize = 0;
            this.pow_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pow_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pow_btn.ForeColor = System.Drawing.Color.White;
            this.pow_btn.Location = new System.Drawing.Point(539, 122);
            this.pow_btn.Name = "pow_btn";
            this.pow_btn.Size = new System.Drawing.Size(220, 30);
            this.pow_btn.TabIndex = 2;
            this.pow_btn.Text = "Potenzfunktion";
            this.pow_btn.UseVisualStyleBackColor = true;
            this.pow_btn.Click += new System.EventHandler(this.pow_onClick);
            // 
            // prime_btn
            // 
            this.prime_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.prime_btn.FlatAppearance.BorderSize = 0;
            this.prime_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prime_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prime_btn.ForeColor = System.Drawing.Color.White;
            this.prime_btn.Location = new System.Drawing.Point(418, 221);
            this.prime_btn.Name = "prime_btn";
            this.prime_btn.Size = new System.Drawing.Size(220, 30);
            this.prime_btn.TabIndex = 3;
            this.prime_btn.Text = "Primzahlen zwischen Grenzwerten";
            this.prime_btn.UseVisualStyleBackColor = true;
            this.prime_btn.Click += new System.EventHandler(this.prim_between_range_onClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(143, 221);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(220, 30);
            this.button5.TabIndex = 4;
            this.button5.Text = "Umwandlung Dezimalbruch";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.trans_decimal_onCLick);
            // 
            // frm_MathematicsFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.prime_btn);
            this.Controls.Add(this.pow_btn);
            this.Controls.Add(this.sqrt_btn);
            this.Controls.Add(this.fak_btn);
            this.Name = "frm_MathematicsFunctions";
            this.Text = "frm_MathematicsFunctions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fak_btn;
        private System.Windows.Forms.Button sqrt_btn;
        private System.Windows.Forms.Button pow_btn;
        private System.Windows.Forms.Button prime_btn;
        private System.Windows.Forms.Button button5;
    }
}