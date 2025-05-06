namespace LibraryManagementSystem.Winforms.helpers
{
    public static class ApiClientHelper
    {
        public static HttpClient CreateClient()
        {
            var token = Properties.Settings.Default.JwtToken;

            var client = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:5049/api/")
            };

            if (!string.IsNullOrEmpty(token))
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            }

            return client;
        }
    }

}
