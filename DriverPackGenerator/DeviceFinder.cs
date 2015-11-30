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
using System.Management;

namespace DriverPackGenerator
{
    public static class DeviceFinder
    {
        public static List<Device> PopulateDevices()
        {
            var devices = new List<Device>();

            var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPSignedDriver");

            foreach (var obj in searcher.Get())
            {
                var inf = GetProperty(obj, "InfName");
                var description = GetProperty(obj, "Description");
                var classGUID = GetProperty(obj, "ClassGuid");
                var provider = GetProperty(obj, "DriverProviderName");

                if(classGUID.Equals("NA") || inf.Equals("NA")) continue;
                var device = new Device(inf, classGUID, null, provider, description);

                devices.Add(device);
            }

            return devices;
        }


        private static string GetProperty(ManagementBaseObject obj, string property)
        {
            var value = (obj.GetPropertyValue(property) == null)
                            ? "NA"
                            : obj.GetPropertyValue(property).ToString();

            return value;
        }
    }
}
