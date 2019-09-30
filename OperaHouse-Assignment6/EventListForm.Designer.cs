namespace OperaHouse_Assignment6
{
    partial class EventListForm
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
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.grpEventDetail = new System.Windows.Forms.GroupBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnSellTicket = new System.Windows.Forms.Button();
            this.lblTickets = new System.Windows.Forms.Label();
            this.lblPerformer = new System.Windows.Forms.LinkLabel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.cmbPerformers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkOpenShows = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtDate = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtTitle = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpEventDetail.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEvents
            // 
            this.lstEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.Location = new System.Drawing.Point(12, 86);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(605, 407);
            this.lstEvents.TabIndex = 0;
            this.lstEvents.SelectedIndexChanged += new System.EventHandler(this.lstEvents_SelectedIndexChanged);
            // 
            // grpEventDetail
            // 
            this.grpEventDetail.Controls.Add(this.dtpTime);
            this.grpEventDetail.Controls.Add(this.btnSellTicket);
            this.grpEventDetail.Controls.Add(this.lblTickets);
            this.grpEventDetail.Controls.Add(this.lblPerformer);
            this.grpEventDetail.Controls.Add(this.btnUpdate);
            this.grpEventDetail.Controls.Add(this.dtpDate);
            this.grpEventDetail.Controls.Add(this.txtTitle);
            this.grpEventDetail.Controls.Add(this.label5);
            this.grpEventDetail.Controls.Add(this.label4);
            this.grpEventDetail.Controls.Add(this.label3);
            this.grpEventDetail.Controls.Add(this.label2);
            this.grpEventDetail.Location = new System.Drawing.Point(623, 83);
            this.grpEventDetail.Name = "grpEventDetail";
            this.grpEventDetail.Size = new System.Drawing.Size(379, 176);
            this.grpEventDetail.TabIndex = 1;
            this.grpEventDetail.TabStop = false;
            this.grpEventDetail.Text = "Event Detail";
            this.grpEventDetail.Visible = false;
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(209, 73);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(72, 20);
            this.dtpTime.TabIndex = 14;
            // 
            // btnSellTicket
            // 
            this.btnSellTicket.Location = new System.Drawing.Point(168, 102);
            this.btnSellTicket.Name = "btnSellTicket";
            this.btnSellTicket.Size = new System.Drawing.Size(77, 23);
            this.btnSellTicket.TabIndex = 12;
            this.btnSellTicket.Text = "Sell/Return";
            this.btnSellTicket.UseVisualStyleBackColor = true;
            this.btnSellTicket.Click += new System.EventHandler(this.btnSellTicket_Click);
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Location = new System.Drawing.Point(117, 107);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(0, 13);
            this.lblTickets.TabIndex = 11;
            // 
            // lblPerformer
            // 
            this.lblPerformer.AutoSize = true;
            this.lblPerformer.Location = new System.Drawing.Point(81, 50);
            this.lblPerformer.Name = "lblPerformer";
            this.lblPerformer.Size = new System.Drawing.Size(0, 13);
            this.lblPerformer.TabIndex = 10;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(298, 147);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(106, 73);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(97, 20);
            this.dtpDate.TabIndex = 6;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(68, 23);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(288, 20);
            this.txtTitle.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Date and Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Available Tickets:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Performer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title:";
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(629, 467);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(75, 23);
            this.btnAddEvent.TabIndex = 9;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // cmbPerformers
            // 
            this.cmbPerformers.FormattingEnabled = true;
            this.cmbPerformers.Location = new System.Drawing.Point(22, 35);
            this.cmbPerformers.Name = "cmbPerformers";
            this.cmbPerformers.Size = new System.Drawing.Size(121, 21);
            this.cmbPerformers.TabIndex = 2;
            this.cmbPerformers.SelectedIndexChanged += new System.EventHandler(this.cmbPerformers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Performer:";
            // 
            // chkOpenShows
            // 
            this.chkOpenShows.AutoSize = true;
            this.chkOpenShows.Location = new System.Drawing.Point(169, 37);
            this.chkOpenShows.Name = "chkOpenShows";
            this.chkOpenShows.Size = new System.Drawing.Size(111, 17);
            this.chkOpenShows.TabIndex = 4;
            this.chkOpenShows.Text = "Open Shows Only";
            this.chkOpenShows.UseVisualStyleBackColor = true;
            this.chkOpenShows.CheckedChanged += new System.EventHandler(this.chkOpenShows_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkOpenShows);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbPerformers);
            this.groupBox2.Location = new System.Drawing.Point(12, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 69);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // rbtDate
            // 
            this.rbtDate.AutoSize = true;
            this.rbtDate.Location = new System.Drawing.Point(38, 31);
            this.rbtDate.Name = "rbtDate";
            this.rbtDate.Size = new System.Drawing.Size(48, 17);
            this.rbtDate.TabIndex = 6;
            this.rbtDate.TabStop = true;
            this.rbtDate.Text = "Date";
            this.rbtDate.UseVisualStyleBackColor = true;
            this.rbtDate.CheckedChanged += new System.EventHandler(this.rbtDate_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtTitle);
            this.groupBox1.Controls.Add(this.rbtDate);
            this.groupBox1.Location = new System.Drawing.Point(316, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 65);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorting";
            // 
            // rbtTitle
            // 
            this.rbtTitle.AutoSize = true;
            this.rbtTitle.Location = new System.Drawing.Point(124, 31);
            this.rbtTitle.Name = "rbtTitle";
            this.rbtTitle.Size = new System.Drawing.Size(45, 17);
            this.rbtTitle.TabIndex = 8;
            this.rbtTitle.TabStop = true;
            this.rbtTitle.Text = "Title";
            this.rbtTitle.UseVisualStyleBackColor = true;
            this.rbtTitle.CheckedChanged += new System.EventHandler(this.rbtTitle_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(536, 49);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(729, 467);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete Event";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // EventListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 505);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpEventDetail);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.lstEvents);
            this.Name = "EventListForm";
            this.Text = "Opera House Events";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventListForm_FormClosing);
            this.grpEventDetail.ResumeLayout(false);
            this.grpEventDetail.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.GroupBox grpEventDetail;
        private System.Windows.Forms.Button btnSellTicket;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.LinkLabel lblPerformer;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPerformers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkOpenShows;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.RadioButton rbtDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtTitle;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
    }
}