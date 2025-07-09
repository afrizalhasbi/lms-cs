namespace Application.DataObj.Auth
{
    public class RegistrationDataObj
    {
        required public String UserName { get; set; }
        required public String Email { get; set; }
        required public String Password { get; set; }
        required public String PasswordConfirm { get; set; }
        required public String Country { get; set; }
    }

    public class LoginDataObj
    {
        required public String Email { get; set; }
        required public String Password { get; set; }
    }

    public class LogoutDataObj
    {
        required public String JwtToken { get; set; }
    }

    public class RefreshDataObj
    {
        required public String JwtToken { get; set; }
    }

    public class ForgotPassDataObj
    {
        required public String Email { get; set; }
    }

    public class ResetPassDataObj
    {
        required public String Email { get; set; }
        required public String NewPassword { get; set; }
        required public String NewPasswordConfirm { get; set; }
        required public String ResetToken { get; set; }
    }

    public class GetProfileDataObj
    {
        public Guid Uuid { get; set; }
    }

    public class UpdateProfileDataObj
    {
        required public String? JwtToken { get; set; }
    }

    public class DeleteAccDataObj
    {
        required public String Email { get; set; }
        required public String Password { get; set; }
        required public String? JwtToken { get; set; }
    }
}
