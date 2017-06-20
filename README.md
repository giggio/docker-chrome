# Chrome Headless for Docker

This is a Docker image that allows you to run Chrome Headless in a Docker Container.

## Getting it

You can simply pull it from the Docker Hub, where an automated build is creating
the image: [hub.docker.com/r/giggio/chrome/](https://hub.docker.com/r/giggio/chrome/).

Simply run, from the command line:

```powershell
docker pull giggio/chrome
```

## Running

You have to run it with the `SYS_ADMIN` capability set, like so:

```powershell
docker run -ti -p 9222:9222 --cap-add=SYS_ADMIN giggio/chrome
```

After that, you can connect to it remotely. See the samples, we currently
have [Node.js](https://github.com/giggio/docker-chrome/tree/master/samples/node)
(Windows and Linux)
and [C#](https://github.com/giggio/docker-chrome/tree/master/samples/csharp)
(Windows Only - because Selenium does not run on Linux with .NET).

## Maintainers/Core team

* [Giovanni Bassi](http://www.lambda3.com.br/L3/giovannibassi/), aka Giggio, [Lambda3](http://www.lambda3.com.br), [@giovannibassi](https://twitter.com/giovannibassi)

Contributors can be found at the [contributors](https://github.com/giggio/docker-chrome/graphs/contributors) page on Github.

## Contact

Use Twitter.

## License

This software is open source, licensed under the Apache License, Version 2.0.
See [LICENSE.txt](https://github.com/giggio/docker-chrome/blob/master/LICENSE.txt) for details.

Check out the terms of the license before you contribute, fork, copy or do anything
with the code. If you decide to contribute you agree to grant copyright of all your contribution to this project, and agree to
mention clearly if do not agree to these terms. Your work will be licensed with the project at Apache V2, along the rest of the code.

This is a community project, free and open source.
Everyone is invited to contribute, fork, share and use the code.
No money shall be charged by this software, nor it will be. Ever.