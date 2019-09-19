# Configurator_RESTAPI_CALL

## Dependencies
- NuGet Packages
  - Newtonsoft.Json v12.0.2
  - RestSharp v106.6.10
  - RestSharp.Newtonsoft.Json v1.5.1
- Microsoft.NETCore.App (2.1)

## Building and importing Library 
 - You can get library by building `Configurator_RESTAPI_CALL`
 - Once the building is done, you can see the library `Configurator_RESTAPI_CALL.dll` in `Configurator_RESTAPI_CALL\bin\Release\netcoreapp2.1` directory.
 - You can import this library from adding `Reference`.

## Usage of wrapper

- Initializing Library
    
    ```c#
    private Configurator configurator = new Configurator();
	// If it is possible to authenticate, for the moment we should skip this.
    configurator.Authenticate("username", "password");
    ```
- Make a Request
    
    ```
		ConfiguratorParameter param = new ConfiguratorParameter()
            {
                REGN = 22,
                AREA = 1,
                SECTION = 77,
                PART = 67123,
                CNTRY = "USA",
                CUSTMOER = "7800000012"
            };

        var response = configurator._globalStorage.Get(param);
	```