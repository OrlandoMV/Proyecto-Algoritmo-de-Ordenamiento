using System;
using System.Windows.Forms;

namespace QuickSortApp
{
    partial class MainForm
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.lblSize = new System.Windows.Forms.Label();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.lblAlgoTitle = new System.Windows.Forms.Label();
            this.cmbAlgorithm = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.lblStats = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.lbOriginal = new System.Windows.Forms.ListBox();
            this.lblOriginalTitle = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.lbSorted = new System.Windows.Forms.ListBox();
            this.lblSortedTitle = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.topPanel.Controls.Add(this.lblSize);
            this.topPanel.Controls.Add(this.nudSize);
            this.topPanel.Controls.Add(this.lblAlgoTitle);
            this.topPanel.Controls.Add(this.cmbAlgorithm);
            this.topPanel.Controls.Add(this.btnSort);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Padding = new System.Windows.Forms.Padding(20);
            this.topPanel.Size = new System.Drawing.Size(900, 80);
            this.topPanel.TabIndex = 2;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(20, 30);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(72, 19);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Array Size:";
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(115, 25);
            this.nudSize.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(80, 25);
            this.nudSize.TabIndex = 1;
            this.nudSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblAlgoTitle
            // 
            this.lblAlgoTitle.AutoSize = true;
            this.lblAlgoTitle.Location = new System.Drawing.Point(210, 30);
            this.lblAlgoTitle.Name = "lblAlgoTitle";
            this.lblAlgoTitle.Size = new System.Drawing.Size(73, 19);
            this.lblAlgoTitle.TabIndex = 2;
            this.lblAlgoTitle.Text = "Algorithm:";
            // 
            // cmbAlgorithm
            // 
            this.cmbAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlgorithm.FormattingEnabled = true;
            this.cmbAlgorithm.Items.AddRange(new object[] {
            "Quick Sort",
            "Bubble Sort",
            "Cocktail Sort",
            "Insert Sort",
            "Selection Sort",
            "Merge Sort D",
            "Merge Sort N",
            "Gnome Sort",
            "Bucket Sort",
            "Counting Sort",
            "Radix Sort",
            "Heap Sort",
            "Shell Sort"});
            this.cmbAlgorithm.Location = new System.Drawing.Point(300, 25);
            this.cmbAlgorithm.Name = "cmbAlgorithm";
            this.cmbAlgorithm.Size = new System.Drawing.Size(140, 25);
            this.cmbAlgorithm.TabIndex = 3;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.ForeColor = System.Drawing.Color.White;
            this.btnSort.Location = new System.Drawing.Point(460, 23);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(150, 35);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Generate & Sort";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.LightYellow;
            this.bottomPanel.Controls.Add(this.lblStats);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 417);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Padding = new System.Windows.Forms.Padding(10);
            this.bottomPanel.Size = new System.Drawing.Size(900, 257);
            this.bottomPanel.TabIndex = 1;
            // 
            // lblStats
            // 
            this.lblStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStats.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.lblStats.Location = new System.Drawing.Point(10, 10);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(880, 237);
            this.lblStats.TabIndex = 0;
            this.lblStats.Text = "Statistics will appear here...";
            this.lblStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 80);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.leftPanel);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.rightPanel);
            this.splitContainer.Size = new System.Drawing.Size(900, 337);
            this.splitContainer.SplitterDistance = 557;
            this.splitContainer.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.lbOriginal);
            this.leftPanel.Controls.Add(this.lblOriginalTitle);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Padding = new System.Windows.Forms.Padding(10);
            this.leftPanel.Size = new System.Drawing.Size(557, 337);
            this.leftPanel.TabIndex = 0;
            // 
            // lbOriginal
            // 
            this.lbOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbOriginal.ItemHeight = 17;
            this.lbOriginal.Location = new System.Drawing.Point(10, 40);
            this.lbOriginal.Name = "lbOriginal";
            this.lbOriginal.Size = new System.Drawing.Size(537, 287);
            this.lbOriginal.TabIndex = 0;
            // 
            // lblOriginalTitle
            // 
            this.lblOriginalTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOriginalTitle.Location = new System.Drawing.Point(10, 10);
            this.lblOriginalTitle.Name = "lblOriginalTitle";
            this.lblOriginalTitle.Size = new System.Drawing.Size(537, 30);
            this.lblOriginalTitle.TabIndex = 1;
            this.lblOriginalTitle.Text = "Original Array (Random)";
            this.lblOriginalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.lbSorted);
            this.rightPanel.Controls.Add(this.lblSortedTitle);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(0, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Padding = new System.Windows.Forms.Padding(10);
            this.rightPanel.Size = new System.Drawing.Size(339, 337);
            this.rightPanel.TabIndex = 0;
            // 
            // lbSorted
            // 
            this.lbSorted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSorted.ItemHeight = 17;
            this.lbSorted.Location = new System.Drawing.Point(10, 40);
            this.lbSorted.Name = "lbSorted";
            this.lbSorted.Size = new System.Drawing.Size(319, 287);
            this.lbSorted.TabIndex = 0;
            // 
            // lblSortedTitle
            // 
            this.lblSortedTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSortedTitle.Location = new System.Drawing.Point(10, 10);
            this.lblSortedTitle.Name = "lblSortedTitle";
            this.lblSortedTitle.Size = new System.Drawing.Size(319, 30);
            this.lblSortedTitle.TabIndex = 1;
            this.lblSortedTitle.Text = "Sorted Array";
            this.lblSortedTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(900, 674);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorting Algorithms Tester";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // Declaración de controles (Fields)
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Label lblAlgoTitle;
        private System.Windows.Forms.ComboBox cmbAlgorithm;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.ListBox lbOriginal;
        private System.Windows.Forms.Label lblOriginalTitle;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.ListBox lbSorted;
        private System.Windows.Forms.Label lblSortedTitle;
    }
}