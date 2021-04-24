
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.EditorTab = new System.Windows.Forms.TabPage();
            this.btn_simulate = new System.Windows.Forms.Button();
            this.btn_sim_nextStep = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textEditor = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.floatRegistersGridView = new System.Windows.Forms.DataGridView();
            this.intRegistersGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.EditorTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.floatRegistersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intRegistersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.EditorTab);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.floatRegistersGridView.DefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.intRegistersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.intRegistersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.intRegistersGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.intRegistersGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.intRegistersGridView.Location = new System.Drawing.Point(10, 13);
            this.intRegistersGridView.Margin = new System.Windows.Forms.Padding(10);
            this.intRegistersGridView.Name = "intRegistersGridView";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Chartreuse;
            this.intRegistersGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.intRegistersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.intRegistersGridView.Size = new System.Drawing.Size(447, 364);
            this.intRegistersGridView.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1478, 810);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.EditorTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.floatRegistersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intRegistersGridView)).EndInit();
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
    }
}

