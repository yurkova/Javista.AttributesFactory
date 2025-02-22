﻿
namespace Javista.AttributesFactory.Forms
{
    partial class EntityCreationDialog
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnCreateEntities = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EntitySchemaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntityOwnershipType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.EntityDisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntityCollectionDisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntityIsActivity = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PrimaryAttributeSchemaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimaryAttributeDisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.pnlHeader.Size = new System.Drawing.Size(1197, 74);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Location = new System.Drawing.Point(15, 15);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1400, 53);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "We detected tables that does not exist on the connected environment. You can crea" +
    "te them now";
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnCreateEntities);
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 547);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1197, 54);
            this.pnlFooter.TabIndex = 3;
            // 
            // btnCreateEntities
            // 
            this.btnCreateEntities.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateEntities.Location = new System.Drawing.Point(896, 8);
            this.btnCreateEntities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateEntities.Name = "btnCreateEntities";
            this.btnCreateEntities.Size = new System.Drawing.Size(165, 42);
            this.btnCreateEntities.TabIndex = 1;
            this.btnCreateEntities.Text = "Create Tables";
            this.btnCreateEntities.UseVisualStyleBackColor = true;
            this.btnCreateEntities.Click += new System.EventHandler(this.btnCreateEntities_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(1070, 8);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 42);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 601);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1197, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 15);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dataGridView1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 74);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.pnlMain.Size = new System.Drawing.Size(1197, 473);
            this.pnlMain.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EntitySchemaName,
            this.EntityOwnershipType,
            this.EntityDisplayName,
            this.EntityCollectionDisplayName,
            this.EntityIsActivity,
            this.PrimaryAttributeSchemaName,
            this.PrimaryAttributeDisplayName});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1177, 455);
            this.dataGridView1.TabIndex = 0;
            // 
            // EntitySchemaName
            // 
            this.EntitySchemaName.HeaderText = "Table Schema Name";
            this.EntitySchemaName.MinimumWidth = 8;
            this.EntitySchemaName.Name = "EntitySchemaName";
            this.EntitySchemaName.ReadOnly = true;
            this.EntitySchemaName.Width = 150;
            // 
            // EntityOwnershipType
            // 
            this.EntityOwnershipType.HeaderText = "Ownership type";
            this.EntityOwnershipType.MinimumWidth = 8;
            this.EntityOwnershipType.Name = "EntityOwnershipType";
            this.EntityOwnershipType.Width = 150;
            // 
            // EntityDisplayName
            // 
            this.EntityDisplayName.HeaderText = "Display name";
            this.EntityDisplayName.MinimumWidth = 8;
            this.EntityDisplayName.Name = "EntityDisplayName";
            this.EntityDisplayName.Width = 150;
            // 
            // EntityCollectionDisplayName
            // 
            this.EntityCollectionDisplayName.HeaderText = "Display collection name";
            this.EntityCollectionDisplayName.MinimumWidth = 8;
            this.EntityCollectionDisplayName.Name = "EntityCollectionDisplayName";
            this.EntityCollectionDisplayName.Width = 150;
            // 
            // EntityIsActivity
            // 
            this.EntityIsActivity.HeaderText = "Is Activity";
            this.EntityIsActivity.MinimumWidth = 8;
            this.EntityIsActivity.Name = "EntityIsActivity";
            this.EntityIsActivity.Width = 150;
            // 
            // PrimaryAttributeSchemaName
            // 
            this.PrimaryAttributeSchemaName.HeaderText = "Primary Column Schema name";
            this.PrimaryAttributeSchemaName.MinimumWidth = 8;
            this.PrimaryAttributeSchemaName.Name = "PrimaryAttributeSchemaName";
            this.PrimaryAttributeSchemaName.Width = 150;
            // 
            // PrimaryAttributeDisplayName
            // 
            this.PrimaryAttributeDisplayName.HeaderText = "Primary Column Display name";
            this.PrimaryAttributeDisplayName.MinimumWidth = 8;
            this.PrimaryAttributeDisplayName.Name = "PrimaryAttributeDisplayName";
            this.PrimaryAttributeDisplayName.Width = 150;
            // 
            // EntityCreationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 623);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.statusStrip1);
            this.Name = "EntityCreationDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Missing tables detected!";
            this.pnlHeader.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnCreateEntities;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntitySchemaName;
        private System.Windows.Forms.DataGridViewComboBoxColumn EntityOwnershipType;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntityDisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntityCollectionDisplayName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EntityIsActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimaryAttributeSchemaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimaryAttributeDisplayName;
    }
}