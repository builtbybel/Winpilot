using System;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace Bloatynosy
{
    internal class Stargazers
    {
        // Event to be subscribed on Mainform
        public event EventHandler<int> StargazersCountFetched;

        // Attributes to indicate that class is a data contract
        [Serializable]
        [DataContract]
        public class GitHubRepository
        {
            [DataMember(Name = "stargazers_count")] // matches GitHub API response
            public int StargazersCount { get; set; }
        }

        public async Task FetchStargazersAsync()
        {
            string repositoryOwner = "builtbybel";
            string repositoryName = "Bloatynosy";

            string apiUrl = $"https://api.github.com/repos/{repositoryOwner}/{repositoryName}";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Add an appropriate user agent header
                    client.DefaultRequestHeaders.Add("User-Agent", "Bloatynosy");

                    // Make GET request
                    Stream responseStream = await client.GetStreamAsync(apiUrl);

                    // Deserialize JSON using DataContractJsonSerializer
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(GitHubRepository));
                    GitHubRepository repoInfo = (GitHubRepository)serializer.ReadObject(responseStream);

                    // Extract and display stargazers count
                    int stargazersCount = repoInfo.StargazersCount;

                    // Notify subscribers (MainForm) about the fetched stargazers count
                    StargazersCountFetched?.Invoke(this, stargazersCount);
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine($"{ex.Message}");

                // Notify subscribers about  exceptions
                StargazersCountFetched?.Invoke(this, -1);
            }
        }
    }
}
