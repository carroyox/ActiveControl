namespace ActiveUser
{
    partial class FControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FControl));
            this.btnEdit = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.tbOwner = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.tbRequestor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbExperiment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Image = global::ActiveUser.Properties.Resources.edit;
            this.btnEdit.Location = new System.Drawing.Point(427, 49);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 40);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.Color.DimGray;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb1.Location = new System.Drawing.Point(8, 37);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(78, 24);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Owner:";
            // 
            // tbOwner
            // 
            this.tbOwner.BackColor = System.Drawing.Color.DimGray;
            this.tbOwner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOwner.ForeColor = System.Drawing.SystemColors.Window;
            this.tbOwner.Location = new System.Drawing.Point(136, 37);
            this.tbOwner.Name = "tbOwner";
            this.tbOwner.ReadOnly = true;
            this.tbOwner.Size = new System.Drawing.Size(274, 29);
            this.tbOwner.TabIndex = 1;
            this.tbOwner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btSave
            // 
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSave.Image = global::ActiveUser.Properties.Resources.save;
            this.btSave.Location = new System.Drawing.Point(473, 49);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(40, 40);
            this.btSave.TabIndex = 5;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tbRequestor
            // 
            this.tbRequestor.BackColor = System.Drawing.Color.DimGray;
            this.tbRequestor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRequestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRequestor.ForeColor = System.Drawing.SystemColors.Window;
            this.tbRequestor.Location = new System.Drawing.Point(136, 72);
            this.tbRequestor.Name = "tbRequestor";
            this.tbRequestor.ReadOnly = true;
            this.tbRequestor.Size = new System.Drawing.Size(274, 29);
            this.tbRequestor.TabIndex = 2;
            this.tbRequestor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Requestor:";
            // 
            // tbExperiment
            // 
            this.tbExperiment.BackColor = System.Drawing.Color.DimGray;
            this.tbExperiment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbExperiment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExperiment.ForeColor = System.Drawing.SystemColors.Window;
            this.tbExperiment.Location = new System.Drawing.Point(136, 107);
            this.tbExperiment.Name = "tbExperiment";
            this.tbExperiment.ReadOnly = true;
            this.tbExperiment.Size = new System.Drawing.Size(383, 29);
            this.tbExperiment.TabIndex = 3;
            this.tbExperiment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(8, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Experiment:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.DimGray;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbName.Location = new System.Drawing.Point(171, 3);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 24);
            this.lbName.TabIndex = 7;
            // 
            // FControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(524, 139);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbExperiment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRequestor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbOwner);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btnEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FControl";
            this.ShowIcon = false;
            this.Text = "Host Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox tbOwner;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tbRequestor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbExperiment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lbName;
    }
}

