namespace JWTCoreApp.Models
{
    public class UserConstant
    {
        // We are not taking data from data base so we get data from constant
        public static List<UserModel> Users = new()
            {
                    new UserModel(){ Username="joshi",Password="admin123",Role="Admin"}
            };
    }
}
