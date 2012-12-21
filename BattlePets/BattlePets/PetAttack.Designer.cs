namespace BattlePets
{
    partial class PetAttack
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlayerID = new System.Windows.Forms.TextBox();
            this.txtPetSkillID = new System.Windows.Forms.TextBox();
            this.txtPetInstanceID = new System.Windows.Forms.TextBox();
            this.txtOpponentPetID = new System.Windows.Forms.TextBox();
            this.txtOpponentPetLevel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PlayerID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PetSkillID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PetInstanceID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "OpponentPetID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "OpponentPetLevel";
            // 
            // txtPlayerID
            // 
            this.txtPlayerID.Location = new System.Drawing.Point(134, 13);
            this.txtPlayerID.Name = "txtPlayerID";
            this.txtPlayerID.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerID.TabIndex = 5;
            // 
            // txtPetSkillID
            // 
            this.txtPetSkillID.Location = new System.Drawing.Point(134, 54);
            this.txtPetSkillID.Name = "txtPetSkillID";
            this.txtPetSkillID.Size = new System.Drawing.Size(100, 20);
            this.txtPetSkillID.TabIndex = 6;
            // 
            // txtPetInstanceID
            // 
            this.txtPetInstanceID.Location = new System.Drawing.Point(134, 90);
            this.txtPetInstanceID.Name = "txtPetInstanceID";
            this.txtPetInstanceID.Size = new System.Drawing.Size(100, 20);
            this.txtPetInstanceID.TabIndex = 7;
            // 
            // txtOpponentPetID
            // 
            this.txtOpponentPetID.Location = new System.Drawing.Point(134, 125);
            this.txtOpponentPetID.Name = "txtOpponentPetID";
            this.txtOpponentPetID.Size = new System.Drawing.Size(100, 20);
            this.txtOpponentPetID.TabIndex = 8;
            // 
            // txtOpponentPetLevel
            // 
            this.txtOpponentPetLevel.Location = new System.Drawing.Point(134, 161);
            this.txtOpponentPetLevel.Name = "txtOpponentPetLevel";
            this.txtOpponentPetLevel.Size = new System.Drawing.Size(100, 20);
            this.txtOpponentPetLevel.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Attack";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(134, 253);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(233, 48);
            this.txtResult.TabIndex = 12;
            // 
            // PetAttack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 327);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOpponentPetLevel);
            this.Controls.Add(this.txtOpponentPetID);
            this.Controls.Add(this.txtPetInstanceID);
            this.Controls.Add(this.txtPetSkillID);
            this.Controls.Add(this.txtPlayerID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PetAttack";
            this.Text = "PetAttack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPlayerID;
        private System.Windows.Forms.TextBox txtPetSkillID;
        private System.Windows.Forms.TextBox txtPetInstanceID;
        private System.Windows.Forms.TextBox txtOpponentPetID;
        private System.Windows.Forms.TextBox txtOpponentPetLevel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtResult;
    }
}