namespace QuickType
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Fixture
    {
        [JsonProperty("venue", NullValueHandling = NullValueHandling.Ignore)]
        public string Venue { get; set; }

        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StatusConverter))]
        public Status? Status { get; set; }

        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(TimeConverter))]
        public Time? Time { get; set; }

        [JsonProperty("fifa_id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? FifaId { get; set; }

        [JsonProperty("weather", NullValueHandling = NullValueHandling.Ignore)]
        public Weather Weather { get; set; }

        [JsonProperty("attendance", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Attendance { get; set; }

        [JsonProperty("officials", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Officials { get; set; }

        [JsonProperty("stage_name", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StageNameConverter))]
        public StageName? StageName { get; set; }

        [JsonProperty("home_team_country", NullValueHandling = NullValueHandling.Ignore)]
        public string HomeTeamCountry { get; set; }

        [JsonProperty("away_team_country", NullValueHandling = NullValueHandling.Ignore)]
        public string AwayTeamCountry { get; set; }

        [JsonProperty("datetime", NullValueHandling = NullValueHandling.Ignore)]

        public DateTimeOffset? Datetime { get; set; }

        [JsonProperty("winner", NullValueHandling = NullValueHandling.Ignore)]
        public string Winner { get; set; }

        [JsonProperty("winner_code", NullValueHandling = NullValueHandling.Ignore)]
        public string WinnerCode { get; set; }

        [JsonProperty("home_team", NullValueHandling = NullValueHandling.Ignore)]
        public Team HomeTeam { get; set; }

        [JsonProperty("away_team", NullValueHandling = NullValueHandling.Ignore)]
        public Team AwayTeam { get; set; }

        [JsonProperty("home_team_events", NullValueHandling = NullValueHandling.Ignore)]
        public List<TeamEvent> HomeTeamEvents { get; set; }

        [JsonProperty("away_team_events", NullValueHandling = NullValueHandling.Ignore)]
        public List<TeamEvent> AwayTeamEvents { get; set; }

        [JsonProperty("home_team_statistics", NullValueHandling = NullValueHandling.Ignore)]
        public TeamStatistics HomeTeamStatistics { get; set; }

        [JsonProperty("away_team_statistics", NullValueHandling = NullValueHandling.Ignore)]
        public TeamStatistics AwayTeamStatistics { get; set; }

        [JsonProperty("last_event_update_at", NullValueHandling = NullValueHandling.Ignore)]

        public DateTimeOffset? LastEventUpdateAt { get; set; }

        [JsonProperty("last_score_update_at")]

        public DateTimeOffset? LastScoreUpdateAt { get; set; }
    }

    public partial class Team
    {
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        [JsonProperty("goals", NullValueHandling = NullValueHandling.Ignore)]
        public long? Goals { get; set; }

        [JsonProperty("penalties", NullValueHandling = NullValueHandling.Ignore)]
        public long? Penalties { get; set; }

        public override string ToString()
        {
            return $"{Country} ({Code})";
        }
    }

    public partial class TeamEvent
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("type_of_event", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(TypeOfEventConverter))]
        public TypeOfEvent? TypeOfEvent { get; set; }

        [JsonProperty("player", NullValueHandling = NullValueHandling.Ignore)]
        public string Player { get; set; }

        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }
    }

    public partial class TeamStatistics
    {
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        [JsonProperty("attempts_on_goal", NullValueHandling = NullValueHandling.Ignore)]
        public long? AttemptsOnGoal { get; set; }

        [JsonProperty("on_target", NullValueHandling = NullValueHandling.Ignore)]
        public long? OnTarget { get; set; }

        [JsonProperty("off_target", NullValueHandling = NullValueHandling.Ignore)]
        public long? OffTarget { get; set; }

        [JsonProperty("blocked", NullValueHandling = NullValueHandling.Ignore)]
        public long? Blocked { get; set; }

        [JsonProperty("woodwork", NullValueHandling = NullValueHandling.Ignore)]
        public long? Woodwork { get; set; }

        [JsonProperty("corners", NullValueHandling = NullValueHandling.Ignore)]
        public long? Corners { get; set; }

        [JsonProperty("offsides", NullValueHandling = NullValueHandling.Ignore)]
        public long? Offsides { get; set; }

        [JsonProperty("ball_possession", NullValueHandling = NullValueHandling.Ignore)]
        public long? BallPossession { get; set; }

        [JsonProperty("pass_accuracy", NullValueHandling = NullValueHandling.Ignore)]
        public long? PassAccuracy { get; set; }

        [JsonProperty("num_passes", NullValueHandling = NullValueHandling.Ignore)]
        public long? NumPasses { get; set; }

        [JsonProperty("passes_completed", NullValueHandling = NullValueHandling.Ignore)]
        public long? PassesCompleted { get; set; }

        [JsonProperty("distance_covered", NullValueHandling = NullValueHandling.Ignore)]
        public long? DistanceCovered { get; set; }

        [JsonProperty("balls_recovered", NullValueHandling = NullValueHandling.Ignore)]
        public long? BallsRecovered { get; set; }

        [JsonProperty("tackles", NullValueHandling = NullValueHandling.Ignore)]
        public long? Tackles { get; set; }

        [JsonProperty("clearances", NullValueHandling = NullValueHandling.Ignore)]
        public long? Clearances { get; set; }

        [JsonProperty("yellow_cards", NullValueHandling = NullValueHandling.Ignore)]
        public long? YellowCards { get; set; }

        [JsonProperty("red_cards", NullValueHandling = NullValueHandling.Ignore)]
        public long? RedCards { get; set; }

        [JsonProperty("fouls_committed")]
        public long? FoulsCommitted { get; set; }

        [JsonProperty("tactics", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(TacticsConverter))]
        public Tactics? Tactics { get; set; }

        [JsonProperty("starting_eleven", NullValueHandling = NullValueHandling.Ignore)]
        public List<StartingEleven> StartingEleven { get; set; }

        [JsonProperty("substitutes", NullValueHandling = NullValueHandling.Ignore)]
        public List<StartingEleven> Substitutes { get; set; }
    }

    public partial class StartingEleven
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("captain", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Captain { get; set; }

        [JsonProperty("shirt_number", NullValueHandling = NullValueHandling.Ignore)]
        public long? ShirtNumber { get; set; }

        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PositionConverter))]
        public Position? Position { get; set; }

        public override string ToString()
        {
            return $"{Name} {ShirtNumber} {Position} {Captain}";
        }
        public override bool Equals(object obj)
        {
            return this.ToString().Equals(obj.ToString());
        }
        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }


    }

    public partial class Weather
    {
        [JsonProperty("humidity", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Humidity { get; set; }

        [JsonProperty("temp_celsius", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? TempCelsius { get; set; }

        [JsonProperty("temp_farenheit", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? TempFarenheit { get; set; }

        [JsonProperty("wind_speed", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? WindSpeed { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DescriptionConverter))]
        public Description? Description { get; set; }
    }

    public enum TypeOfEvent { Goal, GoalOwn, GoalPenalty, RedCard, SubstitutionIn, SubstitutionOut, YellowCard, YellowCardSecond };

    public enum Position { Defender, Forward, Goalie, Midfield };

    public enum Tactics { The3421, The343, The352, The4231, The4321, The433, The442, The451, The532, The541 };

    public enum StageName { Final, FirstStage, PlayOffForThirdPlace, QuarterFinals, RoundOf16, SemiFinals };

    public enum Status { Completed };

    public enum Time { FullTime };

    public enum Description { ClearNight, Cloudy, PartlyCloudy, PartlyCloudyNight, Sunny };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                TypeOfEventConverter.Singleton,
                PositionConverter.Singleton,
                TacticsConverter.Singleton,
                StageNameConverter.Singleton,
                StatusConverter.Singleton,
                TimeConverter.Singleton,
                DescriptionConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class TypeOfEventConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeOfEvent) || t == typeof(TypeOfEvent?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "goal":
                    return TypeOfEvent.Goal;
                case "goal-own":
                    return TypeOfEvent.GoalOwn;
                case "goal-penalty":
                    return TypeOfEvent.GoalPenalty;
                case "red-card":
                    return TypeOfEvent.RedCard;
                case "substitution-in":
                    return TypeOfEvent.SubstitutionIn;
                case "substitution-out":
                    return TypeOfEvent.SubstitutionOut;
                case "yellow-card":
                    return TypeOfEvent.YellowCard;
                case "yellow-card-second":
                    return TypeOfEvent.YellowCardSecond;
            }
            throw new Exception("Cannot unmarshal type TypeOfEvent");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeOfEvent)untypedValue;
            switch (value)
            {
                case TypeOfEvent.Goal:
                    serializer.Serialize(writer, "goal");
                    return;
                case TypeOfEvent.GoalOwn:
                    serializer.Serialize(writer, "goal-own");
                    return;
                case TypeOfEvent.GoalPenalty:
                    serializer.Serialize(writer, "goal-penalty");
                    return;
                case TypeOfEvent.RedCard:
                    serializer.Serialize(writer, "red-card");
                    return;
                case TypeOfEvent.SubstitutionIn:
                    serializer.Serialize(writer, "substitution-in");
                    return;
                case TypeOfEvent.SubstitutionOut:
                    serializer.Serialize(writer, "substitution-out");
                    return;
                case TypeOfEvent.YellowCard:
                    serializer.Serialize(writer, "yellow-card");
                    return;
                case TypeOfEvent.YellowCardSecond:
                    serializer.Serialize(writer, "yellow-card-second");
                    return;
            }
            throw new Exception("Cannot marshal type TypeOfEvent");
        }

        public static readonly TypeOfEventConverter Singleton = new TypeOfEventConverter();
    }

    internal class PositionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Position) || t == typeof(Position?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Defender":
                    return Position.Defender;
                case "Forward":
                    return Position.Forward;
                case "Goalie":
                    return Position.Goalie;
                case "Midfield":
                    return Position.Midfield;
            }
            throw new Exception("Cannot unmarshal type Position");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Position)untypedValue;
            switch (value)
            {
                case Position.Defender:
                    serializer.Serialize(writer, "Defender");
                    return;
                case Position.Forward:
                    serializer.Serialize(writer, "Forward");
                    return;
                case Position.Goalie:
                    serializer.Serialize(writer, "Goalie");
                    return;
                case Position.Midfield:
                    serializer.Serialize(writer, "Midfield");
                    return;
            }
            throw new Exception("Cannot marshal type Position");
        }

        public static readonly PositionConverter Singleton = new PositionConverter();
    }

    internal class TacticsConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Tactics) || t == typeof(Tactics?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "3-4-2-1":
                    return Tactics.The3421;
                case "3-4-3":
                    return Tactics.The343;
                case "3-5-2":
                    return Tactics.The352;
                case "4-2-3-1":
                    return Tactics.The4231;
                case "4-3-2-1":
                    return Tactics.The4321;
                case "4-3-3":
                    return Tactics.The433;
                case "4-4-2":
                    return Tactics.The442;
                case "4-5-1":
                    return Tactics.The451;
                case "5-3-2":
                    return Tactics.The532;
                case "5-4-1":
                    return Tactics.The541;
            }
            throw new Exception("Cannot unmarshal type Tactics");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Tactics)untypedValue;
            switch (value)
            {
                case Tactics.The3421:
                    serializer.Serialize(writer, "3-4-2-1");
                    return;
                case Tactics.The343:
                    serializer.Serialize(writer, "3-4-3");
                    return;
                case Tactics.The352:
                    serializer.Serialize(writer, "3-5-2");
                    return;
                case Tactics.The4231:
                    serializer.Serialize(writer, "4-2-3-1");
                    return;
                case Tactics.The4321:
                    serializer.Serialize(writer, "4-3-2-1");
                    return;
                case Tactics.The433:
                    serializer.Serialize(writer, "4-3-3");
                    return;
                case Tactics.The442:
                    serializer.Serialize(writer, "4-4-2");
                    return;
                case Tactics.The451:
                    serializer.Serialize(writer, "4-5-1");
                    return;
                case Tactics.The532:
                    serializer.Serialize(writer, "5-3-2");
                    return;
                case Tactics.The541:
                    serializer.Serialize(writer, "5-4-1");
                    return;
            }
            throw new Exception("Cannot marshal type Tactics");
        }

        public static readonly TacticsConverter Singleton = new TacticsConverter();
    }

    internal class StageNameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StageName) || t == typeof(StageName?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Final":
                    return StageName.Final;
                case "First stage":
                    return StageName.FirstStage;
                case "First Stage":
                    return StageName.FirstStage;
                case "Play-off for third place":
                    return StageName.PlayOffForThirdPlace;
                case "Match for third place":
                    return StageName.PlayOffForThirdPlace;
                case "Quarter-finals":
                    return StageName.QuarterFinals;
                case "Quarter-final":
                    return StageName.QuarterFinals;
                case "Round of 16":
                    return StageName.RoundOf16;
                case "Semi-finals":
                    return StageName.SemiFinals;
                case "Semi-final":
                    return StageName.SemiFinals;
            }
            throw new Exception("Cannot unmarshal type StageName");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (StageName)untypedValue;
            switch (value)
            {
                case StageName.Final:
                    serializer.Serialize(writer, "Final");
                    return;
                case StageName.FirstStage:
                    serializer.Serialize(writer, "First stage");
                    return;
                case StageName.PlayOffForThirdPlace:
                    serializer.Serialize(writer, "Play-off for third place");
                    return;
                case StageName.QuarterFinals:
                    serializer.Serialize(writer, "Quarter-finals");
                    return;
                case StageName.RoundOf16:
                    serializer.Serialize(writer, "Round of 16");
                    return;
                case StageName.SemiFinals:
                    serializer.Serialize(writer, "Semi-finals");
                    return;
            }
            throw new Exception("Cannot marshal type StageName");
        }

        public static readonly StageNameConverter Singleton = new StageNameConverter();
    }

    internal class StatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Status) || t == typeof(Status?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "completed")
            {
                return Status.Completed;
            }
            throw new Exception("Cannot unmarshal type Status");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Status)untypedValue;
            if (value == Status.Completed)
            {
                serializer.Serialize(writer, "completed");
                return;
            }
            throw new Exception("Cannot marshal type Status");
        }

        public static readonly StatusConverter Singleton = new StatusConverter();
    }

    internal class TimeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Time) || t == typeof(Time?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "full-time")
            {
                return Time.FullTime;
            }
            throw new Exception("Cannot unmarshal type Time");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Time)untypedValue;
            if (value == Time.FullTime)
            {
                serializer.Serialize(writer, "full-time");
                return;
            }
            throw new Exception("Cannot marshal type Time");
        }

        public static readonly TimeConverter Singleton = new TimeConverter();
    }

    internal class DescriptionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Description) || t == typeof(Description?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Clear Night":
                    return Description.ClearNight;
                case "Cloudy Night":
                    return Description.PartlyCloudyNight;
                case "Cloudy":
                    return Description.Cloudy;
                case "Partly Cloudy":
                    return Description.PartlyCloudy;
                case "Partly Cloudy Night":
                    return Description.PartlyCloudyNight;
                case "Sunny":
                    return Description.Sunny;
            }
            throw new Exception("Cannot unmarshal type Description");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Description)untypedValue;
            switch (value)
            {
                case Description.ClearNight:
                    serializer.Serialize(writer, "Clear Night");
                    return;
                case Description.Cloudy:
                    serializer.Serialize(writer, "Cloudy");
                    return;
                case Description.PartlyCloudy:
                    serializer.Serialize(writer, "Partly Cloudy");
                    return;
                case Description.PartlyCloudyNight:
                    serializer.Serialize(writer, "Partly Cloudy Night");
                    return;
                case Description.Sunny:
                    serializer.Serialize(writer, "Sunny");
                    return;
            }
            throw new Exception("Cannot marshal type Description");
        }

        public static readonly DescriptionConverter Singleton = new DescriptionConverter();
    }
}
    

