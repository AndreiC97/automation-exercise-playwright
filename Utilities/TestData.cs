namespace AutomationExercise.Utilities
{
    public static class TestData
    {
        public static string ValidEmail = "existinguser@test.com";
        public static string ValidPassword = "Password123";

        public static string InvalidEmail = "invalid@test.com";
        public static string InvalidPassword = "invalid123";

        public static string NewUserName = "John";
        public static string NewUserEmail = $"john{DateTime.Now.Ticks}@test.com";
    }
}