namespace ParserRobot
{
    partial class SQLEditor
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
            this.dataSQLEd = new System.Windows.Forms.DataGridView();
            this.btnReadSql = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSQLEd)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSQLEd
            // 
            this.dataSQLEd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataSQLEd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSQLEd.Location = new System.Drawing.Point(2, 35);
            this.dataSQLEd.Name = "dataSQLEd";
            this.dataSQLEd.Size = new System.Drawing.Size(796, 283);
            this.dataSQLEd.TabIndex = 0;
            // 
            // btnReadSql
            // 
            this.btnReadSql.Location = new System.Drawing.Point(2, 6);
            this.btnReadSql.Name = "btnReadSql";
            this.btnReadSql.Size = new System.Drawing.Size(75, 23);
            this.btnReadSql.TabIndex = 1;
            this.btnReadSql.Text = "ReadSQL";
            this.btnReadSql.UseVisualStyleBackColor = true;
            this.btnReadSql.Click += new System.EventHandler(this.btnReadSql_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(588, 6);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "ClearGardage";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(171, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SQLEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnReadSql);
            this.Controls.Add(this.dataSQLEd);
            this.Name = "SQLEditor";
            this.Text = "SQLEditor";
            ((System.ComponentModel.ISupportInitialize)(this.dataSQLEd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataSQLEd;
        private System.Windows.Forms.Button btnReadSql;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
    }
}