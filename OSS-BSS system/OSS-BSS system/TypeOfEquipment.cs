//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OSS_BSS_system
{
    using System;
    using System.Collections.Generic;
    
    public partial class TypeOfEquipment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TypeOfEquipment()
        {
            this.Application = new HashSet<Application>();
            this.Equipment = new HashSet<Equipment>();
        }
    
        public int TypeOfEquipmentId { get; set; }
        public string TypeOfEquipment1 { get; set; }
        public string FirmwareVersion { get; set; }
        public string MACAddress { get; set; }
        public string IPAddress { get; set; }
        public short NumberOfPorts { get; set; }
        public string DataTransmissionStandard { get; set; }
        public double DataTransferRate_Mbit_sec_ { get; set; }
        public double Frequency_Hz_ { get; set; }
        public byte[] Certificate { get; set; }
        public byte[] TechSpecification { get; set; }
        public System.DateTime ReleaseDate { get; set; }
        public string Fault { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Application> Application { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Equipment> Equipment { get; set; }
    }
}