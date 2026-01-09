using Inventory_System_with_POS_for_UMVC_Canteen.Data;
using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Factories
{
    public static class RepositoryFactory
    {
        // 🔁 CHANGE THIS ONE FLAG ONLY
        public static bool UseMock = false;

        public static IProductRepository CreateProductRepository()
        {
            if (UseMock)
                return new MockDBProductRepository();
            else
                return new SQLProductRepository();
        }

        public static ITransactionRepository CreateTransactionRepository()
        {
            if (UseMock)
                return new MockDBTransactionRepository();
            else
                return new SQLTransactionRepository();
        }

        public static IUserRepository CreateUserRepository()
        {
            if (UseMock)
                return new MockDBUserRepository();
            else
                return new SQLUserRepository();
        }
        public static IStockRepository CreateStockRepository()
        {
            if (UseMock)
                return new MockDBStockRepository();
            else
                return new SQLStockRepository();
        }
        public static ISupplierRepository CreateSupplierRepository()
        {
            if (UseMock)
                return new MockDBSupplierRepository();
            else
                return new SQLSupplierRepository();
        }
        public static IReportRepository CreateReportRepository()
        {
            if (UseMock)
                return new MockDBReportRepository();
            else
                return new SQLReportRepository();
        }
    }
}
