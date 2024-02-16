using System;
using System.Management;

namespace FluidAPI
{
    public class Hwid
    {
        public static string UserHwid() => $"Fluid-{getCpuId()}-{Environment.Version}-{Environment.UserName}";

        private static string getCpuId()
        {
            ManagementClass managClass = new ManagementClass("win32_processor");
            ManagementObjectCollection manageCollect = managClass.GetInstances();

            foreach (ManagementObject item in manageCollect)
            { return item.Properties["processorID"].Value.ToString(); }
            return "null";
        }
    }
}
