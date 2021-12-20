
namespace kurs
{
    partial class Form2
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
            this.picDisplay2 = new System.Windows.Forms.PictureBox();
            this.tbDirection2 = new System.Windows.Forms.TrackBar();
            this.lblDirection = new System.Windows.Forms.Label();
            this.tbGraviton2 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton2)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay2
            // 
            this.picDisplay2.Location = new System.Drawing.Point(12, 12);
            this.picDisplay2.Name = "picDisplay2";
            this.picDisplay2.Size = new System.Drawing.Size(776, 361);
            this.picDisplay2.TabIndex = 0;
            this.picDisplay2.TabStop = false;
            // 
            // tbDirection2
            // 
            this.tbDirection2.Location = new System.Drawing.Point(53, 380);
            this.tbDirection2.Name = "tbDirection2";
            this.tbDirection2.Size = new System.Drawing.Size(130, 56);
            this.tbDirection2.TabIndex = 1;
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(190, 380);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(50, 20);
            this.lblDirection.TabIndex = 2;
            this.lblDirection.Text = "label1";
            // 
            // tbGraviton2
            // 
            this.tbGraviton2.Location = new System.Drawing.Point(551, 380);
            this.tbGraviton2.Name = "tbGraviton2";
            this.tbGraviton2.Size = new System.Drawing.Size(130, 56);
            this.tbGraviton2.TabIndex = 3;
            this.tbGraviton2.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbGraviton2);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.tbDirection2);
            this.Controls.Add(this.picDisplay2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picDisplay2;
        private System.Windows.Forms.TrackBar tbDirection2;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar tbGraviton2;
        private System.Windows.Forms.Timer timer1;
    }
}