using System.IO;
using Plex.Server.Webhooks.Service;
using Plex.Server.Webhooks.Events;
using Xunit;

namespace Plex.Server.Webhooks.Tests
{
    public class ParseDemoEventTest
    {
        [Fact]
        public void ParseEvent()
        {
            // Arrange
            var payload = File.ReadAllText(@".\Payloads\MediaPlay.json");
            var parser = new WebhookParser();

            // Act
            var plexEvent = parser.ParseEvent(payload);

            // Assert
            Assert.IsAssignableFrom<WebhookEventBase>(plexEvent);
        }
    }
}