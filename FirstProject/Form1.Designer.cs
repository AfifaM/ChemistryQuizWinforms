namespace FirstProject
{
    partial class MultipleChoiceGame
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.grpSingleAnswers = new System.Windows.Forms.GroupBox();
            this.rdoAnswer4 = new System.Windows.Forms.RadioButton();
            this.rdoAnswer3 = new System.Windows.Forms.RadioButton();
            this.rdoAnswer2 = new System.Windows.Forms.RadioButton();
            this.rdoAnswer1 = new System.Windows.Forms.RadioButton();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpSingleAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FirstProject.Properties.Resources.main_picture1;
            this.pictureBox1.Location = new System.Drawing.Point(312, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuestion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.ForeColor = System.Drawing.Color.White;
            this.txtQuestion.Location = new System.Drawing.Point(1, 156);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(909, 130);
            this.txtQuestion.TabIndex = 3;
            this.txtQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuestion.TextChanged += new System.EventHandler(this.txtQuestion_TextChanged);
            // 
            // grpSingleAnswers
            // 
            this.grpSingleAnswers.Controls.Add(this.rdoAnswer4);
            this.grpSingleAnswers.Controls.Add(this.rdoAnswer3);
            this.grpSingleAnswers.Controls.Add(this.rdoAnswer2);
            this.grpSingleAnswers.Controls.Add(this.rdoAnswer1);
            this.grpSingleAnswers.Location = new System.Drawing.Point(1, 320);
            this.grpSingleAnswers.Name = "grpSingleAnswers";
            this.grpSingleAnswers.Size = new System.Drawing.Size(909, 143);
            this.grpSingleAnswers.TabIndex = 4;
            this.grpSingleAnswers.TabStop = false;
            this.grpSingleAnswers.Enter += new System.EventHandler(this.grpSingleAnswers_Enter);
            // 
            // rdoAnswer4
            // 
            this.rdoAnswer4.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoAnswer4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rdoAnswer4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoAnswer4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAnswer4.ForeColor = System.Drawing.Color.White;
            this.rdoAnswer4.Location = new System.Drawing.Point(473, 82);
            this.rdoAnswer4.Name = "rdoAnswer4";
            this.rdoAnswer4.Size = new System.Drawing.Size(424, 51);
            this.rdoAnswer4.TabIndex = 3;
            this.rdoAnswer4.Text = "radioButton1";
            this.rdoAnswer4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoAnswer4.UseVisualStyleBackColor = false;
            // 
            // rdoAnswer3
            // 
            this.rdoAnswer3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoAnswer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rdoAnswer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoAnswer3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAnswer3.ForeColor = System.Drawing.Color.White;
            this.rdoAnswer3.Location = new System.Drawing.Point(14, 82);
            this.rdoAnswer3.Name = "rdoAnswer3";
            this.rdoAnswer3.Size = new System.Drawing.Size(424, 51);
            this.rdoAnswer3.TabIndex = 2;
            this.rdoAnswer3.Text = "radioButton1";
            this.rdoAnswer3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoAnswer3.UseVisualStyleBackColor = false;
            // 
            // rdoAnswer2
            // 
            this.rdoAnswer2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoAnswer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rdoAnswer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoAnswer2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAnswer2.ForeColor = System.Drawing.Color.White;
            this.rdoAnswer2.Location = new System.Drawing.Point(473, 15);
            this.rdoAnswer2.Name = "rdoAnswer2";
            this.rdoAnswer2.Size = new System.Drawing.Size(424, 51);
            this.rdoAnswer2.TabIndex = 1;
            this.rdoAnswer2.Text = "radioButton1";
            this.rdoAnswer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoAnswer2.UseVisualStyleBackColor = false;
            // 
            // rdoAnswer1
            // 
            this.rdoAnswer1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoAnswer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rdoAnswer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoAnswer1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAnswer1.ForeColor = System.Drawing.Color.White;
            this.rdoAnswer1.Location = new System.Drawing.Point(14, 15);
            this.rdoAnswer1.Name = "rdoAnswer1";
            this.rdoAnswer1.Size = new System.Drawing.Size(424, 51);
            this.rdoAnswer1.TabIndex = 0;
            this.rdoAnswer1.Text = "radioButton1";
            this.rdoAnswer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoAnswer1.UseVisualStyleBackColor = false;
            this.rdoAnswer1.CheckedChanged += new System.EventHandler(this.rdoAnswer1_CheckedChanged);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(15, 12);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(101, 35);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(15, 475);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(101, 35);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(797, 475);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(101, 35);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(398, 475);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(109, 35);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblScore
            // 
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScore.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(784, 12);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(114, 37);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "Score:";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestion
            // 
            this.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuestion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(15, 125);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(53, 28);
            this.lblQuestion.TabIndex = 10;
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // MultipleChoiceGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(910, 522);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.grpSingleAnswers);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "MultipleChoiceGame";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpSingleAnswers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.GroupBox grpSingleAnswers;
        private System.Windows.Forms.RadioButton rdoAnswer1;
        private System.Windows.Forms.RadioButton rdoAnswer4;
        private System.Windows.Forms.RadioButton rdoAnswer3;
        private System.Windows.Forms.RadioButton rdoAnswer2;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblQuestion;
    }
}

