namespace MathQuizApplication
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
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.differennce = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.difference = new System.Windows.Forms.Label();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.prooduct = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.timesRightLabel = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.Label();
            this.timesLeftLabel = new System.Windows.Forms.Label();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.dividedRightLabel = new System.Windows.Forms.Label();
            this.division = new System.Windows.Forms.Label();
            this.dividedLeftLabel = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.differennce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prooduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(221, 24);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Left";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.AutoSize = true;
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLabel.Location = new System.Drawing.Point(125, 78);
            this.plusLeftLabel.MaximumSize = new System.Drawing.Size(100, 100);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(25, 29);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.Click += new System.EventHandler(this.pulseLeftLabel_Click);
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.add.Location = new System.Drawing.Point(156, 78);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(27, 29);
            this.add.TabIndex = 3;
            this.add.Text = "+";
            this.add.Click += new System.EventHandler(this.label3_Click);
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.AutoSize = true;
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightLabel.Location = new System.Drawing.Point(198, 78);
            this.plusRightLabel.MaximumSize = new System.Drawing.Size(100, 100);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(25, 29);
            this.plusRightLabel.TabIndex = 4;
            this.plusRightLabel.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(229, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "=";
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.sum.Location = new System.Drawing.Point(274, 72);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(120, 35);
            this.sum.TabIndex = 1;
            // 
            // differennce
            // 
            this.differennce.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.differennce.Location = new System.Drawing.Point(274, 119);
            this.differennce.Name = "differennce";
            this.differennce.Size = new System.Drawing.Size(120, 35);
            this.differennce.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(229, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "=";
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.AutoSize = true;
            this.minusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRightLabel.Location = new System.Drawing.Point(198, 125);
            this.minusRightLabel.MaximumSize = new System.Drawing.Size(100, 100);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(25, 29);
            this.minusRightLabel.TabIndex = 9;
            this.minusRightLabel.Text = "?";
            // 
            // difference
            // 
            this.difference.AutoSize = true;
            this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.difference.Location = new System.Drawing.Point(156, 125);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(21, 29);
            this.difference.TabIndex = 8;
            this.difference.Text = "-";
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.AutoSize = true;
            this.minusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLeftLabel.Location = new System.Drawing.Point(125, 125);
            this.minusLeftLabel.MaximumSize = new System.Drawing.Size(100, 100);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(25, 29);
            this.minusLeftLabel.TabIndex = 7;
            this.minusLeftLabel.Text = "?";
            // 
            // prooduct
            // 
            this.prooduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.prooduct.Location = new System.Drawing.Point(274, 165);
            this.prooduct.Name = "prooduct";
            this.prooduct.Size = new System.Drawing.Size(120, 35);
            this.prooduct.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label8.Location = new System.Drawing.Point(229, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "=";
            // 
            // timesRightLabel
            // 
            this.timesRightLabel.AutoSize = true;
            this.timesRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesRightLabel.Location = new System.Drawing.Point(198, 171);
            this.timesRightLabel.MaximumSize = new System.Drawing.Size(100, 100);
            this.timesRightLabel.Name = "timesRightLabel";
            this.timesRightLabel.Size = new System.Drawing.Size(25, 29);
            this.timesRightLabel.TabIndex = 14;
            this.timesRightLabel.Text = "?";
            // 
            // product
            // 
            this.product.AutoSize = true;
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.product.Location = new System.Drawing.Point(156, 171);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(23, 29);
            this.product.TabIndex = 13;
            this.product.Text = "*";
            // 
            // timesLeftLabel
            // 
            this.timesLeftLabel.AutoSize = true;
            this.timesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLeftLabel.Location = new System.Drawing.Point(125, 171);
            this.timesLeftLabel.MaximumSize = new System.Drawing.Size(100, 100);
            this.timesLeftLabel.Name = "timesLeftLabel";
            this.timesLeftLabel.Size = new System.Drawing.Size(25, 29);
            this.timesLeftLabel.TabIndex = 12;
            this.timesLeftLabel.Text = "?";
            // 
            // quotient
            // 
            this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.quotient.Location = new System.Drawing.Point(274, 209);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(120, 35);
            this.quotient.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label12.Location = new System.Drawing.Point(229, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 29);
            this.label12.TabIndex = 20;
            this.label12.Text = "=";
            // 
            // dividedRightLabel
            // 
            this.dividedRightLabel.AutoSize = true;
            this.dividedRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedRightLabel.Location = new System.Drawing.Point(198, 215);
            this.dividedRightLabel.MaximumSize = new System.Drawing.Size(100, 100);
            this.dividedRightLabel.Name = "dividedRightLabel";
            this.dividedRightLabel.Size = new System.Drawing.Size(25, 29);
            this.dividedRightLabel.TabIndex = 19;
            this.dividedRightLabel.Text = "?";
            // 
            // division
            // 
            this.division.AutoSize = true;
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.division.Location = new System.Drawing.Point(156, 215);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(27, 29);
            this.division.TabIndex = 18;
            this.division.Text = "÷";
            // 
            // dividedLeftLabel
            // 
            this.dividedLeftLabel.AutoSize = true;
            this.dividedLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedLeftLabel.Location = new System.Drawing.Point(125, 215);
            this.dividedLeftLabel.MaximumSize = new System.Drawing.Size(100, 100);
            this.dividedLeftLabel.Name = "dividedLeftLabel";
            this.dividedLeftLabel.Size = new System.Drawing.Size(25, 29);
            this.dividedLeftLabel.TabIndex = 17;
            this.dividedLeftLabel.Text = "?";
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.startBtn.Location = new System.Drawing.Point(192, 281);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(135, 33);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start the Quiz";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 357);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dividedRightLabel);
            this.Controls.Add(this.division);
            this.Controls.Add(this.dividedLeftLabel);
            this.Controls.Add(this.prooduct);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.timesRightLabel);
            this.Controls.Add(this.product);
            this.Controls.Add(this.timesLeftLabel);
            this.Controls.Add(this.differennce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.add);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Quiz Application";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.differennce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prooduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label add;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown differennce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label difference;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.NumericUpDown prooduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label timesRightLabel;
        private System.Windows.Forms.Label product;
        private System.Windows.Forms.Label timesLeftLabel;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label dividedRightLabel;
        private System.Windows.Forms.Label division;
        private System.Windows.Forms.Label dividedLeftLabel;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Timer timer1;
    }
}

