using System.Drawing;

namespace ExamSchedule.GUI.Const
{
    internal class GUIConstant
    {
        public static Color[] ColorsTask = { Color.Coral, Color.ForestGreen, Color.LightSeaGreen, Color.SaddleBrown, Color.Teal };

        #region Font

        public static readonly Font FontMain = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);

        public static readonly Font FontMainLabel = new Font("Segoe UI", 12F, FontStyle.Regular,
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