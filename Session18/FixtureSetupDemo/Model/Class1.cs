namespace FixtureSetupDemo.Model
{
    public class Order
    {
        public long Counter { get; set; }
        public OrderState State { get; set; }
    }

    public enum OrderState
    {
        Draft,
        Confirmed,
        Shipped
    }
}