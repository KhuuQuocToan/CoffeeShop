namespace CoffeeShop.Containts
{
    public class FlagConts
    {
        public class DeletedFlag
        {
            /// <summary>
            /// Trạng thái không bị xóa
            /// </summary>
            public const int NOT_DELETED = 0;

            /// <summary>
            /// Trạng thái bị xóa
            /// </summary>
            public const int IS_DELETED = 1;
        }

        public class StatusFlag
        {
            /// <summary>
            /// Trạng thái đang sử dụng
            /// </summary>
            public const int ACTIVE = 0;

            /// <summary>
            /// Trạng thái ngưng sử dụng
            /// </summary>
            public const int DEACTIVE = 1;
        }
    }
}
