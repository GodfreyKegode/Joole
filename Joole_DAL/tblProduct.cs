//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Joole_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProduct()
        {
            this.tblTypes = new HashSet<tblType>();
        }
    
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Series { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public int SubCategoryID { get; set; }
        public Nullable<int> ManufacturerID { get; set; }
        public string ProductImagePath { get; set; }
    
        public virtual tblManufacturer tblManufacturer { get; set; }
        public virtual tblSubCategory tblSubCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblType> tblTypes { get; set; }
    }
}
