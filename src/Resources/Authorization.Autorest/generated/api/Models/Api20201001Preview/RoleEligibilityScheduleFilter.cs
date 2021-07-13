namespace Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Extensions;

    /// <summary>Role eligibility schedule filter</summary>
    public partial class RoleEligibilityScheduleFilter :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleFilter,
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleFilterInternal
    {

        /// <summary>Backing field for <see cref="PrincipalId" /> property.</summary>
        private string _principalId;

        /// <summary>Returns role eligibility schedule of the specific principal.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string PrincipalId { get => this._principalId; set => this._principalId = value; }

        /// <summary>Backing field for <see cref="RoleDefinitionId" /> property.</summary>
        private string _roleDefinitionId;

        /// <summary>Returns role eligibility schedule of the specific role definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string RoleDefinitionId { get => this._roleDefinitionId; set => this._roleDefinitionId = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Returns role eligibility schedule of the specific status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="RoleEligibilityScheduleFilter" /> instance.</summary>
        public RoleEligibilityScheduleFilter()
        {

        }
    }
    /// Role eligibility schedule filter
    public partial interface IRoleEligibilityScheduleFilter :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.IJsonSerializable
    {
        /// <summary>Returns role eligibility schedule of the specific principal.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Returns role eligibility schedule of the specific principal.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get; set; }
        /// <summary>Returns role eligibility schedule of the specific role definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Returns role eligibility schedule of the specific role definition.",
        SerializedName = @"roleDefinitionId",
        PossibleTypes = new [] { typeof(string) })]
        string RoleDefinitionId { get; set; }
        /// <summary>Returns role eligibility schedule of the specific status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Returns role eligibility schedule of the specific status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }

    }
    /// Role eligibility schedule filter
    internal partial interface IRoleEligibilityScheduleFilterInternal

    {
        /// <summary>Returns role eligibility schedule of the specific principal.</summary>
        string PrincipalId { get; set; }
        /// <summary>Returns role eligibility schedule of the specific role definition.</summary>
        string RoleDefinitionId { get; set; }
        /// <summary>Returns role eligibility schedule of the specific status.</summary>
        string Status { get; set; }

    }
}