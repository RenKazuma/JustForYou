
namespace CreditCalculation
{
    partial class frm_CreditCalculation
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
            this.Btn_CreditWithRateAmount = new System.Windows.Forms.Button();
            this.Btn_CreditWithRunTime = new System.Windows.Forms.Button();
            this.Btn_CreditOnePayment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_CreditWithRateAmount
            // 
            this.Btn_CreditWithRateAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.Btn_CreditWithRateAmount.FlatAppearance.BorderSize = 0;
            this.Btn_CreditWithRateAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CreditWithRateAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CreditWithRateAmount.ForeColor = System.Drawing.Color.White;
            this.Btn_CreditWithRateAmount.Location = new System.Drawing.Point(558, 187);
            this.Btn_CreditWithRateAmount.Name = "Btn_CreditWithRateAmount";
            this.Btn_CreditWithRateAmount.Size = new System.Drawing.Size(230, 30);
            this.Btn_CreditWithRateAmount.TabIndex = 8;
            this.Btn_CreditWithRateAmount.Text = "Ratenkredit, Vorgabe der Ratenhöhe";
            this.Btn_CreditWithRateAmount.UseVisualStyleBackColor = false;
            this.Btn_CreditWithRateAmount.Click += new System.EventHandler(this.Btn_CreditWithRateAmount_Click);
            // 
            // Btn_CreditWithRunTime
            // 
            this.Btn_CreditWithRunTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.Btn_CreditWithRunTime.FlatAppearance.BorderSize = 0;
            this.Btn_CreditWithRunTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CreditWithRunTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CreditWithRunTime.ForeColor = System.Drawing.Color.White;
            this.Btn_CreditWithRunTime.Location = new System.Drawing.Point(284, 187);
            this.Btn_CreditWithRunTime.Name = "Btn_CreditWithRunTime";
            this.Btn_CreditWithRunTime.Size = new System.Drawing.Size(230, 30);
            this.Btn_CreditWithRunTime.TabIndex = 7;
            this.Btn_CreditWithRunTime.Text = "Ratenkredit, Vorgabe der Laufzeit";
            this.Btn_CreditWithRunTime.UseVisualStyleBackColor = false;
            this.Btn_CreditWithRunTime.Click += new System.EventHandler(this.Btn_CreditWithRunTime_Click);
            // 
            // Btn_CreditOnePayment
            // 
            this.Btn_CreditOnePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.Btn_CreditOnePayment.FlatAppearance.BorderSize = 0;
            this.Btn_CreditOnePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CreditOnePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CreditOnePayment.ForeColor = System.Drawing.Color.White;
            this.Btn_CreditOnePayment.Location = new System.Drawing.Point(12, 187);
            this.Btn_CreditOnePayment.Name = "Btn_CreditOnePayment";
            this.Btn_CreditOnePayment.Size = new System.Drawing.Size(230, 30);
            this.Btn_CreditOnePayment.TabIndex = 6;
            this.Btn_CreditOnePayment.Text = "Kredit mit einmaliger Rückzahlung";
            this.Btn_CreditOnePayment.UseVisualStyleBackColor = false;
            this.Btn_CreditOnePayment.Click += new System.EventHandler(this.Btn_CreditOnePayment_Click);
            // 
            // frm_CreditCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_CreditWithRateAmount);
            this.Controls.Add(this.Btn_CreditWithRunTime);
            this.Controls.Add(this.Btn_CreditOnePayment);
            this.Name = "frm_CreditCalculation";
            this.Text = "frm_CreditCalculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_CreditWithRateAmount;
        private System.Windows.Forms.Button Btn_CreditWithRunTime;
        private System.Windows.Forms.Button Btn_CreditOnePayment;
    }
}