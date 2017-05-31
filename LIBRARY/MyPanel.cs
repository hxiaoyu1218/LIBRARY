using System.Windows.Forms;

namespace LIBRARY
{
    /// <summary>
    /// 用途：防止Panel闪烁
    /// </summary>
    class MyPanel : Panel
    {
        public MyPanel()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
        }
    }
}