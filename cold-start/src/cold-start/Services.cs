using System;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

using System.Threading;
using System.Threading.Tasks;

using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.Runtime;

namespace cold_start
{
    public class Services
    {
        public string field { get; set; }
        private static string tableName = "Hero";
        private static AmazonDynamoDBClient client = new AmazonDynamoDBClient();

        
        public Hero CheckRequest(string request, JObject payload){

            if(request.Equals("Add"))
            {
                Task<Hero> res = Task.Run<Hero>(async () => await AddItem(payload));
                return res.Result;
            }
            return null;
        }

        public async Task<Hero> AddItem(JObject payload)
        {
            var id = (string)payload.SelectToken("id");
            var name = (string)payload.SelectToken("name");
            var year = (int)payload.SelectToken("year");
            Hero newHero = new Hero(id, name, year);

            Table table = Table.LoadTable(client, "Hero");
            var newHeroRequest = new Document();
            newHeroRequest["id"] = id;
            newHeroRequest["Name"] = name;
            newHeroRequest["Year"] = year;
            var res = await table.PutItemAsync(newHeroRequest);

            return newHero;

        }
    }
}