
namespace Ceiling_Fan
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
            this.btnSpeed = new System.Windows.Forms.Button();
            this.btnDirection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSpeedOutput = new System.Windows.Forms.Label();
            this.lblDirectionOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSpeed
            // 
            this.btnSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeed.Location = new System.Drawing.Point(28, 126);
            this.btnSpeed.Name = "btnSpeed";
            this.btnSpeed.Size = new System.Drawing.Size(140, 37);
            this.btnSpeed.TabIndex = 0;
            this.btnSpeed.Text = "Speed cord";
            this.btnSpeed.UseVisualStyleBackColor = true;
            this.btnSpeed.Click += new System.EventHandler(this.btnSpeed_Click);
            // 
            // btnDirection
            // 
            this.btnDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirection.Location = new System.Drawing.Point(213, 126);
            this.btnDirection.Name = "btnDirection";
            this.btnDirection.Size = new System.Drawing.Size(140, 37);
            this.btnDirection.TabIndex = 1;
            this.btnDirection.Text = "Direction cord";
            this.btnDirection.UseVisualStyleBackColor = true;
            this.btnDirection.Click += new System.EventHandler(this.btnDirection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current fan speed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Direction of fan:";
            // 
            // lblSpeedOutput
            // 
            this.lblSpeedOutput.AutoSize = true;
            this.lblSpeedOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeedOutput.Location = new System.Drawing.Point(210, 12);
            this.lblSpeedOutput.Name = "lblSpeedOutput";
            this.lblSpeedOutput.Size = new System.Drawing.Size(0, 20);
            this.lblSpeedOutput.TabIndex = 4;
            // 
            // lblDirectionOutput
            // 
            this.lblDirectionOutput.AutoSize = true;
            this.lblDirectionOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectionOutput.Location = new System.Drawing.Point(210, 67);
            this.lblDirectionOutput.Name = "lblDirectionOutput";
            this.lblDirectionOutput.Size = new System.Drawing.Size(0, 20);
            this.lblDirectionOutput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 176);
            this.Controls.Add(this.lblDirectionOutput);
            this.Controls.Add(this.lblSpeedOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDirection);
            this.Controls.Add(this.btnSpeed);
            this.Name = "Form1";
            this.Text = "Ceiling Fan Application by Daniel Hoyt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpeed;
        private System.Windows.Forms.Button btnDirection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSpeedOutput;
        private System.Windows.Forms.Label lblDirectionOutput;
    }
}

