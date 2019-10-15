using System;
using System.Runtime.InteropServices;


namespace R5T.Rugia.Base
{
    public static class Utilities
    {
        /// <summary>
        /// If code is running, it's executing on a machine platform.
        /// If the <see cref="RuntimeInformation.IsOSPlatform(OSPlatform)"/> is <see cref="OSPlatform.Windows"/>, then the output is <see cref="Platform.Windows"/>, else <see cref="Platform.NonWindows"/>.
        /// </summary>
        public static Platform GetExecutingMachinePlatform()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return Platform.Windows;
            }
            else
            {
                return Platform.NonWindows;
            }
        }
    }
}
