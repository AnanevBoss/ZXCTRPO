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
    
    public partial class GetBookings_Result
    {
        public int Id_Booking { get; set; }
        public System.DateTime Booking_date { get; set; }
        public System.TimeSpan Booking_time { get; set; }
        public Nullable<int> Number_of_guests { get; set; }
        public Nullable<int> Table_id { get; set; }
        public Nullable<int> User_id { get; set; }
        public Nullable<int> Booking_status_id { get; set; }
    }
}
