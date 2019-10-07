namespace TrackingInfo.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Status LastStatus { get; set; }

        public override bool Equals(object obj)
        {
            var order = obj as Order;

            if(order == null)
            {
                return false;
            }

            return this.Id == order.Id && this.UserId == order.UserId;
        }
    }
}
