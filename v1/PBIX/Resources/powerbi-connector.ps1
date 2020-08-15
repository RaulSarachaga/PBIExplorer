$processids = Get-Process msmdsrv | Select-Object -ExpandProperty id 
if($processids)
{
    foreach($processid in $processids)
    {
        $pbidiagnosticport = Get-NetTCPConnection | ? {($_.State -eq 'Listen') -and ($_.RemoteAddress -eq '0.0.0.0') -and ($_.OwningProcess -eq $processid)} | Select-Object -ExpandProperty LocalPort
        Write-Host localhost:$pbidiagnosticport
    } 
}
else
{
    Write-Host 'Please open a Power BI File!'
}