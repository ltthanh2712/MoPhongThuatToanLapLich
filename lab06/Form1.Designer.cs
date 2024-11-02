namespace lab06
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProcessID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BurstTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantumTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnFCFS = new System.Windows.Forms.Button();
            this.BtnSJF = new System.Windows.Forms.Button();
            this.BtnRR = new System.Windows.Forms.Button();
            this.BtnPriority = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTurnaroundTime = new System.Windows.Forms.Label();
            this.lblWaitingTime = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Process = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnAroundTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaitingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcessID,
            this.ArrivalTime,
            this.BurstTime,
            this.QuantumTime});
            this.dataGridView1.Location = new System.Drawing.Point(121, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(692, 173);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ProcessID
            // 
            this.ProcessID.HeaderText = "ProcessID";
            this.ProcessID.MinimumWidth = 6;
            this.ProcessID.Name = "ProcessID";
            this.ProcessID.Width = 125;
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.HeaderText = "ArrivalTime";
            this.ArrivalTime.MinimumWidth = 6;
            this.ArrivalTime.Name = "ArrivalTime";
            this.ArrivalTime.Width = 125;
            // 
            // BurstTime
            // 
            this.BurstTime.HeaderText = "BurstTime";
            this.BurstTime.MinimumWidth = 6;
            this.BurstTime.Name = "BurstTime";
            this.BurstTime.Width = 125;
            // 
            // QuantumTime
            // 
            this.QuantumTime.HeaderText = "QuantumTime";
            this.QuantumTime.MinimumWidth = 6;
            this.QuantumTime.Name = "QuantumTime";
            this.QuantumTime.Width = 125;
            // 
            // BtnFCFS
            // 
            this.BtnFCFS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnFCFS.Location = new System.Drawing.Point(843, 26);
            this.BtnFCFS.Name = "BtnFCFS";
            this.BtnFCFS.Size = new System.Drawing.Size(100, 46);
            this.BtnFCFS.TabIndex = 1;
            this.BtnFCFS.Text = "FCFS";
            this.BtnFCFS.UseVisualStyleBackColor = true;
            this.BtnFCFS.Click += new System.EventHandler(this.BtnFCFS_Click);
            // 
            // BtnSJF
            // 
            this.BtnSJF.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnSJF.Location = new System.Drawing.Point(843, 88);
            this.BtnSJF.Name = "BtnSJF";
            this.BtnSJF.Size = new System.Drawing.Size(100, 46);
            this.BtnSJF.TabIndex = 2;
            this.BtnSJF.Text = "SJF";
            this.BtnSJF.UseVisualStyleBackColor = true;
            this.BtnSJF.Click += new System.EventHandler(this.BtnSJF_Click);
            // 
            // BtnRR
            // 
            this.BtnRR.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnRR.Location = new System.Drawing.Point(843, 215);
            this.BtnRR.Name = "BtnRR";
            this.BtnRR.Size = new System.Drawing.Size(100, 46);
            this.BtnRR.TabIndex = 3;
            this.BtnRR.Text = "RR";
            this.BtnRR.UseVisualStyleBackColor = true;
            this.BtnRR.Click += new System.EventHandler(this.BtnRR_Click);
            // 
            // BtnPriority
            // 
            this.BtnPriority.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnPriority.Location = new System.Drawing.Point(843, 151);
            this.BtnPriority.Name = "BtnPriority";
            this.BtnPriority.Size = new System.Drawing.Size(100, 46);
            this.BtnPriority.TabIndex = 4;
            this.BtnPriority.Text = "Priority";
            this.BtnPriority.UseVisualStyleBackColor = true;
            this.BtnPriority.Click += new System.EventHandler(this.BtnPriority_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRandom.Location = new System.Drawing.Point(24, 30);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(82, 46);
            this.btnRandom.TabIndex = 5;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(74, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 67);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTurnaroundTime
            // 
            this.lblTurnaroundTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTurnaroundTime.AutoSize = true;
            this.lblTurnaroundTime.Location = new System.Drawing.Point(71, 463);
            this.lblTurnaroundTime.Name = "lblTurnaroundTime";
            this.lblTurnaroundTime.Size = new System.Drawing.Size(168, 16);
            this.lblTurnaroundTime.TabIndex = 7;
            this.lblTurnaroundTime.Text = "Average Turnaround Time:";
            this.lblTurnaroundTime.Click += new System.EventHandler(this.lblTurnaroundTime_Click);
            // 
            // lblWaitingTime
            // 
            this.lblWaitingTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWaitingTime.AutoSize = true;
            this.lblWaitingTime.Location = new System.Drawing.Point(71, 488);
            this.lblWaitingTime.Name = "lblWaitingTime";
            this.lblWaitingTime.Size = new System.Drawing.Size(89, 16);
            this.lblWaitingTime.TabIndex = 8;
            this.lblWaitingTime.Text = "Waiting Time:";
            this.lblWaitingTime.Click += new System.EventHandler(this.lblWaitingTime_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Process,
            this.TurnAroundTime,
            this.WaitingTime});
            this.dataGridView2.Location = new System.Drawing.Point(121, 228);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(692, 159);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Process
            // 
            this.Process.HeaderText = "Process";
            this.Process.MinimumWidth = 6;
            this.Process.Name = "Process";
            this.Process.Width = 125;
            // 
            // TurnAroundTime
            // 
            this.TurnAroundTime.HeaderText = "TurnAroundTime";
            this.TurnAroundTime.MinimumWidth = 6;
            this.TurnAroundTime.Name = "TurnAroundTime";
            this.TurnAroundTime.Width = 125;
            // 
            // WaitingTime
            // 
            this.WaitingTime.HeaderText = "WaitingTime";
            this.WaitingTime.MinimumWidth = 6;
            this.WaitingTime.Name = "WaitingTime";
            this.WaitingTime.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 529);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.BtnSJF);
            this.Controls.Add(this.BtnFCFS);
            this.Controls.Add(this.lblWaitingTime);
            this.Controls.Add(this.lblTurnaroundTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.BtnPriority);
            this.Controls.Add(this.BtnRR);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BurstTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantumTime;
        private System.Windows.Forms.Button BtnFCFS;
        private System.Windows.Forms.Button BtnSJF;
        private System.Windows.Forms.Button BtnRR;
        private System.Windows.Forms.Button BtnPriority;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTurnaroundTime;
        private System.Windows.Forms.Label lblWaitingTime;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurnAroundTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaitingTime;
    }
}

