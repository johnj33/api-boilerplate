$serviceName = "api-boilerplate"

$existingService = Get-WmiObject -Class Win32_Service -Filter "Name='$serviceName'"

if ($existingService) 
{
	$service = Get-Service $serviceName
	$service.Stop()
	$service.WaitForStatus("Stopped")
}