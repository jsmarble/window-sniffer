using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace WindowSniffer
{
    public class Window : IComparable<Window>
    {
        public IntPtr Handle { get; set; }
        public String Text { get; set; }
        public Rectangle Bounds { get; set; }

        public Size Size
        {
            get { return this.Bounds.Size; }
        }

        public Point Location
        {
            get { return this.Bounds.Location; }
        }

        #region IComparable<Window> Members

        public int CompareTo(Window other)
        {
            return this.Handle.ToInt32().CompareTo(other.Handle.ToInt32());
        }

        #endregion
    }
}
