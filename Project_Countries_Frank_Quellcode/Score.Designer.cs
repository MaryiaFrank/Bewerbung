
namespace Project_Countries_Frank
{
    partial class Score
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_score = new System.Windows.Forms.DataGridView();
            this.name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_score)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "HIGHSCORES";
            // 
            // dgv_score
            // 
            this.dgv_score.AllowUserToAddRows = false;
            this.dgv_score.AllowUserToDeleteRows = false;
            this.dgv_score.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_score.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_score.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name_col,
            this.score_col});
            this.dgv_score.Location = new System.Drawing.Point(12, 92);
            this.dgv_score.MultiSelect = false;
            this.dgv_score.Name = "dgv_score";
            this.dgv_score.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_score.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_score.RowHeadersWidth = 51;
            this.dgv_score.RowTemplate.Height = 24;
            this.dgv_score.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_score.Size = new System.Drawing.Size(376, 251);
            this.dgv_score.TabIndex = 1;
            // 
            // name_col
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_col.DefaultCellStyle = dataGridViewCellStyle1;
            this.name_col.HeaderText = "Name";
            this.name_col.MinimumWidth = 6;
            this.name_col.Name = "name_col";
            this.name_col.ReadOnly = true;
            this.name_col.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.name_col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name_col.Width = 125;
            // 
            // score_col
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_col.DefaultCellStyle = dataGridViewCellStyle2;
            this.score_col.HeaderText = "score";
            this.score_col.MinimumWidth = 6;
            this.score_col.Name = "score_col";
            this.score_col.ReadOnly = true;
            this.score_col.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.score_col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.score_col.Width = 125;
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(403, 355);
            this.Controls.Add(this.dgv_score);
            this.Controls.Add(this.groupBox1);
            this.Name = "Score";
            this.Text = "Score";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_score)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_score;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn score_col;
    }
}