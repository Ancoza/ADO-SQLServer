namespace HR_ADO_SQLServer
{
    partial class FrmHome
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

        private void InitializeComponent()
        {
            this.dgv_employees = new System.Windows.Forms.DataGridView();
            this.btn_jobs = new System.Windows.Forms.Button();
            this.btn_countries = new System.Windows.Forms.Button();
            this.btn_departments = new System.Windows.Forms.Button();
            this.btn_dependents = new System.Windows.Forms.Button();
            this.btn_locations = new System.Windows.Forms.Button();
            this.btn_regions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_employees
            // 
            this.dgv_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employees.Location = new System.Drawing.Point(12, 132);
            this.dgv_employees.Name = "dgv_employees";
            this.dgv_employees.Size = new System.Drawing.Size(1260, 417);
            this.dgv_employees.TabIndex = 0;
            // 
            // btn_jobs
            // 
            this.btn_jobs.Location = new System.Drawing.Point(384, 34);
            this.btn_jobs.Name = "btn_jobs";
            this.btn_jobs.Size = new System.Drawing.Size(91, 71);
            this.btn_jobs.TabIndex = 1;
            this.btn_jobs.Text = "Jobs";
            this.btn_jobs.UseVisualStyleBackColor = true;
            this.btn_jobs.Click += new System.EventHandler(this.btn_jobs_Click);
            // 
            // btn_countries
            // 
            this.btn_countries.Location = new System.Drawing.Point(27, 34);
            this.btn_countries.Name = "btn_countries";
            this.btn_countries.Size = new System.Drawing.Size(91, 71);
            this.btn_countries.TabIndex = 2;
            this.btn_countries.Text = "Countries";
            this.btn_countries.UseVisualStyleBackColor = true;
            // 
            // btn_departments
            // 
            this.btn_departments.Location = new System.Drawing.Point(144, 34);
            this.btn_departments.Name = "btn_departments";
            this.btn_departments.Size = new System.Drawing.Size(91, 71);
            this.btn_departments.TabIndex = 3;
            this.btn_departments.Text = "Departments";
            this.btn_departments.UseVisualStyleBackColor = true;
            // 
            // btn_dependents
            // 
            this.btn_dependents.Location = new System.Drawing.Point(267, 34);
            this.btn_dependents.Name = "btn_dependents";
            this.btn_dependents.Size = new System.Drawing.Size(91, 71);
            this.btn_dependents.TabIndex = 4;
            this.btn_dependents.Text = "Dependents";
            this.btn_dependents.UseVisualStyleBackColor = true;
            // 
            // btn_locations
            // 
            this.btn_locations.Location = new System.Drawing.Point(501, 34);
            this.btn_locations.Name = "btn_locations";
            this.btn_locations.Size = new System.Drawing.Size(91, 71);
            this.btn_locations.TabIndex = 5;
            this.btn_locations.Text = "Locations";
            this.btn_locations.UseVisualStyleBackColor = true;
            // 
            // btn_regions
            // 
            this.btn_regions.Location = new System.Drawing.Point(616, 34);
            this.btn_regions.Name = "btn_regions";
            this.btn_regions.Size = new System.Drawing.Size(91, 71);
            this.btn_regions.TabIndex = 6;
            this.btn_regions.Text = "Regions";
            this.btn_regions.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 561);
            this.Controls.Add(this.btn_regions);
            this.Controls.Add(this.btn_locations);
            this.Controls.Add(this.btn_dependents);
            this.Controls.Add(this.btn_departments);
            this.Controls.Add(this.btn_countries);
            this.Controls.Add(this.btn_jobs);
            this.Controls.Add(this.dgv_employees);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FormHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_employees;
        private System.Windows.Forms.Button btn_jobs;
        private System.Windows.Forms.Button btn_countries;
        private System.Windows.Forms.Button btn_departments;
        private System.Windows.Forms.Button btn_dependents;
        private System.Windows.Forms.Button btn_locations;
        private System.Windows.Forms.Button btn_regions;
    }
}

