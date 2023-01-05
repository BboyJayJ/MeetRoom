namespace MJ_Rent_Login.Models
{
    public class Notifylnfo
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        //通知內容
        public string InfoContext { get; set; }
        //是否已通知
        public Boolean HaveNotify { get; set; }
    }
}
