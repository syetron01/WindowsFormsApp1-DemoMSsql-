namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IdNumTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.ViewDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label1.Location = new System.Drawing.Point(140, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label2.Location = new System.Drawing.Point(140, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // IdNumTextBox
            // 
            this.IdNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.IdNumTextBox.Location = new System.Drawing.Point(338, 89);
            this.IdNumTextBox.Name = "IdNumTextBox";
            this.IdNumTextBox.Size = new System.Drawing.Size(145, 46);
            this.IdNumTextBox.TabIndex = 2;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.NameTextBox.Location = new System.Drawing.Point(338, 173);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(145, 46);
            this.NameTextBox.TabIndex = 3;
            // 
            // DisplayButton
            // 
            this.DisplayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.DisplayButton.Location = new System.Drawing.Point(181, 260);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(251, 79);
            this.DisplayButton.TabIndex = 4;
            this.DisplayButton.Text = "Save";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // ViewDataButton
            // 
            this.ViewDataButton.Location = new System.Drawing.Point(237, 364);
            this.ViewDataButton.Name = "ViewDataButton";
            this.ViewDataButton.Size = new System.Drawing.Size(122, 51);
            this.ViewDataButton.TabIndex = 5;
            this.ViewDataButton.Text = "Display";
            this.ViewDataButton.UseVisualStyleBackColor = true;
            this.ViewDataButton.Click += new System.EventHandler(this.ViewDataButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewDataButton);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IdNumTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "S";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdNumTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button ViewDataButton;
    }
}

