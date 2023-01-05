namespace MJ_Rent_Login.Models
{
    public class BorrowRecord
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public string UserId { get; set; }
        //預約時間
        public DateTime BorrowDateTime { get; set; }
        //預約時間查長度,單位為分,有30, 60, 90, 120, 150, 180, 480(一天)可選
        public int PrevBorrowTime { get; set; }
        //真正借用時間
        public int ActualBorrowTime { get; set;}
    }
}
