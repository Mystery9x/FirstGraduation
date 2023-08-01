using GraduationThesis4211036.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationThesis4211036.Services
{
    public class MockRouteDataStore : IDataStore<Route>
    {
        readonly List<Route> Routes;

        public MockRouteDataStore()
        {
            Routes = new List<Route>()
            {
                new Route { Id = Guid.NewGuid().ToString(), 
                    Actived=false, Description="tesst",
                    EndAt="test",EndTime=new DateTime(),
                    Exported=false,Name="Tesst1",
                    OpenStreetMap="",StartAt="sa",
                    StartTime=new DateTime(), Tag="tets;test",
                TrackPoint=1,Type=RouteType.Private,RouteWaypoint= Waypoint.None},
                new Route { Id = Guid.NewGuid().ToString(),
                    Actived=false, Description="tesst",
                    EndAt="test",EndTime=new DateTime(),
                    Exported=false,Name="Tesst1",
                    OpenStreetMap="",StartAt="sa",
                    StartTime=new DateTime(), Tag="tets;test",
                TrackPoint=1,Type=RouteType.Private,RouteWaypoint= Waypoint.None},
                new Route { Id = Guid.NewGuid().ToString(),
                    Actived=false, Description="tesst",
                    EndAt="test",EndTime=new DateTime(),
                    Exported=false,Name="Tesst1",
                    OpenStreetMap="",StartAt="sa",
                    StartTime=new DateTime(), Tag="tets;test",
                TrackPoint=1,Type=RouteType.Private,RouteWaypoint= Waypoint.None}
            };
        }

        public async Task<bool> AddItemAsync(Route Route)
        {
            Routes.Add(Route);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Route Route)
        {
            var oldRoute = Routes.Where((Route arg) => arg.Id == Route.Id).FirstOrDefault();
            Routes.Remove(oldRoute);
            Routes.Add(Route);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldRoute = Routes.Where((Route arg) => arg.Id == id).FirstOrDefault();
            Routes.Remove(oldRoute);

            return await Task.FromResult(true);
        }

        public async Task<Route> GetItemAsync(string id)
        {
            return await Task.FromResult(Routes.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Route>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(Routes);
        }
    }
}