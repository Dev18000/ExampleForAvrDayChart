namespace ExampleForAvrDayChart.AppSettings
{
    public static class ApplicationServicesSettings
    {
        public const string ApiSettings = "ApiSettings";
        public static ApiSettingsOptions ApiSettingsOptions { get; set; } = new ApiSettingsOptions();
    }

    public class ApiSettingsOptions
    {
    }
}
