namespace GameOfLife
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.btnRandom = new System.Windows.Forms.RadioButton();
            this.btnCustom = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(182, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grid length:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblOutput.Location = new System.Drawing.Point(40, 117);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 23);
            this.lblOutput.TabIndex = 1;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(270, 30);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(33, 22);
            this.txtInput.TabIndex = 2;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(35, 31);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(35, 60);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(75, 23);
            this.btnInit.TabIndex = 4;
            this.btnInit.Text = "INIT";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.BtnInit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(342, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "cells:";
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(377, 30);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(33, 22);
            this.txtInput2.TabIndex = 6;
            // 
            // btnRandom
            // 
            this.btnRandom.AutoSize = true;
            this.btnRandom.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRandom.Location = new System.Drawing.Point(458, 31);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(82, 21);
            this.btnRandom.TabIndex = 7;
            this.btnRandom.TabStop = true;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            // 
            // btnCustom
            // 
            this.btnCustom.AutoSize = true;
            this.btnCustom.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCustom.Location = new System.Drawing.Point(458, 55);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(76, 21);
            this.btnCustom.TabIndex = 8;
            this.btnCustom.TabStop = true;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(615, 494);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.RadioButton btnRandom;
        private System.Windows.Forms.RadioButton btnCustom;
        private System.Windows.Forms.Timer timer1;
    }
}

