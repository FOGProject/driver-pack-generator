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

using MetroFramework.Controls;

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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.packPage = new System.Windows.Forms.TabPage();
            this.button3 = new MetroFramework.Controls.MetroButton();
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deviceTab = new System.Windows.Forms.TabPage();
            this.addBtn = new MetroFramework.Controls.MetroButton();
            this.localDeviceGrid = new System.Windows.Forms.DataGridView();
            this.descriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.includeCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.currentPgrs = new System.Windows.Forms.TabPage();
            this.saveBtn = new MetroButton();
            this.currentLbl = new MetroFramework.Controls.MetroLabel();
            this.deviceLbl = new MetroFramework.Controls.MetroLabel();
            this.progressBar2 = new MetroFramework.Controls.MetroProgressBar();
            this.totalPgrs = new MetroFramework.Controls.MetroProgressBar();
            this.tabControl.SuspendLayout();
            this.packPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.deviceTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localDeviceGrid)).BeginInit();
            this.currentPgrs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.packPage);
            this.tabControl.Controls.Add(this.deviceTab);
            this.tabControl.Controls.Add(this.currentPgrs);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(20, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(660, 420);
            this.tabControl.TabIndex = 0;
            // 
            // packPage
            // 
            this.packPage.Controls.Add(this.button3);
            this.packPage.Controls.Add(this.button1);
            this.packPage.Controls.Add(this.dataGridView1);
            this.packPage.Location = new System.Drawing.Point(4, 22);
            this.packPage.Name = "packPage";
            this.packPage.Padding = new System.Windows.Forms.Padding(3);
            this.packPage.Size = new System.Drawing.Size(652, 394);
            this.packPage.TabIndex = 0;
            this.packPage.Text = "Pack";
            this.packPage.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(6, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(311, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Load";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(323, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Devices";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 353);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // deviceTab
            // 
            this.deviceTab.Controls.Add(this.addBtn);
            this.deviceTab.Controls.Add(this.localDeviceGrid);
            this.deviceTab.Location = new System.Drawing.Point(4, 22);
            this.deviceTab.Name = "deviceTab";
            this.deviceTab.Padding = new System.Windows.Forms.Padding(3);
            this.deviceTab.Size = new System.Drawing.Size(652, 394);
            this.deviceTab.TabIndex = 1;
            this.deviceTab.Text = "Devices";
            this.deviceTab.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addBtn.Location = new System.Drawing.Point(3, 368);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(646, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add Devices";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // localDeviceGrid
            // 
            this.localDeviceGrid.AllowUserToAddRows = false;
            this.localDeviceGrid.AllowUserToDeleteRows = false;
            this.localDeviceGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.localDeviceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.localDeviceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionCol,
            this.includeCol});
            this.localDeviceGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.localDeviceGrid.Location = new System.Drawing.Point(3, 3);
            this.localDeviceGrid.Name = "localDeviceGrid";
            this.localDeviceGrid.RowHeadersVisible = false;
            this.localDeviceGrid.Size = new System.Drawing.Size(646, 356);
            this.localDeviceGrid.TabIndex = 0;
            // 
            // descriptionCol
            // 
            this.descriptionCol.HeaderText = "Description";
            this.descriptionCol.Name = "descriptionCol";
            // 
            // includeCol
            // 
            this.includeCol.HeaderText = "Include";
            this.includeCol.Name = "includeCol";
            // 
            // currentPgrs
            // 
            this.currentPgrs.Controls.Add(this.saveBtn);
            this.currentPgrs.Controls.Add(this.deviceLbl);

            this.currentPgrs.Controls.Add(this.currentLbl);
            this.currentPgrs.Controls.Add(this.progressBar2);
            this.currentPgrs.Controls.Add(this.totalPgrs);
            this.currentPgrs.Location = new System.Drawing.Point(4, 22);
            this.currentPgrs.Name = "currentPgrs";
            this.currentPgrs.Padding = new System.Windows.Forms.Padding(3);
            this.currentPgrs.Size = new System.Drawing.Size(652, 394);
            this.currentPgrs.TabIndex = 2;
            this.currentPgrs.Text = "Progress";
            this.currentPgrs.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(6, 365);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(640, 23);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);


            //
            // deviceLbl
            //
            // 
            this.deviceLbl.AutoSize = true;
            this.deviceLbl.Location = new System.Drawing.Point(6, 13);
            this.deviceLbl.Name = "deviceLbl";
            this.deviceLbl.Size = new System.Drawing.Size(42, 19);
            this.deviceLbl.TabIndex = 2;
            this.deviceLbl.Text = "label1";

            // totalPgrs
            // 
            this.totalPgrs.Location = new System.Drawing.Point(6, 45);
            this.totalPgrs.Name = "totalPgrs";
            this.totalPgrs.Size = new System.Drawing.Size(640, 23);
            this.totalPgrs.TabIndex = 0;
            // 
            // currentLbl
            // 
            this.currentLbl.AutoSize = true;
            this.currentLbl.Location = new System.Drawing.Point(6, 80);
            this.currentLbl.Name = "currentLbl";
            this.currentLbl.Size = new System.Drawing.Size(42, 19);
            this.currentLbl.TabIndex = 2;
            this.currentLbl.Text = "label1";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(6, 112);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(640, 23);
            this.progressBar2.TabIndex = 1;

            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "SelectionForm";
            this.Text = "Driver Pack Generator";
            this.tabControl.ResumeLayout(false);
            this.packPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.deviceTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.localDeviceGrid)).EndInit();
            this.currentPgrs.ResumeLayout(false);
            this.currentPgrs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage packPage;
        private System.Windows.Forms.TabPage deviceTab;
        private System.Windows.Forms.TabPage currentPgrs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroButton button1;
        private MetroButton button3;
        private System.Windows.Forms.DataGridView localDeviceGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn includeCol;
        private MetroButton addBtn;
        private MetroProgressBar progressBar2;
        private MetroProgressBar totalPgrs;
        private MetroLabel currentLbl;
        private MetroLabel deviceLbl;

        private MetroButton saveBtn;
    }
}

