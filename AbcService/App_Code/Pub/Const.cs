using System;
using System.Configuration;

namespace BankService.Pub
{
	/// <summary>
	/// Const ��ժҪ˵����
	/// </summary>
	public class Const
	{
		public const string BankABC = "�й�ũҵ����";
        public const string Server_IP = "192.168.70.100";//ConfigurationManager.AppSettings["ABCserver"].ToString();
        public const int PORT = 3837;//Convert.ToInt16( ConfigurationManager.AppSettings["Port"].ToString() );//3837;

		public Const()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}
	}
}
