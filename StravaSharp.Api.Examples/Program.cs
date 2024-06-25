// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using StravaSharp.Api.Clients;
using StravaSharp.Api.Models.Request;
using StravaSharp.Api.Models.Response;

StravaClient client = new StravaClient("");
var activies = await client.Activities.GetAthleteActivitiesAsync();

foreach (var activity in activies)
{
    Console.WriteLine(activity.Name);
}

var testActivity = new ActivityCreate
{
    Name = "Test Activity",
    Description = "This is a test activity",
    Type = ActivityType.Walk,
    SportType = SportType.Walk,
    StartDateLocal = DateTime.Now - TimeSpan.FromDays(1),
    ElapsedTime = 3600,
    Distance = 10000,
    Commute = false,
    Trainer = false
};

var createdActivity = await client.Activities.CreateActivityAsync(testActivity);
var updated = await client.Activities.UpdateActivityAsync(createdActivity.Id, new ActivityUpdate
{
    Name = "Updated Test Activity"
});