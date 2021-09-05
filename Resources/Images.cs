

namespace FerryFinder.Resources
{
    public static class Images
    {
        private static string Base => "images/";
        public static string Ferry => $"{Base}ship-solid.svg";
        public static string Schedule => $"{Base}calendar-alt-solid.svg";
        public static string Close => $"{Base}times-solid.svg";
        public static string ArrowLeft => $"{Base}arrow-left-solid.svg";
        public static string ArrowRight => $"{Base}arrow-right-solid.svg";

        public static string GetFerryImage(string imagePath) => $"../{Base}{imagePath}.jpg";
        
    }
}
