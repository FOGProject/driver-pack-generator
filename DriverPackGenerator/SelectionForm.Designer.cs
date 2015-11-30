/*
 * DriverPack Generator
 * Copyright (C) 2015 FOG Project
 * 
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 3
 * of the License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */

namespace DriverPackGenerator
{
    partial class SelectionForm
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
            this.INFCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INFSecCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProducerCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GUIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.INFCol,
            this.INFSecCol,
            this.ProducerCol,
            this.GUIDCol,
            this.DescriptionCol,
            this.FilesCol});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(657, 356);
            this.dataGridView1.TabIndex = 0;
            // 
            // INFCol
            // 
            this.INFCol.HeaderText = "INF";
            this.INFCol.Name = "INFCol";
            this.INFCol.ReadOnly = true;
            // 
            // INFSecCol
            // 
            this.INFSecCol.HeaderText = "INF Section";
            this.INFSecCol.Name = "INFSecCol";
            this.INFSecCol.ReadOnly = true;
            // 
            // ProducerCol
            // 
            this.ProducerCol.HeaderText = "Producer";
            this.ProducerCol.Name = "ProducerCol";
            this.ProducerCol.ReadOnly = true;
            // 
            // GUIDCol
            // 
            this.GUIDCol.HeaderText = "GUID";
            this.GUIDCol.Name = "GUIDCol";
            this.GUIDCol.ReadOnly = true;
            // 
            // DescriptionCol
            // 
            this.DescriptionCol.HeaderText = "Description";
            this.DescriptionCol.Name = "DescriptionCol";
            this.DescriptionCol.ReadOnly = true;
            // 
            // FilesCol
            // 
            this.FilesCol.HeaderText = "Files";
            this.FilesCol.Name = "FilesCol";
            this.FilesCol.ReadOnly = true;
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 356);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SelectionForm";
            this.Text = "Driver Pack Generator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn INFCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn INFSecCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProducerCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilesCol;
    }
}

