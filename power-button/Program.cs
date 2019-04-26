using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Power_Button
{
    class PowerButtonOptions
    {
        // to logoff or lock import the following dll file
        [DllImport("user32")]

        // to log off
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        [DllImport("user32")]
        // to lock 
        public static extern void LockWorkStation();

        // to put your computer in Hibernate or Sleep, you need the smae DllImport statement for them 
        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);

        public static void Shutdown()
        {
            // starts the shutdown application
            // the argument /s is to shutdown the computer
            // the argument /t is to tell the process that
            // the specified operation needs to be completed
            // after 0 seconds

            Process.Start("shutdown", "/s /t 0");
        }

        public static void Restart()
        {
            // starts the Restart application
            // the argument /r is to restart the computer
            // the argument /t is to tell the process that
            // the specified operation needs to be completed
            // after 0 seconds

            Process.Start("shutdown", "/s /t 0");
        }

        

        public static void LogOff()
        {
            ExitWindowsEx(0, 0);
        }

        public static void Lock()
        {
            LockWorkStation();
        }

        public static void Sleep()
        {
            SetSuspendState(false, true, true);
        }
        public static void Hibernate()
        {
            SetSuspendState(true, true, true);
        }


        static void Main(string[] args)
        {
            try
            {
                // Lock();
                // ShutDown();
                // Restart();
                // Hibernate();
                // Sleep();
            }
            catch
            {
                Console.Write("Catch Block");
            }

        }

}
}
