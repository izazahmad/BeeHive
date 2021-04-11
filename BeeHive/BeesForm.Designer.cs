
namespace BeeHive
{
    partial class BeesForm
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
            this.lstViewBees = new System.Windows.Forms.ListView();
            this.clmnNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnHealth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstViewBees
            // 
            this.lstViewBees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnNo,
            this.clmnType,
            this.clmnHealth,
            this.clmnStatus});
            this.lstViewBees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstViewBees.FullRowSelect = true;
            this.lstViewBees.GridLines = true;
            this.lstViewBees.HideSelection = false;
            this.lstViewBees.Location = new System.Drawing.Point(148, 26);
            this.lstViewBees.Name = "lstViewBees";
            this.lstViewBees.Size = new System.Drawing.Size(615, 474);
            this.lstViewBees.TabIndex = 0;
            this.lstViewBees.UseCompatibleStateImageBehavior = false;
            this.lstViewBees.View = System.Windows.Forms.View.Details;
            // 
            // clmnNo
            // 
            this.clmnNo.Text = "No";
            this.clmnNo.Width = 70;
            // 
            // clmnType
            // 
            this.clmnType.Text = "Bee Type";
            this.clmnType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmnType.Width = 110;
            // 
            // clmnHealth
            // 
            this.clmnHealth.Text = "Health";
            this.clmnHealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmnHealth.Width = 110;
            // 
            // clmnStatus
            // 
            this.clmnStatus.Text = "Status";
            this.clmnStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmnStatus.Width = 110;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(29, 130);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 60);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(29, 206);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(92, 60);
            this.btnAttack.TabIndex = 2;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // BeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 637);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lstViewBees);
            this.Name = "BeesForm";
            this.Text = "Bees";
            this.Load += new System.EventHandler(this.BeesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstViewBees;
        private System.Windows.Forms.ColumnHeader clmnNo;
        private System.Windows.Forms.ColumnHeader clmnType;
        private System.Windows.Forms.ColumnHeader clmnHealth;
        private System.Windows.Forms.ColumnHeader clmnStatus;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAttack;
    }
}

