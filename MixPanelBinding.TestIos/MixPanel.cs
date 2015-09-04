using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using MixpanelBindings;

namespace MixPanelBinding.TestIos
{
	public interface IMixPanel
	{
		void LoginUser(string userId);
		void CreateUser(string userId);
		void LogoutUser();
	}


	public class MixPanelStat : IMixPanel
	{
		//TODO: USE YOUR OWN MIXPANEL ID !!!
		const string YourMixPanelId = "77CDAB368BB216CAF691703C82D911A6";

		public void LoginUser(string userId)
		{
			var mixpanel = Mixpanel.SharedInstance;
			mixpanel.Identify(userId);
		}

		public void CreateUser(string userId)
		{
			var mixpanel = Mixpanel.SharedInstance;
			mixpanel.CreateAlias(userId, mixpanel.DistinctId);
			mixpanel.Identify(mixpanel.DistinctId);
		}

		public void LogoutUser()
		{
			var mixpanel = Mixpanel.SharedInstance;
			mixpanel.Reset();
		}


		internal static void Init()
		{
			try
			{
				//This version displays the real binding error
				var mixpanel = new Mixpanel(YourMixPanelId, 1);

				//This is the recommended version to use when the binding works.
				//It returns null if the binding does not work.
				//var mixpanel = Mixpanel.SharedInstanceWithToken(YourMixpanelId);

				Debug.WriteLine("Mixpanel initialized DistinctId {0}", (object)mixpanel.DistinctId);
			}
			catch(Exception e)
			{
				Debug.WriteLine ("Error in Mixpanel SDK: {0}", (object)e.ToString());
			}
		}
	}
}

