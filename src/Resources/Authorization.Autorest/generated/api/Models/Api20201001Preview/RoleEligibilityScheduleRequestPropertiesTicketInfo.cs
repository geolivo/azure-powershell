namespace Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Extensions;

    /// <summary>Ticket Info of the role eligibility</summary>
    public partial class RoleEligibilityScheduleRequestPropertiesTicketInfo :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesTicketInfo,
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesTicketInfoInternal
    {

        /// <summary>Backing field for <see cref="TicketNumber" /> property.</summary>
        private string _ticketNumber;

        /// <summary>Ticket number for the role eligibility</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string TicketNumber { get => this._ticketNumber; set => this._ticketNumber = value; }

        /// <summary>Backing field for <see cref="TicketSystem" /> property.</summary>
        private string _ticketSystem;

        /// <summary>Ticket system name for the role eligibility</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string TicketSystem { get => this._ticketSystem; set => this._ticketSystem = value; }

        /// <summary>
        /// Creates an new <see cref="RoleEligibilityScheduleRequestPropertiesTicketInfo" /> instance.
        /// </summary>
        public RoleEligibilityScheduleRequestPropertiesTicketInfo()
        {

        }
    }
    /// Ticket Info of the role eligibility
    public partial interface IRoleEligibilityScheduleRequestPropertiesTicketInfo :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.IJsonSerializable
    {
        /// <summary>Ticket number for the role eligibility</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Ticket number for the role eligibility",
        SerializedName = @"ticketNumber",
        PossibleTypes = new [] { typeof(string) })]
        string TicketNumber { get; set; }
        /// <summary>Ticket system name for the role eligibility</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Ticket system name for the role eligibility",
        SerializedName = @"ticketSystem",
        PossibleTypes = new [] { typeof(string) })]
        string TicketSystem { get; set; }

    }
    /// Ticket Info of the role eligibility
    internal partial interface IRoleEligibilityScheduleRequestPropertiesTicketInfoInternal

    {
        /// <summary>Ticket number for the role eligibility</summary>
        string TicketNumber { get; set; }
        /// <summary>Ticket system name for the role eligibility</summary>
        string TicketSystem { get; set; }

    }
}