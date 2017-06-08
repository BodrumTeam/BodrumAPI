using Entity.DAL;
using API.BLL.Managers;

namespace API.BLL.UnitOFWork
{
    public class UnitOfWork
    {
        BodrumEntities ctx = new BodrumEntities();
        
        public CategoryManager CategoryManager
        {
            get
            {
                return new CategoryManager(ctx);
            }
        }
        public CommentManager CommentManager
        {
            get
            {
                return new CommentManager(ctx);
            }
        }
        public ItemManager ItemManager
        {
            get
            {
                return new ItemManager(ctx);
            }
        }
        public ItemOperationManager ItemOperationManager
        {
            get
            {
                return new ItemOperationManager(ctx);
            }
        }
        public NeedManager NeedManager
        {
            get
            {
                return new NeedManager(ctx);
            }
        }
        public NeedOperationManager NeedOperationManager
        {
            get
            {
                return new NeedOperationManager(ctx);
            }
        }
        public NotificationManager NotificationManager
        {
            get
            {
                return new NotificationManager(ctx);
            }
        }
        public OperationManager OperationManager
        {
            get
            {
                return new OperationManager(ctx);
            }
        }
        public RoleManager RoleManager
        {
            get
            {
                return new RoleManager(ctx);
            }
        }
        public UserCommentItemManager UserCommentItemManager
        {
            get
            {
                return new UserCommentItemManager(ctx);
            }
        }
        public UserManager UserManager
        {
            get
            {
                return new UserManager(ctx);
            }
        }
        public UserMobileManager UserMobileManager
        {
            get
            {
                return new UserMobileManager(ctx);
            }
        }
    }
}