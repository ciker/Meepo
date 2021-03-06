# <img src ="https://rawgit.com/GowenGit/Meepo/master/Assets/Meepo%20Logo.svg" height="120px"/>

### [![Build Status](https://travis-ci.org/GowenGit/Meepo.svg?branch=master)](https://travis-ci.org/GowenGit/Meepo)

### Socket based duplex communication framework for .NET Core

Cross platform lightweight communication framework based on TCP Sockets. Provides basic
exception handling and automatic reconnects once the network is restored.

### Example

You can initialize a new node like this:

```
var config = new MeepoConfig
{
    Logger = new ConsoleLogger()
};

// IP Address to expose
var address = new TcpAddress(IPAddress.Loopback, 9201);

// Nodes to connect to
var serverAddresses = new[] { new TcpAddress(IPAddress.Loopback, 9200) };

using (var meepo = new MeepoNode(address, serverAddresses, config))
{
    meepo.Start();

    meepo.MessageReceived += x => System.Console.WriteLine(x.Bytes.Decode());

    while (true)
    {
        var text = System.Console.ReadLine();

        meepo.SendAsync(text).Wait();
    }
}
```

You can pass in a `MeepoConfig` object that lets you change the behavior of the server:

```
var config = new MeepoConfig
{
    BufferSizeInBytes = 1000,
    Logger = new ConsoleLogger()
};

...

var meepo = new Meepo(address, serverAddresses, config);
```

### Installation

* Restore solution: `dotnet restore`
* Run the console app: `dotnet run`

### License

MIT License