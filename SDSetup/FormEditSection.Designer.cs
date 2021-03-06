﻿namespace SDSetupManifestGenerator {
    partial class FormEditSection {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditSection));
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFooter = new System.Windows.Forms.TextBox();
            this.nudListingMode = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudWhenMode = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDeleteWhen = new System.Windows.Forms.Button();
            this.btnAddWhen = new System.Windows.Forms.Button();
            this.txtWhen = new System.Windows.Forms.TextBox();
            this.ddlPlatform = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxVisible = new System.Windows.Forms.CheckBox();
            this.lvwWhenDependencies = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.nudListingMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWhenMode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 64);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(505, 20);
            this.txtId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 103);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(505, 20);
            this.txtName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Display Name";
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(12, 142);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(505, 20);
            this.txtDisplayName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Section Footer (HTML)";
            // 
            // txtFooter
            // 
            this.txtFooter.Location = new System.Drawing.Point(12, 220);
            this.txtFooter.Name = "txtFooter";
            this.txtFooter.Size = new System.Drawing.Size(505, 20);
            this.txtFooter.TabIndex = 5;
            // 
            // nudListingMode
            // 
            this.nudListingMode.Location = new System.Drawing.Point(12, 181);
            this.nudListingMode.Name = "nudListingMode";
            this.nudListingMode.Size = new System.Drawing.Size(120, 20);
            this.nudListingMode.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ListingMode (0: checkboxes, 1: menu buttons)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(539, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "When Mode (0: all, 1: any)";
            // 
            // nudWhenMode
            // 
            this.nudWhenMode.Location = new System.Drawing.Point(542, 25);
            this.nudWhenMode.Name = "nudWhenMode";
            this.nudWhenMode.Size = new System.Drawing.Size(168, 20);
            this.nudWhenMode.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(539, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "When Dependencies";
            // 
            // btnDeleteWhen
            // 
            this.btnDeleteWhen.Location = new System.Drawing.Point(542, 165);
            this.btnDeleteWhen.Name = "btnDeleteWhen";
            this.btnDeleteWhen.Size = new System.Drawing.Size(168, 23);
            this.btnDeleteWhen.TabIndex = 8;
            this.btnDeleteWhen.Text = "Delete";
            this.btnDeleteWhen.UseVisualStyleBackColor = true;
            this.btnDeleteWhen.Click += new System.EventHandler(this.btnDeleteWhen_Click);
            // 
            // btnAddWhen
            // 
            this.btnAddWhen.Location = new System.Drawing.Point(542, 231);
            this.btnAddWhen.Name = "btnAddWhen";
            this.btnAddWhen.Size = new System.Drawing.Size(168, 23);
            this.btnAddWhen.TabIndex = 10;
            this.btnAddWhen.Text = "Add";
            this.btnAddWhen.UseVisualStyleBackColor = true;
            this.btnAddWhen.Click += new System.EventHandler(this.btnAddWhen_Click);
            // 
            // txtWhen
            // 
            this.txtWhen.Location = new System.Drawing.Point(542, 205);
            this.txtWhen.Name = "txtWhen";
            this.txtWhen.Size = new System.Drawing.Size(168, 20);
            this.txtWhen.TabIndex = 9;
            // 
            // ddlPlatform
            // 
            this.ddlPlatform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPlatform.FormattingEnabled = true;
            this.ddlPlatform.Location = new System.Drawing.Point(12, 24);
            this.ddlPlatform.Name = "ddlPlatform";
            this.ddlPlatform.Size = new System.Drawing.Size(171, 21);
            this.ddlPlatform.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Platform";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(440, 283);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(578, 283);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxVisible
            // 
            this.cbxVisible.AutoSize = true;
            this.cbxVisible.Location = new System.Drawing.Point(12, 246);
            this.cbxVisible.Name = "cbxVisible";
            this.cbxVisible.Size = new System.Drawing.Size(56, 17);
            this.cbxVisible.TabIndex = 21;
            this.cbxVisible.Text = "Visible";
            this.cbxVisible.UseVisualStyleBackColor = true;
            // 
            // lvwWhenDependencies
            // 
            this.lvwWhenDependencies.Location = new System.Drawing.Point(542, 65);
            this.lvwWhenDependencies.Name = "lvwWhenDependencies";
            this.lvwWhenDependencies.Size = new System.Drawing.Size(168, 94);
            this.lvwWhenDependencies.TabIndex = 22;
            this.lvwWhenDependencies.UseCompatibleStateImageBehavior = false;
            this.lvwWhenDependencies.View = System.Windows.Forms.View.List;
            // 
            // FormEditSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 318);
            this.ControlBox = false;
            this.Controls.Add(this.lvwWhenDependencies);
            this.Controls.Add(this.cbxVisible);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ddlPlatform);
            this.Controls.Add(this.txtWhen);
            this.Controls.Add(this.btnAddWhen);
            this.Controls.Add(this.btnDeleteWhen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudWhenMode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudListingMode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFooter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDisplayName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEditSection";
            this.Text = "Edit Section";
            ((System.ComponentModel.ISupportInitialize)(this.nudListingMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWhenMode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFooter;
        private System.Windows.Forms.NumericUpDown nudListingMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudWhenMode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDeleteWhen;
        private System.Windows.Forms.Button btnAddWhen;
        private System.Windows.Forms.TextBox txtWhen;
        private System.Windows.Forms.ComboBox ddlPlatform;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox cbxVisible;
        private System.Windows.Forms.ListView lvwWhenDependencies;
    }
}