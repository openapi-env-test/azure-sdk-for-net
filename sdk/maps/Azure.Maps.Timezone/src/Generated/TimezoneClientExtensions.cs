// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Timezone
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for TimezoneClient.
    /// </summary>
    public static partial class TimezoneClientExtensions
    {
            /// <summary>
            /// __Time Zone by Id__
            ///
            /// **Applies to**: S0 and S1 pricing tiers.
            ///
            ///
            /// This API returns current, historical, and future time zone information for
            /// the specified IANA time zone ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='query'>
            /// The IANA time zone ID.
            /// </param>
            /// <param name='acceptLanguage'>
            /// Specifies the language code in which the timezone names should be returned.
            /// If no language code is provided, the response will be in "EN". Please refer
            /// to [Supported
            /// Languages](https://docs.microsoft.com/en-us/azure/azure-maps/supported-languages)
            /// for details.
            /// </param>
            /// <param name='options'>
            /// Alternatively, use alias "o". Options available for types of information
            /// returned in the result. Possible values include: 'none', 'zoneInfo',
            /// 'transitions', 'all'
            /// </param>
            /// <param name='timeStamp'>
            /// Alternatively, use alias "stamp", or "s". Reference time, if omitted, the
            /// API will use the machine time serving the request.
            /// </param>
            /// <param name='transitionsFrom'>
            /// Alternatively, use alias "tf". The start date from which daylight savings
            /// time (DST) transitions are requested, only applies when "options" = all or
            /// "options" = transitions.
            /// </param>
            /// <param name='transitionsYears'>
            /// Alternatively, use alias "ty". The number of years from "transitionsFrom"
            /// for which DST transitions are requested, only applies when "options" = all
            /// or "options" = transitions.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TimezoneByIdResult> GetTimezoneByIDAsync(this ITimezoneClient operations, string query, string acceptLanguage = default(string), string options = default(string), System.DateTime? timeStamp = default(System.DateTime?), System.DateTime? transitionsFrom = default(System.DateTime?), int? transitionsYears = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTimezoneByIDWithHttpMessagesAsync(query, acceptLanguage, options, timeStamp, transitionsFrom, transitionsYears, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// __Time Zone by Coordinates__
            ///
            /// **Applies to**: S0 and S1 pricing tiers.
            ///
            ///
            /// This API returns current, historical, and future time zone information for
            /// a specified latitude-longitude pair. In addition, the API provides sunset
            /// and sunrise times for a given location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='query'>
            /// Coordinates of the point for which time zone information is requested. The
            /// applicable query is specified as a comma separated string composed by
            /// latitude followed by longitude e.g. "47.641268,-122.125679".
            /// </param>
            /// <param name='acceptLanguage'>
            /// Specifies the language code in which the timezone names should be returned.
            /// If no language code is provided, the response will be in "EN". Please refer
            /// to [Supported
            /// Languages](https://docs.microsoft.com/en-us/azure/azure-maps/supported-languages)
            /// for details.
            /// </param>
            /// <param name='options'>
            /// Alternatively, use alias "o". Options available for types of information
            /// returned in the result. Possible values include: 'none', 'zoneInfo',
            /// 'transitions', 'all'
            /// </param>
            /// <param name='timeStamp'>
            /// Alternatively, use alias "stamp", or "s". Reference time, if omitted, the
            /// API will use the machine time serving the request.
            /// </param>
            /// <param name='transitionsFrom'>
            /// Alternatively, use alias "tf". The start date from which daylight savings
            /// time (DST) transitions are requested, only applies when "options" = all or
            /// "options" = transitions.
            /// </param>
            /// <param name='transitionsYears'>
            /// Alternatively, use alias "ty". The number of years from "transitionsFrom"
            /// for which DST transitions are requested, only applies when "options" = all
            /// or "options" = transitions.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TimezoneByCoordinatesResult> GetTimezoneByCoordinatesAsync(this ITimezoneClient operations, string query, string acceptLanguage = default(string), string options = default(string), System.DateTime? timeStamp = default(System.DateTime?), System.DateTime? transitionsFrom = default(System.DateTime?), int? transitionsYears = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTimezoneByCoordinatesWithHttpMessagesAsync(query, acceptLanguage, options, timeStamp, transitionsFrom, transitionsYears, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// __Enumerate Windows Time Zones__
            ///
            ///
            /// **Applies to**: S0 and S1 pricing tiers.
            ///
            ///
            /// This API returns a full list of Windows Time Zone IDs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<TimezoneEnumWindow>> GetTimezoneEnumWindowsAsync(this ITimezoneClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTimezoneEnumWindowsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// __Enumerate IANA Time Zones__
            ///
            ///
            /// **Applies to**: S0 and S1 pricing tiers.
            ///
            ///
            /// This API returns a full list of IANA time zone IDs. Updates to the IANA
            /// service will be reflected in the system within one day.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<IanaId>> GetTimezoneEnumIANAAsync(this ITimezoneClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTimezoneEnumIANAWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// __Time Zone IANA Version__
            ///
            ///
            /// **Applies to**: S0 and S1 pricing tiers.
            ///
            ///
            /// This API returns the current IANA version number.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TimezoneIanaVersionResult> GetTimezoneIANAVersionAsync(this ITimezoneClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTimezoneIANAVersionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// __Windows to IANA Time Zone__
            ///
            ///
            /// **Applies to**: S0 and S1 pricing tiers.
            ///
            ///
            /// This API returns a corresponding IANA ID, given a valid Windows Time Zone
            /// ID. Multiple IANA IDs may be returned for a single Windows ID. It is
            /// possible to narrow these results by adding an optional territory parameter.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='query'>
            /// The Windows time zone ID.
            /// </param>
            /// <param name='territory'>
            /// Windows Time Zone territory code.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<IanaId>> GetTimezoneWindowsToIANAAsync(this ITimezoneClient operations, string query, string territory = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTimezoneWindowsToIANAWithHttpMessagesAsync(query, territory, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
