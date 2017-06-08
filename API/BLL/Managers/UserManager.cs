using API.DTO;
using API.Enum;
using Entity.DAL;
using Repository;
using System.Linq;
using System;

namespace API.BLL.Managers
{
    public class UserManager : Repository<BodrumEntities, User>
    {
        public UserManager(BodrumEntities ctx) : base(ctx)
        {
        }
        public UserManager() : this(new BodrumEntities())
        {
        }

        

        public UserLogin userLogin { get; set; }
        public RegisterResult RegisterResult { get; set; }
        public bool IsUserExist(UserLogin userLogin)
        {
            bool result = false;
            if (GetAll().FirstOrDefault(c => c.username == userLogin.username && c.password == userLogin.password) != null)
                result = true;
            return result;
        }
        public RegisterResult Register(UserLogin userLogin)
        {
            //var data = GetAllBind();
            this.userLogin = userLogin;
            GetAll().FirstOrDefault(CheckUser);
            if (RegisterResult == RegisterResult.ok)
            {
                User newUser = new User();
                newUser.username = userLogin.username;
                newUser.password = userLogin.password;
                newUser.email = userLogin.email;
                SubmitOnAdd(newUser);
            }
            return RegisterResult;
        }
        private bool CheckUser(User user)
        {

            var result = false;
            if (user.username == userLogin.username)
            {
                RegisterResult = RegisterResult.usernameExist;
            }
            else if (user.email == userLogin.email)
            {
                RegisterResult = RegisterResult.emailExist;
            }
            else
            {
                RegisterResult = RegisterResult.ok;
                result = true;
            }
            return result;
        }
    }
}