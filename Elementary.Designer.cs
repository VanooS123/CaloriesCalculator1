using System.ComponentModel;

namespace CaloriesCalculator
{
    partial class Elementary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.GoingMainForm = new System.Windows.Forms.Button();
            this.Manual = new System.Windows.Forms.Button();
            this.ExitApplication = new System.Windows.Forms.Button();
            this.AboutAuthor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoingMainForm
            // 
            this.GoingMainForm.Location = new System.Drawing.Point(53, 197);
            this.GoingMainForm.Margin = new System.Windows.Forms.Padding(5);
            this.GoingMainForm.Name = "GoingMainForm";
            this.GoingMainForm.Size = new System.Drawing.Size(193, 58);
            this.GoingMainForm.TabIndex = 0;
            this.GoingMainForm.Text = "Перейти на главную форму";
            this.GoingMainForm.UseVisualStyleBackColor = true;
            this.GoingMainForm.Click += new System.EventHandler(this.GoingMainForm_Click);
            // 
            // Manual
            // 
            this.Manual.Location = new System.Drawing.Point(323, 197);
            this.Manual.Margin = new System.Windows.Forms.Padding(5);
            this.Manual.Name = "Manual";
            this.Manual.Size = new System.Drawing.Size(193, 58);
            this.Manual.TabIndex = 1;
            this.Manual.Text = "Справка";
            this.Manual.UseVisualStyleBackColor = true;
            this.Manual.Click += new System.EventHandler(this.Manual_Click);
            // 
            // ExitApplication
            // 
            this.ExitApplication.Location = new System.Drawing.Point(593, 197);
            this.ExitApplication.Margin = new System.Windows.Forms.Padding(5);
            this.ExitApplication.Name = "ExitApplication";
            this.ExitApplication.Size = new System.Drawing.Size(193, 58);
            this.ExitApplication.TabIndex = 2;
            this.ExitApplication.Text = "Выход";
            this.ExitApplication.UseVisualStyleBackColor = true;
            this.ExitApplication.Click += new System.EventHandler(this.ExitApplication_Click);
            // 
            // AboutAuthor
            // 
            this.AboutAuthor.Location = new System.Drawing.Point(323, 331);
            this.AboutAuthor.Margin = new System.Windows.Forms.Padding(5);
            this.AboutAuthor.Name = "AboutAuthor";
            this.AboutAuthor.Size = new System.Drawing.Size(193, 58);
            this.AboutAuthor.TabIndex = 3;
            this.AboutAuthor.Text = "Об авторе";
            this.AboutAuthor.UseVisualStyleBackColor = true;
            this.AboutAuthor.Click += new System.EventHandler(this.AboutAuthor_Click);
            // 
            // Elementary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 478);
            this.Controls.Add(this.AboutAuthor);
            this.Controls.Add(this.ExitApplication);
            this.Controls.Add(this.Manual);
            this.Controls.Add(this.GoingMainForm);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Elementary";
            this.Text = "Elementary";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button AboutAuthor;

        private System.Windows.Forms.Button Manual;
        private System.Windows.Forms.Button ExitApplication;
        private System.Windows.Forms.Button GoingMainForm;

        #endregion
    }
}