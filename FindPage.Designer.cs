namespace CreativeArtReach_InventoryManagement
{
    partial class FindPage
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstbxProjects = new System.Windows.Forms.ListBox();
            this.lblKids = new System.Windows.Forms.Label();
            this.txtbxKids = new System.Windows.Forms.TextBox();
            this.combobxSite = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(247, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(541, 73);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Possible Projects";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(2, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(239, 100);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstbxProjects
            // 
            this.lstbxProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxProjects.FormattingEnabled = true;
            this.lstbxProjects.ItemHeight = 46;
            this.lstbxProjects.Location = new System.Drawing.Point(12, 183);
            this.lstbxProjects.Name = "lstbxProjects";
            this.lstbxProjects.Size = new System.Drawing.Size(776, 234);
            this.lstbxProjects.TabIndex = 8;
            this.lstbxProjects.SelectedIndexChanged += new System.EventHandler(this.lstbxProjects_SelectedIndexChanged);
            // 
            // lblKids
            // 
            this.lblKids.AutoSize = true;
            this.lblKids.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKids.Location = new System.Drawing.Point(372, 118);
            this.lblKids.Name = "lblKids";
            this.lblKids.Size = new System.Drawing.Size(255, 37);
            this.lblKids.TabIndex = 9;
            this.lblKids.Text = "How Many Kids?";
            // 
            // txtbxKids
            // 
            this.txtbxKids.Location = new System.Drawing.Point(644, 123);
            this.txtbxKids.Name = "txtbxKids";
            this.txtbxKids.Size = new System.Drawing.Size(100, 31);
            this.txtbxKids.TabIndex = 10;
            this.txtbxKids.TextChanged += new System.EventHandler(this.txtbxKids_TextChanged);
            // 
            // combobxSite
            // 
            this.combobxSite.FormattingEnabled = true;
            this.combobxSite.Items.AddRange(new object[] {
            "Alamo",
            "Browns Valley",
            "Callison"});
            this.combobxSite.Location = new System.Drawing.Point(12, 123);
            this.combobxSite.Name = "combobxSite";
            this.combobxSite.Size = new System.Drawing.Size(212, 33);
            this.combobxSite.TabIndex = 11;
            this.combobxSite.Text = "Select Site";
            this.combobxSite.SelectedIndexChanged += new System.EventHandler(this.combobxSite_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(230, 118);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(119, 41);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FindPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.combobxSite);
            this.Controls.Add(this.txtbxKids);
            this.Controls.Add(this.lblKids);
            this.Controls.Add(this.lstbxProjects);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Name = "FindPage";
            this.Text = "FindPage";
            this.Load += new System.EventHandler(this.FindPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstbxProjects;
        private System.Windows.Forms.Label lblKids;
        private System.Windows.Forms.TextBox txtbxKids;
        private System.Windows.Forms.ComboBox combobxSite;
        private System.Windows.Forms.Button btnRefresh;
    }
}