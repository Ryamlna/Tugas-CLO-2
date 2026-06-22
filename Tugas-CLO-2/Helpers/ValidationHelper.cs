namespace BintangGUI.Helpers
{
    public static class ValidationHelper
    {
        public static void ValidateCoordinate(double latitude, double longitude)
        {
            if (latitude < -90 || latitude > 90)
            {
                throw new ArgumentException("Latitude tidak valid. Harus antara -90 dan 90.");
            }

            if (longitude < -180 || longitude > 180)
            {
                throw new ArgumentException("Longitude tidak valid. Harus antara -180 dan 180.");
            }
        }
    }
}
