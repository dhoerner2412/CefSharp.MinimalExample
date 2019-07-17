Perform following steps to reproduce the error:
1. Start hfs.exe found in the WebPage folder
2. in hfs.exe, click Menu -> Add files, select index.html found in WebPage folder
3. Open google chrome and open http://localhost
4. Both buttons clicks display a valid Text
5. Start CefSharp.MinimalExample.Wpf.exe and click both buttons

=> text is empty when clicking second button. In devtools -> Network-Tab, you can see that the Response of the second request is empty

In chrome all works as expected, also if you start chrome with disabled web-security: chrome.exe --disable-web-security --disable-gpu --user-data-dir=~/chromeTemp

