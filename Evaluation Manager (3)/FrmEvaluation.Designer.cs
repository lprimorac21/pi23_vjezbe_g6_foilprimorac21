namespace Evaluation_Manager {
    partial class FrmEvaluation {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtMinForSignature = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinForGrade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboActivities = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtEvaluationDate = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numPoints = new System.Windows.Forms.Label();
            this.txtActivityDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMinForSignature
            // 
            this.txtMinForSignature.Location = new System.Drawing.Point(486, 55);
            this.txtMinForSignature.Name = "txtMinForSignature";
            this.txtMinForSignature.Size = new System.Drawing.Size(100, 20);
            this.txtMinForSignature.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Uvjet za potpis";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMinForGrade
            // 
            this.txtMinForGrade.Location = new System.Drawing.Point(649, 55);
            this.txtMinForGrade.Name = "txtMinForGrade";
            this.txtMinForGrade.Size = new System.Drawing.Size(100, 20);
            this.txtMinForGrade.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(646, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Uvjet za ocjenu:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboActivities
            // 
            this.cboActivities.FormattingEnabled = true;
            this.cboActivities.Location = new System.Drawing.Point(55, 54);
            this.cboActivities.Name = "cboActivities";
            this.cboActivities.Size = new System.Drawing.Size(254, 21);
            this.cboActivities.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Aktivnost";
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(311, 327);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(100, 20);
            this.txtTeacher.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ocjenivač";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(486, 327);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // txtEvaluationDate
            // 
            this.txtEvaluationDate.AutoSize = true;
            this.txtEvaluationDate.Location = new System.Drawing.Point(490, 310);
            this.txtEvaluationDate.Name = "txtEvaluationDate";
            this.txtEvaluationDate.Size = new System.Drawing.Size(89, 13);
            this.txtEvaluationDate.TabIndex = 9;
            this.txtEvaluationDate.Text = "Datum evaluacije";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(510, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(649, 373);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(649, 327);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 12;
            // 
            // numPoints
            // 
            this.numPoints.AutoSize = true;
            this.numPoints.Location = new System.Drawing.Point(663, 312);
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(40, 13);
            this.numPoints.TabIndex = 13;
            this.numPoints.Text = "Bodovi";
            // 
            // txtActivityDescription
            // 
            this.txtActivityDescription.Location = new System.Drawing.Point(55, 94);
            this.txtActivityDescription.Multiline = true;
            this.txtActivityDescription.Name = "txtActivityDescription";
            this.txtActivityDescription.Size = new System.Drawing.Size(694, 196);
            this.txtActivityDescription.TabIndex = 14;
            // 
            // FrmEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 420);
            this.Controls.Add(this.txtActivityDescription);
            this.Controls.Add(this.numPoints);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEvaluationDate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboActivities);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMinForGrade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMinForSignature);
            this.Name = "FrmEvaluation";
            this.Text = "FrmEvaluation";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMinForSignature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMinForGrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboActivities;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtEvaluationDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label numPoints;
        private System.Windows.Forms.TextBox txtActivityDescription;
    }
}