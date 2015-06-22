using BusinessServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServiceModule
{
	class BusinessService : IBusinessService
	{
		public List<string> GetAllNames()
		{
			List<string> names = new List<string>();
			names.Add("Me");
			names.Add("Myself");
			names.Add("George");

			return names;
		}
	}
}
