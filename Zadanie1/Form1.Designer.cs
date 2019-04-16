using System;

namespace Zadanie1
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
            this.listOfToys = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listOfCreated = new System.Windows.Forms.ListBox();
            this.speedBox = new System.Windows.Forms.GroupBox();
            this.textSpeed = new System.Windows.Forms.TextBox();
            this.minusSpeed = new System.Windows.Forms.Button();
            this.plusSpeed = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.depthBox = new System.Windows.Forms.GroupBox();
            this.textDepth = new System.Windows.Forms.TextBox();
            this.depthMinus = new System.Windows.Forms.Button();
            this.depthPlus = new System.Windows.Forms.Button();
            this.heightBox = new System.Windows.Forms.GroupBox();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.heightMinus = new System.Windows.Forms.Button();
            this.heightPlus = new System.Windows.Forms.Button();
            this.speedBox.SuspendLayout();
            this.depthBox.SuspendLayout();
            this.heightBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listOfToys
            // 
            this.listOfToys.FormattingEnabled = true;
            this.listOfToys.Items.AddRange(new object[] {
            "Car",
            "Plane",
            "Submarine",
            "Computer"});
            this.listOfToys.Location = new System.Drawing.Point(12, 12);
            this.listOfToys.Name = "listOfToys";
            this.listOfToys.Size = new System.Drawing.Size(120, 199);
            this.listOfToys.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(169, 32);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(83, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listOfCreated
            // 
            this.listOfCreated.FormattingEnabled = true;
            this.listOfCreated.Location = new System.Drawing.Point(296, 12);
            this.listOfCreated.Name = "listOfCreated";
            this.listOfCreated.Size = new System.Drawing.Size(120, 199);
            this.listOfCreated.TabIndex = 2;
            this.listOfCreated.Click += new System.EventHandler(this.listOfCreated_Click);
            // 
            // speedBox
            // 
            this.speedBox.AutoSize = true;
            this.speedBox.Controls.Add(this.textSpeed);
            this.speedBox.Controls.Add(this.minusSpeed);
            this.speedBox.Controls.Add(this.plusSpeed);
            this.speedBox.Location = new System.Drawing.Point(483, 13);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(194, 61);
            this.speedBox.TabIndex = 3;
            this.speedBox.TabStop = false;
            this.speedBox.Text = "Speed";
            this.speedBox.Visible = false;
            // 
            // textSpeed
            // 
            this.textSpeed.Location = new System.Drawing.Point(49, 19);
            this.textSpeed.Name = "textSpeed";
            this.textSpeed.Size = new System.Drawing.Size(88, 20);
            this.textSpeed.TabIndex = 1;
            // 
            // minusSpeed
            // 
            this.minusSpeed.Location = new System.Drawing.Point(143, 19);
            this.minusSpeed.Name = "minusSpeed";
            this.minusSpeed.Size = new System.Drawing.Size(36, 22);
            this.minusSpeed.TabIndex = 0;
            this.minusSpeed.Text = "-";
            this.minusSpeed.UseVisualStyleBackColor = true;
            this.minusSpeed.Click += new System.EventHandler(this.minusSpeed_Click);
            // 
            // plusSpeed
            // 
            this.plusSpeed.Location = new System.Drawing.Point(7, 20);
            this.plusSpeed.Name = "plusSpeed";
            this.plusSpeed.Size = new System.Drawing.Size(36, 22);
            this.plusSpeed.TabIndex = 0;
            this.plusSpeed.Text = "+";
            this.plusSpeed.UseVisualStyleBackColor = true;
            this.plusSpeed.Click += new System.EventHandler(this.plusSpeed_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(169, 61);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(83, 23);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // depthBox
            // 
            this.depthBox.Controls.Add(this.textDepth);
            this.depthBox.Controls.Add(this.depthMinus);
            this.depthBox.Controls.Add(this.depthPlus);
            this.depthBox.Location = new System.Drawing.Point(483, 80);
            this.depthBox.Name = "depthBox";
            this.depthBox.Size = new System.Drawing.Size(194, 52);
            this.depthBox.TabIndex = 3;
            this.depthBox.TabStop = false;
            this.depthBox.Text = "Depth";
            this.depthBox.Visible = false;
            // 
            // textDepth
            // 
            this.textDepth.Location = new System.Drawing.Point(49, 19);
            this.textDepth.Name = "textDepth";
            this.textDepth.Size = new System.Drawing.Size(88, 20);
            this.textDepth.TabIndex = 1;
            // 
            // depthMinus
            // 
            this.depthMinus.Location = new System.Drawing.Point(143, 19);
            this.depthMinus.Name = "depthMinus";
            this.depthMinus.Size = new System.Drawing.Size(36, 22);
            this.depthMinus.TabIndex = 0;
            this.depthMinus.Text = "-";
            this.depthMinus.UseVisualStyleBackColor = true;
            this.depthMinus.Click += new System.EventHandler(this.depthMinus_Click);
            // 
            // depthPlus
            // 
            this.depthPlus.Location = new System.Drawing.Point(7, 20);
            this.depthPlus.Name = "depthPlus";
            this.depthPlus.Size = new System.Drawing.Size(36, 22);
            this.depthPlus.TabIndex = 0;
            this.depthPlus.Text = "+";
            this.depthPlus.UseVisualStyleBackColor = true;
            this.depthPlus.Click += new System.EventHandler(this.depthPlus_Click);
            // 
            // heightBox
            // 
            this.heightBox.Controls.Add(this.textHeight);
            this.heightBox.Controls.Add(this.heightMinus);
            this.heightBox.Controls.Add(this.heightPlus);
            this.heightBox.Location = new System.Drawing.Point(483, 138);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(194, 52);
            this.heightBox.TabIndex = 3;
            this.heightBox.TabStop = false;
            this.heightBox.Text = "Height";
            this.heightBox.Visible = false;
            // 
            // textHeight
            // 
            this.textHeight.Location = new System.Drawing.Point(49, 19);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(88, 20);
            this.textHeight.TabIndex = 1;
            // 
            // heightMinus
            // 
            this.heightMinus.Location = new System.Drawing.Point(143, 19);
            this.heightMinus.Name = "heightMinus";
            this.heightMinus.Size = new System.Drawing.Size(36, 22);
            this.heightMinus.TabIndex = 0;
            this.heightMinus.Text = "-";
            this.heightMinus.UseVisualStyleBackColor = true;
            this.heightMinus.Click += new System.EventHandler(this.heightMinus_Click);
            // 
            // heightPlus
            // 
            this.heightPlus.Location = new System.Drawing.Point(7, 20);
            this.heightPlus.Name = "heightPlus";
            this.heightPlus.Size = new System.Drawing.Size(36, 22);
            this.heightPlus.TabIndex = 0;
            this.heightPlus.Text = "+";
            this.heightPlus.UseVisualStyleBackColor = true;
            this.heightPlus.Click += new System.EventHandler(this.heightPlus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 270);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.depthBox);
            this.Controls.Add(this.speedBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.listOfCreated);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listOfToys);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.speedBox.ResumeLayout(false);
            this.speedBox.PerformLayout();
            this.depthBox.ResumeLayout(false);
            this.depthBox.PerformLayout();
            this.heightBox.ResumeLayout(false);
            this.heightBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

 

        #endregion

        private System.Windows.Forms.ListBox listOfToys;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listOfCreated;
        private System.Windows.Forms.GroupBox speedBox;
        private System.Windows.Forms.Button minusSpeed;
        private System.Windows.Forms.Button plusSpeed;
        private System.Windows.Forms.TextBox textSpeed;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.GroupBox depthBox;
        private System.Windows.Forms.TextBox textDepth;
        private System.Windows.Forms.Button depthMinus;
        private System.Windows.Forms.Button depthPlus;
        private System.Windows.Forms.GroupBox heightBox;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.Button heightMinus;
        private System.Windows.Forms.Button heightPlus;
        private EventHandler speedBox_Enter;
    }
}

