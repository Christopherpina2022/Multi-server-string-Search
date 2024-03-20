param ([string]$searchString, [string]$serverName)
# Checks if the server we input is a Domain-bound server before adding it to Trusted Hosts.
try {
	$serverCheck = Get-ADComputer -Server "DOMAIN_CONTROLLER" -Filter {Name -eq $serverName}
	
	if ($serverCheck){
	set-item wsman:\localhost\client\trustedhosts -Concatenate -value $serverName -Force
	# Run query on remote server
	
	Invoke-Command -ComputerName $serverName -Scriptblock {
	Get-ChildItem c:\bin\* `
	| Get-ChildItem -Recurse -file `
	| Select-String $using:searchString -List `
	| Select-String $using:serverName -Notmatch `
	| Select Path, LineNumber, Line `
	} | Export-CSV -Path ./Results/$serverName.csv # Exports back to local device, as noted by the pipe element.
	
}
else{
	Write-Warning "Server could not be found."
	}
}
catch {
$message = $_
Write-Warning "$message"
}
