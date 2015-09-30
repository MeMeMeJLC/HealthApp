namespace HealthApp
{
    partial class FormMain
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
            this.lblDates = new System.Windows.Forms.Label();
            this.listBoxDates = new System.Windows.Forms.ListBox();
            this.listBoxDateSymptoms = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnvirFactorsCreate = new System.Windows.Forms.Button();
            this.txtBxOverallHealthNum = new System.Windows.Forms.TextBox();
            this.lblOverallHealthNum = new System.Windows.Forms.Label();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDates
            // 
            this.lblDates.AutoSize = true;
            this.lblDates.Location = new System.Drawing.Point(12, 245);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(35, 13);
            this.lblDates.TabIndex = 0;
            this.lblDates.Text = "Dates";
            // 
            // listBoxDates
            // 
            this.listBoxDates.FormattingEnabled = true;
            this.listBoxDates.Location = new System.Drawing.Point(11, 272);
            this.listBoxDates.Name = "listBoxDates";
            this.listBoxDates.Size = new System.Drawing.Size(150, 95);
            this.listBoxDates.TabIndex = 1;
            this.listBoxDates.SelectedIndexChanged += new System.EventHandler(this.listBoxHealth_SelectedIndexChanged);
            // 
            // listBoxDateSymptoms
            // 
            this.listBoxDateSymptoms.FormattingEnabled = true;
            this.listBoxDateSymptoms.Location = new System.Drawing.Point(189, 272);
            this.listBoxDateSymptoms.Name = "listBoxDateSymptoms";
            this.listBoxDateSymptoms.Size = new System.Drawing.Size(150, 95);
            this.listBoxDateSymptoms.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Symptoms";
            // 
            // btnEnvirFactorsCreate
            // 
            this.btnEnvirFactorsCreate.Location = new System.Drawing.Point(120, 90);
            this.btnEnvirFactorsCreate.Name = "btnEnvirFactorsCreate";
            this.btnEnvirFactorsCreate.Size = new System.Drawing.Size(75, 23);
            this.btnEnvirFactorsCreate.TabIndex = 4;
            this.btnEnvirFactorsCreate.Text = "Create";
            this.btnEnvirFactorsCreate.UseVisualStyleBackColor = true;
            this.btnEnvirFactorsCreate.Click += new System.EventHandler(this.btnEnvirFactorsCreate_Click);
            // 
            // txtBxOverallHealthNum
            // 
            this.txtBxOverallHealthNum.Location = new System.Drawing.Point(15, 42);
            this.txtBxOverallHealthNum.Name = "txtBxOverallHealthNum";
            this.txtBxOverallHealthNum.Size = new System.Drawing.Size(75, 20);
            this.txtBxOverallHealthNum.TabIndex = 5;
            // 
            // lblOverallHealthNum
            // 
            this.lblOverallHealthNum.AutoSize = true;
            this.lblOverallHealthNum.Location = new System.Drawing.Point(11, 26);
            this.lblOverallHealthNum.Name = "lblOverallHealthNum";
            this.lblOverallHealthNum.Size = new System.Drawing.Size(401, 13);
            this.lblOverallHealthNum.TabIndex = 6;
            this.lblOverallHealthNum.Text = "Enter how you feel your health has been today from 1 (terrible) to 10 (perfect) o" +
    "verall";
            this.lblOverallHealthNum.Click += new System.EventHandler(this.lblOverallHealthNum_Click);
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(14, 92);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCity.TabIndex = 7;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(11, 74);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(107, 13);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "What city are you in?";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 469);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtBoxCity);
            this.Controls.Add(this.lblOverallHealthNum);
            this.Controls.Add(this.txtBxOverallHealthNum);
            this.Controls.Add(this.btnEnvirFactorsCreate);
            this.Controls.Add(this.listBoxDateSymptoms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDates);
            this.Controls.Add(this.lblDates);
            this.Name = "FormMain";
            this.Text = "Symptom Tracker";
            this.Load += new System.EventHandler(this.FromMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDates;
        private System.Windows.Forms.ListBox listBoxDates;
        private System.Windows.Forms.ListBox listBoxDateSymptoms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnvirFactorsCreate;
        private System.Windows.Forms.TextBox txtBxOverallHealthNum;
        private System.Windows.Forms.Label lblOverallHealthNum;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.Label lblCity;
    }
}

