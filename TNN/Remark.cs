//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TNN
{
    using System;
    using System.Collections.Generic;
    
    public partial class Remark
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Response_status { get; set; }
        public Nullable<int> Response_project_company_ { get; set; }
        public string Expert_review { get; set; }
        public int Project_info { get; set; }
        public string Expert_comment { get; set; }
        public int Branch_Id { get; set; }
        public int Set_Remarks_ID { get; set; }
    
        public virtual Group Group { get; set; }
        public virtual Projects Projects { get; set; }
        public virtual Response_status Response_status1 { get; set; }
        public virtual Response_Project_Company_ Response_Project_Company_1 { get; set; }
        public virtual Set_remarks Set_remarks { get; set; }
    }
}
