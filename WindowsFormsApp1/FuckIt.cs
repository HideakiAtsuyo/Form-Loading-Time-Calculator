using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static class FuckIt
    {
        public static Stopwatch sw = new Stopwatch();
        public static void Stop()
        {
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",ts.Hours, ts.Minutes, ts.Seconds,ts.Milliseconds / 10);
            //string elapsedTime = String.Format("{0:00} ms",ts.Milliseconds / 10); //Only MS
            MessageBox.Show("RunTime " + elapsedTime);
        }
    }
}
