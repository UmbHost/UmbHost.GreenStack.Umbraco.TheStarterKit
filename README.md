# UmbHost.GreenStack.Umbraco.StarterKit

A dotnet new template for Umbraco 17 with The Starter Kit preconfigured for [GreenStack](https://umbhost.net/sustainable-cloud-hosting/modern-umbraco-hosting) hosting.

## Installation

```bash
dotnet new install UmbHost.GreenStack.Umbraco.StarterKit
```

## Usage

```bash
dotnet new greenstack-umbraco-starterkit -n MyProject
```

This creates a new Umbraco 17 project with [The Starter Kit](https://marketplace.umbraco.com/package/umbraco.thestarterkit) and:

- Forwarded headers middleware for Traefik proxy
- HTTPS runtime validator removed (SSL terminated by GreenStack)
- Data protection keys persisted to `/app/keys` in production
- Multi-stage Dockerfile exposing port 8080
- Docker launch profile (HTTP)

## Getting started

Follow the [Getting Started with Umbraco 17 on GreenStack](https://umbhost.net/gb/blog/2026/01/getting-started-with-umbraco-17-on-greenstack-with-github) guide.

## Source

The template content comes from [GreenStack.Umbraco.StarterKit](https://github.com/UmbHost/GreenStack.Umbraco.StarterKit), which is also available as a GitHub template repository.

## GreenStack

- [Purchase GreenStack hosting](https://umbhost.net/sustainable-cloud-hosting/modern-umbraco-hosting)
- [GreenStack documentation](https://my.umbhost.net/knowledgebase/17/GreenStack)
- [GreenStack CI/CD samples](https://github.com/UmbHost/GreenStack.CICD.Samples)

## License

MIT
