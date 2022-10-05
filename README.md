# Durable Functions

[![Build status](https://ci.appveyor.com/api/projects/status/rsoa2rrjxmd9h8i1?svg=true)](https://ci.appveyor.com/project/appsvc/azure-functions-durable-extension)
[![Build Status](https://durabletaskframework.visualstudio.com/Durable%20Task%20Framework%20CI/_apis/build/status/Azure.azure-functions-durable-extension?branchName=dev)](https://durabletaskframework.visualstudio.com/Durable%20Task%20Framework%20CI/_build/latest?definitionId=15&branchName=dev)

Durable Functions is an extension that helps developers build reliable, stateful apps on the [Azure Functions](https://functions.azure.com) platform.

This extension adds three new types functions to the Azure Functions family:

* **[Orchestrator functions](https://docs.microsoft.com/azure/azure-functions/durable/durable-functions-orchestrations)**: Long-running, reliable workflow functions written in code that schedule and coordinate other functions.
* **[Activity functions](https://docs.microsoft.com/azure/azure-functions/durable/durable-functions-types-features-overview#activity-functions)**: Stateless functions that are the basic unit of work in a durable function orchestration.
* **[Entity functions](https://docs.microsoft.com/azure/azure-functions/durable/durable-functions-entities)**: Stateful [actor](https://en.wikipedia.org/wiki/Actor_model)-like functions that have identities and store state explicitly.

Durable Functions can run anywhere that Azure Functions can run, including in the Azure Functions "Serverless" [Consumption plan](https://docs.microsoft.com/azure/azure-functions/functions-scale#consumption-plan), the [Elastic Premium plan](https://docs.microsoft.com/azure/azure-functions/functions-scale#premium-plan), on [Kubernetes](https://docs.microsoft.com/azure/azure-functions/functions-kubernetes-keda), or even locally for development using [Visual Studio](https://docs.microsoft.com/azure/azure-functions/durable/durable-functions-create-first-csharp) or [Visual Studio Code](https://docs.microsoft.com/azure/azure-functions/functions-develop-vs-code).

📑 **[Official documentation](https://docs.microsoft.com/azure/azure-functions/durable/)** 📑

For a more detailed overview, including examples of what you can do with Durable Functions, see our [What is Durable Functions?](https://docs.microsoft.com/azure/azure-functions/durable/durable-functions-overview) article.

# Fan-Out/Fan-In Azure Durable Function

![image](https://user-images.githubusercontent.com/93994559/194022821-104c866a-b9a4-4684-aef5-9c1996c62555.png)

This type of azure durable function allows us to start several functions(tasks) simultaneously and do an aggregation of the results.

Fan-Out/Fan-In Azure Durable Function helps us to optimize our solutions when we have a very heavy workload by dividing it to smaller blocks(task) which are executed concurrently. At the end of the execution of these tasks, an aggregation of the results is made.
The result obtained can be reused to perform other tasks, for example ratio calculations.


## Example

We are going to do a little demo with Fan-Out/Fan-In using the ASP.NET/C# Framework.

* First we retrieve a list of products from the database [AdventureWorks2012](https://github.com/Microsoft/sql-server-samples/releases/download/adventureworks/AdventureWorks2012.bak)
* Then we retrieve the list of sales of all products in parallel.
* At the end, we aggregate all product sales.


## Installation

To install this project in your computer, you must install these prerequisites listed below:

* [Visual studio 2022](https://visualstudio.microsoft.com/fr/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&cid=2030&passive=false)
* [SDK .NET 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
* [Database AdventureWorks2012](https://github.com/Microsoft/sql-server-samples/releases/download/adventureworks/AdventureWorks2012.bak)


## Configuration

You need to create a local.setting.json file in the project folder of the project then add the contents of the json below in this file..
```json
{
  "IsEncrypted": false,
  "Values": {
    "AzureWebJobsStorage": "UseDevelopmentStorage=true",
    "FUNCTIONS_WORKER_RUNTIME": "dotnet",
    "AzureWebJobsSecretStorageType": "files",

    // FeatureFlags
    "FeatureFlags:EnableMonitor": true,

    // ConnectionStrings
    "ConnectionStrings:DefaultConnection": ""
  }
}
```

## FeatureFlags

In this project, we have implemented a monitor that allows us to follow the execution of our functions and to see the returned values. This feature FeatureFlags can be used to enable/disable this monitor.

![image](https://user-images.githubusercontent.com/93994559/194033882-b5bf2556-a80d-4aff-ae98-c3363c04b8e1.png)
1. Monitor home page

![image](https://user-images.githubusercontent.com/93994559/194034038-1b93681c-e1ea-4e04-95a8-33c240a9902e.png)
2. example of running tasks in parallel with the monitor interface.

## Documentation

* [Durable Functions](https://github.com/Azure/azure-functions-durable-extension)
* [Fan-out/fan-in Azure Durable Function](https://learn.microsoft.com/en-us/azure/azure-functions/durable/durable-functions-cloud-backup?tabs=csharp)
* [DurableFunctionsMonitor.DotNetBackend](https://github.com/scale-tone/DurableFunctionsMonitor/blob/master/durablefunctionsmonitor.dotnetbackend/README.md) _(The monitot for Azure Function with ASP.NET/C#)_

