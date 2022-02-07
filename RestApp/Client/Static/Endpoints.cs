namespace RestApp.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string BookingsEndpoint = $"{Prefix}/bookings";
        public static readonly string CuisinesEndpoint = $"{Prefix}/cuisines";
        public static readonly string CustomersEndpoint = $"{Prefix}/customers";
        public static readonly string MenusEndpoint = $"{Prefix}/menus";
        public static readonly string ImagesEndpoint = $"{Prefix}/images";
        public static readonly string PaymentTypesEndpoint = $"{Prefix}/paymentTypes";
        public static readonly string RestaurantsEndpoint = $"{Prefix}/restaurants";
        public static readonly string TablesEndpoint = $"{Prefix}/tables";
        public static readonly string AccountsEndpoint = $"{Prefix}/accounts";
    }
}
