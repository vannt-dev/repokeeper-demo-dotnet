# repokeeper-demo-dotnet

[![ci](https://github.com/vannt-dev/repokeeper-demo-dotnet/actions/workflows/ci.yml/badge.svg)](https://github.com/vannt-dev/repokeeper-demo-dotnet/actions/workflows/ci.yml) [![release](https://img.shields.io/github/v/release/vannt-dev/repokeeper-demo-dotnet)](https://github.com/vannt-dev/repokeeper-demo-dotnet/releases) [![repokeeper standard](https://img.shields.io/badge/dynamic/yaml?url=https%3A%2F%2Fraw.githubusercontent.com%2Fvannt-dev%2Frepokeeper-demo-dotnet%2Fmain%2F.repokeeper.yml&query=%24.standard&label=repokeeper%20standard)](https://github.com/vannt-dev/repokeeper)

A minimal .NET solution used to pilot [repokeeper](https://github.com/vannt-dev/repokeeper) on the dotnet stack.

## What repokeeper did here

The CI, the releases and the dependency updates of this repository are set up by
[repokeeper](https://github.com/vannt-dev/repokeeper), and each step went through a pull request:

- [#1](https://github.com/vannt-dev/repokeeper-demo-dotnet/pull/1): `repokeeper init` applied standard 1.2.1: CI, releases, dependency updates, hooks and the community files
- [#2](https://github.com/vannt-dev/repokeeper-demo-dotnet/pull/2): a Dependabot update (Bump xunit.runner.visualstudio from 3.1.5 to 4.0.0), tested by the generated CI
- [#3](https://github.com/vannt-dev/repokeeper-demo-dotnet/pull/3): the repository's GitHub settings written into `.repokeeper.yml` for `repokeeper github apply`
- [#4](https://github.com/vannt-dev/repokeeper-demo-dotnet/pull/4): `repokeeper update` moved the repository to standard 1.3.1
- [#5](https://github.com/vannt-dev/repokeeper-demo-dotnet/pull/5): the release pull request release-please opened; merging it tagged `v0.2.0` and published the release with its changelog
- [#6](https://github.com/vannt-dev/repokeeper-demo-dotnet/pull/6): `repokeeper update` moved the repository to standard 1.4.1

The settings are in [`.repokeeper.yml`](.repokeeper.yml); [all pull requests](https://github.com/vannt-dev/repokeeper-demo-dotnet/pulls?q=is%3Apr) and
[releases](https://github.com/vannt-dev/repokeeper-demo-dotnet/releases) show the rest.
