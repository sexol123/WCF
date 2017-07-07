﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfExamService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface IGameRegistration

    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Добавьте здесь операции служб
        /// <summary>
        /// connection test
        /// </summary>
        /// <returns>ok</returns>
        [OperationContract]
        string TestConnection();

        #region GameMethods
        /// <summary>
        /// adding new gamer
        /// </summary>
        /// <param name="gam"></param>
        /// <returns></returns>
        [OperationContract]
        int AddNewGamerToDb(Gamer gam);
        /// <summary>
        /// login method
        /// </summary>
        /// <param name="login"></param>
        /// <param name="passwd"></param>
        /// <returns></returns>
        [OperationContract]
        string LoginToReg(string login, string passwd);

        [OperationContract]
        int AddNewGamerToDbString(string nick, string login,string passwd);

        #endregion

    }


    // Используйте контракт данных, как показано в примере ниже, чтобы добавить составные типы к операциям служб.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
