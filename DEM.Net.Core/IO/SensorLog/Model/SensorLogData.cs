﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using SensorLog;
//
//    var sensorLogData = SensorLogData.FromJson(jsonString);

namespace DEM.Net.Core.IO.SensorLog
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using System.Numerics;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public partial class SensorLogData
    {
        #region Computed props

        #region AccelerometerAcceleration
        private Vector3 _accelerometerAcceleration = Vector3.Zero;

        public Vector3 AccelerometerAcceleration
        {
            get
            {
                if (_accelerometerAcceleration == Vector3.Zero)
                {
                    _accelerometerAcceleration = new Vector3(AccelerometerAccelerationX ?? 0
                        , AccelerometerAccelerationY ?? 0
                        , AccelerometerAccelerationZ ?? 0);
                }
                return _accelerometerAcceleration;
            }
        }
        #endregion

        #region GyroRotation
        private Vector3 _gyroRotation = Vector3.Zero;

        public Vector3 GyroRotation
        {
            get
            {
                if (_gyroRotation == Vector3.Zero)
                {
                    _gyroRotation = new Vector3(GyroRotationX ?? 0
                        , GyroRotationY ?? 0
                        , GyroRotationZ ?? 0);
                }
                return _gyroRotation;
            }
        }
        #endregion

        #region LocationHeading
        private Vector3 _locationHeading = Vector3.Zero;

        public Vector3 LocationHeading
        {
            get
            {
                if (_locationHeading == Vector3.Zero)
                {
                    _locationHeading = new Vector3(LocationHeadingX ?? 0
                        , LocationHeadingY ?? 0
                        , LocationHeadingZ ?? 0);
                }
                return _locationHeading;
            }
        }
        #endregion

        #region Magnetometer
        private Vector3 _magnetometer = Vector3.Zero;

        public Vector3 Magnetometer
        {
            get
            {
                if (_magnetometer == Vector3.Zero)
                {
                    _magnetometer = new Vector3(MagnetometerX ?? 0
                        , MagnetometerY ?? 0
                        , MagnetometerZ ?? 0);
                }
                return _magnetometer;
            }
        }
        #endregion

        #region MotionGravity
        private Vector3 _motionGravity = Vector3.One;

        public Vector3 MotionGravity
        {
            get
            {
                if (_motionGravity == Vector3.Zero)
                {
                    _motionGravity = new Vector3(MotionGravityX ?? 1
                        , MotionGravityY ?? 1
                        , MotionGravityZ ?? 1);
                }
                return _motionGravity;
            }
        }
        #endregion

        #region MotionMagneticField
        private Vector3 _motionMagneticField = Vector3.Zero;

        public Vector3 MotionMagneticField
        {
            get
            {
                if (_motionMagneticField == Vector3.Zero)
                {
                    _motionMagneticField = new Vector3(MotionMagneticFieldX ?? 0
                        , MotionMagneticFieldY ?? 0
                        , MotionMagneticFieldZ ?? 0);
                }
                return _motionMagneticField;
            }
        }
        #endregion

        #region MotionQuaternion
        private Quaternion _motionQuaternion = Quaternion.Identity;

        public Quaternion MotionQuaternion
        {
            get
            {
                if (_motionQuaternion == Quaternion.Identity)
                {
                    _motionQuaternion = new Quaternion(MotionQuaternionX ?? 0
                        , MotionQuaternionY ?? 0
                        , MotionQuaternionZ ?? 0
                        , MotionQuaternionW ?? 1);
                }
                return _motionQuaternion;
            }
        }
        #endregion

        #region AccelerometerAcceleration
        private Vector3 _motionRotationRate = Vector3.Zero;

        public Vector3 MotionRotationRate
        {
            get
            {
                if (_motionRotationRate == Vector3.Zero)
                {
                    _motionRotationRate = new Vector3(MotionRotationRateX ?? 0
                        , MotionRotationRateY ?? 0
                        , MotionRotationRateZ ?? 0);
                }
                return _motionRotationRate;
            }
        }
        #endregion

        #region MotionUserAcceleration
        private Vector3 _motionUserAcceleration = Vector3.Zero;

        public Vector3 MotionUserAcceleration
        {
            get
            {
                if (_motionUserAcceleration == Vector3.Zero)
                {
                    _motionUserAcceleration = new Vector3(MotionUserAccelerationX ?? 0
                        , MotionUserAccelerationY ?? 0
                        , MotionUserAccelerationZ ?? 0);
                }
                return _motionUserAcceleration;
            }
        }
        #endregion

        public bool HasCoordinates => LocationLatitude.HasValue && LocationLongitude.HasValue;

        #endregion


        #region Json data properties

        [JsonProperty("accelerometerAccelerationX")]
        internal float? AccelerometerAccelerationX { get; set; }

        [JsonProperty("accelerometerAccelerationY")]
        internal float? AccelerometerAccelerationY { get; set; }

        [JsonProperty("accelerometerAccelerationZ")]
        internal float? AccelerometerAccelerationZ { get; set; }

        [JsonProperty("accelerometerTimestamp_sinceReboot")]
        public float? AccelerometerTimestampSinceReboot { get; set; }

        [JsonProperty("activity")]
        public string Activity { get; set; }

        [JsonProperty("activityActivityConfidence")]
        public int ActivityActivityConfidence { get; set; }

        [JsonProperty("activityActivityStartDate")]
        public DateTime ActivityActivityStartDate { get; set; }

        [JsonProperty("activityTimestamp_sinceReboot")]
        public float? ActivityTimestampSinceReboot { get; set; }

        [JsonProperty("altimeterPressure")]
        public float? AltimeterPressure { get; set; }

        [JsonProperty("altimeterRelativeAltitude")]
        public float? AltimeterRelativeAltitude { get; set; }

        [JsonProperty("altimeterReset")]
        public int AltimeterReset { get; set; }

        [JsonProperty("altimeterTimestamp_sinceReboot")]
        public float? AltimeterTimestampSinceReboot { get; set; }

        [JsonProperty("avAudioRecorderAveragePower")]
        public float? AvAudioRecorderAveragePower { get; set; }

        [JsonProperty("avAudioRecorderPeakPower")]
        public float? AvAudioRecorderPeakPower { get; set; }

        [JsonProperty("batteryLevel")]
        public float? BatteryLevel { get; set; }

        [JsonProperty("batteryState")]
        public int BatteryState { get; set; }

        [JsonProperty("deviceID")]
        public string DeviceId { get; set; }

        [JsonProperty("deviceOrientation")]
        public int DeviceOrientation { get; set; }

        [JsonProperty("gyroRotationX")]
        internal float? GyroRotationX { get; set; }

        [JsonProperty("gyroRotationY")]
        internal float? GyroRotationY { get; set; }

        [JsonProperty("gyroRotationZ")]
        internal float? GyroRotationZ { get; set; }

        [JsonProperty("gyroTimestamp_sinceReboot")]
        public float? GyroTimestampSinceReboot { get; set; }

        [JsonProperty("identifierForVendor")]
        public string IdentifierForVendor { get; set; }

        [JsonProperty("IP_en0")]
        public string IpEn0 { get; set; }

        [JsonProperty("IP_pdp_ip0")]
        public string IpPdpIp0 { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("locationAltitude")]
        public float? LocationAltitude { get; set; }

        [JsonProperty("locationCourse")]
        public float? LocationCourse { get; set; }

        [JsonProperty("locationFloor")]
        public float? LocationFloor { get; set; }

        [JsonProperty("locationHeadingAccuracy")]
        public float? LocationHeadingAccuracy { get; set; }

        [JsonProperty("locationHeadingTimestamp_since1970")]
        public float? LocationHeadingTimestampSince1970 { get; set; }

        [JsonProperty("locationHeadingX")]
        internal float? LocationHeadingX { get; set; }

        [JsonProperty("locationHeadingY")]
        internal float? LocationHeadingY { get; set; }

        [JsonProperty("locationHeadingZ")]
        internal float? LocationHeadingZ { get; set; }

        [JsonProperty("locationHorizontalAccuracy")]
        public float? LocationHorizontalAccuracy { get; set; }

        [JsonProperty("locationLatitude")]
        public float? LocationLatitude { get; set; }

        [JsonProperty("locationLongitude")]
        public float? LocationLongitude { get; set; }

        [JsonProperty("locationMagneticHeading")]
        public float? LocationMagneticHeading { get; set; }

        [JsonProperty("locationSpeed")]
        public float? LocationSpeed { get; set; }

        [JsonProperty("locationTimestamp_since1970")]
        public float? LocationTimestampSince1970 { get; set; }

        [JsonProperty("locationTrueHeading")]
        public float? LocationTrueHeading { get; set; }

        [JsonProperty("locationVerticalAccuracy")]
        public float? LocationVerticalAccuracy { get; set; }

        [JsonProperty("loggingTime")]
        public DateTime LoggingTime { get; set; }

        [JsonProperty("logSampleNr")]
        public int LogSampleNr { get; set; }

        [JsonProperty("magnetometerTimestamp_sinceReboot")]
        public float? MagnetometerTimestampSinceReboot { get; set; }

        [JsonProperty("magnetometerX")]
        internal float? MagnetometerX { get; set; }

        [JsonProperty("magnetometerY")]
        internal float? MagnetometerY { get; set; }

        [JsonProperty("magnetometerZ")]
        internal float? MagnetometerZ { get; set; }

        [JsonProperty("motionAttitudeReferenceFrame")]
        public string MotionAttitudeReferenceFrame { get; set; }

        [JsonProperty("motionGravityX")]
        internal float? MotionGravityX { get; set; }

        [JsonProperty("motionGravityY")]
        internal float? MotionGravityY { get; set; }

        [JsonProperty("motionGravityZ")]
        internal float? MotionGravityZ { get; set; }

        [JsonProperty("motionMagneticFieldCalibrationAccuracy")]
        public float? MotionMagneticFieldCalibrationAccuracy { get; set; }

        [JsonProperty("motionMagneticFieldX")]
        internal float? MotionMagneticFieldX { get; set; }

        [JsonProperty("motionMagneticFieldY")]
        internal float? MotionMagneticFieldY { get; set; }

        [JsonProperty("motionMagneticFieldZ")]
        internal float? MotionMagneticFieldZ { get; set; }

        [JsonProperty("motionPitch")]
        public float? MotionPitch { get; set; }

        [JsonProperty("motionQuaternionW")]
        internal float? MotionQuaternionW { get; set; }

        [JsonProperty("motionQuaternionX")]
        internal float? MotionQuaternionX { get; set; }

        [JsonProperty("motionQuaternionY")]
        internal float? MotionQuaternionY { get; set; }

        [JsonProperty("motionQuaternionZ")]
        internal float? MotionQuaternionZ { get; set; }

        [JsonProperty("motionRoll")]
        public float? MotionRoll { get; set; }

        [JsonProperty("motionRotationRateX")]
        internal float? MotionRotationRateX { get; set; }

        [JsonProperty("motionRotationRateY")]
        internal float? MotionRotationRateY { get; set; }

        [JsonProperty("motionRotationRateZ")]
        internal float? MotionRotationRateZ { get; set; }

        [JsonProperty("motionTimestamp_sinceReboot")]
        public float? MotionTimestampSinceReboot { get; set; }


        [JsonProperty("motionUserAccelerationX")]
        internal float? MotionUserAccelerationX { get; set; }

        [JsonProperty("motionUserAccelerationY")]
        internal float? MotionUserAccelerationY { get; set; }

        [JsonProperty("motionUserAccelerationZ")]
        internal float? MotionUserAccelerationZ { get; set; }

        [JsonProperty("motionYaw")]
        public float? MotionYaw { get; set; }

        #endregion
    }

    public partial class SensorLogData
    {
        internal static List<SensorLogData> FromJson(string json) => JsonConvert.DeserializeObject<List<SensorLogData>>(json, IO.SensorLog.Converter.Settings);

    }

    internal static class Serialize
    {
        internal static string ToJson(this SensorLogData self) => JsonConvert.SerializeObject(self, IO.SensorLog.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
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
    }
}
