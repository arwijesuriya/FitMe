namespace FitMe
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFitness = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNutrition = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(81)))));
            this.button1.FlatAppearance.BorderSize = 10;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(631, 665);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(81)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(115, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(402, 273);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnFitness
            // 
            this.btnFitness.AutoSize = true;
            this.btnFitness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(81)))));
            this.btnFitness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFitness.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(81)))));
            this.btnFitness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFitness.Font = new System.Drawing.Font("Californian FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFitness.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFitness.Location = new System.Drawing.Point(146, 235);
            this.btnFitness.Name = "btnFitness";
            this.btnFitness.Size = new System.Drawing.Size(340, 93);
            this.btnFitness.TabIndex = 2;
            this.btnFitness.Text = "Fitness Results";
            this.btnFitness.UseVisualStyleBackColor = false;
            this.btnFitness.Click += new System.EventHandler(this.btnFitness_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(386, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(277, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 58);
            this.label1.TabIndex = 6;
            this.label1.Text = "FitMe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNutrition
            // 
            this.btnNutrition.AutoSize = true;
            this.btnNutrition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(81)))));
            this.btnNutrition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNutrition.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(81)))));
            this.btnNutrition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNutrition.Font = new System.Drawing.Font("Californian FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNutrition.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNutrition.Location = new System.Drawing.Point(146, 353);
            this.btnNutrition.Name = "btnNutrition";
            this.btnNutrition.Size = new System.Drawing.Size(340, 93);
            this.btnNutrition.TabIndex = 7;
            this.btnNutrition.Text = "Nutrition Advice";
            this.btnNutrition.UseVisualStyleBackColor = false;
            this.btnNutrition.Click += new System.EventHandler(this.btnNutrition_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(81)))));
            this.label2.Location = new System.Drawing.Point(253, 627);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Project By Group C1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 665);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNutrition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFitness);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(646, 704);
            this.MinimumSize = new System.Drawing.Size(646, 704);
            this.Name = "Home";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "FitMe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnFitness;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNutrition;
        private System.Windows.Forms.Label label2;
    }
}

