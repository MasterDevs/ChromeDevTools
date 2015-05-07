[![Build Status](https://travis-ci.org/MasterDevs/ChromeDevTools.svg?branch=master)](https://travis-ci.org/MasterDevs/ChromeDevTools)

# ChromeDevTools
C# Library to interact with the Chrome Developer Tools.

## About
This library is C# API that enabled interaction with the Chrome Developer Tools.  When the Chrome Developer Tools are started, the chrome process starts a server.  The Chrome Developer Tools UI communicates with this server via Web Sockets.  So can you.  In fact, everything in the Chrome Developers Tools UI is available to you ... and now, it's available to you in C#.

Communication with this server is defined in a protocol.json file.  This is subject to change at any time.  Below are instructions what to do if this library becomes out of date with the protocol.
  * [Google's Version](https://code.google.com/p/chromium/codesearch#chromium/src/third_party/WebKit/Source/devtools/protocol.json&q=protocol.json&sq=package:chromium&type=cs)
  * [This Repo's Version](source/ProtocolGenerator/protocol.json)

## Examples

Currently, the only example (and it's a poor one) is in the Sample project.
 
## Library out of date?
