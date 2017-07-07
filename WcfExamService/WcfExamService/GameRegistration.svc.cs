using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfExamService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public class GameRegistration : IGameRegistration
    {
        public string msg = "default";

        public static string conectionS =
                "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\sergei\\Documents\\Visual Studio 2017\\Projects\\WcfExamService\\WcfExamService\\App_Data\\Database1.mdf\";Integrated Security=True"
            ;
        public static string conectionS2 =
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|Database1.mdf';Integrated Security=True"
            ;

        static DataContext db = new DataContext(conectionS2);
        private Table<Gamer> tbGamers = db.GetTable<Gamer>();

        //public static List<Gamer> GamerList = new List<Gamer>()
        //{
        //    new Gamer {GamerId = 0, NickName="Test",
        //        Login="test", Passwd="test" }
                   
        //};
       
        public string LoginToReg(string login, string passwd)
        {
            Gamer query = db.GetTable<Gamer>().FirstOrDefault(p => p.Login == login && p.Passwd == passwd);
            //Gamer g = GamerList.FirstOrDefault(p => p.Login == login && p.Passwd == passwd);
            if (query != null)
            {
                int count = db.GetTable<Gamer>().Count();
                return count.ToString();
            }
            //return GamerList.Count.ToString();
            return "Access denied";
        }

        public int AddNewGamerToDbString(string nick, string login, string passwd)
        {
            Gamer g = new Gamer {Login = login, Passwd = passwd, NickName = nick };
            //GamerList.Add(g);
            db.GetTable<Gamer>().InsertOnSubmit(g);
            db.SubmitChanges();
          
            return 0;
        }

        public string GetData(int value)
        {
           
            return msg;
        }

        //public bool InsertGamer(Gamer gam)
        //{
            
        //    return true;
        //}
       
        //public List<Gamer> GetAllGamers()
        //{
        //    return GamerList;
        //}

        //public bool DeleteGamer(int Cid)
        //{
        //    var item = GamerList.First(x => x.GamerId == Cid);

        //    GamerList.Remove(item);
        //    return true;
        //}

        //public bool UpdateGamer(Gamer gam)
        //{
        //    var list = GamerList;
        //    GamerList.Where(p => p.GamerId ==
        //                           gam.GamerId).Update(p => p.NickName = gam.NickName);
        //    return true;
        //}

       

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string TestConnection()
        {
            db.Connection.Open();
            db.Connection.Close();
            return "OK";
        }

        public int AddNewGamerToDb(Gamer gam)
        {
            Gamer g = new Gamer { Login = gam.Login, Passwd = gam.Passwd, NickName = gam.NickName };
            //GamerList.Add(g);
            db.GetTable<Gamer>().InsertOnSubmit(g);
            db.SubmitChanges();
            return 0;
        }

        

    }
    public static class LinqUpdates
    {
        public static void Update<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
                action(item);
        }
    }
}
