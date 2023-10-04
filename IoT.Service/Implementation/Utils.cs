namespace IoT.Service.Implementation
{

    /// <summary>
    /// Utilities for the application
    /// </summary>
    public static class Utils
    {


        /// <summary>
        /// Generate Random string
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
        /// <summary>
        /// Generate random Enum value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GenerateRandomEnumValue<T>()
        {
            Array values = Enum.GetValues(typeof(T));
            Random random = new Random();
            return (T)values.GetValue(random.Next(values.Length));
        }

        /// <summary>
        /// Generate Random date
        /// </summary>
        /// <returns></returns>
        public static DateTime GenerateRandomDate()
        {
            Random random = new Random();
            DateTime startDate = new DateTime(2023, 5, 5);
            int range = (DateTime.Today - startDate).Days;
            return startDate.AddDays(random.Next(range));
        }
    }
}
