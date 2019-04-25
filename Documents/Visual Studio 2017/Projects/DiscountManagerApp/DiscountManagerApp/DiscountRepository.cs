using System.IO;

namespace DiscountManagerApp
{
    public class DiscountRepository : IDiscountRepository
    {
        public void SaveAll(DiscountManagerDto data)
        {
            File.WriteAllLines("MojeData.txt", new string[] { $"{data.Amount};{data.Type};{data.Years};" });
        }
    }
}
