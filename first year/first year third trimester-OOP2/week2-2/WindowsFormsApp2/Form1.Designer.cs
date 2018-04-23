namespace WindowsFormsApp2
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
            this.name = new System.Windows.Forms.Label();
            this.facNum = new System.Windows.Forms.Label();
            this.speciality = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.numBox = new System.Windows.Forms.TextBox();
            this.specBox = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(33, 50);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // facNum
            // 
            this.facNum.AutoSize = true;
            this.facNum.Location = new System.Drawing.Point(36, 84);
            this.facNum.Name = "facNum";
            this.facNum.Size = new System.Drawing.Size(81, 13);
            this.facNum.TabIndex = 1;
            this.facNum.Text = "Faculty Number";
            this.facNum.Click += new System.EventHandler(this.label2_Click);
            // 
            // speciality
            // 
            this.speciality.AutoSize = true;
            this.speciality.Location = new System.Drawing.Point(36, 113);
            this.speciality.Name = "speciality";
            this.speciality.Size = new System.Drawing.Size(52, 13);
            this.speciality.TabIndex = 2;
            this.speciality.Text = "Speciality";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(94, 47);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 3;
            // 
            // numBox
            // 
            this.numBox.Location = new System.Drawing.Point(123, 81);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(100, 20);
            this.numBox.TabIndex = 4;
            // 
            // specBox
            // 
            this.specBox.Location = new System.Drawing.Point(105, 113);
            this.specBox.Name = "specBox";
            this.specBox.Size = new System.Drawing.Size(100, 20);
            this.specBox.TabIndex = 5;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(281, 74);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 6;
            this.submitBtn.Text = "Enter Info";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 442);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.specBox);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.speciality);
            this.Controls.Add(this.facNum);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label facNum;
        private System.Windows.Forms.Label speciality;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox numBox;
        private System.Windows.Forms.TextBox specBox;
        private System.Windows.Forms.Button submitBtn;
    }
}

