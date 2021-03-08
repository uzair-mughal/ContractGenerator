namespace Contarctible
{
    partial class Edit_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Page));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.wording_textBox = new System.Windows.Forms.TextBox();
            this.descrption_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cancel_button);
            this.groupBox2.Controls.Add(this.save_button);
            this.groupBox2.Controls.Add(this.wording_textBox);
            this.groupBox2.Controls.Add(this.descrption_textBox);
            this.groupBox2.Controls.Add(this.name_textBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 549);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Clause";
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.White;
            this.cancel_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_button.Location = new System.Drawing.Point(465, 487);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(104, 39);
            this.cancel_button.TabIndex = 9;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.White;
            this.save_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_button.Location = new System.Drawing.Point(132, 487);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(104, 39);
            this.save_button.TabIndex = 8;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click_1);
            // 
            // wording_textBox
            // 
            this.wording_textBox.Location = new System.Drawing.Point(132, 207);
            this.wording_textBox.Multiline = true;
            this.wording_textBox.Name = "wording_textBox";
            this.wording_textBox.Size = new System.Drawing.Size(437, 260);
            this.wording_textBox.TabIndex = 7;
            this.wording_textBox.TextChanged += new System.EventHandler(this.wording_textBox_TextChanged);
            // 
            // descrption_textBox
            // 
            this.descrption_textBox.Location = new System.Drawing.Point(132, 96);
            this.descrption_textBox.Multiline = true;
            this.descrption_textBox.Name = "descrption_textBox";
            this.descrption_textBox.Size = new System.Drawing.Size(437, 105);
            this.descrption_textBox.TabIndex = 6;
            this.descrption_textBox.TextChanged += new System.EventHandler(this.descrption_textBox_TextChanged);
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(132, 54);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(437, 34);
            this.name_textBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Wording:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // Edit_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(644, 574);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit_Page";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.TextBox wording_textBox;
        private System.Windows.Forms.TextBox descrption_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancel_button;
    }
}