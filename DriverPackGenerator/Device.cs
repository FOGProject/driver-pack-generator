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
using System.Windows.Forms;
using Microsoft.Win32;

namespace DriverPackGenerator
{
    public class Device
    {
        public string INF { get; }
        public string INFSection { get; private set; }
        public string ClassGUID { get; }
        public string Provider { get; }
        public string Description { get; }
        public List<string> Files = new List<string>();

        public Device(string inf, string classGUID, string infSection, string provider, string description)
        {
            this.INF = inf;
            this.INFSection = infSection;
            this.ClassGUID = NormalizeGUID(classGUID);
            this.Provider = provider;
            this.Description = description;

            if(string.IsNullOrEmpty(INFSection))
                PopulateINFSection();

            PopulateFiles();
            Files = Files.Distinct().ToList();
        }

        private string NormalizeGUID(string guid)
        {
            guid = guid.Trim();
            guid = guid.ToUpper();
            if (!guid.StartsWith("{")) guid = "{" + guid;
            if (!guid.EndsWith("}")) guid = guid + "}";
            return guid;
        }

        private void PopulateINFSection()
        {
            try
            {
                using (var key = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Class\" + ClassGUID))
                {
                    if (key == null) return;

                    var subKeys = key.GetSubKeyNames();

                    foreach (var subKeyPath in subKeys)
                    {
                        try
                        {
                            var subKey = key.OpenSubKey(subKeyPath);
                            if (subKey == null || !INF.Equals(subKey.GetValue("infPath"))) continue;

                            INFSection = subKey.GetValue("InfSection").ToString();
                            return;
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("INFSection ERROR: " + ex.Message);
            }
        }

        private void PopulateFiles()
        {
            AddSection(INF, INFSection);
        }

        private void AddSection(string file, string section)
        {
            var infPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "INF", file);
            Files.Add(infPath);

            try
            {
                var reader = new INFReader(infPath);
                var data = reader.GetSection(section);
                if (data.Keys.Count == 0) throw new Exception("No data in section");

                // Reference another INF
                if (data.ContainsKey("Include") && data.ContainsKey("Needs"))
                {
                    for (var index = 0; index < data["Include"].Count; index++)
                    {
                        var refName = data["Include"][index];
                        var refSection = data["Needs"][index];
                        AddSection(refName, refSection);
                    }
                }

                // CopyFiles
                if (data.ContainsKey("CopyFiles"))
                {
                    foreach (var fileData in data["CopyFiles"])
                    {
                        if (fileData.Contains("@"))
                            AddFile(Files, fileData);
                        else
                            AddFiles(Files, reader, fileData);
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERR: " + ex.Message);
            }

        }

        private void AddFile(List<string> files, string data)
        {
            data = Strip(data, "@");
            data = data.Trim();
            files.Add(data);
        }

        private void AddFiles(List<string> files, INFReader reader, string data)
        {
            data = data.Trim();

            var section = reader.GetSection(data);
            files.AddRange(section[""]);
        }

        private string Strip(string line, string text)
        {
            var index = line.IndexOf(text);
            if (index >= 0)
                line = line.Remove(index, text.Length);

            return line;
        }

    }
}
