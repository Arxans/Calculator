
namespace Calculator
{
    partial class SorryView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewEquation = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(84, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sorry";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(37, 62);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(177, 80);
            this.label2.TabIndex = 1;
            this.label2.Text = "Our programmers are already dealing with the problem, the manager at this time be" +
    "ats them with a whip, while the director is tearing his hair out.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewEquation
            // 
            this.btnNewEquation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.btnNewEquation.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnNewEquation.FlatAppearance.BorderSize = 0;
            this.btnNewEquation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewEquation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewEquation.Location = new System.Drawing.Point(40, 160);
            this.btnNewEquation.Name = "btnNewEquation";
            this.btnNewEquation.Size = new System.Drawing.Size(174, 29);
            this.btnNewEquation.TabIndex = 2;
            this.btnNewEquation.Text = "NEW EQUATION";
            this.btnNewEquation.UseVisualStyleBackColor = false;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnQuit.Location = new System.Drawing.Point(40, 197);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(174, 29);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = false;
            // 
            // SorryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(254, 249);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnNewEquation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SorryView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sorry";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SorryView_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnNewEquation;
    }
}