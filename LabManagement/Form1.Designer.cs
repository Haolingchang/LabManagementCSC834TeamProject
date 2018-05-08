namespace LabManagement
{
    partial class MainScreen
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
            this.B1 = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.sortOptionBox = new System.Windows.Forms.GroupBox();
            this.compARB = new System.Windows.Forms.RadioButton();
            this.compDRB = new System.Windows.Forms.RadioButton();
            this.labSchedule = new System.Windows.Forms.GroupBox();
            this.scheduleRichBox = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labGroup = new System.Windows.Forms.GroupBox();
            this.d1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.d2 = new System.Windows.Forms.Button();
            this.d3 = new System.Windows.Forms.Button();
            this.d4 = new System.Windows.Forms.Button();
            this.sortOptionBox.SuspendLayout();
            this.labSchedule.SuspendLayout();
            this.labGroup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(3, 0);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(256, 47);
            this.B1.TabIndex = 0;
            this.B1.Tag = "button1";
            this.B1.Text = "lab1";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(6, 268);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(81, 26);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.Location = new System.Drawing.Point(148, 142);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(81, 26);
            this.applyButton.TabIndex = 4;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            // 
            // sortOptionBox
            // 
            this.sortOptionBox.BackColor = System.Drawing.SystemColors.Control;
            this.sortOptionBox.Controls.Add(this.compARB);
            this.sortOptionBox.Controls.Add(this.compDRB);
            this.sortOptionBox.Controls.Add(this.applyButton);
            this.sortOptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortOptionBox.Location = new System.Drawing.Point(490, 366);
            this.sortOptionBox.Name = "sortOptionBox";
            this.sortOptionBox.Size = new System.Drawing.Size(229, 174);
            this.sortOptionBox.TabIndex = 5;
            this.sortOptionBox.TabStop = false;
            this.sortOptionBox.Text = "Sort by";
            // 
            // compARB
            // 
            this.compARB.AutoSize = true;
            this.compARB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compARB.Location = new System.Drawing.Point(6, 63);
            this.compARB.Name = "compARB";
            this.compARB.Size = new System.Drawing.Size(214, 19);
            this.compARB.TabIndex = 6;
            this.compARB.TabStop = true;
            this.compARB.Text = "Available Computers: Less to More";
            this.compARB.UseVisualStyleBackColor = true;
            // 
            // compDRB
            // 
            this.compDRB.AutoSize = true;
            this.compDRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compDRB.Location = new System.Drawing.Point(6, 30);
            this.compDRB.Name = "compDRB";
            this.compDRB.Size = new System.Drawing.Size(214, 19);
            this.compDRB.TabIndex = 5;
            this.compDRB.TabStop = true;
            this.compDRB.Text = "Available Computers: More to Less";
            this.compDRB.UseVisualStyleBackColor = true;
            // 
            // labSchedule
            // 
            this.labSchedule.Controls.Add(this.scheduleRichBox);
            this.labSchedule.Controls.Add(this.textBox1);
            this.labSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSchedule.Location = new System.Drawing.Point(490, 71);
            this.labSchedule.Name = "labSchedule";
            this.labSchedule.Size = new System.Drawing.Size(229, 174);
            this.labSchedule.TabIndex = 6;
            this.labSchedule.TabStop = false;
            this.labSchedule.Text = "Schedule";
            // 
            // scheduleRichBox
            // 
            this.scheduleRichBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.scheduleRichBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scheduleRichBox.Location = new System.Drawing.Point(6, 46);
            this.scheduleRichBox.Name = "scheduleRichBox";
            this.scheduleRichBox.Size = new System.Drawing.Size(217, 122);
            this.scheduleRichBox.TabIndex = 1;
            this.scheduleRichBox.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(6, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(158, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Select a lab to view its schedule";
            // 
            // labGroup
            // 
            this.labGroup.Controls.Add(this.d4);
            this.labGroup.Controls.Add(this.d3);
            this.labGroup.Controls.Add(this.d2);
            this.labGroup.Controls.Add(this.panel1);
            this.labGroup.Controls.Add(this.d1);
            this.labGroup.Controls.Add(this.refreshButton);
            this.labGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGroup.Location = new System.Drawing.Point(96, 71);
            this.labGroup.Name = "labGroup";
            this.labGroup.Size = new System.Drawing.Size(362, 303);
            this.labGroup.TabIndex = 7;
            this.labGroup.TabStop = false;
            this.labGroup.Text = "Lab List";
            // 
            // d1
            // 
            this.d1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d1.Location = new System.Drawing.Point(274, 39);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(82, 47);
            this.d1.TabIndex = 4;
            this.d1.Text = "Detail";
            this.d1.UseVisualStyleBackColor = true;
            this.d1.Click += new System.EventHandler(this.Detail1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.B4);
            this.panel1.Controls.Add(this.B3);
            this.panel1.Controls.Add(this.B2);
            this.panel1.Controls.Add(this.B1);
            this.panel1.Location = new System.Drawing.Point(6, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 213);
            this.panel1.TabIndex = 5;
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(3, 53);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(256, 49);
            this.B2.TabIndex = 1;
            this.B2.Text = "lab2";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(3, 108);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(256, 49);
            this.B3.TabIndex = 2;
            this.B3.Text = "lab3";
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.B3_Click);
            // 
            // B4
            // 
            this.B4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B4.Location = new System.Drawing.Point(3, 163);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(256, 49);
            this.B4.TabIndex = 3;
            this.B4.Text = "lab4";
            this.B4.UseVisualStyleBackColor = true;
            this.B4.Click += new System.EventHandler(this.B4_Click);
            // 
            // d2
            // 
            this.d2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d2.Location = new System.Drawing.Point(274, 92);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(82, 47);
            this.d2.TabIndex = 6;
            this.d2.Text = "Detail";
            this.d2.UseVisualStyleBackColor = true;
            this.d2.Click += new System.EventHandler(this.d2_Click);
            // 
            // d3
            // 
            this.d3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d3.Location = new System.Drawing.Point(274, 149);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(82, 47);
            this.d3.TabIndex = 7;
            this.d3.Text = "Detail";
            this.d3.UseVisualStyleBackColor = true;
            this.d3.Click += new System.EventHandler(this.d3_Click);
            // 
            // d4
            // 
            this.d4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d4.Location = new System.Drawing.Point(274, 205);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(82, 47);
            this.d4.TabIndex = 8;
            this.d4.Text = "Detail";
            this.d4.UseVisualStyleBackColor = true;
            this.d4.Click += new System.EventHandler(this.d4_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 590);
            this.Controls.Add(this.labGroup);
            this.Controls.Add(this.labSchedule);
            this.Controls.Add(this.sortOptionBox);
            this.Name = "MainScreen";
            this.Text = "Lab Management System";
            this.sortOptionBox.ResumeLayout(false);
            this.sortOptionBox.PerformLayout();
            this.labSchedule.ResumeLayout(false);
            this.labSchedule.PerformLayout();
            this.labGroup.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.GroupBox sortOptionBox;
        private System.Windows.Forms.RadioButton compARB;
        private System.Windows.Forms.RadioButton compDRB;
        private System.Windows.Forms.GroupBox labSchedule;
        private System.Windows.Forms.GroupBox labGroup;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox scheduleRichBox;
        private System.Windows.Forms.Button d1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button d4;
        private System.Windows.Forms.Button d3;
        private System.Windows.Forms.Button d2;
    }
}

