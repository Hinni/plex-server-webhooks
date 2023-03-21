using Plex.Server.Webhooks.Events;
using Plex.Server.Webhooks.Service;
using System;
using System.IO;
using Xunit;

namespace Plex.Server.Webhooks.Tests
{
    public class ParseDemoEventTest
    {
        [Fact]
        public void ParseEvent()
        {
            // Arrange
            var path = Path.Combine(Environment.CurrentDirectory, "Payloads", "MediaPlay.json");
            var payload = File.ReadAllText(path);

            // Act
            var plexEvent = PlexWebhookParser.ParseEvent(payload);

            // Assert
            Assert.IsType<PlexWebhookEvent>(plexEvent);
        }
    }
}