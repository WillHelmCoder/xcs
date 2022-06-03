using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using xcs.DTO;

namespace xcs;

public partial class App : Application
{
	public static App Instance { private set; get; }
	public App()
	{
		Instance = this;

		BaseUrl = "https://xiper.azurewebsites.net/";

		Client = new RestClient(new RestClientOptions(BaseUrl));

		Client.UseNewtonsoftJson(new JsonSerializerSettings
		{
			ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver(),
		});


		InitializeComponent();

		if (Preferences.Get("SessionStatus", "Default")!="valid") {

			MainPage = new NavigationPage(new Login());
			//MainPage = new AppShell();
		}
        else
        {
			
			
			MainPage = new AppShell();

	
		}		
	}

	readonly RestClient Client;
	readonly string BaseUrl;
	string AuthToken;

	public async Task<RestResponse<T>> Send<T>(string url, Method method = Method.Get, object data = null)
	{
		var request = new RestRequest(url);

		if (data != null)
			request.AddJsonBody(data);

		//this be cool for OAUTH or BASIC AUTH
		//Client.Authenticator = new CustomAuthenticator();

		request.Method = method;

		request.AddHeader("Content-Type", "application/json");
		request.AddHeader("X-Requested-With", "Requestor");

		if (!string.IsNullOrWhiteSpace(AuthToken))
			request.AddHeader("authorization", $"bearer {AuthToken}");

		return await Client.ExecuteAsync<T>(request);
	}
	public void StartSession(string authToken)
	{
		AuthToken = authToken;
	}
	public void Logout()
	{
		AuthToken = null;
		//Client.CookieContainer.Clear();
	}

	public ErrorModel GetErrorModel(string content)
	{
		var model = new ErrorModel { Error = "Error inesperado" };

		if (string.IsNullOrWhiteSpace(content))
			return model;

		var dictionary = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(content);

		if (dictionary == null)
			model = new ErrorModel { Error = "Error inesperado" };
		else if (dictionary.Any())
			model.Error = dictionary.First().Value.FirstOrDefault() ?? model.Error;

		return model;
	}
}