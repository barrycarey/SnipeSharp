# SnipeSharp

A .NET wrapper for the Snipe IT API written (poorly) in C#.

## Before You Dive In

The goal of this project is to give easy access to all endpoints of the Snipe IT API via C#.  With that said, this build is currently a rough demo. Most of the endpoints work as expected but plan on things breaking or not working 100%.

This project was built to support my own needs.  As such features are being worked on in the order I personally need them.  However, if you want a feature or find a bug please open an issue. 

Final note, this is my first C# project of this scale.  I'm not up on all the best practices.  If you see something I've done that should be done differently, I encourage you to let me know. 

### Prerequisites

```
A Working Install of Snipe IT V4+
```

## Installation

```
nuget install SnipeSharp
```

## Usage

```csharp
SnipeItApi snipe = new SnipeItApi();
snipe.ApiSettings.ApiToken = "XXXXXXXX"
snipe.ApiSettings.BaseUrl = new Uri("http://xxxxx.com/api/v1")
```

Each endpoint has it's own manager assigned to the SnipeItApi object.  Example, SnipeItApi.AssetManager 

Each endpoint has a common set of actions.  With the exception Assets, Status Labels and Users which use extended managers to deal with extra API functions associated with them. 

##### Common Actions
Return all objects at this end point
```csharp
snipe.AssetManager.GetAll()
```

Find all objects matching certain filtering criteria 
```csharp
snipe.AssetManager.FindAll(ISearchFilter filter)
```

Find first object matching search criteria
```csharp
snipe.AssetManager.FindOne(ISearchFilter filter)
```

Get object with ID
```csharp
snipe.AssetManager.Get(int ID)
```

Search for object with given name
```csharp
snipe.AssetManager.Get(string name)
```

Create an object
```csharp
snipe.AssetManager.Create(ICommonEndpointObject item)
```

Update an object
```csharp
snipe.AssetManager.Update(ICommonEndpointObject item)
```

Delete an object
```csharp
snipe.AssetManager.Delete(int id)
```


## Examples

Create a new asset
```csharp
Asset asset = new Asset() {
    Name = "Loaner1",
    AssetTag = "12345678",
    Model = snipe.ModelManager.Get("Lenovo"),
    Status = snipe.StatusLabelManager.Get("Ready to Deploy"),
    Location = snipe.LocationManager.Get("Maine")
};

snipe.AssetManager.Create(asset);
```

Update an Asset
```csharp
Asset asset = snipe.AssetManager.Get("Loaner1");
asset.Serial = "1i37dpc3k";
snipe.AssetManager.Update(asset);
```

Get all assets from made by a certain manufacturer
```csharp
AssetSearchFilter filter = new AssetSearchFilter() {
    Manufacturer = snipe.ManufacturerManager.Get("Lenovo")
};

var result = snipe.AssetManager.FindAll(filter);
```
## Contributing

Please read [CONTRIBUTING.md](https://gist.github.com/PurpleBooth/b24679402957c63ec426) for details on our code of conduct, and the process for submitting pull requests to us.

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](./SnipeSharp/tags).

## Authors

* **Matthew 'Barry' Carey** - *Initial work* - [BarryCarey](https://github.com/barrycarey)

See also the list of [contributors](./SnipeSharp/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* [Snipe](https://github.com/snipe) - https://snipeitapp.com
