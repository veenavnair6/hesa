
namespace BeeStatusChecker
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
            this.btn_Dmg = new System.Windows.Forms.Button();
            this.tbl_lyt = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // btn_Dmg
            // 
            this.btn_Dmg.Location = new System.Drawing.Point(32, 40);
            this.btn_Dmg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Dmg.Name = "btn_Dmg";
            this.btn_Dmg.Size = new System.Drawing.Size(104, 36);
            this.btn_Dmg.TabIndex = 1;
            this.btn_Dmg.Text = "Damage";
            this.btn_Dmg.UseVisualStyleBackColor = true;
            this.btn_Dmg.Click += new System.EventHandler(this.btn_Dmg_Click);
            // 
            // tbl_lyt
            // 
            this.tbl_lyt.ColumnCount = 2;
            this.tbl_lyt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_lyt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_lyt.Location = new System.Drawing.Point(41, 122);
            this.tbl_lyt.Margin = new System.Windows.Forms.Padding(2);
            this.tbl_lyt.Name = "tbl_lyt";
            this.tbl_lyt.RowCount = 5;
            this.tbl_lyt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.29578F));
            this.tbl_lyt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.70422F));
            this.tbl_lyt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tbl_lyt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tbl_lyt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tbl_lyt.Size = new System.Drawing.Size(437, 201);
            this.tbl_lyt.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tbl_lyt);
            this.Controls.Add(this.btn_Dmg);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Dmg;
        private System.Windows.Forms.TableLayoutPanel tbl_lyt;
    }
}

