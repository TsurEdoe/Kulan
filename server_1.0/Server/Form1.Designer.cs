namespace Server
{
    partial class adminView
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
            this.BTN_search = new System.Windows.Forms.Button();
            this.RBTN_user = new System.Windows.Forms.RadioButton();
            this.RBTN_event = new System.Windows.Forms.RadioButton();
            this.TXTBOX_search = new System.Windows.Forms.TextBox();
            this.LSTVIEW_results = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // BTN_search
            // 
            this.BTN_search.Location = new System.Drawing.Point(209, 190);
            this.BTN_search.Name = "BTN_search";
            this.BTN_search.Size = new System.Drawing.Size(115, 49);
            this.BTN_search.TabIndex = 2;
            this.BTN_search.Text = "Search";
            this.BTN_search.UseVisualStyleBackColor = true;
            this.BTN_search.Click += new System.EventHandler(this.BTN_search_Click);
            // 
            // RBTN_user
            // 
            this.RBTN_user.AutoSize = true;
            this.RBTN_user.Location = new System.Drawing.Point(59, 190);
            this.RBTN_user.Name = "RBTN_user";
            this.RBTN_user.Size = new System.Drawing.Size(47, 17);
            this.RBTN_user.TabIndex = 0;
            this.RBTN_user.TabStop = true;
            this.RBTN_user.Text = "User";
            this.RBTN_user.UseVisualStyleBackColor = true;
            // 
            // RBTN_event
            // 
            this.RBTN_event.AutoSize = true;
            this.RBTN_event.Location = new System.Drawing.Point(59, 222);
            this.RBTN_event.Name = "RBTN_event";
            this.RBTN_event.Size = new System.Drawing.Size(53, 17);
            this.RBTN_event.TabIndex = 1;
            this.RBTN_event.TabStop = true;
            this.RBTN_event.Text = "Event";
            this.RBTN_event.UseVisualStyleBackColor = true;
            // 
            // TXTBOX_search
            // 
            this.TXTBOX_search.Location = new System.Drawing.Point(12, 104);
            this.TXTBOX_search.Name = "TXTBOX_search";
            this.TXTBOX_search.Size = new System.Drawing.Size(133, 20);
            this.TXTBOX_search.TabIndex = 3;
            this.TXTBOX_search.Text = "Enter ID";
            // 
            // LSTVIEW_results
            // 
            this.LSTVIEW_results.Location = new System.Drawing.Point(209, 27);
            this.LSTVIEW_results.Name = "LSTVIEW_results";
            this.LSTVIEW_results.Size = new System.Drawing.Size(147, 134);
            this.LSTVIEW_results.TabIndex = 4;
            this.LSTVIEW_results.UseCompatibleStateImageBehavior = false;
            // 
            // adminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 328);
            this.Controls.Add(this.LSTVIEW_results);
            this.Controls.Add(this.TXTBOX_search);
            this.Controls.Add(this.BTN_search);
            this.Controls.Add(this.RBTN_event);
            this.Controls.Add(this.RBTN_user);
            this.Name = "adminView";
            this.Text = "Administrative View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_search;
        private System.Windows.Forms.RadioButton RBTN_user;
        private System.Windows.Forms.RadioButton RBTN_event;
        private System.Windows.Forms.TextBox TXTBOX_search;
        private System.Windows.Forms.ListView LSTVIEW_results;
    }
}

