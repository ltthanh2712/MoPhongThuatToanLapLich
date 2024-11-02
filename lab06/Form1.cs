using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace lab06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView2(); // Khởi tạo cấu trúc cho DataGridView2
        }

        private void BtnFCFS_Click(object sender, EventArgs e)
        {
            var processes = GetProcessesFromGrid();
            processes = processes.OrderBy(p => p.ArrivalTime).ToList();
            int currentTime = 0;

            foreach (var process in processes)
            {
                process.StartTime = Math.Max(currentTime, process.ArrivalTime);
                process.CompletionTime = process.StartTime + process.BurstTime;
                process.TurnaroundTime = process.CompletionTime - process.ArrivalTime;
                process.WaitingTime = process.TurnaroundTime - process.BurstTime;
                currentTime = process.CompletionTime;
            }

            DrawGanttChart(processes);
            DisplayResults(processes);
        }

        private void BtnSJF_Click(object sender, EventArgs e)
        {
            var processes = GetProcessesFromGrid();
            processes = processes.OrderBy(p => p.BurstTime).ToList();

            int currentTime = 0;
            foreach (var process in processes)
            {
                process.StartTime = Math.Max(currentTime, process.ArrivalTime);
                process.CompletionTime = process.StartTime + process.BurstTime;
                process.TurnaroundTime = process.CompletionTime - process.ArrivalTime;
                process.WaitingTime = process.TurnaroundTime - process.BurstTime;
                currentTime = process.CompletionTime;
            }

            DrawGanttChart(processes);
            DisplayResults(processes);
        }

        private void BtnRR_Click(object sender, EventArgs e)
        {
            var processes = GetProcessesFromGrid(); // Ensure this method retrieves processes correctly.
            int quantum = GetQuantumTime(); // Retrieve the quantum time
            Queue<Process> queue = new Queue<Process>();
            int currentTime = 0;

            // Check if the quantum time is valid before proceeding
            if (quantum <= 0)
            {
                MessageBox.Show("Invalid quantum time. Operation aborted.");
                return; // Exit if quantum time is invalid
            }

            // Add initial processes to the queue
            foreach (var process in processes.Where(p => p.ArrivalTime <= currentTime))
            {
                queue.Enqueue(process);
            }

            while (queue.Count > 0)
            {
                var process = queue.Dequeue();

                // Process the current job
                if (process.RemainingTime > quantum)
                {
                    currentTime += quantum;
                    process.RemainingTime -= quantum;

                    // Check for new arrivals while the current process is running
                    foreach (var newProcess in processes.Where(p => p.ArrivalTime <= currentTime && p.RemainingTime > 0))
                    {
                        if (!queue.Contains(newProcess))
                        {
                            queue.Enqueue(newProcess);
                        }
                    }
                    queue.Enqueue(process); // Re-add the current process to the queue
                }
                else
                {
                    currentTime += process.RemainingTime; // Process finishes
                    process.CompletionTime = currentTime;
                    process.TurnaroundTime = process.CompletionTime - process.ArrivalTime;
                    process.WaitingTime = process.TurnaroundTime - process.BurstTime;
                    process.RemainingTime = 0; // Mark the process as complete
                }

                // Check for new arrivals again after processing the current job
                foreach (var newProcess in processes.Where(p => p.ArrivalTime <= currentTime && p.RemainingTime > 0))
                {
                    if (!queue.Contains(newProcess))
                    {
                        queue.Enqueue(newProcess);
                    }
                }
            }

            DrawGanttChart(processes);
            DisplayResults(processes);
        }

        private void BtnPriority_Click(object sender, EventArgs e)
        {
            var processes = GetProcessesFromGrid();
            processes = processes.OrderBy(p => p.Priority).ToList();

            int currentTime = 0;
            foreach (var process in processes)
            {
                process.StartTime = Math.Max(currentTime, process.ArrivalTime);
                process.CompletionTime = process.StartTime + process.BurstTime;
                process.TurnaroundTime = process.CompletionTime - process.ArrivalTime;
                process.WaitingTime = process.TurnaroundTime - process.BurstTime;
                currentTime = process.CompletionTime;
            }

            DrawGanttChart(processes);
            DisplayResults(processes);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int processCount = rand.Next(1, 15);
            dataGridView1.Rows.Clear();
            for (int i = 0; i < processCount; i++)
            {
                int arrivalTime = rand.Next(0, 10);
                int burstTime = rand.Next(1, 10);
                int priority = rand.Next(1, 5);
                dataGridView1.Rows.Add(i + 1, arrivalTime, burstTime, priority);
            }
        }

        private void DisplayResults(List<Process> processes)
        {
            double totalTurnaroundTime = 0;
            double totalWaitingTime = 0;

            foreach (var process in processes)
            {
                totalTurnaroundTime += process.TurnaroundTime;
                totalWaitingTime += process.WaitingTime;
            }

            double avgTurnaroundTime = totalTurnaroundTime / processes.Count;
            double avgWaitingTime = totalWaitingTime / processes.Count;

            lblTurnaroundTime.Text = $"Average Turnaround Time: {avgTurnaroundTime:F2}";
            lblWaitingTime.Text = $"Average Waiting Time: {avgWaitingTime:F2}";

            PopulateProcessResults(processes);
        }

        private void PopulateProcessResults(List<Process> processes)
        {
            dataGridView2.Rows.Clear();

            foreach (var process in processes)
            {
                dataGridView2.Rows.Add(process.Id, process.TurnaroundTime, process.WaitingTime);
            }
        }

        private void DrawGanttChart(List<Process> processes)
        {
            using (Graphics g = panel1.CreateGraphics())
            {
                g.Clear(panel1.BackColor);
                int x = 10;
                int height = 30;
                int scale = 20;

                foreach (var process in processes)
                {
                    int width = process.BurstTime * scale;
                    g.FillRectangle(Brushes.Blue, x, 20, width, height);
                    g.DrawRectangle(Pens.Black, x, 20, width, height);
                    g.DrawString($"P{process.Id}", this.Font, Brushes.White, x + width / 2 - 10, 25);
                    x += width;
                }

                panel1.AutoScrollMinSize = new Size(x + 10, height + 40);
            }
        }

        private int GetQuantumTime()
        {
            // Check if there are rows and the specific column index exists
            if (dataGridView1.Rows.Count > 0 && dataGridView1.Columns.Count > 3)
            {
                var cellValue = dataGridView1.Rows[0].Cells[3].Value; // Get the value from the Quantum Time column
                if (cellValue != null)
                {
                    // Try to parse the cell value to an integer
                    if (int.TryParse(cellValue.ToString(), out int quantum) && quantum > 0)
                    {
                        return quantum; // Return the parsed quantum value if valid
                    }
                }
            }

            // Show message if the quantum time is invalid
            MessageBox.Show("Please enter a valid Quantum Time in the 'QuantumTime' column (greater than 0).");
            return 1; // Default value if `Quantum Time` is invalid
        }

        private List<Process> GetProcessesFromGrid()
        {
            var processes = new List<Process>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null &&
                    int.TryParse(row.Cells[0].Value.ToString(), out int id) &&
                    int.TryParse(row.Cells[1].Value.ToString(), out int arrivalTime) &&
                    int.TryParse(row.Cells[2].Value.ToString(), out int burstTime) &&
                    int.TryParse(row.Cells[3].Value.ToString(), out int priority))
                {
                    processes.Add(new Process { Id = id, ArrivalTime = arrivalTime, BurstTime = burstTime, Priority = priority, RemainingTime = burstTime });
                }
            }
            return processes;
        }

        private void InitializeDataGridView2()
        {
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("ProcessID", "Process ID");
            dataGridView2.Columns.Add("TurnaroundTime", "Turnaround Time");
            dataGridView2.Columns.Add("WaitingTime", "Waiting Time");

            dataGridView2.Columns["ProcessID"].Width = 80;
            dataGridView2.Columns["TurnaroundTime"].Width = 120;
            dataGridView2.Columns["WaitingTime"].Width = 120;
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void lblTurnaroundTime_Click(object sender, EventArgs e) { }

        private void lblWaitingTime_Click(object sender, EventArgs e) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }

    internal class Process
    {
        public int Id { get; set; }
        public int ArrivalTime { get; set; }
        public int BurstTime { get; set; }
        public int RemainingTime { get; set; }
        public int CompletionTime { get; set; }
        public int TurnaroundTime { get; set; }
        public int WaitingTime { get; set; }
        public int Priority { get; set; }
        public int StartTime { get; set; }
    }
}
