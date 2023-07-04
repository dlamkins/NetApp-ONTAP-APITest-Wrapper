# ![icons8-netapp-cute-color-32](https://github.com/dlamkins/NetApp-ONTAP-APITest-Wrapper/assets/1950594/f1a896a2-7b50-463d-8da4-85d1004b1e2f) NetApp / ONTAP APITest Wrapper

## Download: https://github.com/dlamkins/NetApp-ONTAP-APITest-Wrapper/releases/latest/download/NetApp.APITest.Wrapper.exe

The NetApp APITest Wrapper is an unofficial GUI wrapper for the NetApp apitest application made available in a single binary.  The tool's primary purpose is to aid in troubleshooting API connections with NetApp appliances.  Commands for `system-get-version` and `qtree-list-iter` are available in the dropdown.

| | |
|-|-|
|![image](https://github.com/dlamkins/NetApp-ONTAP-APITest-Wrapper/assets/1950594/0f5b49e4-b3e8-4459-9703-e6ee138a1eff)|![image](https://github.com/dlamkins/NetApp-ONTAP-APITest-Wrapper/assets/1950594/c6eb84e9-1766-4766-b548-f28fc16baac8)|

### What does the tool do?

The tool performs several basic checks:
- Checks to see if the appliance can be successfully pinged.
- Checks to see if the appliance is listening for HTTP/HTTPS API calls.
- Performs the selected API call, which should return some basic data if successful.

### This application is blocked by my anti-virus software.

If you want to use the application, you will need to unblock it.  The tool is likely to trigger av software as it bundles the NetApp tool within it and extracts it to run it.  In the future, we may look at making the [API calls](https://library.netapp.com/ecmdocs/ECMLP2856304/html/index.html) directly instead of feeding them through the apitest application, but I don't have access to a NetApp appliance any more to work on that sort of development.

### HTTP fails, but HTTPS succeeds?

v8.6 (or something - I can't quite remember) of ONTAP disables HTTP (80) by default and enforces API calls over HTTPS (443).  You're fine as long as one or the other works (whatever your client is using).  Honestly, in $currentYear you should be using HTTPS regardless.  If you still have HTTP enabled... 😔 consider disabling it.

### Common Error Codes

Shown in the Raw Output you'll see an XML response provided by the apitest tool.  It will indicate an `errorno` and `status="failed"` if there was an issue.

|Code|Error Message|Common Cause|
|-|-|-|
|10060|_Can't connect to host (err=10060)._|Nothing appears to be even listening on the port we reached out to - check the IP and that the API is enabled.|
|13011|_HTTP POST failed_|This likely isn't the correct IP, and you're hitting another system that happens to be hosting a web server.|

_Feel free to suggest updates to this table._

### Credits

Thank you [Icons8](https://icons8.com/) for the icon used by the application.
