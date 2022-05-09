
namespace PlaneFall.UI_design
{
    partial class FormHeader
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
            this.pnHeader = new System.Windows.Forms.Panel();
            this.btnMinimizate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnContent = new System.Windows.Forms.Panel();
            this.pnHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnHeader.Controls.Add(this.btnMinimizate);
            this.pnHeader.Controls.Add(this.btnClose);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(957, 27);
            this.pnHeader.TabIndex = 0;
            this.pnHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseDown);
            this.pnHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseMove);
            this.pnHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseUp);
            // 
            // btnMinimizate
            // 
            this.btnMinimizate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinimizate.BackColor = System.Drawing.Color.DimGray;
            this.btnMinimizate.FlatAppearance.BorderSize = 0;
            this.btnMinimizate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinimizate.ForeColor = System.Drawing.Color.Black;
            this.btnMinimizate.Location = new System.Drawing.Point(897, 0);
            this.btnMinimizate.Name = "btnMinimizate";
            this.btnMinimizate.Size = new System.Drawing.Size(29, 27);
            this.btnMinimizate.TabIndex = 1;
            this.btnMinimizate.Text = "_";
            this.btnMinimizate.UseVisualStyleBackColor = false;
            this.btnMinimizate.Click += new System.EventHandler(this.btnMinimizate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(929, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 26);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.Color.Gray;
            this.pnContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnContent.ImeMode = System.Windows.Forms.ImeMode.On;
            this.pnContent.Location = new System.Drawing.Point(0, 27);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(957, 470);
            this.pnContent.TabIndex = 1;
            // 
            // FormHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 497);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHeader";
            this.Text = "FormHeader";
            this.pnHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.Button btnMinimizate;
    }
}