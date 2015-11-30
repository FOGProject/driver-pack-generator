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

using System.Windows.Forms;

namespace DriverPackGenerator
{
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
            AddDevices();
        }

        private void AddDevices()
        {
            var devices = DeviceFinder.PopulateDevices();
            foreach (var device in devices)
            {
                if(device.ClassGUID.Equals("{NA}")) continue;
                if (device.INF.Equals("NA")) continue;

                dataGridView1.Rows.Add(device.INF, device.INFSection, device.Provider, device.ClassGUID, device.Description, device.Files.Count);
            }
        }
    }
}
