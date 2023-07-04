# ![icons8-netapp-cute-color-32](https://github.com/dlamkins/NetApp-APITest-Wrapper/assets/1950594/2d4b92a5-d536-4a52-881b-923001520b06) NetApp APITest Wrapper

The NetApp APITest Wrapper is an unofficial GUI wrapper for the NetApp apitest application made available in a single binary.  The tool's primary purpose is to aid in troubleshooting API connections with NetApp appliances.  Commands for `system-get-version` and `qtree-list-iter` are available in the dropdown.

| | |
|-|-|
|![image](https://github.com/dlamkins/NetApp-APITest-Wrapper/assets/1950594/ac1d936c-e7cd-4542-a69e-86fa4afbad53)|![image](https://github.com/dlamkins/NetApp-APITest-Wrapper/assets/1950594/ebd9fb61-adb3-4eca-b261-d5baba11589d)|

### What does the tool do?

The tool performs several basic checks:
- Checks to see if the appliance can be successfully pinged.
- Checks to see if the appliance is listening for HTTP/HTTPS API calls.
- Performs the selected API call, which should return some basic data if successful.

### This application is blocked by my anti-virus software.

If you want to use the application, you will need to unblock it.  The tool is likely to trigger av software as it bundles the NetApp tool within it and extracts it to run it.  In the future, we may look at making the [API calls](https://library.netapp.com/ecmdocs/ECMLP2856304/html/index.html) directly instead of feeding them through the apitest application, but I don't have access to a NetApp appliance any more to work on that sort of development.

### HTTP fails, but HTTPS succeeds?

v8.6 (or something - I can't quite remember) of ONTAP disables HTTP (80) by default and enforces API calls over HTTPS (443).  You're fine as long as one or the other works (whatever your client is using).  Honestly, in $currentYear you should be using HTTPS regardless.  If you still have HTTP enabled... 😔 consider disabling it.

### Credits

Thank you [Icons8](https://icons8.com/) for the icon used by the application.
