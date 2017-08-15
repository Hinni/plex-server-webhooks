using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Plex.Server.Webhooks.Service;
using Plex.Server.Webhooks.Events;

namespace Plex.Server.Webhooks.Tests
{
    [TestClass]
    public class ParseDemoEventTest
    {
        [TestMethod]
        public void ParseEvent()
        {
            // Arrange
            var payload = File.ReadAllText(@".\Payloads\MediaPlay.json");
            var parser = new WebhookParser();

            // Act
            var plexEvent = parser.ParseEvent(payload);

            // Assert
            Assert.IsNotNull(plexEvent);
            Assert.IsInstanceOfType(plexEvent, typeof(WebhookEventBase));
        }
    }
}