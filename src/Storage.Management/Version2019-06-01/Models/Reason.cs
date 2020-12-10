// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.Storage.Version2019_06_01.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for Reason.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Reason
    {
        [EnumMember(Value = "AccountNameInvalid")]
        AccountNameInvalid,
        [EnumMember(Value = "AlreadyExists")]
        AlreadyExists
    }
    internal static class ReasonEnumExtension
    {
        internal static string ToSerializedValue(this Reason? value)
        {
            return value == null ? null : ((Reason)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this Reason value)
        {
            switch( value )
            {
                case Reason.AccountNameInvalid:
                    return "AccountNameInvalid";
                case Reason.AlreadyExists:
                    return "AlreadyExists";
            }
            return null;
        }

        internal static Reason? ParseReason(this string value)
        {
            switch( value )
            {
                case "AccountNameInvalid":
                    return Reason.AccountNameInvalid;
                case "AlreadyExists":
                    return Reason.AlreadyExists;
            }
            return null;
        }
    }
}