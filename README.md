# search-script

This program is an alternative to the Powershell search script
that provides a GUI to the original script. the script looks in the
C:/bin folder for the server you specify and looks for any instance where your
string was mentioned that you asked for.

# Setup
In the StringSearch.ps1 script, you will need to setup the Domain controller on **Line 4** before you start building the app.
you will also need the RSAT Active directory tools to use this correctly, and when running this application, you should be running it as an
administrator, if you do not, it will alert you that the app may not work as intended.

## How do you run a powershell script in the c# programming language?
using the *system.diagnostics* namespace there is a class called *ProcessStartInfo* and *Process*. What i did for this app is
declare the needed parameters for ProcessStartInfo then pass it to Process which is then executed. you could generally
run the powershell script by itself by telling the app what application you want then telling the app where the path to your script.

## about winRM

WinRM is the main component that allows me to execute script blocks to servers from my
local machine. By default, this tool is installed and running on pretty much any Windows Operating 
system that is older than Windows Server 2008. 

A problem I had for a while was that you weren't 
able to send a script block to the remote server. the reason was because we didn't set up those servers as a trusted 
host prior to runtime, which is resolved with this command:

```
set-item wsman:\localhost\client\trustedhosts -Concatenate -value $servername -Force
```

We can't just add every single server we put into this script into the trusted hosts site for security reasons, so
I also added a validation loop so that users aren't just able to add bad values that will then be put into the
Trusted Hosts list by accident. The end goal of this script is that every server ran through this script needs 
to be a valid computer within the Domain Controller you setup to add itself to the list of trusted hostnames.

this is completed by executing the following command and then running the results through another screen:

```
$serverCheck = Get-ADComputer -Server "DOMAIN_CONTROLLER" -Filter {Name -eq $serverName}
```

Once we ensure that the server is in the Domain, the script will then execute the remote
command to the designated server and the rest will be handled by the c# filter that i will build.
