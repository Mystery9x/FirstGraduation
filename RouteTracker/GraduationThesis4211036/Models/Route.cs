using System;
using System.Collections.Generic;

namespace GraduationThesis4211036.Models
{
    public class Route
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Tag { get; set; }
        public RouteType Type { get; set; }
        public int TrackPoint { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string StartAt { get; set; }
        public string EndAt { get; set; }
        public string OpenStreetMap { get; set; }
        public bool Exported { get; set; }
        public Waypoint RouteWaypoint { get; set; }
        public bool Actived { get; set; }

        public Route(string id, string name, string description, string tag, RouteType type, int trackPoint, DateTime startTime, DateTime endTime, string startAt, string endAt, string openStreetMap, bool exported, Waypoint waypoint, bool actived)
        {
            Id = id;
            Name = name;
            Description = description;
            Tag = tag;
            Type = type;
            TrackPoint = trackPoint;
            StartTime = startTime;
            EndTime = endTime;
            StartAt = startAt;
            EndAt = endAt;
            OpenStreetMap = openStreetMap;
            Exported = exported;
            RouteWaypoint = waypoint;
            Actived = actived;
        }
        public Route() { }
    }
}
