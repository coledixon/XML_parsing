namespace XML_parseForm
{
    partial class XMLparser
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lvOutput = new System.Windows.Forms.ListView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(376, 26);
            this.txtSearch.TabIndex = 0;
            // 
            // lvOutput
            // 
            this.lvOutput.HideSelection = false;
            this.lvOutput.Location = new System.Drawing.Point(12, 70);
            this.lvOutput.Name = "lvOutput";
            this.lvOutput.Size = new System.Drawing.Size(599, 299);
            this.lvOutput.TabIndex = 1;
            this.lvOutput.UseCompatibleStateImageBehavior = false;
            this.lvOutput.View = System.Windows.Forms.View.List;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(409, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(202, 38);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // XMLparser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 383);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lvOutput);
            this.Controls.Add(this.txtSearch);
            this.Name = "XMLparser";
            this.Text = "XML Parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListView lvOutput;
        private System.Windows.Forms.Button btnSearch;
    }
}

