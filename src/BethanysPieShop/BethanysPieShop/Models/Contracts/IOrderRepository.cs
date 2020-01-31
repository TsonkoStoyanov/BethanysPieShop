namespace BethanysPieShop.Models.Contracts
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
