

### Create app

```
dotnet new web -o PizzaStore -f net6.0
cd PizzaStore
dotnet add package Swashbuckle.AspNetCore --version 6.2.3
```


dotnet run

### Hot Reload

Add this to `launchSettings.json` for the application profile.

```
"hotReloadProfile": "aspnetcore"
```

Run using:

```
dotnet watch
```


### ReadyToRun

https://github.com/dotnet/dotnet-docker/blob/main/samples/aspnetapp/README.md

```
dotnet publish -c Release -r osx-x64 -p:PublishReadyToRun=true -p:PublishTrimmed=true --self-contained
```

Note: You can ignore the `Trim analysis warning`s.

Run:

```
bin/Release/net6.0/osx-x64/publish/PizzaStore
```


Cross compile from Mac to Linux is supported:
```
dotnet publish -c Release -r linux-x64 -p:PublishReadyToRun=true -p:PublishTrimmed=true --self-contained
```