[![Build status](https://ci.appveyor.com/api/projects/status/49o50p7fbn5hv6x1?svg=true)](https://ci.appveyor.com/project/brewdente/chromedevtools) [![NuGet version](https://badge.fury.io/nu/masterdevs.chromedevtools.svg)](http://badge.fury.io/nu/masterdevs.chromedevtools)

# ChromeDevTools
C# Library to interact with the Chrome Developer Tools.

```c#
    chromeSession.Subscribe<Protocol.Page.DomContentEventFiredEvent>(domContentEvent =>
    {
        Console.WriteLine("DomContentEvent: " + domContentEvent.Timestamp);
    });
    
    chromeSession.SendAsync(new NavigateCommand
    {
        Url = "http://www.google.com"
    }).Wait();
```

## About
This library is C# API that enabled interaction with the Chrome Developer Tools.  When the Chrome Developer Tools are started, the chrome process starts a server.  The Chrome Developer Tools UI communicates with this server via Web Sockets.  So can you.  In fact, everything in the Chrome Developers Tools UI is available to you via JSON, by default.  This library makes it available to you in C#.

Communication with this server is defined in a protocol.json file.  This is subject to change at any time.  Below are instructions what to do if this library becomes out of date with the protocol.
  * [Google's Version](https://code.google.com/p/chromium/codesearch#chromium/src/third_party/WebKit/Source/devtools/protocol.json&q=protocol.json&sq=package:chromium&type=cs)
  * [This Repo's Version](source/ProtocolGenerator/protocol.json)

## Contents

Contained in this repo are 3 projects.

  * [MasterDevs.ChromeDevTools](source/ChromeDevTools)
    * [Typed commands, events, and responses](source/ChromeDevTools/Protocol)
    * [An implementation of a messenger (a chrome session)](source/ChromeDevTools/ChromeSession.cs)
    * Other supporting classes including class to manage the chrome process, startup args, etc.
  * [MasterDevs.ChromeDevTools.ProtocolParser](source/ProtocolParser)
    * A really ugly (it used to be more ugly, but @qmfrederik did some cleaning) console application which parses the `protocol.json` file and generates all of the classes in the [Protocol](source/ChromeDevTools/Protocol)
  * [MasterDevs.ChromeDevTools.Sample](source/Sample)
    * While the sample on this page is great and all, you want something you can just fire off and dig right in.  That's what the sample is for.

## How it works

I've included a code example.  [Check it out](source/Sample/Program.cs) and read no further.  Wait, no.  Keep reading!

### Chrome Developer Tools

The Chrome Developer Tools have a pretty cool API.  There are 2 basic types of objects that the Developer Tools understand:
  * Events
    * These events will only be received by you
    * The are events triggered by page events, network events, the DOM, or something else.
    * You can tell Chrome to enable, or disable, domain events using ... commands (_keep reading_)
  * Commands
    * A command is an object that you will send to the Developer Tools.  This command will generate a response (or an error response).
    * Every Command has a CommandResponse

### MasterDevs.ChromeDevTools

If you made it this far, it's best to read the sample - [Program.cs](source/Sample/Program.cs).

## Library out of date?

If you didn't read the entire README (I don't blame you, I wouldn't), I've included a project in this repository which allows anyone to rebuild the protocol.  Following these steps:
  1. Download the latest `protocol.json` file and replace [this one](source/ProtocolGenerator/protocol.json)
  2. Build & run [MasterDevs.ChromeDevTools.ProtocolParser](source/ProtocolParser)
  3. Copy the contents of the `OutputProtocol` directory and paste it into (overwrite everything!) the [Protocol](source/ChromeDevTools/Protocol) directory
  4. Submit a pull request so others can benefit! (_optional_)

## Resources

  * [NuGet](https://www.nuget.org/packages/MasterDevs.ChromeDevTools/)
  * Obligatory [blog post](http://blog.masterdevs.com/chrome-debugging-api/)
  * Here's what the Chrome Team has to say about the Developer Tools protocol (it's not much)
    * [https://developer.chrome.com/devtools/docs/debugger-protocol](https://developer.chrome.com/devtools/docs/debugger-protocol)
  * Some cool apps that other developers have built using the Chrome Debugging Protocol
    * [https://developer.chrome.com/devtools/docs/debugging-clients](https://developer.chrome.com/devtools/docs/debugging-clients)
