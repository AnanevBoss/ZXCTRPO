﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TableTapEntities3 : DbContext
    {
        private static TableTapEntities3 _context;
        public TableTapEntities3()
            : base("name=TableTapEntities3")
        {
        }
        public static TableTapEntities3 GetContext()
        {
            if (_context == null)
                _context = new TableTapEntities3();
            return _context;

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Booking_status> Booking_status { get; set; }
        public virtual DbSet<Dish> Dish { get; set; }
        public virtual DbSet<Dish_Order> Dish_Order { get; set; }
        public virtual DbSet<logs> logs { get; set; }
        public virtual DbSet<Manager> Manager { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Order_status> Order_status { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Restaurant> Restaurant { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Table> Table { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<User_View> User_View { get; set; }
        public virtual DbSet<PaymentDetails> PaymentDetails { get; set; }
        public virtual DbSet<RestaurantTableList> RestaurantTableList { get; set; }
        public virtual DbSet<RestaurantView> RestaurantView { get; set; }
        public virtual DbSet<TableView> TableView { get; set; }
        public virtual DbSet<UserView> UserView { get; set; }
    
        [DbFunction("TableTapEntities3", "GetBookings")]
        public virtual IQueryable<GetBookings_Result> GetBookings()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GetBookings_Result>("[TableTapEntities3].[GetBookings]()");
        }
    
        [DbFunction("TableTapEntities3", "GetOrders")]
        public virtual IQueryable<GetOrders_Result> GetOrders()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GetOrders_Result>("[TableTapEntities3].[GetOrders]()");
        }
    
        [DbFunction("TableTapEntities3", "GetRestaurants")]
        public virtual IQueryable<GetRestaurants_Result> GetRestaurants()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GetRestaurants_Result>("[TableTapEntities3].[GetRestaurants]()");
        }
    
        [DbFunction("TableTapEntities3", "GetTables")]
        public virtual IQueryable<GetTables_Result> GetTables()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GetTables_Result>("[TableTapEntities3].[GetTables]()");
        }
    
        [DbFunction("TableTapEntities3", "GetUsers")]
        public virtual IQueryable<GetUsers_Result> GetUsers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GetUsers_Result>("[TableTapEntities3].[GetUsers]()");
        }
    
        public virtual int AddOrder(Nullable<System.DateTime> order_Date, Nullable<System.TimeSpan> order_Time, Nullable<int> order_status_Id)
        {
            var order_DateParameter = order_Date.HasValue ?
                new ObjectParameter("Order_Date", order_Date) :
                new ObjectParameter("Order_Date", typeof(System.DateTime));
    
            var order_TimeParameter = order_Time.HasValue ?
                new ObjectParameter("Order_Time", order_Time) :
                new ObjectParameter("Order_Time", typeof(System.TimeSpan));
    
            var order_status_IdParameter = order_status_Id.HasValue ?
                new ObjectParameter("Order_status_Id", order_status_Id) :
                new ObjectParameter("Order_status_Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddOrder", order_DateParameter, order_TimeParameter, order_status_IdParameter);
        }
    
        public virtual int AddPayment(Nullable<int> payment_amount, Nullable<System.DateTime> date_and_time_of_payment, string payment_status, Nullable<int> order_id, Nullable<int> user_id)
        {
            var payment_amountParameter = payment_amount.HasValue ?
                new ObjectParameter("Payment_amount", payment_amount) :
                new ObjectParameter("Payment_amount", typeof(int));
    
            var date_and_time_of_paymentParameter = date_and_time_of_payment.HasValue ?
                new ObjectParameter("Date_and_time_of_payment", date_and_time_of_payment) :
                new ObjectParameter("Date_and_time_of_payment", typeof(System.DateTime));
    
            var payment_statusParameter = payment_status != null ?
                new ObjectParameter("Payment_status", payment_status) :
                new ObjectParameter("Payment_status", typeof(string));
    
            var order_idParameter = order_id.HasValue ?
                new ObjectParameter("Order_id", order_id) :
                new ObjectParameter("Order_id", typeof(int));
    
            var user_idParameter = user_id.HasValue ?
                new ObjectParameter("User_id", user_id) :
                new ObjectParameter("User_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddPayment", payment_amountParameter, date_and_time_of_paymentParameter, payment_statusParameter, order_idParameter, user_idParameter);
        }
    
        public virtual int AddRestaurant(Nullable<System.DateTime> work_schedule, string address)
        {
            var work_scheduleParameter = work_schedule.HasValue ?
                new ObjectParameter("Work_schedule", work_schedule) :
                new ObjectParameter("Work_schedule", typeof(System.DateTime));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddRestaurant", work_scheduleParameter, addressParameter);
        }
    
        public virtual int AddRestaurants(Nullable<System.DateTime> workSchedule, string address)
        {
            var workScheduleParameter = workSchedule.HasValue ?
                new ObjectParameter("WorkSchedule", workSchedule) :
                new ObjectParameter("WorkSchedule", typeof(System.DateTime));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddRestaurants", workScheduleParameter, addressParameter);
        }
    
        public virtual int AddTable(Nullable<int> table_number, Nullable<int> number_of_seats, Nullable<int> restaurant_Id, string location)
        {
            var table_numberParameter = table_number.HasValue ?
                new ObjectParameter("Table_number", table_number) :
                new ObjectParameter("Table_number", typeof(int));
    
            var number_of_seatsParameter = number_of_seats.HasValue ?
                new ObjectParameter("Number_of_seats", number_of_seats) :
                new ObjectParameter("Number_of_seats", typeof(int));
    
            var restaurant_IdParameter = restaurant_Id.HasValue ?
                new ObjectParameter("Restaurant_Id", restaurant_Id) :
                new ObjectParameter("Restaurant_Id", typeof(int));
    
            var locationParameter = location != null ?
                new ObjectParameter("Location", location) :
                new ObjectParameter("Location", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddTable", table_numberParameter, number_of_seatsParameter, restaurant_IdParameter, locationParameter);
        }
    }
}
