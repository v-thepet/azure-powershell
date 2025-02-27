// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401
{
    using Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.PowerShell;

    /// <summary>A provider instance associated with SAP monitor.</summary>
    [System.ComponentModel.TypeConverter(typeof(ProviderInstanceTypeConverter))]
    public partial class ProviderInstance
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ProviderInstance"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstance" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstance DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ProviderInstance(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ProviderInstance"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstance" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstance DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ProviderInstance(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ProviderInstance" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ProviderInstance" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstance FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ProviderInstance"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ProviderInstance(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IUserAssignedServiceIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.UserAssignedServiceIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ProviderInstancePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).IdentityType = (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.ManagedServiceIdentityType) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).IdentityType, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.ManagedServiceIdentityType.CreateFrom);
            }
            if (content.Contains("IdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.UserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.WorkloadMonitorProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.WorkloadMonitorProvisioningState.CreateFrom);
            }
            if (content.Contains("ProviderSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).ProviderSetting = (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderSpecificProperties) content.GetValueForProperty("ProviderSetting",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).ProviderSetting, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ProviderSpecificPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ErrorCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).ErrorCode = (string) content.GetValueForProperty("ErrorCode",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).ErrorCode, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).ErrorMessage = (string) content.GetValueForProperty("ErrorMessage",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).ErrorMessage, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).ErrorTarget = (string) content.GetValueForProperty("ErrorTarget",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).ErrorTarget, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).ErrorDetail = (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IError[]) content.GetValueForProperty("ErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).ErrorDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IError>(__y, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("ErrorInnerError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).ErrorInnerError = (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IErrorInnerError) content.GetValueForProperty("ErrorInnerError",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).ErrorInnerError, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ErrorInnerErrorTypeConverter.ConvertFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ProviderInstance"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ProviderInstance(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IUserAssignedServiceIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.UserAssignedServiceIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ProviderInstancePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).IdentityType = (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.ManagedServiceIdentityType) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).IdentityType, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.ManagedServiceIdentityType.CreateFrom);
            }
            if (content.Contains("IdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.UserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.WorkloadMonitorProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.WorkloadMonitorProvisioningState.CreateFrom);
            }
            if (content.Contains("ProviderSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).ProviderSetting = (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderSpecificProperties) content.GetValueForProperty("ProviderSetting",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).ProviderSetting, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ProviderSpecificPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ErrorCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).ErrorCode = (string) content.GetValueForProperty("ErrorCode",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).ErrorCode, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).ErrorMessage = (string) content.GetValueForProperty("ErrorMessage",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).ErrorMessage, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).ErrorTarget = (string) content.GetValueForProperty("ErrorTarget",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).ErrorTarget, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).ErrorDetail = (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IError[]) content.GetValueForProperty("ErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).ErrorDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IError>(__y, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("ErrorInnerError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).ErrorInnerError = (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IErrorInnerError) content.GetValueForProperty("ErrorInnerError",((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IProviderInstanceInternal)this).ErrorInnerError, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ErrorInnerErrorTypeConverter.ConvertFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// A provider instance associated with SAP monitor.
    [System.ComponentModel.TypeConverter(typeof(ProviderInstanceTypeConverter))]
    public partial interface IProviderInstance

    {

    }
}