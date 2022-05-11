namespace _PDIE__Hotel_Event_Management_System_v._2
{
    partial class MainMenuStaff
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnViewEvent = new System.Windows.Forms.Button();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(270, 206);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnViewEvent
            // 
            this.btnViewEvent.Location = new System.Drawing.Point(114, 97);
            this.btnViewEvent.Name = "btnViewEvent";
            this.btnViewEvent.Size = new System.Drawing.Size(128, 23);
            this.btnViewEvent.TabIndex = 13;
            this.btnViewEvent.Text = "View Event Schedule";
            this.btnViewEvent.UseVisualStyleBackColor = true;
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCreateEvent.Location = new System.Drawing.Point(98, 57);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(160, 23);
            this.btnCreateEvent.TabIndex = 12;
            this.btnCreateEvent.Text = "Create Event Reservation";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Staff System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hotel Event Management System";
            // 
            // MainMenuStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 234);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnViewEvent);
            this.Controls.Add(this.btnCreateEvent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainMenuStaff";
            this.Text = "MainMenu Staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnViewEvent;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}