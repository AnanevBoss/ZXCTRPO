//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TableTapManager.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class RestaurantTableList
    {
        public int Id_Restaurant { get; set; }
        public System.DateTime Work_schedule { get; set; }
        public string Address { get; set; }
        public int Id_Table { get; set; }
        public int Table_number { get; set; }
        public int Number_of_seats { get; set; }
    }
}
