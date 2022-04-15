namespace mis321_pa4_betsybryant
{
    public class ConnectionString
    {
        public string cs {get; set;}

        public ConnectionString()
        {
            string server = "pfw0ltdr46khxib3.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "zguu1r33256nyicv";
            string port = "3306";
            string userName = "ucpegw0lm1iugdo9";
            string password = "zpmofohcj8jibvgm";

            cs = $@"server = {server}; user = {userName}; database = {database}; port = {port}; password = {password};";
            
        }
    }
}