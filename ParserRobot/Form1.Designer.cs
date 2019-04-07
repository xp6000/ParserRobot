namespace ParserRobot
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.btnChkChange = new System.Windows.Forms.Button();
            this.btnSaveDB = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.radioRN = new System.Windows.Forms.RadioButton();
            this.radioMagenta = new System.Windows.Forms.RadioButton();
            this.btnGetLink = new System.Windows.Forms.Button();
            this.radioMnogo = new System.Windows.Forms.RadioButton();
            this.radioUnit = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSqlEditor = new System.Windows.Forms.Button();
            this.btnFullGrabber = new System.Windows.Forms.Button();
            this.btnCheckTask = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(810, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(84, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 34);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(660, 266);
            this.dataGrid.TabIndex = 1;
            // 
            // txtIn
            // 
            this.txtIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIn.Location = new System.Drawing.Point(12, 12);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(660, 20);
            this.txtIn.TabIndex = 2;
            // 
            // btnChkChange
            // 
            this.btnChkChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChkChange.Location = new System.Drawing.Point(810, 41);
            this.btnChkChange.Name = "btnChkChange";
            this.btnChkChange.Size = new System.Drawing.Size(84, 23);
            this.btnChkChange.TabIndex = 3;
            this.btnChkChange.Text = "CheckChange";
            this.btnChkChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChkChange.UseVisualStyleBackColor = true;
            this.btnChkChange.Click += new System.EventHandler(this.btnChkChange_Click);
            // 
            // btnSaveDB
            // 
            this.btnSaveDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveDB.Location = new System.Drawing.Point(810, 70);
            this.btnSaveDB.Name = "btnSaveDB";
            this.btnSaveDB.Size = new System.Drawing.Size(84, 23);
            this.btnSaveDB.TabIndex = 4;
            this.btnSaveDB.Text = "SaveDB";
            this.btnSaveDB.UseVisualStyleBackColor = true;
            this.btnSaveDB.Click += new System.EventHandler(this.btnSaveDB_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Location = new System.Drawing.Point(686, 191);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(84, 23);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "Accept";
            this.btnAccept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtOut
            // 
            this.txtOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOut.Location = new System.Drawing.Point(810, 128);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(92, 172);
            this.txtOut.TabIndex = 6;
            // 
            // radioRN
            // 
            this.radioRN.AutoSize = true;
            this.radioRN.Location = new System.Drawing.Point(691, 12);
            this.radioRN.Name = "radioRN";
            this.radioRN.Size = new System.Drawing.Size(79, 17);
            this.radioRN.TabIndex = 10;
            this.radioRN.TabStop = true;
            this.radioRN.Text = "RashodNet";
            this.radioRN.UseVisualStyleBackColor = true;
            this.radioRN.CheckedChanged += new System.EventHandler(this.radioRN_CheckedChanged);
            // 
            // radioMagenta
            // 
            this.radioMagenta.AutoSize = true;
            this.radioMagenta.Location = new System.Drawing.Point(691, 35);
            this.radioMagenta.Name = "radioMagenta";
            this.radioMagenta.Size = new System.Drawing.Size(74, 17);
            this.radioMagenta.TabIndex = 11;
            this.radioMagenta.TabStop = true;
            this.radioMagenta.Text = "MagentaS";
            this.radioMagenta.UseVisualStyleBackColor = true;
            this.radioMagenta.CheckedChanged += new System.EventHandler(this.radioMS_CheckedChanged);
            // 
            // btnGetLink
            // 
            this.btnGetLink.Location = new System.Drawing.Point(686, 99);
            this.btnGetLink.Name = "btnGetLink";
            this.btnGetLink.Size = new System.Drawing.Size(75, 23);
            this.btnGetLink.TabIndex = 12;
            this.btnGetLink.Text = "GetLinks";
            this.btnGetLink.UseVisualStyleBackColor = true;
            this.btnGetLink.Click += new System.EventHandler(this.btnGetLink_Click);
            // 
            // radioMnogo
            // 
            this.radioMnogo.AutoSize = true;
            this.radioMnogo.Location = new System.Drawing.Point(691, 58);
            this.radioMnogo.Name = "radioMnogo";
            this.radioMnogo.Size = new System.Drawing.Size(64, 17);
            this.radioMnogo.TabIndex = 13;
            this.radioMnogo.TabStop = true;
            this.radioMnogo.Text = "Mnogo4";
            this.radioMnogo.UseVisualStyleBackColor = true;
            this.radioMnogo.CheckedChanged += new System.EventHandler(this.radioMnogo_CheckedChanged);
            // 
            // radioUnit
            // 
            this.radioUnit.AutoSize = true;
            this.radioUnit.Location = new System.Drawing.Point(691, 81);
            this.radioUnit.Name = "radioUnit";
            this.radioUnit.Size = new System.Drawing.Size(44, 17);
            this.radioUnit.TabIndex = 14;
            this.radioUnit.TabStop = true;
            this.radioUnit.Text = "Unit";
            this.radioUnit.UseVisualStyleBackColor = true;
            this.radioUnit.CheckedChanged += new System.EventHandler(this.radioUnit_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(691, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "ZipZip";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSqlEditor
            // 
            this.btnSqlEditor.Location = new System.Drawing.Point(691, 266);
            this.btnSqlEditor.Name = "btnSqlEditor";
            this.btnSqlEditor.Size = new System.Drawing.Size(75, 23);
            this.btnSqlEditor.TabIndex = 16;
            this.btnSqlEditor.Text = "SQLEditor";
            this.btnSqlEditor.UseVisualStyleBackColor = true;
            this.btnSqlEditor.Click += new System.EventHandler(this.btnSqlEditor_Click);
            // 
            // btnFullGrabber
            // 
            this.btnFullGrabber.Location = new System.Drawing.Point(691, 162);
            this.btnFullGrabber.Name = "btnFullGrabber";
            this.btnFullGrabber.Size = new System.Drawing.Size(75, 23);
            this.btnFullGrabber.TabIndex = 17;
            this.btnFullGrabber.Text = "fullGrabber";
            this.btnFullGrabber.UseVisualStyleBackColor = true;
            this.btnFullGrabber.Click += new System.EventHandler(this.btnFullGrabber_Click);
            // 
            // btnCheckTask
            // 
            this.btnCheckTask.Location = new System.Drawing.Point(686, 126);
            this.btnCheckTask.Name = "btnCheckTask";
            this.btnCheckTask.Size = new System.Drawing.Size(75, 23);
            this.btnCheckTask.TabIndex = 18;
            this.btnCheckTask.Text = "checkTask";
            this.btnCheckTask.UseVisualStyleBackColor = true;
            this.btnCheckTask.Click += new System.EventHandler(this.btnCheckTask_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 450);
            this.Controls.Add(this.btnCheckTask);
            this.Controls.Add(this.btnFullGrabber);
            this.Controls.Add(this.btnSqlEditor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioUnit);
            this.Controls.Add(this.radioMnogo);
            this.Controls.Add(this.btnGetLink);
            this.Controls.Add(this.radioMagenta);
            this.Controls.Add(this.radioRN);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnSaveDB);
            this.Controls.Add(this.btnChkChange);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.Button btnChkChange;
        private System.Windows.Forms.Button btnSaveDB;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.RadioButton radioRN;
        private System.Windows.Forms.RadioButton radioMagenta;
        private System.Windows.Forms.Button btnGetLink;
        private System.Windows.Forms.RadioButton radioMnogo;
        private System.Windows.Forms.RadioButton radioUnit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSqlEditor;
        private System.Windows.Forms.Button btnFullGrabber;
        private System.Windows.Forms.Button btnCheckTask;
    }
}

