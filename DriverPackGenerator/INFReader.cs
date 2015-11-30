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

using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DriverPackGenerator
{
    class INFReader
    {
        private readonly string[] _lines;

        public INFReader(string filePath)
        {
            _lines = File.ReadAllLines(filePath);
        }

        public Dictionary<string, List<string>> GetSection(string section)
        {
            var data = new Dictionary<string, List<string>>();
            section = "[" + section + "]";
            var start = false;
            var lineBRK = false;
            var prepend = "";
            foreach (var line in _lines)
            {
                if(string.IsNullOrWhiteSpace(line)) continue;

                if (line.ToLower().StartsWith(section.ToLower()))
                {
                    start = true;
                    continue;
                }

                if (start && line.StartsWith("[")) break;

                if (!start) continue;

                lineBRK = line.EndsWith("\\");

                var lineFiltered = line.Replace("\\", "");

                
                var tag = AddData(data, prepend + lineFiltered);

                if (lineBRK)
                {
                    if(!string.IsNullOrEmpty(tag))
                        prepend = tag + "=";
                }
                else
                {
                    prepend = "";
                }
            }

            return data;
        }

        private string AddData(Dictionary<string, List<string>> data, string line)
        {
            // Strip out comments
            var commentIndex = line.IndexOf(';');
            if (commentIndex >= 0)
            {
                line = line.Substring(0, commentIndex);
            }

            if (line.Length == 0) return null;

            // Strip out the tag and =
            var tag = "";
            var index = line.IndexOf('=');
            if (index > 0)
                tag = line.Substring(0, index).Trim();

            if (!data.ContainsKey(tag))
                data[tag] = new List<string>();

            line = line.Substring(index + 1).Trim();

            // Seperate multiple entries per line (,)
            var entries = line.Split(',');
            foreach (var entry in entries)
            {
                var trimmed = entry.Trim();
                if(trimmed.Length == 0) continue;

                data[tag].Add(trimmed);
            }

            return tag;
        }
    }
}
