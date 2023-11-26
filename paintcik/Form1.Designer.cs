namespace paintcik
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.circleBtn = new System.Windows.Forms.Button();
            this.rectangleBtn = new System.Windows.Forms.Button();
            this.lineBtn = new System.Windows.Forms.Button();
            this.eraserBtn = new System.Windows.Forms.Button();
            this.fillBtn = new System.Windows.Forms.Button();
            this.pencilBtn = new System.Windows.Forms.Button();
            this.colorBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBtn = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.stringTB = new System.Windows.Forms.TextBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBtn);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.circleBtn);
            this.panel1.Controls.Add(this.rectangleBtn);
            this.panel1.Controls.Add(this.lineBtn);
            this.panel1.Controls.Add(this.eraserBtn);
            this.panel1.Controls.Add(this.fillBtn);
            this.panel1.Controls.Add(this.pencilBtn);
            this.panel1.Controls.Add(this.colorBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 88);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(36, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(878, 43);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(94, 25);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Zapisz";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(878, 3);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(94, 28);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Wyczyść";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // circleBtn
            // 
            this.circleBtn.Location = new System.Drawing.Point(790, 3);
            this.circleBtn.Name = "circleBtn";
            this.circleBtn.Size = new System.Drawing.Size(79, 65);
            this.circleBtn.TabIndex = 6;
            this.circleBtn.Text = "Koło";
            this.circleBtn.UseVisualStyleBackColor = true;
            this.circleBtn.Click += new System.EventHandler(this.circleBtn_Click);
            // 
            // rectangleBtn
            // 
            this.rectangleBtn.Location = new System.Drawing.Point(705, 3);
            this.rectangleBtn.Name = "rectangleBtn";
            this.rectangleBtn.Size = new System.Drawing.Size(79, 65);
            this.rectangleBtn.TabIndex = 5;
            this.rectangleBtn.Text = "Kwadrat";
            this.rectangleBtn.UseVisualStyleBackColor = true;
            this.rectangleBtn.Click += new System.EventHandler(this.rectangleBtn_Click);
            // 
            // lineBtn
            // 
            this.lineBtn.Location = new System.Drawing.Point(620, 3);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(79, 65);
            this.lineBtn.TabIndex = 4;
            this.lineBtn.Text = "Linia";
            this.lineBtn.UseVisualStyleBackColor = true;
            this.lineBtn.Click += new System.EventHandler(this.lineBtn_Click);
            // 
            // eraserBtn
            // 
            this.eraserBtn.Location = new System.Drawing.Point(535, 3);
            this.eraserBtn.Name = "eraserBtn";
            this.eraserBtn.Size = new System.Drawing.Size(79, 65);
            this.eraserBtn.TabIndex = 3;
            this.eraserBtn.Text = "Gumka ";
            this.eraserBtn.UseVisualStyleBackColor = true;
            this.eraserBtn.Click += new System.EventHandler(this.eraserBtn_Click);
            // 
            // fillBtn
            // 
            this.fillBtn.Location = new System.Drawing.Point(450, 3);
            this.fillBtn.Name = "fillBtn";
            this.fillBtn.Size = new System.Drawing.Size(79, 65);
            this.fillBtn.TabIndex = 2;
            this.fillBtn.Text = "Wypełnienie";
            this.fillBtn.UseVisualStyleBackColor = true;
            this.fillBtn.Click += new System.EventHandler(this.fillBtn_Click);
            // 
            // pencilBtn
            // 
            this.pencilBtn.Location = new System.Drawing.Point(365, 3);
            this.pencilBtn.Name = "pencilBtn";
            this.pencilBtn.Size = new System.Drawing.Size(79, 65);
            this.pencilBtn.TabIndex = 1;
            this.pencilBtn.Text = "Ołówek";
            this.pencilBtn.UseVisualStyleBackColor = true;
            this.pencilBtn.Click += new System.EventHandler(this.pencilBtn_Click);
            // 
            // colorBtn
            // 
            this.colorBtn.Location = new System.Drawing.Point(280, 3);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(79, 65);
            this.colorBtn.TabIndex = 0;
            this.colorBtn.Text = "Kolor";
            this.colorBtn.UseVisualStyleBackColor = true;
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 473);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // textBtn
            // 
            this.textBtn.Location = new System.Drawing.Point(195, 3);
            this.textBtn.Name = "textBtn";
            this.textBtn.Size = new System.Drawing.Size(79, 65);
            this.textBtn.TabIndex = 10;
            this.textBtn.Text = "Tekst";
            this.textBtn.UseVisualStyleBackColor = true;
            this.textBtn.Click += new System.EventHandler(this.textBtn_Click);
            // 
            // stringTB
            // 
            this.stringTB.Location = new System.Drawing.Point(391, 279);
            this.stringTB.Name = "stringTB";
            this.stringTB.Size = new System.Drawing.Size(225, 20);
            this.stringTB.TabIndex = 2;
            this.stringTB.Visible = false;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(456, 305);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmBtn.TabIndex = 3;
            this.confirmBtn.Text = "Potwierdź";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Visible = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.stringTB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button circleBtn;
        private System.Windows.Forms.Button rectangleBtn;
        private System.Windows.Forms.Button lineBtn;
        private System.Windows.Forms.Button eraserBtn;
        private System.Windows.Forms.Button fillBtn;
        private System.Windows.Forms.Button pencilBtn;
        private System.Windows.Forms.Button colorBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button textBtn;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox stringTB;
        private System.Windows.Forms.Button confirmBtn;
    }
}

