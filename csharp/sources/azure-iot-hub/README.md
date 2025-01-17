# Azure IoT hub sample
The sample contained in this folder gives an example on how to connect to Azure IoT Hub and bridge data into Kafka using the Quix SDK.

![graph](iot-bridge.png?raw=true)

## Environment variables

The code sample uses the following environment variables:

- **output**: This is the ouput topic where data will be written to.
- **eventHubsEndpoint**: This is the Event Hub endpoint.
- **eventHubName**: This is the Event Hub name.
- **iotSasKeyName**: This is the IoT Sas Key Name.
- **iotSasKey**: This is the IoT Sas Key.

### Connection to Quix
In this code snippet, the service connects to the Kafka topic in Quix. Use the Library page in the Quix portal to generate this code for a particular topic in your workspace.
```csharp
 // Create a client factory. The Factory helps you create a QuixStreamingClient (see below) more easily
var client = new Quix.Sdk.Streaming.QuixStreamingClient();

// Create a QuixStreamingClient (using the factory) in order to create new streams for the above configured topic
using var outputTopic = client.OpenOutputTopic("{placeholder:outputTopic}");
```

### Connection to IoT Hub
Use **az** to get connection information for specified IoT hub.

```csharp
// Event Hub-compatible endpoint
// az iot hub show --query properties.eventHubEndpoints.events.endpoint --name {your IoT Hub name}
var eventHubsCompatibleEndpoint = "{placeholder:endpoint}";

// Event Hub-compatible name
// az iot hub show --query properties.eventHubEndpoints.events.path --name {your IoT Hub name}
var eventHubName = "{placeholder:eventHubName}";

// az iot hub policy show --name service --query primaryKey --hub-name {your IoT Hub name}
var iotHubSasKeyName = "{placeholder:service}";
var iotHubSasKey = "{placeholder:SAS_KEY}";

// If you chose to copy the "Event Hub-compatible endpoint" from the "Built-in endpoints" section
// of your IoT Hub instance in the Azure portal, you can set the connection string to that value
// directly and remove the call to "BuildEventHubsConnectionString".
string connectionString =
    BuildEventHubsConnectionString(eventHubsCompatibleEndpoint, iotHubSasKeyName, iotHubSasKey);

// Create the consumer using the default consumer group using a direct connection to the service.
await using EventHubConsumerClient consumer =
    new EventHubConsumerClient(EventHubConsumerClient.DefaultConsumerGroupName, connectionString,
        eventHubName);
```

### Transformation to Quix SDK format
In code example we simply get the whole JSON message and send it as an event with the Quix SDK.

```csharp
var data = Encoding.UTF8.GetString(partitionEvent.Data.Body.ToArray());

stream.Events
	.AddTimestamp(partitionEvent.Data.EnqueuedTime.ToUniversalTime().DateTime)
	.AddValue("message", data)
	.Write();
```
but in a real application, we suggest developing a model to parse this data and send it using parameters to the Quix SDK. 

## Docs

Check out the [SDK docs](https://quix.ai/docs/sdk/introduction.html) for detailed usage guidance

## How to run
This bridge can run locally or in our serverless environment. To learn how to deploy services in Quix, please create an account at [Quix](https://portal.platform.quix.ai/self-sign-up?xlink=github) and see our [docs](https://quix.ai/docs/guides/index.html).

