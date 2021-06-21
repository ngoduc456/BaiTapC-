using ModelEF.Model;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelEF.DAO
{
    public class UserDao
    {
        private NongNgocDucContext db;

        public UserDao()
        {
            db = new NongNgocDucContext();
        }
        public int login(string user, string pass)
        {
            var result = db.UserAccount.SingleOrDefault(x => x.UserName.Contains(user) && x.Mk.Contains(pass));
            if (result == null)
            {
                return 0;
            }
            else { return 1; }
        }
        public List<UserAccount> ListAll()
        {

            return db.UserAccount.ToList();
        }
        public IEnumerable<UserAccount> ListWhereAll(string keysearch,int page,int pagesize)
        {
            IQueryable<UserAccount> model = db.UserAccount;
            if (!string.IsNullOrEmpty(keysearch))
            {
                model= model.Where(x => x.UserName.Contains(keysearch));
            }
            //return db.UserAccount.Where(x => x.UserName.Contains(keysearch)).ToList();
            
            return model.OrderBy(x => x.UserName).ToPagedList(page, pagesize);
        }
        //public bool Delete(string username)
        //{
        //    try {
        //    var user = db.UserAccounts.Find(username);
        //    db.UserAccounts.Remove(user);
        //    db.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}
        public UserAccount Find(string username)
        {
            return db.UserAccount.Find(username);
        }
        public IEnumerable<UserAccount> ListwhereAll(string keysearch, int page, int pagesize)
        {
            IQueryable<UserAccount> model = db.UserAccount;
            if (!string.IsNullOrEmpty(keysearch))
            {
                model = model.Where(x => x.UserName.Contains(keysearch));
            }
            return model.OrderBy(x => x.UserName).ToPagedList(page, pagesize);
        }
        public bool Delete(int id)
        {
            try
            {
                var user = db.UserAccount.Find(id);
                db.UserAccount.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
