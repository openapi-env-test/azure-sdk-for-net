// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.AI.AnomalyDetector.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.AI.AnomalyDetector
{
    internal partial class AnomalyDetectorRestClient
    {
        private string endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of AnomalyDetectorRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> Supported Cognitive Services endpoints (protocol and hostname, for example: https://westus2.api.cognitive.microsoft.com). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public AnomalyDetectorRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }

            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateBreakingChangeDetectEntireSeriesRequest(DetectRequest body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendRaw("/anomalydetector/v1.0", false);
            uri.AppendPath("/timeseries/entire/detect", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            request.Headers.Add("Accept", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(body);
            request.Content = content;
            return message;
        }

        /// <summary> This operation generates a model using an entire series, each point is detected with the same model. With this method, points before and after a certain point are used to determine whether it is an anomaly. The entire detection can give user an overall status of the time series. </summary>
        /// <param name="body"> Time series points and period if needed. Advanced model parameters can also be set in the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public async Task<Response<EntireDetectResponse>> BreakingChangeDetectEntireSeriesAsync(DetectRequest body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateBreakingChangeDetectEntireSeriesRequest(body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EntireDetectResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = EntireDetectResponse.DeserializeEntireDetectResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> This operation generates a model using an entire series, each point is detected with the same model. With this method, points before and after a certain point are used to determine whether it is an anomaly. The entire detection can give user an overall status of the time series. </summary>
        /// <param name="body"> Time series points and period if needed. Advanced model parameters can also be set in the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public Response<EntireDetectResponse> BreakingChangeDetectEntireSeries(DetectRequest body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateBreakingChangeDetectEntireSeriesRequest(body);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EntireDetectResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = EntireDetectResponse.DeserializeEntireDetectResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDetectLastPointRequest(DetectRequest body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendRaw("/anomalydetector/v1.0", false);
            uri.AppendPath("/timeseries/last/detect", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            request.Headers.Add("Accept", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(body);
            request.Content = content;
            return message;
        }

        /// <summary> This operation generates a model using points before the latest one. With this method, only historical points are used to determine whether the target point is an anomaly. The latest point detecting operation matches the scenario of real-time monitoring of business metrics. </summary>
        /// <param name="body"> Time series points and period if needed. Advanced model parameters can also be set in the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public async Task<Response<LastDetectResponse>> DetectLastPointAsync(DetectRequest body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateDetectLastPointRequest(body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LastDetectResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LastDetectResponse.DeserializeLastDetectResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> This operation generates a model using points before the latest one. With this method, only historical points are used to determine whether the target point is an anomaly. The latest point detecting operation matches the scenario of real-time monitoring of business metrics. </summary>
        /// <param name="body"> Time series points and period if needed. Advanced model parameters can also be set in the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public Response<LastDetectResponse> DetectLastPoint(DetectRequest body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateDetectLastPointRequest(body);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LastDetectResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LastDetectResponse.DeserializeLastDetectResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDetectChangePointRequest(ChangePointDetectRequest body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendRaw("/anomalydetector/v1.0", false);
            uri.AppendPath("/timeseries/changepoint/detect", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            request.Headers.Add("Accept", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(body);
            request.Content = content;
            return message;
        }

        /// <summary> Evaluate change point score of every series point. </summary>
        /// <param name="body"> Time series points and granularity is needed. Advanced model parameters can also be set in the request if needed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public async Task<Response<ChangePointDetectResponse>> DetectChangePointAsync(ChangePointDetectRequest body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateDetectChangePointRequest(body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ChangePointDetectResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ChangePointDetectResponse.DeserializeChangePointDetectResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Evaluate change point score of every series point. </summary>
        /// <param name="body"> Time series points and granularity is needed. Advanced model parameters can also be set in the request if needed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public Response<ChangePointDetectResponse> DetectChangePoint(ChangePointDetectRequest body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateDetectChangePointRequest(body);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ChangePointDetectResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ChangePointDetectResponse.DeserializeChangePointDetectResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
