
namespace HW_6._16
{
    partial class Form1
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
            this.tblGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.tlpUpper = new System.Windows.Forms.TableLayoutPanel();
            this.tbFirstNum = new System.Windows.Forms.TextBox();
            this.tbSecondNum = new System.Windows.Forms.TextBox();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.tlbLower = new System.Windows.Forms.TableLayoutPanel();
            this.lblGcd = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.tblGeneral.SuspendLayout();
            this.tlpUpper.SuspendLayout();
            this.tlbLower.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblGeneral
            // 
            this.tblGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tblGeneral.ColumnCount = 2;
            this.tblGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 378F));
            this.tblGeneral.Controls.Add(this.tlbLower, 0, 1);
            this.tblGeneral.Controls.Add(this.btnFind, 1, 0);
            this.tblGeneral.Controls.Add(this.tlpUpper, 0, 0);
            this.tblGeneral.Location = new System.Drawing.Point(21, 20);
            this.tblGeneral.Name = "tblGeneral";
            this.tblGeneral.RowCount = 2;
            this.tblGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.76191F));
            this.tblGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.23809F));
            this.tblGeneral.Size = new System.Drawing.Size(992, 427);
            this.tblGeneral.TabIndex = 3;
            // 
            // tlpUpper
            // 
            this.tlpUpper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpUpper.AutoSize = true;
            this.tlpUpper.ColumnCount = 2;
            this.tlpUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.47368F));
            this.tlpUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.52632F));
            this.tlpUpper.Controls.Add(this.tbFirstNum, 1, 0);
            this.tlpUpper.Controls.Add(this.tbSecondNum, 1, 1);
            this.tlpUpper.Controls.Add(this.lblSecondNumber, 0, 1);
            this.tlpUpper.Controls.Add(this.lblFirstNumber, 0, 0);
            this.tlpUpper.Location = new System.Drawing.Point(3, 3);
            this.tlpUpper.Name = "tlpUpper";
            this.tlpUpper.RowCount = 2;
            this.tlpUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tlpUpper.Size = new System.Drawing.Size(608, 219);
            this.tlpUpper.TabIndex = 1;
            // 
            // tbFirstNum
            // 
            this.tbFirstNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFirstNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbFirstNum.Location = new System.Drawing.Point(242, 35);
            this.tbFirstNum.Name = "tbFirstNum";
            this.tbFirstNum.Size = new System.Drawing.Size(363, 38);
            this.tbFirstNum.TabIndex = 2;
            // 
            // tbSecondNum
            // 
            this.tbSecondNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSecondNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSecondNum.Location = new System.Drawing.Point(242, 144);
            this.tbSecondNum.Name = "tbSecondNum";
            this.tbSecondNum.Size = new System.Drawing.Size(363, 38);
            this.tbSecondNum.TabIndex = 3;
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSecondNumber.AutoEllipsis = true;
            this.lblSecondNumber.AutoSize = true;
            this.lblSecondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecondNumber.Location = new System.Drawing.Point(3, 108);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(233, 111);
            this.lblSecondNumber.TabIndex = 1;
            this.lblSecondNumber.Text = "Second Number:";
            this.lblSecondNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstNumber.AutoEllipsis = true;
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirstNumber.Location = new System.Drawing.Point(3, 0);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(233, 108);
            this.lblFirstNumber.TabIndex = 0;
            this.lblFirstNumber.Text = "First Number:";
            this.lblFirstNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlbLower
            // 
            this.tlbLower.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlbLower.ColumnCount = 1;
            this.tlbLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbLower.Controls.Add(this.lblGcd, 0, 0);
            this.tlbLower.Location = new System.Drawing.Point(3, 228);
            this.tlbLower.Name = "tlbLower";
            this.tlbLower.RowCount = 1;
            this.tlbLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbLower.Size = new System.Drawing.Size(608, 196);
            this.tlbLower.TabIndex = 2;
            // 
            // lblGcd
            // 
            this.lblGcd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGcd.AutoSize = true;
            this.lblGcd.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGcd.Location = new System.Drawing.Point(3, 0);
            this.lblGcd.Name = "lblGcd";
            this.lblGcd.Size = new System.Drawing.Size(602, 196);
            this.lblGcd.TabIndex = 0;
            this.lblGcd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.AutoSize = true;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFind.Location = new System.Drawing.Point(617, 20);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(372, 184);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "FIND GCD";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 553);
            this.Controls.Add(this.tblGeneral);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tblGeneral.ResumeLayout(false);
            this.tblGeneral.PerformLayout();
            this.tlpUpper.ResumeLayout(false);
            this.tlpUpper.PerformLayout();
            this.tlbLower.ResumeLayout(false);
            this.tlbLower.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblGeneral;
        private System.Windows.Forms.TableLayoutPanel tlpUpper;
        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.TextBox tbFirstNum;
        private System.Windows.Forms.TableLayoutPanel tlbLower;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblGcd;
        private System.Windows.Forms.TextBox tbSecondNum;
        private System.Windows.Forms.Label lblSecondNumber;
    }
}

