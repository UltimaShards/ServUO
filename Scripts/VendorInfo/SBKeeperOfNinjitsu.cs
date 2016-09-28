using System;
using System.Collections.Generic;
using Server.Items;

namespace Server.Mobiles
{
	public class SBKeeperOfNinjitsu : SBInfo
	{
		private readonly List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private readonly IShopSellInfo m_SellInfo = new InternalSellInfo();
		public SBKeeperOfNinjitsu()
		{
		}

		public override IShopSellInfo SellInfo
		{
			get
			{
				return this.m_SellInfo;
			}
		}
		public override List<GenericBuyInfo> BuyInfo
		{
			get
			{
				return this.m_BuyInfo;
			}
		}
		
		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				this.Add(new GenericBuyInfo(typeof(BookOfNinjitsu), 500, 20, 0x2252, 0));
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
			}
		}
	}
}