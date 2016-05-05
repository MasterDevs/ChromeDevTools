# What about these .json files?

The .json files describe the remote debugging protocol. They originate from Webkit (which Safari uses), which was forked
by Chromium (which Chrome uses).

Hence, the protocols are similar, but not the same. Plus, both Webkit and Chromium have released multiple versions of the
protocol.

## iOS
There are versions of protocol.json for iOS 7, 8, 9 and 9.3

You can find them on the:
* [Official SVN repository](http://trac.webkit.org/browser/trunk/Source/WebInspectorUI/Versions/)
* [GitHub mirror](https://github.com/WebKit/webkit/tree/master/Source/WebInspectorUI/Versions)

## Chrome
Chrome maintains three versions 0.1, 1.0 and 1.1; plus an additional "tip of the head" version simply known
as `protocol.json`.

You can find them on the:
* [Official SVN repository](https://src.chromium.org/viewvc/blink/trunk/Source/devtools/)
* [GitHub mirror](https://github.com/nwjs/blink/tree/nw12/Source/devtools)