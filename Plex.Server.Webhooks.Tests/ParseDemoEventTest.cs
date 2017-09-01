using System.IO;
using Plex.Server.Webhooks.Service;
using Plex.Server.Webhooks.Events;
using Xunit;
using System;

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
            var parser = new WebhookParser();

            // Act
            var plexEvent = parser.ParseEvent(payload);

            // Assert
            Assert.IsType<MediaPlay>(plexEvent);
        }
    }
}