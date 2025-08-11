using nhom4.Models;

namespace nhom4
{
    public static class AppSession
    {
        public static User CurrentUser { get; set; }  // giữ user đã đăng nhập
        public static bool IsAdmin => CurrentUser?.VaiTro == "Admin";
    }
}