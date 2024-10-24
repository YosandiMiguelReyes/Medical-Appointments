
using MedicalAppointment.Domain.Core.Base;
using MedicalAppointment.Domain.Core.Insurance;
using MedicalAppointment.Domain.Core.Interface;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Entities.Insurance
{
    [Table("InsuranceProviders", Schema = "Insurance")]
    public sealed class InsuranceProviders : BaseEntity, IIsActive, IName
    {
        [Column("Name")]
        public string Name { get; set; }
        [Column("ContactNumber")]
        public string ContactNumber { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("Website")]
        public string? Website { get; set; }
        [Column("Address")]
        public string Address { get; set; }
        [Column("City")]
        public string? City { get; set; }
        [Column("State")]
        public string? State { get; set; }
        [Column("Country")]
        public string? Country { get; set; }
        [Column("ZipCode")]
        public string? ZipCode { get; set; }
        [Column("CoverageDetails")]
        public string CoverageDetails { get; set; }
        [Column("LogoUrl")]
        public string? LogoUrl { get; set; }
        [Column("IsPreferred")]
        public bool IsPreferred { get; set; }
        [ForeignKey("NetworkTypeId")]
        public int NetworkTypeId { get; set; }
        [Column("CustomerSupportContact")]
        public string? CustomerSupportContact { get; set; }
        [Column("AcceptedRegions")]
        public string? AcceptedRegions { get; set; }
        [Column("MaxCoverageAmount")]
        public decimal? MaxCoverageAmount { get; set; }
        [Column("IsActive")]
        public bool IsActive { get; set; }
    }
}
