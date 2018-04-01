namespace SageCRMDotNetTemplatesVSIX.Wizards.WebPageItemWizard
{
    partial class WebPageItemForm
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
            this.SuspendLayout();
            // 
            // cbxOverrideBuildContents
            // 
            this.cbxOverrideBuildContents.AutoSize = true;
            this.cbxOverrideBuildContents.Location = new System.Drawing.Point(12, 12);
            this.cbxOverrideBuildContents.Name = "cbxOverrideBuildContents";
            this.cbxOverrideBuildContents.Size = new System.Drawing.Size(134, 17);
            this.cbxOverrideBuildContents.TabIndex = 0;
            this.cbxOverrideBuildContents.Text = "Override BuildContents";
            this.cbxOverrideBuildContents.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(281, 36);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "&Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // WebPageItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 69);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cbxOverrideBuildContents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WebPageItemForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Web Page Item Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxOverrideBuildContents;
        private System.Windows.Forms.Button btnCreate;
    }
}