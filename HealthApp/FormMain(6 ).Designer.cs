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
            this.components = new System.ComponentModel.Container();
            this.lblDates = new System.Windows.Forms.Label();
            this.listBoxDates = new System.Windows.Forms.ListBox();
            this.btnEnvirFactorsCreate = new System.Windows.Forms.Button();
            this.txtBxOverallHealthNum = new System.Windows.Forms.TextBox();
            this.lblOverallHealthNum = new System.Windows.Forms.Label();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCreateSymptom = new System.Windows.Forms.Button();
            this.textBoxSymptomSeverity = new System.Windows.Forms.TextBox();
            this.textBoxSymptomDescription = new System.Windows.Forms.TextBox();
            this.textBoxProblemArea = new System.Windows.Forms.TextBox();
            this.lblSymptomSeverity = new System.Windows.Forms.Label();
            this.lblSymptomDescription = new System.Windows.Forms.Label();
            this.lblProblemArea = new System.Windows.Forms.Label();
            this.lblDisplayTemp = new System.Windows.Forms.Label();
            this.lblDisplayOverallScore = new System.Windows.Forms.Label();
            this.healthDatabaseDataSet = new HealthApp.HealthDatabaseDataSet();
            this.environmentalFactorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.environmentalFactorTableAdapter = new HealthApp.HealthDatabaseDataSetTableAdapters.EnvironmentalFactorTableAdapter();
            this.symptomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.symptomTableAdapter = new HealthApp.HealthDatabaseDataSetTableAdapters.SymptomTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnDisplayHealthData = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDisplayByTemp = new System.Windows.Forms.Button();
            this.btnDisplayBySeverity = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.environmentalFactorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.symptomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDates
            // 
            this.lblDates.AutoSize = true;
            this.lblDates.Location = new System.Drawing.Point(4, 127);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(214, 13);
            this.lblDates.TabIndex = 0;
            this.lblDates.Text = "Step 2 - Select Date To Add Symptoms Too";
            // 
            // listBoxDates
            // 
            this.listBoxDates.FormattingEnabled = true;
            this.listBoxDates.Location = new System.Drawing.Point(7, 143);
            this.listBoxDates.Name = "listBoxDates";
            this.listBoxDates.Size = new System.Drawing.Size(133, 95);
            this.listBoxDates.TabIndex = 1;
            this.listBoxDates.SelectedIndexChanged += new System.EventHandler(this.listBoxHealth_SelectedIndexChanged);
            // 
            // btnEnvirFactorsCreate
            // 
            this.btnEnvirFactorsCreate.Location = new System.Drawing.Point(119, 69);
            this.btnEnvirFactorsCreate.Name = "btnEnvirFactorsCreate";
            this.btnEnvirFactorsCreate.Size = new System.Drawing.Size(75, 23);
            this.btnEnvirFactorsCreate.TabIndex = 4;
            this.btnEnvirFactorsCreate.Text = "Input Date";
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
            this.txtBoxCity.Location = new System.Drawing.Point(13, 69);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCity.TabIndex = 7;
            this.txtBoxCity.Text = "christchurch";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(7, 53);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(107, 13);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "What city are you in?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxCity);
            this.groupBox1.Controls.Add(this.lblCity);
            this.groupBox1.Controls.Add(this.btnEnvirFactorsCreate);
            this.groupBox1.Location = new System.Drawing.Point(1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 112);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1 - Create the Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCreateSymptom);
            this.groupBox2.Controls.Add(this.textBoxSymptomSeverity);
            this.groupBox2.Controls.Add(this.textBoxSymptomDescription);
            this.groupBox2.Controls.Add(this.textBoxProblemArea);
            this.groupBox2.Controls.Add(this.lblSymptomSeverity);
            this.groupBox2.Controls.Add(this.lblSymptomDescription);
            this.groupBox2.Controls.Add(this.lblProblemArea);
            this.groupBox2.Location = new System.Drawing.Point(-1, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 79);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 3 - Input Each Symptom";
            // 
            // btnCreateSymptom
            // 
            this.btnCreateSymptom.Location = new System.Drawing.Point(408, 46);
            this.btnCreateSymptom.Name = "btnCreateSymptom";
            this.btnCreateSymptom.Size = new System.Drawing.Size(129, 23);
            this.btnCreateSymptom.TabIndex = 6;
            this.btnCreateSymptom.Text = "Input Symptom";
            this.btnCreateSymptom.UseVisualStyleBackColor = true;
            this.btnCreateSymptom.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSymptomSeverity
            // 
            this.textBoxSymptomSeverity.Location = new System.Drawing.Point(287, 46);
            this.textBoxSymptomSeverity.Name = "textBoxSymptomSeverity";
            this.textBoxSymptomSeverity.Size = new System.Drawing.Size(100, 20);
            this.textBoxSymptomSeverity.TabIndex = 5;
            // 
            // textBoxSymptomDescription
            // 
            this.textBoxSymptomDescription.Location = new System.Drawing.Point(131, 46);
            this.textBoxSymptomDescription.Name = "textBoxSymptomDescription";
            this.textBoxSymptomDescription.Size = new System.Drawing.Size(100, 20);
            this.textBoxSymptomDescription.TabIndex = 4;
            // 
            // textBoxProblemArea
            // 
            this.textBoxProblemArea.Location = new System.Drawing.Point(14, 46);
            this.textBoxProblemArea.Name = "textBoxProblemArea";
            this.textBoxProblemArea.Size = new System.Drawing.Size(100, 20);
            this.textBoxProblemArea.TabIndex = 3;
            // 
            // lblSymptomSeverity
            // 
            this.lblSymptomSeverity.AutoSize = true;
            this.lblSymptomSeverity.Location = new System.Drawing.Point(244, 20);
            this.lblSymptomSeverity.Name = "lblSymptomSeverity";
            this.lblSymptomSeverity.Size = new System.Drawing.Size(213, 13);
            this.lblSymptomSeverity.TabIndex = 2;
            this.lblSymptomSeverity.Text = "Symptom Severity from 1 (worst) to 10 (best)";
            // 
            // lblSymptomDescription
            // 
            this.lblSymptomDescription.AutoSize = true;
            this.lblSymptomDescription.Location = new System.Drawing.Point(128, 20);
            this.lblSymptomDescription.Name = "lblSymptomDescription";
            this.lblSymptomDescription.Size = new System.Drawing.Size(106, 13);
            this.lblSymptomDescription.TabIndex = 1;
            this.lblSymptomDescription.Text = "Symptom Description";
            // 
            // lblProblemArea
            // 
            this.lblProblemArea.AutoSize = true;
            this.lblProblemArea.Location = new System.Drawing.Point(10, 20);
            this.lblProblemArea.Name = "lblProblemArea";
            this.lblProblemArea.Size = new System.Drawing.Size(70, 13);
            this.lblProblemArea.TabIndex = 0;
            this.lblProblemArea.Text = "Problem Area";
            // 
            // lblDisplayTemp
            // 
            this.lblDisplayTemp.AutoSize = true;
            this.lblDisplayTemp.Location = new System.Drawing.Point(198, 189);
            this.lblDisplayTemp.Name = "lblDisplayTemp";
            this.lblDisplayTemp.Size = new System.Drawing.Size(0, 13);
            this.lblDisplayTemp.TabIndex = 17;
            // 
            // lblDisplayOverallScore
            // 
            this.lblDisplayOverallScore.AutoSize = true;
            this.lblDisplayOverallScore.Location = new System.Drawing.Point(421, 189);
            this.lblDisplayOverallScore.Name = "lblDisplayOverallScore";
            this.lblDisplayOverallScore.Size = new System.Drawing.Size(0, 13);
            this.lblDisplayOverallScore.TabIndex = 18;
            // 
            // healthDatabaseDataSet
            // 
            this.healthDatabaseDataSet.DataSetName = "HealthDatabaseDataSet";
            this.healthDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // environmentalFactorBindingSource
            // 
            this.environmentalFactorBindingSource.DataMember = "EnvironmentalFactor";
            this.environmentalFactorBindingSource.DataSource = this.healthDatabaseDataSet;
            // 
            // environmentalFactorTableAdapter
            // 
            this.environmentalFactorTableAdapter.ClearBeforeFill = true;
            // 
            // symptomBindingSource
            // 
            this.symptomBindingSource.DataMember = "Symptom";
            this.symptomBindingSource.DataSource = this.healthDatabaseDataSet;
            // 
            // symptomTableAdapter
            // 
            this.symptomTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 53);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(634, 190);
            this.dataGridView2.TabIndex = 20;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btnDisplayHealthData
            // 
            this.btnDisplayHealthData.Location = new System.Drawing.Point(8, 19);
            this.btnDisplayHealthData.Name = "btnDisplayHealthData";
            this.btnDisplayHealthData.Size = new System.Drawing.Size(119, 29);
            this.btnDisplayHealthData.TabIndex = 21;
            this.btnDisplayHealthData.Text = "Display Health Data";
            this.btnDisplayHealthData.UseVisualStyleBackColor = true;
            this.btnDisplayHealthData.Click += new System.EventHandler(this.btnDisplayHealthData_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDisplayHealthData);
            this.groupBox3.Controls.Add(this.btnDisplayByTemp);
            this.groupBox3.Controls.Add(this.btnDisplayBySeverity);
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(7, 340);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(663, 280);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step 4 - Display Health Report";
            // 
            // btnDisplayByTemp
            // 
            this.btnDisplayByTemp.Location = new System.Drawing.Point(299, 19);
            this.btnDisplayByTemp.Name = "btnDisplayByTemp";
            this.btnDisplayByTemp.Size = new System.Drawing.Size(169, 28);
            this.btnDisplayByTemp.TabIndex = 22;
            this.btnDisplayByTemp.Text = "Display By Outside Temperature";
            this.btnDisplayByTemp.UseVisualStyleBackColor = true;
            this.btnDisplayByTemp.Click += new System.EventHandler(this.btnDisplayByTemp_Click);
            // 
            // btnDisplayBySeverity
            // 
            this.btnDisplayBySeverity.Location = new System.Drawing.Point(132, 19);
            this.btnDisplayBySeverity.Name = "btnDisplayBySeverity";
            this.btnDisplayBySeverity.Size = new System.Drawing.Size(161, 28);
            this.btnDisplayBySeverity.TabIndex = 21;
            this.btnDisplayBySeverity.Text = "Display By Symptom Severity";
            this.btnDisplayBySeverity.UseVisualStyleBackColor = true;
            this.btnDisplayBySeverity.Click += new System.EventHandler(this.btnDisplayBySeverity_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(481, 18);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(210, 60);
            this.btnAbout.TabIndex = 23;
            this.btnAbout.Text = "About Symptom Tracker";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 617);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.lblDisplayOverallScore);
            this.Controls.Add(this.lblDisplayTemp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblOverallHealthNum);
            this.Controls.Add(this.txtBxOverallHealthNum);
            this.Controls.Add(this.listBoxDates);
            this.Controls.Add(this.lblDates);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormMain";
            this.Text = "Symptom Tracker";
            this.Load += new System.EventHandler(this.FromMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.environmentalFactorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.symptomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDates;
        private System.Windows.Forms.ListBox listBoxDates;
        private System.Windows.Forms.Button btnEnvirFactorsCreate;
        private System.Windows.Forms.TextBox txtBxOverallHealthNum;
        private System.Windows.Forms.Label lblOverallHealthNum;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreateSymptom;
        private System.Windows.Forms.TextBox textBoxSymptomSeverity;
        private System.Windows.Forms.TextBox textBoxSymptomDescription;
        private System.Windows.Forms.TextBox textBoxProblemArea;
        private System.Windows.Forms.Label lblSymptomSeverity;
        private System.Windows.Forms.Label lblSymptomDescription;
        private System.Windows.Forms.Label lblProblemArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDisplayTemp;
        private System.Windows.Forms.Label lblDisplayOverallScore;
        private HealthDatabaseDataSet healthDatabaseDataSet;
        private System.Windows.Forms.BindingSource environmentalFactorBindingSource;
        private HealthDatabaseDataSetTableAdapters.EnvironmentalFactorTableAdapter environmentalFactorTableAdapter;
        private System.Windows.Forms.BindingSource symptomBindingSource;
        private HealthDatabaseDataSetTableAdapters.SymptomTableAdapter symptomTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnDisplayHealthData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDisplayByTemp;
        private System.Windows.Forms.Button btnDisplayBySeverity;
        private System.Windows.Forms.Button btnAbout;
    }
}

