using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentManger
{
    partial class StudentView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentView));
            toolStrip1 = new ToolStrip();
            toolAdd = new ToolStripButton();
            toolRemove = new ToolStripButton();
            toolSave = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            splitContainer1 = new SplitContainer();
            dataView = new DataGridView();
            numYear = new NumericUpDown();
            txtPhoneNum = new TextBox();
            txtGrade = new TextBox();
            txtDescription = new TextBox();
            txtName = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            bindingSource1 = new BindingSource(components);
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolAdd, toolRemove, toolSave });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1326, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolAdd
            // 
            toolAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolAdd.Image = Properties.Resources.download;
            toolAdd.ImageTransparentColor = Color.Magenta;
            toolAdd.Name = "toolAdd";
            toolAdd.Size = new Size(24, 24);
            toolAdd.Text = "Add";
            // 
            // toolRemove
            // 
            toolRemove.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolRemove.Image = Properties.Resources.download__1_;
            toolRemove.ImageTransparentColor = Color.Magenta;
            toolRemove.Name = "toolRemove";
            toolRemove.Size = new Size(24, 24);
            toolRemove.Text = "Remove";
            // 
            // toolSave
            // 
            toolSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolSave.Image = Properties.Resources.download1;
            toolSave.ImageTransparentColor = Color.Magenta;
            toolSave.Name = "toolSave";
            toolSave.Size = new Size(24, 24);
            toolSave.Text = "Save";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 418);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(1326, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 27);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataView);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(numYear);
            splitContainer1.Panel2.Controls.Add(txtPhoneNum);
            splitContainer1.Panel2.Controls.Add(txtGrade);
            splitContainer1.Panel2.Controls.Add(txtDescription);
            splitContainer1.Panel2.Controls.Add(txtName);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(1326, 391);
            splitContainer1.SplitterDistance = 837;
            splitContainer1.TabIndex = 2;
            // 
            // dataView
            // 
            dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView.Dock = DockStyle.Fill;
            dataView.Location = new Point(0, 0);
            dataView.Margin = new Padding(3, 2, 3, 2);
            dataView.Name = "dataView";
            dataView.RowHeadersWidth = 51;
            dataView.Size = new Size(837, 391);
            dataView.TabIndex = 0;
            // 
            // numYear
            // 
            numYear.Location = new Point(116, 148);
            numYear.Margin = new Padding(3, 2, 3, 2);
            numYear.Maximum = new decimal(new int[] { 2050, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(131, 23);
            numYear.TabIndex = 14;
            numYear.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Location = new Point(116, 116);
            txtPhoneNum.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(338, 23);
            txtPhoneNum.TabIndex = 12;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(116, 85);
            txtGrade.Margin = new Padding(3, 2, 3, 2);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(338, 23);
            txtGrade.TabIndex = 11;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(116, 54);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(338, 23);
            txtDescription.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(116, 26);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(338, 23);
            txtName.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 152);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 5;
            label6.Text = "Year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 119);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 3;
            label4.Text = "PhoneNum";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 88);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "Grade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 57);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 29);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Student Name";
            // 
            // StudentView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1326, 440);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "StudentView";
            Text = "Student Manager";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolAdd;
        private ToolStripButton toolRemove;
        private ToolStripButton toolSave;
        private StatusStrip statusStrip1;
        private SplitContainer splitContainer1;
        private DataGridView dataView;
        private BindingSource bindingSource1;
        private Label label1;
        private Label label2;
        private Label label6;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtPhoneNum;
        private NumericUpDown numYear;
        private Label label4;
        private TextBox txtGrade;
        private Label label3;
    }
}
