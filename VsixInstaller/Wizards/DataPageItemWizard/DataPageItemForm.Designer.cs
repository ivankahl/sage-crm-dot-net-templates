namespace SageCRMDotNetTemplatesVSIX.Wizards.DataPageItemWizard
{
    partial class DataPageItemForm
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
            this.cbxOverrideBuildContents = new System.Windows.Forms.CheckBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxIncludeDetailScreen = new System.Windows.Forms.CheckBox();
            this.txtDetailScreen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEntityIDField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEntityName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxOverrideBuildContents
            // 
            this.cbxOverrideBuildContents.AutoSize = true;
            this.cbxOverrideBuildContents.Location = new System.Drawing.Point(12, 196);
            this.cbxOverrideBuildContents.Name = "cbxOverrideBuildContents";
            this.cbxOverrideBuildContents.Size = new System.Drawing.Size(134, 17);
            this.cbxOverrideBuildContents.TabIndex = 6;
            this.cbxOverrideBuildContents.Text = "Override BuildContents";
            this.cbxOverrideBuildContents.UseVisualStyleBackColor = true;
            this.cbxOverrideBuildContents.CheckedChanged += new System.EventHandler(this.cbxOverrideBuildContents_CheckedChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(281, 223);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "&Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxIncludeDetailScreen);
            this.groupBox3.Controls.Add(this.txtDetailScreen);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 64);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Screens";
            // 
            // cbxIncludeDetailScreen
            // 
            this.cbxIncludeDetailScreen.AutoSize = true;
            this.cbxIncludeDetailScreen.Checked = true;
            this.cbxIncludeDetailScreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxIncludeDetailScreen.Location = new System.Drawing.Point(323, 35);
            this.cbxIncludeDetailScreen.Name = "cbxIncludeDetailScreen";
            this.cbxIncludeDetailScreen.Size = new System.Drawing.Size(15, 14);
            this.cbxIncludeDetailScreen.TabIndex = 5;
            this.cbxIncludeDetailScreen.UseVisualStyleBackColor = true;
            // 
            // txtDetailScreen
            // 
            this.txtDetailScreen.Location = new System.Drawing.Point(9, 32);
            this.txtDetailScreen.Name = "txtDetailScreen";
            this.txtDetailScreen.Size = new System.Drawing.Size(308, 20);
            this.txtDetailScreen.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Detail Screen";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEntityIDField);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEntityName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 108);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // txtEntityIDField
            // 
            this.txtEntityIDField.Location = new System.Drawing.Point(9, 75);
            this.txtEntityIDField.Name = "txtEntityIDField";
            this.txtEntityIDField.Size = new System.Drawing.Size(329, 20);
            this.txtEntityIDField.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entity ID Field";
            // 
            // txtEntityName
            // 
            this.txtEntityName.Location = new System.Drawing.Point(9, 32);
            this.txtEntityName.Name = "txtEntityName";
            this.txtEntityName.Size = new System.Drawing.Size(329, 20);
            this.txtEntityName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entity Name";
            // 
            // DataPageItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 259);
            this.Controls.Add(this.cbxOverrideBuildContents);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataPageItemForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "DataPage Setup";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxOverrideBuildContents;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbxIncludeDetailScreen;
        private System.Windows.Forms.TextBox txtDetailScreen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEntityIDField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEntityName;
        private System.Windows.Forms.Label label1;
    }
}