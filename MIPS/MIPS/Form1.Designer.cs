
namespace MIPS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.EditorTab = new System.Windows.Forms.TabPage();
            this.btn_simulate = new System.Windows.Forms.Button();
            this.btn_sim_nextStep = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textEditor = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.floatRegistersGridView = new System.Windows.Forms.DataGridView();
            this.intRegistersGridView = new System.Windows.Forms.DataGridView();
            this.MemoryTab = new System.Windows.Forms.TabPage();
            this.memoryDataGridView = new System.Windows.Forms.DataGridView();
            this.readMe = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.EditorTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.floatRegistersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intRegistersGridView)).BeginInit();
            this.MemoryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoryDataGridView)).BeginInit();
            this.readMe.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.EditorTab);
            this.tabControl1.Controls.Add(this.MemoryTab);
            this.tabControl1.Controls.Add(this.readMe);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(965, 786);
            this.tabControl1.TabIndex = 0;
            // 
            // EditorTab
            // 
            this.EditorTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditorTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EditorTab.Controls.Add(this.btn_simulate);
            this.EditorTab.Controls.Add(this.btn_sim_nextStep);
            this.EditorTab.Controls.Add(this.panel2);
            this.EditorTab.ForeColor = System.Drawing.Color.Transparent;
            this.EditorTab.Location = new System.Drawing.Point(4, 22);
            this.EditorTab.Name = "EditorTab";
            this.EditorTab.Padding = new System.Windows.Forms.Padding(3);
            this.EditorTab.Size = new System.Drawing.Size(957, 760);
            this.EditorTab.TabIndex = 0;
            this.EditorTab.Text = "Editor";
            // 
            // btn_simulate
            // 
            this.btn_simulate.ForeColor = System.Drawing.Color.Black;
            this.btn_simulate.Location = new System.Drawing.Point(13, 523);
            this.btn_simulate.Margin = new System.Windows.Forms.Padding(10);
            this.btn_simulate.Name = "btn_simulate";
            this.btn_simulate.Size = new System.Drawing.Size(156, 58);
            this.btn_simulate.TabIndex = 4;
            this.btn_simulate.Text = "Simulate Code";
            this.btn_simulate.UseVisualStyleBackColor = true;
            this.btn_simulate.Click += new System.EventHandler(this.btn_simulate_Click);
            // 
            // btn_sim_nextStep
            // 
            this.btn_sim_nextStep.Enabled = false;
            this.btn_sim_nextStep.ForeColor = System.Drawing.Color.Black;
            this.btn_sim_nextStep.Location = new System.Drawing.Point(189, 523);
            this.btn_sim_nextStep.Margin = new System.Windows.Forms.Padding(10);
            this.btn_sim_nextStep.Name = "btn_sim_nextStep";
            this.btn_sim_nextStep.Size = new System.Drawing.Size(170, 58);
            this.btn_sim_nextStep.TabIndex = 3;
            this.btn_sim_nextStep.Text = "Next Step";
            this.btn_sim_nextStep.UseVisualStyleBackColor = true;
            this.btn_sim_nextStep.Click += new System.EventHandler(this.btn_sim_nextStep_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textEditor);
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(929, 501);
            this.panel2.TabIndex = 1;
            // 
            // textEditor
            // 
            this.textEditor.BackColor = System.Drawing.Color.Black;
            this.textEditor.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEditor.ForeColor = System.Drawing.Color.Chartreuse;
            this.textEditor.Location = new System.Drawing.Point(10, 10);
            this.textEditor.Margin = new System.Windows.Forms.Padding(10);
            this.textEditor.Name = "textEditor";
            this.textEditor.Size = new System.Drawing.Size(909, 479);
            this.textEditor.TabIndex = 0;
            this.textEditor.Text = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.floatRegistersGridView);
            this.panel1.Controls.Add(this.intRegistersGridView);
            this.panel1.Location = new System.Drawing.Point(990, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 764);
            this.panel1.TabIndex = 1;
            // 
            // floatRegistersGridView
            // 
            this.floatRegistersGridView.AllowUserToResizeRows = false;
            this.floatRegistersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.floatRegistersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.floatRegistersGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.floatRegistersGridView.Location = new System.Drawing.Point(10, 397);
            this.floatRegistersGridView.Margin = new System.Windows.Forms.Padding(10);
            this.floatRegistersGridView.Name = "floatRegistersGridView";
            this.floatRegistersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.floatRegistersGridView.Size = new System.Drawing.Size(447, 355);
            this.floatRegistersGridView.TabIndex = 1;
            // 
            // intRegistersGridView
            // 
            this.intRegistersGridView.AllowUserToResizeRows = false;
            this.intRegistersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.intRegistersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.intRegistersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.intRegistersGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.intRegistersGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.intRegistersGridView.Location = new System.Drawing.Point(10, 13);
            this.intRegistersGridView.Margin = new System.Windows.Forms.Padding(10);
            this.intRegistersGridView.Name = "intRegistersGridView";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Chartreuse;
            this.intRegistersGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.intRegistersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.intRegistersGridView.Size = new System.Drawing.Size(447, 364);
            this.intRegistersGridView.TabIndex = 0;
            // 
            // MemoryTab
            // 
            this.MemoryTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MemoryTab.Controls.Add(this.memoryDataGridView);
            this.MemoryTab.Location = new System.Drawing.Point(4, 22);
            this.MemoryTab.Name = "MemoryTab";
            this.MemoryTab.Size = new System.Drawing.Size(957, 760);
            this.MemoryTab.TabIndex = 1;
            this.MemoryTab.Text = "Memory";
            // 
            // memoryDataGridView
            // 
            this.memoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.memoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.memoryDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.memoryDataGridView.Location = new System.Drawing.Point(10, 14);
            this.memoryDataGridView.Margin = new System.Windows.Forms.Padding(10);
            this.memoryDataGridView.Name = "memoryDataGridView";
            this.memoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.memoryDataGridView.Size = new System.Drawing.Size(937, 736);
            this.memoryDataGridView.TabIndex = 0;
            // 
            // readMe
            // 
            this.readMe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.readMe.Controls.Add(this.richTextBox1);
            this.readMe.Location = new System.Drawing.Point(4, 22);
            this.readMe.Name = "readMe";
            this.readMe.Size = new System.Drawing.Size(957, 760);
            this.readMe.TabIndex = 2;
            this.readMe.Text = "README";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Chartreuse;
            this.richTextBox1.Location = new System.Drawing.Point(10, 10);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(937, 740);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1478, 810);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "MIPS SIMULATOR - 182010020068 - 172010010022";
            this.tabControl1.ResumeLayout(false);
            this.EditorTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.floatRegistersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intRegistersGridView)).EndInit();
            this.MemoryTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoryDataGridView)).EndInit();
            this.readMe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage EditorTab;
        private System.Windows.Forms.RichTextBox textEditor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView intRegistersGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView floatRegistersGridView;
        private System.Windows.Forms.Button btn_sim_nextStep;
        private System.Windows.Forms.Button btn_simulate;
        private System.Windows.Forms.TabPage MemoryTab;
        private System.Windows.Forms.DataGridView memoryDataGridView;
        private System.Windows.Forms.TabPage readMe;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

