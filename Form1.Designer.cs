namespace DrawingBoard
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtn_drwEllipse = new System.Windows.Forms.RadioButton();
            this.radioBtn_drwCircle = new System.Windows.Forms.RadioButton();
            this.radioBtn_drwLine = new System.Windows.Forms.RadioButton();
            this.radioBtn_drwRect = new System.Windows.Forms.RadioButton();
            this.radioBtn_drwPolygon = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBtn_clrBlack = new System.Windows.Forms.RadioButton();
            this.radioBtn_clrRed = new System.Windows.Forms.RadioButton();
            this.radioBtn_clrBlue = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtn_drwPolygon);
            this.groupBox1.Controls.Add(this.radioBtn_drwRect);
            this.groupBox1.Controls.Add(this.radioBtn_drwLine);
            this.groupBox1.Controls.Add(this.radioBtn_drwCircle);
            this.groupBox1.Controls.Add(this.radioBtn_drwEllipse);
            this.groupBox1.Location = new System.Drawing.Point(641, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graf. objekti";
            // 
            // radioBtn_drwEllipse
            // 
            this.radioBtn_drwEllipse.AutoSize = true;
            this.radioBtn_drwEllipse.Location = new System.Drawing.Point(6, 21);
            this.radioBtn_drwEllipse.Name = "radioBtn_drwEllipse";
            this.radioBtn_drwEllipse.Size = new System.Drawing.Size(67, 21);
            this.radioBtn_drwEllipse.TabIndex = 0;
            this.radioBtn_drwEllipse.TabStop = true;
            this.radioBtn_drwEllipse.Text = "Elipsa";
            this.radioBtn_drwEllipse.UseVisualStyleBackColor = true;
            // 
            // radioBtn_drwCircle
            // 
            this.radioBtn_drwCircle.AutoSize = true;
            this.radioBtn_drwCircle.Location = new System.Drawing.Point(6, 48);
            this.radioBtn_drwCircle.Name = "radioBtn_drwCircle";
            this.radioBtn_drwCircle.Size = new System.Drawing.Size(84, 21);
            this.radioBtn_drwCircle.TabIndex = 1;
            this.radioBtn_drwCircle.TabStop = true;
            this.radioBtn_drwCircle.Text = "Kružnica";
            this.radioBtn_drwCircle.UseVisualStyleBackColor = true;
            // 
            // radioBtn_drwLine
            // 
            this.radioBtn_drwLine.AutoSize = true;
            this.radioBtn_drwLine.Location = new System.Drawing.Point(6, 75);
            this.radioBtn_drwLine.Name = "radioBtn_drwLine";
            this.radioBtn_drwLine.Size = new System.Drawing.Size(62, 21);
            this.radioBtn_drwLine.TabIndex = 2;
            this.radioBtn_drwLine.TabStop = true;
            this.radioBtn_drwLine.Text = "Linija";
            this.radioBtn_drwLine.UseVisualStyleBackColor = true;
            // 
            // radioBtn_drwRect
            // 
            this.radioBtn_drwRect.AutoSize = true;
            this.radioBtn_drwRect.Location = new System.Drawing.Point(6, 102);
            this.radioBtn_drwRect.Name = "radioBtn_drwRect";
            this.radioBtn_drwRect.Size = new System.Drawing.Size(103, 21);
            this.radioBtn_drwRect.TabIndex = 3;
            this.radioBtn_drwRect.TabStop = true;
            this.radioBtn_drwRect.Text = "Pravokutnik";
            this.radioBtn_drwRect.UseVisualStyleBackColor = true;
            // 
            // radioBtn_drwPolygon
            // 
            this.radioBtn_drwPolygon.AutoSize = true;
            this.radioBtn_drwPolygon.Location = new System.Drawing.Point(6, 129);
            this.radioBtn_drwPolygon.Name = "radioBtn_drwPolygon";
            this.radioBtn_drwPolygon.Size = new System.Drawing.Size(76, 21);
            this.radioBtn_drwPolygon.TabIndex = 4;
            this.radioBtn_drwPolygon.TabStop = true;
            this.radioBtn_drwPolygon.Text = "Poligon";
            this.radioBtn_drwPolygon.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBtn_clrBlue);
            this.groupBox2.Controls.Add(this.radioBtn_clrRed);
            this.groupBox2.Controls.Add(this.radioBtn_clrBlack);
            this.groupBox2.Location = new System.Drawing.Point(641, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 128);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Boja";
            // 
            // radioBtn_clrBlack
            // 
            this.radioBtn_clrBlack.AutoSize = true;
            this.radioBtn_clrBlack.Location = new System.Drawing.Point(6, 21);
            this.radioBtn_clrBlack.Name = "radioBtn_clrBlack";
            this.radioBtn_clrBlack.Size = new System.Drawing.Size(59, 21);
            this.radioBtn_clrBlack.TabIndex = 0;
            this.radioBtn_clrBlack.TabStop = true;
            this.radioBtn_clrBlack.Text = "Crna";
            this.radioBtn_clrBlack.UseVisualStyleBackColor = true;
            // 
            // radioBtn_clrRed
            // 
            this.radioBtn_clrRed.AutoSize = true;
            this.radioBtn_clrRed.Location = new System.Drawing.Point(6, 48);
            this.radioBtn_clrRed.Name = "radioBtn_clrRed";
            this.radioBtn_clrRed.Size = new System.Drawing.Size(74, 21);
            this.radioBtn_clrRed.TabIndex = 1;
            this.radioBtn_clrRed.TabStop = true;
            this.radioBtn_clrRed.Text = "Crvena";
            this.radioBtn_clrRed.UseVisualStyleBackColor = true;
            // 
            // radioBtn_clrBlue
            // 
            this.radioBtn_clrBlue.AutoSize = true;
            this.radioBtn_clrBlue.Location = new System.Drawing.Point(6, 75);
            this.radioBtn_clrBlue.Name = "radioBtn_clrBlue";
            this.radioBtn_clrBlue.Size = new System.Drawing.Size(64, 21);
            this.radioBtn_clrBlue.TabIndex = 2;
            this.radioBtn_clrBlue.TabStop = true;
            this.radioBtn_clrBlue.Text = "Plava";
            this.radioBtn_clrBlue.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtn_drwPolygon;
        private System.Windows.Forms.RadioButton radioBtn_drwRect;
        private System.Windows.Forms.RadioButton radioBtn_drwLine;
        private System.Windows.Forms.RadioButton radioBtn_drwCircle;
        private System.Windows.Forms.RadioButton radioBtn_drwEllipse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioBtn_clrBlue;
        private System.Windows.Forms.RadioButton radioBtn_clrRed;
        private System.Windows.Forms.RadioButton radioBtn_clrBlack;
    }
}

