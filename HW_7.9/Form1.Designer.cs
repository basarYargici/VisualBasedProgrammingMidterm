
namespace HW_7._9
{
    partial class Form
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
            this.lblExplanation = new System.Windows.Forms.Label();
            this.lblEnter = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.tlbLower = new System.Windows.Forms.TableLayoutPanel();
            this.lblSearched = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblResultSet = new System.Windows.Forms.TextBox();
            this.tblGeneral.SuspendLayout();
            this.tlpUpper.SuspendLayout();
            this.tlbLower.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblGeneral
            // 
            this.tblGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblGeneral.ColumnCount = 1;
            this.tblGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblGeneral.Controls.Add(this.tlpUpper, 0, 0);
            this.tblGeneral.Controls.Add(this.tlbLower, 0, 1);
            this.tblGeneral.Location = new System.Drawing.Point(12, 13);
            this.tblGeneral.Name = "tblGeneral";
            this.tblGeneral.RowCount = 2;
            this.tblGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblGeneral.Size = new System.Drawing.Size(859, 512);
            this.tblGeneral.TabIndex = 2;
            // 
            // tlpUpper
            // 
            this.tlpUpper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpUpper.ColumnCount = 4;
            this.tlpUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpUpper.Controls.Add(this.lblExplanation, 3, 0);
            this.tlpUpper.Controls.Add(this.lblEnter, 0, 0);
            this.tlpUpper.Controls.Add(this.lblResult, 2, 0);
            this.tlpUpper.Controls.Add(this.tbKey, 1, 0);
            this.tlpUpper.Location = new System.Drawing.Point(3, 3);
            this.tlpUpper.Name = "tlpUpper";
            this.tlpUpper.RowCount = 1;
            this.tlpUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpUpper.Size = new System.Drawing.Size(853, 96);
            this.tlpUpper.TabIndex = 1;
            // 
            // lblExplanation
            // 
            this.lblExplanation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExplanation.AutoEllipsis = true;
            this.lblExplanation.AutoSize = true;
            this.lblExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExplanation.Location = new System.Drawing.Point(642, 0);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(208, 96);
            this.lblExplanation.TabIndex = 3;
            this.lblExplanation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEnter
            // 
            this.lblEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnter.Location = new System.Drawing.Point(3, 0);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(207, 96);
            this.lblEnter.TabIndex = 0;
            this.lblEnter.Text = "Enter key:";
            this.lblEnter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.Location = new System.Drawing.Point(429, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(207, 96);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Result:";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbKey
            // 
            this.tbKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbKey.Location = new System.Drawing.Point(216, 29);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(207, 38);
            this.tbKey.TabIndex = 2;
            // 
            // tlbLower
            // 
            this.tlbLower.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlbLower.ColumnCount = 1;
            this.tlbLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbLower.Controls.Add(this.lblSearched, 0, 1);
            this.tlbLower.Controls.Add(this.btnFind, 0, 0);
            this.tlbLower.Controls.Add(this.lblResultSet, 0, 2);
            this.tlbLower.Location = new System.Drawing.Point(3, 105);
            this.tlbLower.Name = "tlbLower";
            this.tlbLower.RowCount = 3;
            this.tlbLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tlbLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlbLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tlbLower.Size = new System.Drawing.Size(853, 404);
            this.tlbLower.TabIndex = 2;
            // 
            // lblSearched
            // 
            this.lblSearched.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearched.AutoSize = true;
            this.lblSearched.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearched.Location = new System.Drawing.Point(3, 168);
            this.lblSearched.Name = "lblSearched";
            this.lblSearched.Size = new System.Drawing.Size(847, 67);
            this.lblSearched.TabIndex = 4;
            this.lblSearched.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFind.Location = new System.Drawing.Point(96, 3);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(660, 162);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "FIND KEY";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // lblResultSet
            // 
            this.lblResultSet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResultSet.Location = new System.Drawing.Point(3, 238);
            this.lblResultSet.Multiline = true;
            this.lblResultSet.Name = "lblResultSet";
            this.lblResultSet.ReadOnly = true;
            this.lblResultSet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblResultSet.Size = new System.Drawing.Size(847, 163);
            this.lblResultSet.TabIndex = 5;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 537);
            this.Controls.Add(this.tblGeneral);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tblGeneral.ResumeLayout(false);
            this.tlpUpper.ResumeLayout(false);
            this.tlpUpper.PerformLayout();
            this.tlbLower.ResumeLayout(false);
            this.tlbLower.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblGeneral;
        private System.Windows.Forms.TableLayoutPanel tlpUpper;
        private System.Windows.Forms.Label lblExplanation;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.TableLayoutPanel tlbLower;
        private System.Windows.Forms.Label lblSearched;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox lblResultSet;
    }
}

