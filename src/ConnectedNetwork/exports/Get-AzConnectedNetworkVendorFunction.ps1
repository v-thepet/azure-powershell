
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Gets information about the specified vendor network function.
.Description
Gets information about the specified vendor network function.
.Example
PS C:\> Get-AzConnectedNetworkVendorFunction -LocationName centraluseuap -ServiceKey 1234-abcd-4321-dcba -SubscriptionId xxxx-3333-xxxx-3333 -VendorName myVendor

Id                                 : /subscriptions/xxxx-3333-xxxx-3333/providers/Microsoft.HybridNetwork/locations/centraluseuap/vendors/myVendor/networkfunctions/1b69005b-9168-4d74-a371-d4c4f6a521d
                                     0
Name                               : 1234-abcd-4321-dcba
NetworkFunctionVendorConfiguration : {Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.SshPublicKey}
ProvisioningState                  : Succeeded
ResourceGroupName                  :
SkuName                            : mySku
SkuType                            : EvolvedPacketCore
SystemDataCreatedAt                : 11/25/2021 2:04:28 PM
SystemDataCreatedBy                : xxxxx-11111-xxxxx-11111
SystemDataCreatedByType            : Application
SystemDataLastModifiedAt           : 11/25/2021 2:04:28 PM
SystemDataLastModifiedBy           : xxxxx-11111-xxxxx-11111
SystemDataLastModifiedByType       : Application
Type                               : microsoft.hybridnetwork/locations/vendors/networkfunctions
VendorProvisioningState            : NotProvisioned

.Example
PS C:\> $vendorNF = @{ ServiceKey = "1234-abcd-4321-dcba"; VendorName = "myVendor"; LocationName = "centraluseuap"; SubscriptionId = "xxxx-3333-xxxx-3333"}
PS C:\> Get-AzConnectedNetworkVendorFunction -InputObject $vendorNF

Id                                 : /subscriptions/xxxx-3333-xxxx-3333/providers/Microsoft.HybridNetwork/locations/centraluseuap/vendors/myVendor/networkfunctions/1b69005b-9168-4d74-a371-d4c4f6a521d
                                     0
Name                               : 1234-abcd-4321-dcba
NetworkFunctionVendorConfiguration : {Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.SshPublicKey}
ProvisioningState                  : Succeeded
ResourceGroupName                  :
SkuName                            : mySku
SkuType                            : EvolvedPacketCore
SystemDataCreatedAt                : 11/25/2021 2:04:44 PM
SystemDataCreatedBy                : xxxxx-11111-xxxxx-11111
SystemDataCreatedByType            : Application
SystemDataLastModifiedAt           : 11/25/2021 2:36:28 PM
SystemDataLastModifiedBy           : xxxxx-11111-xxxxx-11111
SystemDataLastModifiedByType       : Application
Type                               : microsoft.hybridnetwork/locations/vendors/networkfunctions
VendorProvisioningState            : Provisioned


.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.IConnectedNetworkIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IVendorNetworkFunction
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IConnectedNetworkIdentity>: Identity Parameter
  [DeviceName <String>]: The name of the device resource.
  [Id <String>]: Resource identity path
  [LocationName <String>]: The Azure region where the network function resource was created by the customer.
  [NetworkFunctionName <String>]: The name of the network function.
  [PreviewSubscription <String>]: Preview subscription ID.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [RoleInstanceName <String>]: The name of the role instance of the vendor network function.
  [ServiceKey <String>]: The GUID for the vendor network function.
  [SkuName <String>]: The name of the sku.
  [SubscriptionId <String>]: The ID of the target subscription.
  [VendorName <String>]: The name of the vendor.
  [VendorSkuName <String>]: The name of the network function sku.
.Link
https://learn.microsoft.com/powershell/module/az.connectednetwork/get-azconnectednetworkvendorfunction
#>
function Get-AzConnectedNetworkVendorFunction {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IVendorNetworkFunction])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Path')]
    [System.String]
    # The Azure region where the network function resource was created by the customer.
    ${LocationName},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Path')]
    [System.String]
    # The GUID for the vendor network function.
    ${ServiceKey},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Path')]
    [System.String]
    # The name of the vendor.
    ${VendorName},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.IConnectedNetworkIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Query')]
    [System.String]
    # The filter to apply on the operation.
    # The properties you can use for eq (equals) are: skuType, skuName and vendorProvisioningState.
    ${Filter},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Get = 'Az.ConnectedNetwork.private\Get-AzConnectedNetworkVendorFunction_Get';
            GetViaIdentity = 'Az.ConnectedNetwork.private\Get-AzConnectedNetworkVendorFunction_GetViaIdentity';
            List = 'Az.ConnectedNetwork.private\Get-AzConnectedNetworkVendorFunction_List';
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
