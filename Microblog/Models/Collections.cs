//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microblog.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Collections
    {
        public int collections_id { get; set; }
        public Nullable<System.DateTime> collections_time { get; set; }
        public bool collections_status { get; set; }
        public int user_id { get; set; }
        public int messages_id { get; set; }
    
        public virtual Messages Messages { get; set; }
        public virtual Users Users { get; set; }
    }
}
