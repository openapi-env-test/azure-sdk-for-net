// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Message Button Content. </summary>
    public partial class AcsMessageButtonContent
    {
        /// <summary> Initializes a new instance of <see cref="AcsMessageButtonContent"/>. </summary>
        internal AcsMessageButtonContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AcsMessageButtonContent"/>. </summary>
        /// <param name="text"> The Text of the button. </param>
        /// <param name="payload"> The Payload of the button which was clicked by the user, setup by the business. </param>
        internal AcsMessageButtonContent(string text, string payload)
        {
            Text = text;
            Payload = payload;
        }

        /// <summary> The Text of the button. </summary>
        public string Text { get; }
        /// <summary> The Payload of the button which was clicked by the user, setup by the business. </summary>
        public string Payload { get; }
    }
}
