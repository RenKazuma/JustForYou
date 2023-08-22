namespace Basic_Calculator
{
    partial class frm_BasicCalculator
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
            this.metroButton17 = new System.Windows.Forms.Button();
            this.metroButton18 = new System.Windows.Forms.Button();
            this.metroButton19 = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblExpression = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRightParenthesis = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.metroButton35 = new System.Windows.Forms.Button();
            this.metroButton34 = new System.Windows.Forms.Button();
            this.metroButton26 = new System.Windows.Forms.Button();
            this.btnLeftParenthesis = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton17
            // 
            this.metroButton17.BackColor = System.Drawing.Color.Transparent;
            this.metroButton17.Location = new System.Drawing.Point(83, 0);
            this.metroButton17.Margin = new System.Windows.Forms.Padding(0);
            this.metroButton17.Name = "metroButton17";
            this.metroButton17.Size = new System.Drawing.Size(82, 58);
            this.metroButton17.TabIndex = 16;
            this.metroButton17.Text = "CE";
            this.metroButton17.Click += new System.EventHandler(this.btnClearNumber_Click);
            // 
            // metroButton18
            // 
            this.metroButton18.BackColor = System.Drawing.Color.Transparent;
            this.metroButton18.Location = new System.Drawing.Point(166, 0);
            this.metroButton18.Margin = new System.Windows.Forms.Padding(0);
            this.metroButton18.Name = "metroButton18";
            this.metroButton18.Size = new System.Drawing.Size(82, 58);
            this.metroButton18.TabIndex = 17;
            this.metroButton18.Text = "C";
            this.metroButton18.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // metroButton19
            // 
            this.metroButton19.BackColor = System.Drawing.Color.Transparent;
            this.metroButton19.Location = new System.Drawing.Point(249, 0);
            this.metroButton19.Margin = new System.Windows.Forms.Padding(0);
            this.metroButton19.Name = "metroButton19";
            this.metroButton19.Size = new System.Drawing.Size(82, 58);
            this.metroButton19.TabIndex = 18;
            this.metroButton19.Text = "⌫";
            this.metroButton19.Click += new System.EventHandler(this.Backspace_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.Transparent;
            this.btnSeven.Location = new System.Drawing.Point(83, 58);
            this.btnSeven.Margin = new System.Windows.Forms.Padding(0);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(82, 58);
            this.btnSeven.TabIndex = 8;
            this.btnSeven.Text = "7";
            this.btnSeven.Click += new System.EventHandler(this.Digits_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.Transparent;
            this.btnEight.Location = new System.Drawing.Point(166, 58);
            this.btnEight.Margin = new System.Windows.Forms.Padding(0);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(82, 58);
            this.btnEight.TabIndex = 9;
            this.btnEight.Text = "8";
            this.btnEight.Click += new System.EventHandler(this.Digits_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.Transparent;
            this.btnNine.Location = new System.Drawing.Point(249, 58);
            this.btnNine.Margin = new System.Windows.Forms.Padding(0);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(82, 58);
            this.btnNine.TabIndex = 10;
            this.btnNine.Text = "9";
            this.btnNine.Click += new System.EventHandler(this.Digits_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.Transparent;
            this.btnFour.Location = new System.Drawing.Point(83, 116);
            this.btnFour.Margin = new System.Windows.Forms.Padding(0);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(82, 58);
            this.btnFour.TabIndex = 12;
            this.btnFour.Text = "4";
            this.btnFour.Click += new System.EventHandler(this.Digits_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.Transparent;
            this.btnFive.Location = new System.Drawing.Point(166, 116);
            this.btnFive.Margin = new System.Windows.Forms.Padding(0);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(82, 58);
            this.btnFive.TabIndex = 13;
            this.btnFive.Text = "5";
            this.btnFive.Click += new System.EventHandler(this.Digits_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.Transparent;
            this.btnSix.Location = new System.Drawing.Point(249, 116);
            this.btnSix.Margin = new System.Windows.Forms.Padding(0);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(82, 58);
            this.btnSix.TabIndex = 14;
            this.btnSix.Text = "6";
            this.btnSix.Click += new System.EventHandler(this.Digits_Click);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.Transparent;
            this.btnOne.Location = new System.Drawing.Point(83, 174);
            this.btnOne.Margin = new System.Windows.Forms.Padding(0);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(82, 58);
            this.btnOne.TabIndex = 27;
            this.btnOne.Text = "1";
            this.btnOne.Click += new System.EventHandler(this.Digits_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.Transparent;
            this.btnTwo.Location = new System.Drawing.Point(166, 174);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(0);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(82, 58);
            this.btnTwo.TabIndex = 28;
            this.btnTwo.Text = "2";
            this.btnTwo.Click += new System.EventHandler(this.Digits_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.Transparent;
            this.btnThree.Location = new System.Drawing.Point(249, 174);
            this.btnThree.Margin = new System.Windows.Forms.Padding(0);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(82, 58);
            this.btnThree.TabIndex = 29;
            this.btnThree.Text = "3";
            this.btnThree.Click += new System.EventHandler(this.Digits_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblNumber.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNumber.Location = new System.Drawing.Point(3, 144);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNumber.Size = new System.Drawing.Size(411, 49);
            this.lblNumber.TabIndex = 4;
            this.lblNumber.Text = "label1";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblExpression
            // 
            this.lblExpression.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblExpression.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExpression.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblExpression.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblExpression.Location = new System.Drawing.Point(6, 0);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblExpression.Size = new System.Drawing.Size(408, 193);
            this.lblExpression.TabIndex = 5;
            this.lblExpression.Text = "label1";
            this.lblExpression.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNumber);
            this.panel1.Controls.Add(this.lblExpression);
            this.panel1.Location = new System.Drawing.Point(3, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 193);
            this.panel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.metroButton34, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.metroButton35, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnZero, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnRightParenthesis, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnLeftParenthesis, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnThree, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnTwo, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnOne, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.metroButton17, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.metroButton26, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.metroButton18, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSubtract, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.metroButton19, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSix, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnDivide, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnFive, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnFour, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnSeven, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnEight, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnMultiply, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnNine, 3, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 250);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(417, 294);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.Transparent;
            this.btnMultiply.Location = new System.Drawing.Point(332, 58);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(0);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(82, 58);
            this.btnMultiply.TabIndex = 21;
            this.btnMultiply.Text = "×";
            this.btnMultiply.Click += new System.EventHandler(this.Operators_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.Transparent;
            this.btnDivide.Location = new System.Drawing.Point(332, 0);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(0);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(82, 58);
            this.btnDivide.TabIndex = 19;
            this.btnDivide.Text = "÷";
            this.btnDivide.Click += new System.EventHandler(this.Operators_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.Transparent;
            this.btnSubtract.Location = new System.Drawing.Point(332, 116);
            this.btnSubtract.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(82, 58);
            this.btnSubtract.TabIndex = 23;
            this.btnSubtract.Text = "-";
            this.btnSubtract.Click += new System.EventHandler(this.Operators_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(332, 174);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 58);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "+";
            this.btnAdd.Click += new System.EventHandler(this.Operators_Click);
            // 
            // btnRightParenthesis
            // 
            this.btnRightParenthesis.BackColor = System.Drawing.Color.Transparent;
            this.btnRightParenthesis.Location = new System.Drawing.Point(83, 232);
            this.btnRightParenthesis.Margin = new System.Windows.Forms.Padding(0);
            this.btnRightParenthesis.Name = "btnRightParenthesis";
            this.btnRightParenthesis.Size = new System.Drawing.Size(82, 58);
            this.btnRightParenthesis.TabIndex = 31;
            this.btnRightParenthesis.Text = ")";
            this.btnRightParenthesis.Click += new System.EventHandler(this.BtnRightParenthesis_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.Transparent;
            this.btnZero.Location = new System.Drawing.Point(166, 232);
            this.btnZero.Margin = new System.Windows.Forms.Padding(0);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(82, 58);
            this.btnZero.TabIndex = 32;
            this.btnZero.Text = "0";
            this.btnZero.Click += new System.EventHandler(this.Digits_Click);
            // 
            // metroButton35
            // 
            this.metroButton35.BackColor = System.Drawing.Color.Transparent;
            this.metroButton35.Location = new System.Drawing.Point(332, 232);
            this.metroButton35.Margin = new System.Windows.Forms.Padding(0);
            this.metroButton35.Name = "metroButton35";
            this.metroButton35.Size = new System.Drawing.Size(82, 58);
            this.metroButton35.TabIndex = 34;
            this.metroButton35.Text = "=";
            this.metroButton35.Click += new System.EventHandler(this.Evaluate_Click);
            // 
            // metroButton34
            // 
            this.metroButton34.BackColor = System.Drawing.Color.Transparent;
            this.metroButton34.Location = new System.Drawing.Point(249, 232);
            this.metroButton34.Margin = new System.Windows.Forms.Padding(0);
            this.metroButton34.Name = "metroButton34";
            this.metroButton34.Size = new System.Drawing.Size(82, 58);
            this.metroButton34.TabIndex = 33;
            this.metroButton34.Text = ".";
            this.metroButton34.Click += new System.EventHandler(this.Dot_Click);
            // 
            // metroButton26
            // 
            this.metroButton26.BackColor = System.Drawing.Color.Transparent;
            this.metroButton26.Location = new System.Drawing.Point(0, 174);
            this.metroButton26.Margin = new System.Windows.Forms.Padding(0);
            this.metroButton26.Name = "metroButton26";
            this.metroButton26.Size = new System.Drawing.Size(82, 58);
            this.metroButton26.TabIndex = 25;
            this.metroButton26.Text = "±";
            this.metroButton26.Click += new System.EventHandler(this.Sign_Click);
            // 
            // btnLeftParenthesis
            // 
            this.btnLeftParenthesis.BackColor = System.Drawing.Color.Transparent;
            this.btnLeftParenthesis.Location = new System.Drawing.Point(0, 232);
            this.btnLeftParenthesis.Margin = new System.Windows.Forms.Padding(0);
            this.btnLeftParenthesis.Name = "btnLeftParenthesis";
            this.btnLeftParenthesis.Size = new System.Drawing.Size(82, 58);
            this.btnLeftParenthesis.TabIndex = 30;
            this.btnLeftParenthesis.Text = "(";
            this.btnLeftParenthesis.Click += new System.EventHandler(this.BtnLeftParenthesis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 549);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Text = "ouurlator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button metroButton17;
        private System.Windows.Forms.Button metroButton18;
        private System.Windows.Forms.Button metroButton19;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblExpression;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button metroButton34;
        private System.Windows.Forms.Button metroButton35;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnRightParenthesis;
        private System.Windows.Forms.Button btnLeftParenthesis;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button metroButton26;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
    }
}

