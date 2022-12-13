
namespace QLgac
{
    partial class LichGac
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUpdateVG = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnUpdateVG
            // 
            this.btnUpdateVG.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.btnUpdateVG.BorderRadius = 5;
            this.btnUpdateVG.BorderThickness = 2;
            this.btnUpdateVG.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.btnUpdateVG.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateVG.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateVG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateVG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateVG.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateVG.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateVG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(27)))), ((int)(((byte)(80)))));
            this.btnUpdateVG.Location = new System.Drawing.Point(1035, 24);
            this.btnUpdateVG.Name = "btnUpdateVG";
            this.btnUpdateVG.PressedColor = System.Drawing.Color.Coral;
            this.btnUpdateVG.Size = new System.Drawing.Size(140, 45);
            this.btnUpdateVG.TabIndex = 4;
            this.btnUpdateVG.Text = "Cập nhật";
            // 
            // LichGac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnUpdateVG);
            this.Name = "LichGac";
            this.Size = new System.Drawing.Size(1200, 510);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnUpdateVG;
    }
}
