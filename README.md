## Installing

```
git clone https://github.com/json-api-dotnet/Templates.git
dotnet new -i ./Model
dotnet new JADNC:Model
```

## Usage
`dotnet new jadnc:model -m MyModelName`

`dotnet new jadnc:controller -r MyResourceName`

`dotnet new jadnc:repository -r MyResourceName`

`dotnet new jadnc:getallservice -r MyResourceName`

All services are available to generate and follow the same convention.

The id type can be specified with the `-id` (`int` default) argument, such as:

`dotnet new jadnc:createservice -r MyResourceName -id Guid`