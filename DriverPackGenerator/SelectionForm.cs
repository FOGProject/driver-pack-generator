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

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using MetroFramework.Forms;

namespace DriverPackGenerator
{
    public partial class SelectionForm : MetroForm
    {
        private List<Device> devices;
        private Thread searchThread;

        public SelectionForm()
        {
            InitializeComponent();
            AddDevices();
            searchThread = new Thread(SaveDrivers);
            devices = devices.Distinct().ToList();

            foreach (var device in devices)
            {
                var duplicateFile = new List<string>();

                foreach (var file in device.Files)
                {
                    if(file.Contains("32") && device.Files.Contains(file.Replace("32", "64")))
                        duplicateFile.Add(file);
                }

                foreach (var file in duplicateFile)
                {
                    //device.Files.Remove(file);
                }
            }
        }

        private void AddDevices()
        {
            devices = DeviceFinder.PopulateDevices();
            foreach (var device in devices)
            {
                if(device.ClassGUID.Equals("{NA}")) continue;
                if (device.INF.Equals("NA")) continue;

                localDeviceGrid.Rows.Add(device.Description, true);
            }
        }

        private void saveBtn_Click(object sender, System.EventArgs e)
        {
            searchThread.Start();
        }

        private void SaveDrivers()
        {
            totalPgrs.Invoke(new Action(() => totalPgrs.Value = 0));
            progressBar2.Invoke(new Action(() => progressBar2.Value = 0));

            var savePath = Path.Combine(System.Reflection.Assembly.GetEntryAssembly().Location, "BackUp");
            Directory.CreateDirectory(savePath);
            totalPgrs.Invoke(new Action(() => totalPgrs.Maximum = devices.Count));

            for (int i =0; i < devices.Count; i++)
            {
                deviceLbl.Invoke(new Action(() => deviceLbl.Text = devices[i].Description));
                progressBar2.Invoke(new Action(() => progressBar2.Value = 0));

                var driverDir = Path.Combine(savePath, devices[i].Description);
                Directory.CreateDirectory(driverDir);

                var root = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.Windows));
                var winDir = Environment.GetFolderPath(Environment.SpecialFolder.Windows);

                var searchWeights = new List<string>
                    {
                       Path.Combine(winDir, "INF"),
                        Path.Combine(winDir, "system32", "DriverStore", "FileRepository"),
                        Path.Combine(winDir, "system32", "drivers"),
                        Path.Combine(winDir, "system32", "CatRoot"),
                        Path.Combine(winDir, "system32"),
                        Path.Combine(winDir, "Help"),
                        Path.Combine(winDir, "Fonts"),
                        Path.Combine(winDir, "system"),
                        Path.Combine(winDir, "system32", "spool"),
                       Path.Combine(winDir, "system32", "spool", "drivers"),
                        winDir,
                        root,
                    };


                SaveFiles(devices[i], driverDir, searchWeights);

                totalPgrs.Invoke(new Action(() => totalPgrs.Value = i + 1));
            }
        }

        private void SaveFiles(Device device, string saveDir, List<string> search)
        {
            progressBar2.Invoke(new Action(() => progressBar2.Maximum = device.Files.Count));
            progressBar2.Invoke(new Action(() => progressBar2.Value = 0));

            for (int i = 0; i < device.Files.Count; i++)
            {
                currentLbl.Invoke(new Action(() => currentLbl.Text = device.Files[i]));
                var src = FindFile(device.Files[i], search);
                if(src != null)
                    File.Copy(src, Path.Combine(saveDir, Path.GetFileName(src)), true);

                progressBar2.Invoke(new Action(() => progressBar2.Value = i + 1));
            }
        }

        private string FindFile(string name, List<string> search)
        {
            if (File.Exists(name)) return name;

            // Perform quick search
            foreach (var sDir in search)
            {
                var files = Directory.EnumerateFiles(sDir, "*.*", SearchOption.TopDirectoryOnly).ToList();
                foreach (var file in files.Where(file => Path.GetFileName(file).Equals(name)))
                {
                    if (search.IndexOf(sDir) > 0)
                    {
                        search.Remove(sDir);
                        search.Insert(0, sDir);
                    }
                    return file;
                }
            }

            // Perform deep search
            foreach (var sDir in search)
            {
                var dirs = Directory.EnumerateDirectories(sDir, "*.*", SearchOption.TopDirectoryOnly).ToList();
                foreach (var dir in dirs)
                {
                    try
                    {
                        var files = Directory.EnumerateFiles(dir, "*.*", SearchOption.TopDirectoryOnly).ToList();
                        foreach (var file in files.Where(file => Path.GetFileName(file).Equals(name)))
                        {
                            if (search.IndexOf(sDir) > 0)
                            {
                                search.Remove(sDir);
                                search.Insert(0, sDir);
                            }
                            return file;
                        }
                    }
                    catch (Exception)
                    {
                        
                    }

                }
            }

            return null;
        }
    }
}
