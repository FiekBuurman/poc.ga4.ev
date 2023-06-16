using System.ComponentModel;

namespace poc.ga4.ev.Types
{
	internal static class EventTypes
	{
		/// <summary>
        /// When the user views a list of products.
        /// This can be search results, recommended products or related products
		/// <br /><see href="https://developers.google.com/analytics/devguides/collection/ga4/ecommerce?client_type=gtm#select_an_item_from_a_list">documentation</see>
        /// </summary>
        public const string ViewItemList = "view_item_list";

        /// <summary>
        /// When the user selects a product page, TODO probably when a assortment page with assortmentItems is selected.
		/// <br /><see href="https://developers.google.com/analytics/devguides/collection/ga4/ecommerce?client_type=gtm#select_item-gtm">documentation</see>
        /// </summary>
        public const string SelectItem = "select_item";

        /// <summary>
        /// When the user views a product page, like ProductDetailPanelControl.ascx
        /// <br /><see href="https://developers.google.com/analytics/devguides/collection/ga4/ecommerce?client_type=gtm#view_item_details">documentation</see>
		/// </summary>
        public const string ViewItem = "view_item";

        /// <summary>
        /// When the user added a product to the ShoppingCart
		/// <br /><see href="https://developers.google.com/analytics/devguides/collection/ga4/ecommerce?client_type=gtm#add_or_remove_an_item_from_a_shopping_cart">documentation</see>
        /// </summary>
		public const string AddToCart = "add_to_cart";

        /// <summary>
        /// When a user removes an item from the ShoppingCart
		/// <br /><see href="https://developers.google.com/analytics/devguides/collection/ga4/ecommerce?client_type=gtm#remove_from_cart-gtm">documentation</see>
        /// </summary>
		public const string RemoveFromCart = "remove_from_cart";

        /// <summary>
        /// When a user subsequently views the cart
        /// <br /><see href="https://developers.google.com/analytics/devguides/collection/ga4/ecommerce?client_type=gtm#view_cart-gtm">documentation</see>
        /// </summary>
		public const string ViewCart = "view_cart";

        /// <summary>
        /// When a user starts the checkout process in CheckoutShoppingCart.aspx
        /// <br /><see href="https://developers.google.com/analytics/devguides/collection/ga4/ecommerce?client_type=gtm#initiate_the_checkout_process">documentation</see>
        /// </summary>
        public const string BeginCheckout = "begin_checkout";

        /// <summary>
        /// When a user selected the DeliveryMethod in CheckoutOrderDeliveryMethod.aspx
		/// <br /><see href="https://developers.google.com/analytics/devguides/collection/ga4/ecommerce?client_type=gtm#add_shipping_info-gtm">documentation</see>
        /// </summary>
        public const string AddShippingInfo = "add_shipping_info";

        /// <summary>
        /// When a user selected the PaymentMethod in CheckoutPaymentMethod.aspx
		/// <br /><see href="https://developers.google.com/analytics/devguides/collection/ga4/ecommerce?client_type=gtm#add_payment_info-gtm">documentation</see>
        /// </summary>
		public const string AddPaymentInfo = "add_payment_info";

        /// <summary>
        /// When a user finished the order, TODO not sure when to fire this after / before iDeal and what about in store/factuur?
        /// <br /><see href="https://developers.google.com/analytics/devguides/collection/ga4/ecommerce?client_type=gtm#make_a_purchase_or_issue_a_refund">documentation</see>
        /// </summary>
        public const string Purchase = "purchase";
    }
}