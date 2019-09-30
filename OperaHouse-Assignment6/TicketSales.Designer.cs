namespace OperaHouse_Assignment6
{
    partial class TicketSales
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
            this.lstTickets = new System.Windows.Forms.ListBox();
            this.btnSelll = new System.Windows.Forms.Button();
            this.txtNumTickets = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTickets
            // 
            this.lstTickets.FormattingEnabled = true;
            this.lstTickets.Location = new System.Drawing.Point(12, 14);
            this.lstTickets.Name = "lstTickets";
            this.lstTickets.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTickets.Size = new System.Drawing.Size(185, 420);
            this.lstTickets.TabIndex = 0;
            // 
            // btnSelll
            // 
            this.btnSelll.Location = new System.Drawing.Point(404, 63);
            this.btnSelll.Name = "btnSelll";
            this.btnSelll.Size = new System.Drawing.Size(75, 23);
            this.btnSelll.TabIndex = 1;
            this.btnSelll.Text = "Sell";
            this.btnSelll.UseVisualStyleBackColor = true;
            this.btnSelll.Click += new System.EventHandler(this.btnSelll_Click);
            // 
            // txtNumTickets
            // 
            this.txtNumTickets.Location = new System.Drawing.Point(338, 63);
            this.txtNumTickets.Name = "txtNumTickets";
            this.txtNumTickets.Size = new System.Drawing.Size(46, 20);
            this.txtNumTickets.TabIndex = 2;
            this.txtNumTickets.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumTickets_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number tickets to sell:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(224, 128);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Return selected";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // TicketSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 448);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumTickets);
            this.Controls.Add(this.btnSelll);
            this.Controls.Add(this.lstTickets);
            this.Name = "TicketSales";
            this.Text = "TicketSales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TicketSales_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTickets;
        private System.Windows.Forms.Button btnSelll;
        private System.Windows.Forms.TextBox txtNumTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
    }
}