# GreenStack.Umbraco.TheStarterKit

A GitHub template repository for Umbraco 17 with The Starter Kit, preconfigured for [GreenStack](https://umbhost.net/sustainable-cloud-hosting/modern-umbraco-hosting) hosting.

## What's included

- Umbraco 17 on .NET 10 with [The Starter Kit](https://marketplace.umbraco.com/package/umbraco.thestarterkit)
- Forwarded headers middleware for Traefik proxy
- HTTPS runtime validator removed (SSL terminated by GreenStack)
- Data protection keys persisted to `/app/keys` in production
- Multi-stage Dockerfile exposing port 8080
- Docker launch profile (HTTP)
- Dependabot configured for weekly Umbraco updates

## Getting started

1. Click **"Use this template"** on GitHub to create a new repository
2. Clone your new repository
3. Follow the [Getting Started with Umbraco 17 on GreenStack](https://umbhost.net/gb/blog/2026/01/getting-started-with-umbraco-17-on-greenstack-with-github) guide

Alternatively, install via dotnet new:

```bash
dotnet new install UmbHost.GreenStack.Umbraco.TheStarterKit
dotnet new greenstack-umbraco-thestarterkit -n MyProject
```

## License

MIT
