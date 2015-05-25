﻿namespace ReverbAccess.Models.Command
{
	public class ReverbCommand
	{
		public static readonly ReverbCommand Unknown = new ReverbCommand( string.Empty );
        public static readonly ReverbCommand GetToken = new ReverbCommand("/api/auth/email");

        public static readonly ReverbCommand GetListings = new ReverbCommand("/api/my/listings");
        public static readonly ReverbCommand GetListingsDrafts = new ReverbCommand("/api/my/listings/drafts");
        public static readonly ReverbCommand GetListingsById = new ReverbCommand("/api/listings/{0}");
        public static readonly ReverbCommand UpdateListing = new ReverbCommand("/api/listings/{0}");

        public static readonly ReverbCommand GetOrdersBuyingAll = new ReverbCommand("/api/my/orders/buying/all");
        public static readonly ReverbCommand GetOrdersBuyingUnpaid = new ReverbCommand("/api/my/orders/buying/unpaid");
        public static readonly ReverbCommand GetOrdersSellingAll = new ReverbCommand("/api/my/orders/selling/all");
        public static readonly ReverbCommand GetOrdersSellingUnpaid = new ReverbCommand("/api/my/orders/selling/unpaid");
        public static readonly ReverbCommand GetOrdersSellingAwaitingShipment = new ReverbCommand("/api/my/orders/selling/awaiting_shipment");

		private ReverbCommand( string command )
		{
			this.Command = command;
		}
        
		public string Command { get; private set; }
	}
}