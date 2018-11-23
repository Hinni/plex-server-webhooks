# Plex Server Webhooks

[![Build Status](https://travis-ci.org/Hinni/plex-server-webhooks.svg?branch=master)](https://travis-ci.org/Hinni/plex-server-webhooks)
[![GitHub release](https://img.shields.io/github/release/Hinni/plex-server-webhooks.svg)](https://github.com/Hinni/plex-server-webhooks/releases)
[![NuGet](https://img.shields.io/nuget/v/Plex.Server.Webhooks.svg)](https://www.nuget.org/packages/Plex.Server.Webhooks/)

A library to parse event webhooks from Plex server.

## Download via NuGet

Install Plex.Server.Webhooks via NuGet package manager (nuget.org)

    Install-Package Plex.Server.Webhooks

## Usage

Declare `WebhookParser` and call `ParseEvent`. This takes in string as JSON received from the HTTP POST callback.

```csharp
var parser = new WebhookParser();
var events = parser.ParseEvent(json);
```

## Plex Webhook Documentation

Check out the documentation on Plex:
https://support.plex.tv/hc/en-us/articles/115002267687-Webhooks

## Thanks

* [mirajavora](https://github.com/mirajavora) for the project structure and converters used in [sendgrid-webhooks](https://github.com/mirajavora/sendgrid-webhooks)