namespace scripting_session.SwagLabs.Models
{
    public class Credential
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public static Credential GetStandardUser()
        {
            return new Credential(){
                Username = "standard_user",
                Password = "secret_sauce"
            };
        }

        public static Credential GetLockedOutUser()
        {
            return new Credential(){
                Username = "locked_out_user",
                Password = "secret_sauce"
            };
        }
        
    }
}