using System.Drawing;

namespace ExamSchedule.GUI
{
    internal class GUIConstant
    {
        #region Font

        public static readonly Font FontMain = new Font("Source Sans Pro", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);

        public static readonly Font FontMainLabel = new Font("Source Sans Pro", 12F, FontStyle.Regular,
            GraphicsUnit.Point, 0);

        #endregion Font

        #region Color

        public static readonly Color ColorForeButton = Color.White;
        public static readonly Color ColorLabel = Color.Green;
        public static readonly Color ColorBackButton = Color.DarkTurquoise;
        public static readonly Color ColorBackHoverButton = Color.SlateGray;
        public static readonly Color ColorForeHoverButton = Color.White;
        public static readonly Color ColorBackLeaveButton = Color.DarkTurquoise;
        public static readonly Color ColorForeLeaveButton = Color.White;

        #endregion Color
    }
}